using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{

    public class Film_actor
    {
        public int Film_actorId { get; set; }
        public int ActorId { get; set; }
        public int Film_Id { get; set; }
        public DateTime Last_Update { get; set; }

       
        public Actor Actor { get; set; }
    }
}
