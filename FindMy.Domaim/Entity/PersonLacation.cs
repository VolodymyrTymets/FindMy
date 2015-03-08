using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMy.Domaim.Entity
{
  public  class PersonLacation
    {
      public Int32 Id { get; set; }
      public String UserName { get; set; }
      public Decimal latitude { get; set; }
      public Decimal longitude { get; set; }
    }
}
