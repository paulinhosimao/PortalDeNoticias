using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }

        public String Titulo { get; set; }

        public String Autor { get; set; }

        public DateTime Data { get; set; }

        public String Conteudo { get; set; }
    }
}