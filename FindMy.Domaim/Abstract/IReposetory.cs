using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMy.Domaim.Entity;

namespace FindMy.Domaim.Abstract
{
     public interface IReposetory
    {
         IQueryable<PersonLacation> PersonLacations { get; }
         PersonLacation PersonLacationAdd(PersonLacation personLacation);
         PersonLacation PersonLacationDelete(Int32 Id);

    }
}
