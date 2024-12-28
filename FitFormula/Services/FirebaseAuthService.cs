using FirebaseAdmin.Auth;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FitFormula.Services
{
    public class FirebaseAuthService
    {
        private readonly FirebaseAuth _auth;

        public FirebaseAuthService(IConfiguration configuration)
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromJson(configuration["Firebase:Credentials"])
            });
            _auth = FirebaseAuth.DefaultInstance;
        }

        public async Task<UserRecord> CreateUserAsync(string email, string password)
        {
            var args = new UserRecordArgs()
            {
                Email = email,
                Password = password,
                EmailVerified = false
            };
            return await _auth.CreateUserAsync(args);
        }

        public async Task<string> VerifyIdTokenAsync(string idToken)
        {
            var decodedToken = await _auth.VerifyIdTokenAsync(idToken);
            return decodedToken.Uid;
        }
    }
}