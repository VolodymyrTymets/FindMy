using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using FindMy.Domaim.Entity;
using FindMy.Domaim.Abstract;
using FindMy.Domaim.Concrate;

namespace FindMy.Controllers
{
    public class LocationController : ApiController
    {
        public LocationController()
        {
            _repository = new EFReposetory();
        }
       
        public IEnumerable<PersonLacation> GetAll()
        {
            return _repository.PersonLacations;
        }
        public bool Set(PersonLacation person)
        {
            _repository.PersonLacationAdd(person);
            return true;
        }
        private IReposetory _repository;
	}
}