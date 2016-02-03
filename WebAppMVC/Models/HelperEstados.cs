using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nome { get; set; }
    }

    public static class HelperEstados
    {
        public static IEnumerable<Estado> Estados = new List<Estado>
        {
            new Estado { EstadoId = 1, Nome = "AC" },
            new Estado { EstadoId = 2, Nome = "MG" },
            new Estado { EstadoId = 3, Nome = "RJ" },
            new Estado { EstadoId = 4, Nome = "SP" }
        };
    }
}
