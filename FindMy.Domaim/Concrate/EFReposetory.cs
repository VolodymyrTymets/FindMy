using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMy.Domaim.Abstract;
using FindMy.Domaim.Entity;

namespace FindMy.Domaim.Concrate
{
    public class EFReposetory : IReposetory
    { 
        private EFDbContext _context = new EFDbContext();


        public IQueryable<Entity.PersonLacation> PersonLacations
        {
            get {return _context.PersonLacations ; }
        }

        public Entity.PersonLacation PersonLacationAdd(PersonLacation personLacation)
        {
            var DbEntity = _context.PersonLacations.FirstOrDefault(x => x.Id == personLacation.Id);
            if (DbEntity == null)
            {
                _context.PersonLacations.Add(personLacation);
            }
            else 
            {
                DbEntity.UserName = personLacation.UserName;
                DbEntity.latitude = personLacation.latitude;
                DbEntity.longitude = personLacation.longitude;

            }
            _context.SaveChanges();
            return personLacation;
        }

        public Entity.PersonLacation PersonLacationDelete(Int32 Id)
        {
            var DbEntity = _context.PersonLacations.FirstOrDefault(x => x.Id == Id);
            if (DbEntity != null) 
            {
                _context.PersonLacations.Remove(DbEntity);
                _context.SaveChanges();
            }
            return DbEntity;
        }
    }

}
