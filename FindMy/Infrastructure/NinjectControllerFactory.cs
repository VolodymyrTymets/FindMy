using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMy.Domaim.Abstract;
using FindMy.Domaim.Concrate;

namespace FindMy.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        public NinjectControllerFactory()
        {
            this._ninjectKernal = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)_ninjectKernal.Get(controllerType);
        }
        private void AddBindings()
        {
            _ninjectKernal.Bind<IReposetory>().To<EFReposetory>();
            
        }
        private IKernel _ninjectKernal;
    }
}