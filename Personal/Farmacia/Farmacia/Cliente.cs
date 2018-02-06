using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    class Cliente
    {
        public string Nome { get; set; }

        private string endereco;
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        private string cep;       
        public string Cep {
            get { return string.Format("{0}", cep); }
        }
        public string Endereco {
            get { return string.Format("{0}, {1} - {2}\n Complemento:{3}\n CEP: {4}", Rua, Numero, Bairro, Complemento, Cep); }
        }

        public int Telefone { get; set; }
        public DateTime Data = DateTime.Now;

        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Farmacia;Data Source=DESKTOP-2VAOEOR\\SQLEXPRESS");
        SqlCommand cmd = new SqlCommand();

        public void Cadastro(int telefone)
        {
            Console.WriteLine(" Nome do cliente: ");
            Nome = Console.ReadLine();

            Telefone = telefone;

            Console.WriteLine(" Endereço:\n Rua ");
            Rua = Console.ReadLine();

            Console.WriteLine(" Número ");
            Numero = Console.ReadLine();

            Console.WriteLine(" Bairro ");
            Bairro = Console.ReadLine();

            Console.WriteLine(" Complemento ");
            Complemento = Console.ReadLine();

            Console.WriteLine(" Cep ");
            cep = Console.ReadLine();
            

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT 
                                INTO Cliente(nome, endereco, telefone, ultimoPedido)
                                VALUES(@nome, @endereco, @telefone, @data);";

          
            
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@endereco", endereco); 
            cmd.Parameters.AddWithValue("@telefone", Telefone);            
            cmd.Parameters.AddWithValue("@data", Data);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            Console.WriteLine("Cliente cadastrado!");

        }

        public void UpdateData(int telefone)
        {
            cmd.Connection = conexao;
            cmd.CommandText = @"UPDATE Cliente
                                SET ultimoPedido = @data
                                WHERE telefone = @telefone";

            cmd.Parameters.AddWithValue("data", Data);
            cmd.Parameters.AddWithValue("telefone", telefone);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Consulta(int telefone)
        {
            cmd.Connection = conexao;
            cmd.CommandText = string.Format(@"SELECT nome, endereco
                                FROM Cliente
                                WHERE telefone = {0}", telefone);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Nome = reader.GetString(0);
                    endereco = reader.GetString(1);

                    Console.WriteLine("Cliente já cadastrado!\n Nome: {0}\n Endereço: {1}\n Telefone: {2}", Nome, endereco, telefone);
                }
            }

            else
            {               
                cmd.Connection.Close();
                Cadastro(telefone);
            }

            cmd.Connection.Close();
        }

        public void DeleteCliente()
        {
            cmd.Connection = conexao;
            cmd.CommandText = string.Format(@"SELECT ultimoPedido, telefone
                                              FROM Cliente");

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                int i = 0, e = 0;

                while(reader.Read())
                {
                    string DataUltimoP = reader.GetString(0);
                    Telefone = reader.GetInt32(1);

                    TimeSpan diferencaDias = Convert.ToDateTime(Data) - Convert.ToDateTime(DataUltimoP);
                    int totaldias = diferencaDias.Days;

                    if (totaldias > 1825)
                    {
                        cmd.CommandText = string.Format(@"DELETE 
                                                          FROM Cliente 
                                                          WHERE telefone = {0}", Telefone);

                        cmd.ExecuteNonQuery();

                        i++;
                    }

                    else
                    {
                        e++;
                    }
                }

                Console.WriteLine(" Há {0} clientes cadastrados em seu banco!\n {0} Cadastros foram deletados.", e, i);
            }

            else
            {
                Console.WriteLine(" Não há cllientes cadastrados!");
            }

            cmd.Connection.Close();
        }

    }
}
