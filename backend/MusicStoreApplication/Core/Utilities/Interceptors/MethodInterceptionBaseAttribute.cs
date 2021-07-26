using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //Attribute üzerinden kullanımı bu sağlamakta...
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodInterceptionBaseAttribute
        : Attribute, IInterceptor
    {
        public int Priority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
