﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
