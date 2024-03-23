using System;

namespace Cadastro2.Services
{
    public class ServicoFormatador
    {
        public string FormatarDados(string nome, string endereco, string telefone)
        {
            // Formatar os dados em uma tabela HTML com bordas e cor vermelha
            string dadosFormatados = "<div style='text-align: center;'>";
            dadosFormatados += "<div style='display: inline-block;'>";
            dadosFormatados += "<table style='border-radius: 50px; border-collapse: collapse; border: 2px solid black;'>";
            dadosFormatados += $"<tr><td style='border: 1px solid black;'>Nome:</td><td style='border: 1px solid black; color: red;'>{nome.ToUpper()}</td></tr>";
            dadosFormatados += $"<tr><td style='border: 1px solid black;'>Endereço:</td><td style='border: 1px solid black; color: red;'>{endereco.ToUpper()}</td></tr>";
            dadosFormatados += $"<tr><td style='border: 1px solid black;'>Telefone:</td><td style='border: 1px solid black; color: red;'>{telefone.ToUpper()}</td></tr>";
            dadosFormatados += "</table>";
            dadosFormatados += "</div>";
            dadosFormatados += "</div>";


            return dadosFormatados;
        }
    }
}
