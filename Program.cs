using System;

namespace AtividadePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();
            cliente.nome = "Vitor";
            cliente.cpf = "123.456.678-99";
            cliente.rua = "Rua dos Programadores";
            cliente.numero = 18;
            cliente.bairro = "São Carlos";
            cliente.cep = "14702-00";
            cliente.estadoNome = "São Paulo";
            cliente.estadoSigla = "SP";

            Console.WriteLine("Nome: " + cliente.nome);
            Console.WriteLine("CPF: " + cliente.cpf);
            Console.WriteLine("Rua: " + cliente.rua);
            Console.WriteLine("Número: " + cliente.numero);
            Console.WriteLine("Bairro: " + cliente.bairro);
            Console.WriteLine("CEP: " + cliente.cep);
            Console.WriteLine("Estado: " + cliente.estadoNome);
            Console.WriteLine("Sigla do Estado: " + cliente.estadoSigla);

        }
    }
}
