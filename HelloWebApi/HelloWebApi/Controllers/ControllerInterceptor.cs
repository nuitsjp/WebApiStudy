using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using Castle.DynamicProxy;

namespace HelloWebApi.Controllers
{
    public class ControllerInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.GetCustomAttribute<InterceptAttribute>() != null)
            {
                Debug.WriteLine($"Type:{invocation.TargetType.Name} Method:{invocation.Method.Name} Before");
                invocation.Proceed();
                Debug.WriteLine($"Type:{invocation.TargetType.Name} Method:{invocation.Method.Name} After");
            }
            else
            {
                invocation.Proceed();
            }
        }
    }
}