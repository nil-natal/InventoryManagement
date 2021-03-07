using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class SigningConfigurations
    {
        public SecurityKey key { get; }
        public SigningCredentials SigningCredentials { get; }
        public SigningConfigurations()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                key = new RsaSecurityKey(provider.ExportParameters(true));
            }
            SigningCredentials = new SigningCredentials(
                key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
