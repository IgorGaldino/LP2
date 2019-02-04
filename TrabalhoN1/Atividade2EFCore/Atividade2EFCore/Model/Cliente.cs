using System;
using System.ComponentModel.DataAnnotations;

namespace Atividade2EFCore
{
    public class Cliente
    {
        //[Key]
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}
