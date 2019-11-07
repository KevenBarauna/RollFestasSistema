using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model
{
    class DAOCaixa
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void IniciarCaixa(String data)
        {
            SqlDataReader dr;
            cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data = @data";


            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@data", data);
            dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                // dr.Read();
                cmd.Parameters.Clear();
                conexao.Desconectar();


                cmd.CommandText = "INSERT INTO TB_CAIXA (data) VALUES (@data)";

                cmd.Parameters.AddWithValue("@data", data);

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conexao.Desconectar();
                    MessageBox.Show("Caixa de hoje iniciado!");
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Erro:  " + e);
                }

                cmd.Parameters.Clear();
                conexao.Desconectar();

            }


            
        }//INICIA NO BANCO UM CAIXA POR DATA

        public void InserirVendaNoCaixaDinheiro(String valorTotal, String data)
        {
            
            cmd.CommandText = "UPDATE TB_CAIXA SET dinheiro = @valorTotal WHERE data = @data";

            cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
        }//NOVA VENDA EM DINHEIRO

        public void InserirVendaNoCaixaCartao(String valorTotal, String data)
        {
            cmd.CommandText = "UPDATE TB_CAIXA SET cartao = @valorTotal WHERE data = @data";

            cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
        }//NOVA VENDA EM CARTAO

        public void InserirVendaNoCaixaOutros(String valorTotal, String data)
        {
            cmd.CommandText = "UPDATE TB_CAIXA SET outros = @valor WHERE data = @data";

            cmd.Parameters.AddWithValue("@valor", valorTotal);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
        }//NOVA VENDA OUTROS

        public void LarcarRetirada(String valor, String data)
        {
            cmd.CommandText = "UPDATE TB_CAIXA SET retirada = @retirada where data = @data";

            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@retirada", valor);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Antes de fazer uma retirada é necessario realizar uma venda");
                MessageBox.Show("Erro:  " + e);
            }
        }//NOVA RETIRADA

        public void LarcarDeposito(String valor, String data)
        {
            cmd.CommandText = "UPDATE TB_CAIXA SET deposito = @deposito where data = @data";

            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@deposito", valor);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
        }//NOVA DEPOSITO

        public Decimal PegarValorDinheiro(String data)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();
            Decimal ValorTotal = 0;

            cmd.CommandText = "SELECT dinheiro FROM TB_CAIXA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ValorDoBanco = Convert.ToString( dr["dinheiro"] );
                    if (String.IsNullOrEmpty(ValorDoBanco))
                    {
                        ValorDoBanco = "0";
                    }
                    ValorTotal = ValorTotal + Convert.ToDecimal(ValorDoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ValorTotal;
        
         }//PEGAR VALOR TOTAL NO CAIXA EM DINHEIRO

        public Decimal PegarValorCartao(String data)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();
            Decimal ValorTotal = 0;

            cmd.CommandText = "SELECT cartao FROM TB_CAIXA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ValorDoBanco = Convert.ToString(dr["cartao"]);
                    if (String.IsNullOrEmpty(ValorDoBanco))
                    {
                        ValorDoBanco = "0";
                    }
                    ValorTotal = ValorTotal + Convert.ToDecimal(ValorDoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ValorTotal;

        }//PEGAR VALOR TOTAL NO CAIXA EM CARTAO

        public Decimal PegarValorOutros(String data)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();
            Decimal ValorTotal = 0;

            cmd.CommandText = "SELECT outros FROM TB_CAIXA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ValorDoBanco = Convert.ToString(dr["outros"]);
                    if (String.IsNullOrEmpty(ValorDoBanco))
                    {
                        ValorDoBanco = "0";
                    }
                    ValorTotal = ValorTotal + Convert.ToDecimal(ValorDoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ValorTotal;

        }//PEGAR VALOR TOTAL NO CAIXA EM OUTROS

        public void RetirarDinheiroCaixa(String valorTotal, String data)
        {

            cmd.CommandText = "UPDATE TB_CAIXA SET dinheiro = @valorTotal WHERE data = @data";

            cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
        }//CASO TENHA UMA DEVOLUCAO

        public String ListarCaixaPorDia(String data)
        {
            SqlDataReader dr;
            String VendaTotaldoBanco = "0";

            cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);
            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    VendaTotaldoBanco = Convert.ToString(dr["valor_total_dia"]);

                    if (String.IsNullOrEmpty(VendaTotaldoBanco))
                    {
                        VendaTotaldoBanco = "0";
                    }
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return VendaTotaldoBanco;

        }//PEGAR VENDA TOTAL DO DIA

        public List<CaixaModel> ListarCaixaPorMes(String data)
        {
            SqlDataReader dr;
            List<CaixaModel> ListaCaixa = new List<CaixaModel>();

            cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data LIKE '%/" + data + "%'" ;

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        CaixaModel v = new CaixaModel();

                        var ValorDoBanco = Convert.ToString(dr["valor_total_dia"]);


                        if (String.IsNullOrEmpty(ValorDoBanco))
                        {
                            ValorDoBanco = "0";
                        }

                        v.ValorTotal = Convert.ToDecimal(ValorDoBanco);

                        ListaCaixa.Add(v);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListaCaixa;

        }//PEGAR VENDA TOTAL DO MES

        public List<CaixaModel> ListarCaixaPorAno(String data)
        {
            SqlDataReader dr;
            List<CaixaModel> ListaCaixa = new List<CaixaModel>();

            cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data LIKE '%/" + data + "%'";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        CaixaModel v = new CaixaModel();

                        var ValorDoBanco = Convert.ToString(dr["valor_total_dia"]);


                        if (String.IsNullOrEmpty(ValorDoBanco))
                        {
                            ValorDoBanco = "0";
                        }

                        v.ValorTotal = Convert.ToDecimal(ValorDoBanco);

                        ListaCaixa.Add(v);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListaCaixa;

        }//PEGAR VENDA TOTAL DO ANO

        public Decimal VerRetirada(String data)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();
            Decimal ValorTotal = 0;

            cmd.CommandText = "SELECT retirada FROM TB_CAIXA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ValorDoBanco = Convert.ToString(dr["retirada"]);
                    if (String.IsNullOrEmpty(ValorDoBanco))
                    {
                        ValorDoBanco = "0";
                    }
                    ValorTotal = Convert.ToDecimal(ValorDoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ValorTotal;

        }//PEGAR VALOR RETIRADA

        public Decimal VerDeposito(String data)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();
            Decimal ValorTotal = 0;

            cmd.CommandText = "SELECT deposito FROM TB_CAIXA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ValorDoBanco = Convert.ToString(dr["deposito"]);
                    if (String.IsNullOrEmpty(ValorDoBanco))
                    {
                        ValorDoBanco = "0";
                    }
                    ValorTotal = Convert.ToDecimal(ValorDoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ValorTotal;

        }//PEGAR VALOR RETIRADA

        public void SomarValorTotal(String valor, String data)
        {
            cmd.CommandText = "UPDATE TB_CAIXA SET valor_total_dia = @valor where data = @data";

            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@valor", valor);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
        }//SOMAR E GuARDAR NO BANCO

    }
}
