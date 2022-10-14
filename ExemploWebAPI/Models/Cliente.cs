using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebAPI.Models
{
    public class Cliente
    {
        public string Name { get; set; }

        public Cliente(string texto)
        {
            this.Name = texto;
        }
    }
}