using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        { 
            // para usar barra invertida ela deve ser dupla \\, senao utilizar o literal @ antes
            File.WriteAllText(@"C:\Users\alexy\Documents\Estudo\projetos-estudo-solid\CursoFoop_Solid_Exercicio2\log\LogOcorrencias.txt", mensagem);
        }
    }
}