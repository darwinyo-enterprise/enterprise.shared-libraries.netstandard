using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enterprise.Constants.NetStandard;
using IdentityModel;
using Microsoft.AspNetCore.Http;

namespace Enterprise.Models.NetStandard
{
    public class UserScopesModel
    {
        public UserScopesModel(HttpContext httpContext)
        {
            // If Claim Doesn't Contain Subject, Means ClientCredential Grant Type.
            if (httpContext != null && httpContext.User.Claims.Where(x => x.Type == JwtClaimTypes.Subject).SingleOrDefault() != null)
            {
                Subject = new Guid(httpContext.User.Claims.Where(x => x.Type == JwtClaimTypes.Subject).SingleOrDefault().Value);
                Name = httpContext.User.Claims.Where(x => x.Type == JwtClaimTypes.Name).SingleOrDefault().Value;
                Role = httpContext.User.Claims.Where(x => x.Type == JwtClaimTypes.Role).SingleOrDefault().Value;
                Email = httpContext.User.Claims.Where(x => x.Type == JwtClaimTypes.Email).SingleOrDefault().Value;
                PhoneNumber = httpContext.User.Claims.Where(x => x.Type == JwtClaimTypes.PhoneNumber).SingleOrDefault().Value;
            }
            else
            {
                Subject = Guid.Empty;
                Name = CommonConstants.ANONYMOUS;
                Role = CommonConstants.NO_ROLE;
                Email = string.Empty;
                PhoneNumber = string.Empty;
            }
        }
        public Guid? Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
    }
}
