using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Home
    {
        public IEnumerable<Fabricante> fabi;
        public IEnumerable<Categoria> categ;
        public IEnumerable<Produto> produtos;
        public string filtro;
    }
}