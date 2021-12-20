
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Text;
using Core.Utilitiess.Interceptors;
using Core.Utilitiess.IoC;
using Castle.DynamicProxy;
using Core.Extensions;
using Business.Constants;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspect.Autofac
{
    //JWT 
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;//IHttpContextAccessor:Her istek için bir httpcontext i oluşturmak için

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
