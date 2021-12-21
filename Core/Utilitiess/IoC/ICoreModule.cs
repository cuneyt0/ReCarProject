using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilitiess.IoC
{
    //tüm projelerimde ortak enjectionsları burada topladım.
    public interface ICoreModule
    {
        //Genel bagımlılıkları yükleme
        void Load(IServiceCollection serviceCollection);
    }
}
