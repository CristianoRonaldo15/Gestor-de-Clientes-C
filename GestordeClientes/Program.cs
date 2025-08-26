using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestordeClientes
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente { 
            public string nome;
            public string email;
            public string cpf;
        }
        static List<Cliente> clientes = new List<Cliente>();
        enum Menu { Adicionar = 1, Listagem , Remover , Sair};
        static void Main(string[] args)
        {
            Carregar();
            bool EscolheuSair = false;
            while (!EscolheuSair) {
                Console.WriteLine("Sistema de Clientes - Bem vindo!");
                Console.WriteLine("1-Adicionar\n2-Listagem\n3-Remover\n4-Sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opc = (Menu)intOp;

                switch (opc) { 
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Sair:
                        EscolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("Nome do Cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do Cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do Cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("Cadastro concluido, aperte ENTER para sair");
            Console.ReadLine();
        }
        static void Listagem() 
        {
            if (clientes.Count > 0)
            {
                Console.WriteLine("Listagem de Clientes");
                int id = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"E-mail: {cliente.email}");
                    Console.WriteLine($"Cliente: {cliente.cpf}");
                    Console.WriteLine("========================================");
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Não existe nenhum cadastro. Volte e cadastre ao menos um para a Listagem");
            }
            Console.WriteLine("Aperte ENTER para sair");
            Console.ReadLine();
        }
        static void Remover() 
        {
            Console.WriteLine("Digite o ID que você quer Remover: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("Id digitado é inválido, Tente Novamente!");
                Console.ReadLine();

            }

        }
        static void Salvar()
        {
            FileStream stream = new FileStream("Clientes.dat", FileMode.OpenOrCreate);
            BinaryFormatter enconder = new BinaryFormatter();
            
            enconder.Serialize(stream, clientes);
            stream.Close();
        }
        static void Carregar()
        {
            FileStream stream = new FileStream("Clientes.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter enconder = new BinaryFormatter();

                enconder.Serialize(stream, clientes);

                if (clientes == null) 
                {
                    clientes = new List<Cliente>();
                }
            }
            catch 
            {
                clientes = new List<Cliente>();
            }
            stream.Close();
        }
    }
}
