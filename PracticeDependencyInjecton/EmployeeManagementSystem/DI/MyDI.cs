using EmployeeManagementSystem.Models.Abstract;
using EmployeeManagementSystem.Models.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.DI
{
    public class MyDI : IDependencyResolver
    {
        IKernel kernel;
        public MyDI() {
            kernel = new StandardKernel();
            Allbind();
        }

        public void Allbind()
        {
           kernel.Bind<IEmployee>().To<EmployeeManagement>();
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