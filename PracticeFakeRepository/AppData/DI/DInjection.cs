using AppData.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppData.DI
{
    public class DInjection : IDependencyResolver
    {   
        IKernel ikernel;
        public DInjection()
        {
            ikernel = new StandardKernel();
            AddBinding();
        }
        public object GetService(Type serviceType)
        {
            return ikernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ikernel.GetAll(serviceType);
        }
        public void AddBinding()
        {
            ikernel.Bind<IStudent>().To<StudentManagement>();
            //ikernel.Bind<IStudent>().To<StudentManagementDb>();

        }
    }
}