using FoodOrderSystem.Models.Abstract;
using FoodOrderSystem.Models.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderSystem.DI
{
    public class MyDI : IDependencyResolver
    {
        IKernel kernel;

        public MyDI()
        {
            kernel = new StandardKernel();
            Allbind();
        }

        private void Allbind()
        {
            kernel.Bind<IFoodOrder>().To<FoodOrderManagementData>();
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