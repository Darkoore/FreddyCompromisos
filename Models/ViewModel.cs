using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compromisos.Models
{
    public class ViewModel
    {
        public IEnumerable <ParticipantesList> Participantes { get; set; }
        //public List<Compromisos.Models.Participantes> Participantes { get; set; }
        public Participantes Participante { get; set; }
    }
}