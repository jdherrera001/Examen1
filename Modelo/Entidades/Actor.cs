using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Last_update { get; set; }
        
        public ICollection<Film_actor> Film_actors { get; set; }
    }
}
