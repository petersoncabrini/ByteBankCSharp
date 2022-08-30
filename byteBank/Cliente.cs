﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            CPF = cpf; 
            Profissao = profissao;
            TotalDeClientesCadastrados += 1;
        }

        public static int TotalDeClientesCadastrados { get; set; }
    }
}
