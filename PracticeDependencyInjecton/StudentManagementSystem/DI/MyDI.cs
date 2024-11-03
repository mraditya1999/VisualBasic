using Ninject;
using StudentManagementSystem.Models.Abstract;
using StudentManagementSystem.Models.TypeOfData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.DI
{
    public class MyDI:IDependencyResolver
    {
        IKernel kernel;
        public MyDI() { 
        kernel = new StandardKernel();
            Allbind();
        }

        public void Allbind()
        {
            kernel.Bind<IStudent>().To<RealData>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}