using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    class Produto
    {
        private string nome;
          
        public int qtdcompra { get; set; }
        
        public string Nome { 
            get { return nome; }
        }

        private string marca;
        public string Marca {
            get { return marca; }
        }

        private int codigo;
        public int Codigo {
            get { return codigo; }
        }

        public string Validade { get; set; }

        public double preco { get; set; }
        public int Estoque { get; set; }
        public string Referencia { get; set; }

        SqlConnection conexao = new SqlConnection("Data Source=EN2LIA_05; Initial Catalog=Farmacia; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();


        public void Cadastro()
        {
            Console.WriteLine("Nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Validade: ");
            Validade = Console.ReadLine();

            Console.WriteLine("Preço: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade em estoque: ");
            Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Referência: ");
            Referencia = Console.ReadLine();

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                                INTO Produto(codigo, nome, marca, validade, preco, estoque, referencia)
                                VALUES (@codigo, @nome, @marca, @validade, @preco, @estoque, @referencia);";

            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@validade", Validade);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@estoque", Estoque);
            cmd.Parameters.AddWithValue("@referencia", Referencia);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Console.WriteLine("Produto cadastrado!");

        }

        
        ConsoleKey finalizar = ConsoleKey.K;

        public void Compra()
        {
            do
            {
                Console.WriteLine("Código do produto: ");
                codigo = int.Parse(Console.ReadLine());

                cmd.Connection = conexao;
                cmd.CommandText = string.Format( @"SELECT nome, marca, preco, estoque
                                                   FROM Produto
                                                   WHERE codigo = {0}", codigo);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        nome = reader.GetString(0);
                        marca = reader.GetString(1);
                        preco = reader.GetDouble(2);
                        Estoque = Convert.ToInt32(reader[3]);

                        Console.WriteLine(" Produto: {0}        Marca: {1}      Preço: {2}", nome, marca, preco);                        
                    }
                    QtdEstoque(preco, Estoque, codigo);               
                }               

                else
                {
                    Console.WriteLine("Produto não encontrado!");
                }
                
                cmd.Connection.Close();
                
                Console.WriteLine("Aperte ENTER para finalizar a compra");                                
                Console.ReadKey();
            }       
            
            while ( finalizar != ConsoleKey.K);
        }


        public void QtdEstoque(double preco, int estoque, int codigo)

        {
            Console.WriteLine("Quantos deseja?");
            int qtdprod = int.Parse(Console.ReadLine());
            
            

            if (estoque < qtdprod)
            {
                Console.Beep(698, 800);
                Console.WriteLine("Não é possível fazer a compra, não temos esta disponibilidade no momento. Estoque atual: {0}", estoque);

            }

            else if (estoque > qtdprod)
            {
                
                Console.Beep(698, 400);
                Console.WriteLine("Compra efetuada com sucesso");
                          
                cmd.Connection.Close();
                qtdcompra = qtdcompra + qtdprod;
                UpdateEstoque(codigo, estoque - qtdprod);                                     
            }
            
           
        }

        public void QtdEstoque(int codg)
        {
            cmd.Connection = conexao;
            cmd.CommandText = string.Format(@"SELECT nome, estoque
                                              FROM Produto
                                              WHERE codigo = {0}", codg);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    nome = reader.GetString(0);
                    Estoque = Convert.ToInt32(reader[1]);
                }

                if(Estoque <= 0)
                {
                    Console.WriteLine("{0} não possui estoque!", nome);
                }

                else if(Estoque > 0 && Estoque <= 5)
                {
                    Console.WriteLine("{0} possui baixa quantidade em estoque: {1}", nome, Estoque);
                }

                else
                {
                    Console.WriteLine("{0} pussui {1} unidade(s) em estoque!", nome, Estoque);
                }
            }

            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

            cmd.Connection.Close();
        }

            public void UpdateEstoque(int cod, int etq)
            {
                cmd.Connection = conexao;
                cmd.CommandText = @"UPDATE Produto 
                                    SET estoque = @estoque
                                    WHERE codigo = @codigo";

                cmd.Parameters.AddWithValue("@estoque", etq);
                cmd.Parameters.AddWithValue("@codigo", cod);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
            }

        public void Consulta()
        {
            Console.WriteLine("Código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            cmd.Connection = conexao;
            cmd.CommandText = string.Format(@"SELECT codigo, nome, marca, preco, referencia
                                              FROM Produto
                                              WHERE codigo = {0}", codigo);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    codigo = reader.GetInt32(0);
                    nome = reader.GetString(1);
                    marca = reader.GetString(2);
                    preco = reader.GetDouble(3);
                    Referencia = reader.GetString(4);

                    Console.WriteLine("{0}  {1}  {2}   {3}", codigo, nome, marca, preco);

                    
                }
                //cmd.Connection.Close();
                

                //cmd.CommandText = string.Format(@"SELECT codigo, nome, marca, preco, referencia
                                                  //FROM Produto
                                                  //WHERE referencia = {0}", Referencia);

                //cmd.Connection.Open();
                //cmd.ExecuteReader();
                
                                        

                //if(reader.HasRows)
                //
                  //  Console.WriteLine("OUTROS: ");

                    /*while(reader.Read())
                    {
                        codigo = reader.GetInt32(0);
                        nome = reader.GetString(1);
                        marca = reader.GetString(2);
                        preco = reader.GetDouble(3);
                        Referencia = reader.GetString(4);

                        Console.WriteLine(" {0}  {1}  {2}   {3}", codigo, nome, marca, preco);
                    }
                }

                else
                {
                    Console.WriteLine("Não foram encontrados outros produtos parecidos!"); 
                }*/
            }

            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
                
            cmd.Connection.Close();
        }

        public void ControleDeQtd()
        {
            int media = qtdcompra / 3;
            Console.WriteLine("A média de compras foi: {0}", media);
            if (media == 0)
            {
                Console.WriteLine("Não foram efetuadas compras, não abasteça");
            }
            else if (media > 0 && media <= 10)
            {
                Console.WriteLine("Não foram efetuadas em média muitas compras, abasteça em baixa quantidade");
            }
            else if (media > 10 && media <= 20)
            {
                Console.WriteLine("Foram efetuadas uma média aceitável de compras, abasteça em boa quantidade");
            }
            else
            {
                Console.WriteLine("Foi efetuada uma média de compras alta, abasteça em alta quantidade");
            }
        }

        public void ControleDeValidade(string data)
        {
            
        }
        

    }
}
