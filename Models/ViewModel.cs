using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compromisos.Models
{
    public class ViewModel
    {
        public ICollection <ParticipantesList> ParticipantesLists { get; set; }
        public Participantes Participantes { get; set; }
    }
}