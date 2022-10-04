using System;
using System.Collections.Generic;
using System.Text;

namespace cursoFoop_Exercicio_SOLID1
{
    class ExportarDados
    {
        public string ExportarCSV(List<Cliente> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}