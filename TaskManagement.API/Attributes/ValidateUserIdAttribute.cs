using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TaskManagement.API.Extensions;

namespace TaskManagement.API.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ValidateUserIdAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userId = context.HttpContext.Session.GetUserId();
            
            if (!userId.HasValue)
            {
                context.Result = new UnauthorizedObjectResult("User not authenticated");
                return;
            }
            context.HttpContext.Items["UserId"] = userId.Value;
        }
    }
} 