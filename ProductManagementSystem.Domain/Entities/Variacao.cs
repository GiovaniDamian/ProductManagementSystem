using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Domain.Entities
{
    public class Variacao
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string NomeVariacao { get; set; }
    }
}
