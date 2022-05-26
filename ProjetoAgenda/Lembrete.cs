using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Lembrete : compromisso
    {
        private byte tempolembrete;
        private char tipolembrete;
        private ValueTuple<bool, bool, bool, bool, bool, bool, bool> dialembrete = (false, false, false, false, false, false, false);
        private int tempofim;
        private DateTime datefim;
        internal byte TempoLembrete { get => tempolembrete; set => tempolembrete = value; }
        internal char TipoLembrete { get => tipolembrete; set => tipolembrete = value; }
        internal ValueTuple<bool, bool, bool, bool, bool, bool, bool> DiaLembrete { get => dialembrete; set => dialembrete = value; }
        internal int TempoFim { get => tempofim; set => tempofim = value; }
        internal DateTime DateFim { get => datefim; set => datefim = value; }

        public Lembrete(string titulo = default, string descricao = default, DateTime DatahoraInicio = default, DateTime DatahoraFim = default, byte tempolembrete = default, char tipolembrete = default, ValueTuple<bool, bool, bool, bool, bool, bool, bool> dialembrete = default, int tempofim = default, DateTime datefim = default, notificação notificação = default) : base(titulo, descricao, DatahoraInicio, DatahoraFim, notificação)
        {
            this.tempolembrete = tempolembrete;
            this.tipolembrete = tipolembrete;
            this.dialembrete = dialembrete;
            this.tempofim = tempofim;
            this.datefim = datefim;
        }
    }
}
