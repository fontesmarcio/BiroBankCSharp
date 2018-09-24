﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BiroBank {
    class Cliente {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF {
            get {
                return _cpf;
            }
            set {
                _cpf = value;
            }
        }
        public string Profissao { get; set; }


        public Cliente(string nome, string cpf, string profissao) {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
        }
    }

}
