using appstore.notification.api.Interfaces;
using appstore.notification.api.Models;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace appstore.notification.api.Services
{
    public class NotificationProcessor : INotificationProcessor
    {
        public void Process(AppleNotification notification)
        {
            var v2Payload = GetVerifiedDecodedData<NotificationV2>(notification.SignedPayload);
            if (v2Payload == null)
            {
                throw new ArgumentNullException($"{nameof(v2Payload)} is null");
            }

            if (v2Payload.ValidResult?.Data == null)
            {
                throw new ArgumentNullException($"{nameof(v2Payload.ValidResult)} is null");
            }

            RenewalInfoV2 renewalInfoV2 = null;
            if (!string.IsNullOrEmpty(v2Payload.ValidResult.Data.SignedRenewalInfo))
            {
                var renewalInfoV2Verified = GetVerifiedDecodedData<RenewalInfoV2>(v2Payload.ValidResult.Data.SignedRenewalInfo);
                renewalInfoV2 = renewalInfoV2Verified.ValidResult;
            }

            var transactionInfoV2 = GetVerifiedDecodedData<TransactionInfoV2>(v2Payload.ValidResult.Data.SignedTransactionInfo);

            // 
        }

        private VerifiedDecodedDataModel<TNotificationData> GetVerifiedDecodedData<TNotificationData>(string signedPayload)
        {
            if (string.IsNullOrEmpty(signedPayload))
            {
                throw new ArgumentNullException("Signed Payload is null");
            }

            var splitParts = signedPayload.Split('.');

            EnsurePartElements(splitParts);

            var valid = VerifyToken(signedPayload);

            return new VerifiedDecodedDataModel<TNotificationData> 
            {
                ValidResult = valid ? DecodeFromBase64<TNotificationData>(splitParts[1]) : default,
                Valid = valid
            };
        }

        private static void EnsurePartElements(string[] split)
        {
            if (split.Length != 3)
            {
                throw new ArgumentException("Invalid signedPayload");
            }

            if (string.IsNullOrEmpty(split[0]))
            {
                throw new ArgumentException("Invalid jws_header part");
            }

            if (string.IsNullOrEmpty(split[1]))
            {
                throw new ArgumentException("Invalid jws_payload part");
            }

            if (string.IsNullOrEmpty(split[2]))
            {
                throw new ArgumentException("Invalid jws_signature part");
            }
        }

        private static bool VerifyToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtSecurityToken = handler.ReadJwtToken(token);


                var x5cTry = jwtSecurityToken.Header.TryGetValue("x5c", out object x5cCerteficates);
                if (!x5cTry || x5cCerteficates == null)
                {
                    throw new KeyNotFoundException("Token Header does not contain x5c");
                }

                var certeficatesItems = JsonConvert.DeserializeObject<IEnumerable<string>>(x5cCerteficates.ToString());
                if (certeficatesItems == null || !certeficatesItems.Any())
                {
                    throw new ArgumentNullException("Certeficates are null");
                }

                var securityToken = Validate(handler, token, certeficatesItems.First());

                return securityToken != null;

            }
            catch (Exception ex)
            {
                // log it
                return false;
            }
        }

        private static SecurityToken? Validate(JwtSecurityTokenHandler tokenHandler, string jwtToken, string publicKey)
        {
            var certificateBytes = Base64UrlEncoder.DecodeBytes(publicKey);
            var certificate = new X509Certificate2(certificateBytes);
            var eCDsa = certificate.GetECDsaPublicKey();
            
            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateLifetime = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new ECDsaSecurityKey(eCDsa),
            };

            tokenHandler.ValidateToken(jwtToken, tokenValidationParameters, out var securityToken);
            return securityToken;
        }

        private static TObj DecodeFromBase64<TObj>(string encodedString)
        {
            var data = Base64UrlTextEncoder.Decode(encodedString);
            string decodedString = Encoding.UTF8.GetString(data);

            var obj = JsonConvert.DeserializeObject<TObj>(decodedString);
            return obj;
        }

    }
}
