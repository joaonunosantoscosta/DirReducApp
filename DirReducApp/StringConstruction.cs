using System;
using System.Collections.Generic;
using System.Text;

namespace DirReducApp
{
    public static class StringConstruction
    {
        public static string getString(string[] resultado)
        {
            StringBuilder myStringBuilder;
            if (resultado == null)
            {
                myStringBuilder = new StringBuilder("Resultado = null");
            }
            else
            {
                myStringBuilder = new StringBuilder("Resultado = [");
                myStringBuilder.Append(resultado[0]);
                for (int i = 1; i < resultado.Length; i++)
                {
                    myStringBuilder.Append(" , ");
                    myStringBuilder.Append(resultado[i]);
                }
                myStringBuilder.Append("]");
                //Console.WriteLine(myStringBuilder);
            }
            return myStringBuilder.ToString();
        }

    }
}
