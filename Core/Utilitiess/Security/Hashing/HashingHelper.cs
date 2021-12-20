using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilitiess.Security.Hashing
{
   public class HashingHelper
    {
     
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {

            // Verdigim password  degerinin salt ve hash degerini oluşturmama yarayan kod satırı

            //Salt:Kullandıgım algoritmanın key degeri:ben HMACSHA512 algoritmasını kullanıyorum.

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {

            using (var hmac= new System.Security.Cryptography.HMACSHA512(passwordHash))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordSalt[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }



    }
}
