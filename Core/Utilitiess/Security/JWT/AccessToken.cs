
using System.Collections.Generic;
using System.Text;
using System;

namespace Core.Utilitiess.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; } //JWT degerimizin kendisi

        public DateTime Expiration { get; set; }    //JWT nin bitiş süresi
    }
}
