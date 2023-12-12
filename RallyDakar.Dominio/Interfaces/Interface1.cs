using System;
using System.Collections.Generic;
using System.Text;

namespace RallyDakar.Dominio.Interfaces
{
    public interface Interface1
    {
        public int Id { get; set; }
        public string CodigoIdentificador { get; set; }
        public string Nome { get; set; }
        public int TemporadaId { get; set; }
    }
}
