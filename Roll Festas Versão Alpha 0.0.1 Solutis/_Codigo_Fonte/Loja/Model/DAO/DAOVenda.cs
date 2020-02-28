using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model
{
    class DAOVenda
    {
        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void NovaVenda(String data, String usuario, String valortotal, String valorpago, String troco, String tipopagamento,int status_pagamento,String valor_pendente, String nome)
        {

            cmd.CommandText = "INSERT INTO TB_VENDA (data,usuario,valortotal,valorpago,troco,tipopagamento,status_pagamento,valor_pendente,nome) VALUES (@data,@usuario,@valortotal,@valorpago,@troco,@tipopagamento,@status_pagamento,@valor_pendente,@nome)";

            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@valortotal", valortotal);
            cmd.Parameters.AddWithValue("@valorpago", valorpago);
            cmd.Parameters.AddWithValue("@troco", troco);
            cmd.Parameters.AddWithValue("@tipopagamento", tipopagamento); 
            cmd.Parameters.AddWithValue("@status_pagamento", status_pagamento);
            cmd.Parameters.AddWithValue("@valor_pendente", valor_pendente);
            cmd.Parameters.AddWithValue("@nome", nome);


            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Venda cadastrado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao cadastrar venda. Erro:  " + e);
            }

        }//INSERIR VENDA

        public VendaModel ExibirDetalhesdaVenda(String id)
        {
            SqlDataReader dr;
            VendaModel venda = new VendaModel();

            cmd.CommandText = "SELECT * FROM TB_VENDA WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var iddoBanco = dr["id"];
                    var datadoBanco = dr["data"];
                    var usuaruidoBanco = dr["usuario"];
                    var valortotaldoBanco = dr["valortotal"];
                    var valorpagodoBanco = dr["valorpago"];
                    var trocodoBanco = dr["troco"];
                    var tipopagamentodoBanco = dr["tipopagamento"];
                    var nomedoBanco = dr["nome"];


                    venda.Id = Convert.ToInt32(iddoBanco);
                    venda.Data = Convert.ToString(datadoBanco);
                    venda.Usuario = Convert.ToString(usuaruidoBanco);
                    venda.ValorTotal = Convert.ToString(valortotaldoBanco);
                    venda.ValorPago = Convert.ToString(valorpagodoBanco);
                    venda.Troco = Convert.ToString(trocodoBanco);
                    venda.TipoPagamento = Convert.ToString(tipopagamentodoBanco);
                    venda.nome = Convert.ToString(nomedoBanco);

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;
        }//EXIBIR DETALHES DA VENDA

        public List<VendaModel> ListarVendas(String data)
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();

            

            cmd.CommandText = "SELECT * FROM TB_VENDA WHERE data = @data";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        VendaModel v = new VendaModel();

                        var iddoBanco = Convert.ToString( dr["id"] );
                        var datadoBanco = Convert.ToString(dr["data"]);
                        var usuaruidoBanco = Convert.ToString(dr["usuario"]);
                        var valortotaldoBanco = Convert.ToString(dr["valortotal"]);
                        var valorpagodoBanco = Convert.ToString(dr["valorpago"]);
                        var trocodoBanco = Convert.ToString(dr["troco"]);
                        var tipopagamentodoBanco = Convert.ToString(dr["tipopagamento"]);
                        var nomedoBanco = dr["nome"];

                        if (String.IsNullOrEmpty(trocodoBanco))
                        {
                            trocodoBanco = "0";
                        }
                        if (String.IsNullOrEmpty(valorpagodoBanco))
                        {
                            valorpagodoBanco = "0";
                        }

                        v.Id = Convert.ToInt32(iddoBanco);
                        v.Data = Convert.ToString(datadoBanco);
                        v.Usuario = Convert.ToString(usuaruidoBanco);
                        v.ValorTotal = Convert.ToString(valortotaldoBanco);
                        v.ValorPago = Convert.ToString(valorpagodoBanco);
                        v.Troco = Convert.ToString(trocodoBanco);
                        v.TipoPagamento = Convert.ToString(tipopagamentodoBanco);
                        v.nome = Convert.ToString(nomedoBanco);


                        venda.Add(v);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }//EXIBIR TODAS AS VENDAS DO DIA

        public List<VendaModel> ListarVendasPorVendedor(String vendedor, String ano)
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();



            cmd.CommandText = "SELECT * FROM TB_VENDA WHERE usuario = @usuario AND ";

            cmd.Parameters.AddWithValue("@usuario", vendedor);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        VendaModel v = new VendaModel();

                        var datadoBanco = Convert.ToString(dr["data"]);
                        var valortotaldoBanco = Convert.ToString(dr["valortotal"]);

                        v.Data = Convert.ToString(datadoBanco);
                        v.ValorTotal = Convert.ToString(valortotaldoBanco);

                        venda.Add(v);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }//EXIBIR TODAS AS VENDAS DO DIA

        public List<VendaModel> ListarVendasPagas(String data)
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();



            cmd.CommandText = "SELECT * FROM TB_VENDA WHERE data = @data and status_pagamento = 1";

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        VendaModel v = new VendaModel();

                        var iddoBanco = Convert.ToString(dr["id"]);
                        var datadoBanco = Convert.ToString(dr["data"]);
                        var usuaruidoBanco = Convert.ToString(dr["usuario"]);
                        var valortotaldoBanco = Convert.ToString(dr["valortotal"]);
                        var valorpagodoBanco = Convert.ToString(dr["valorpago"]);
                        var trocodoBanco = Convert.ToString(dr["troco"]);
                        var tipopagamentodoBanco = Convert.ToString(dr["tipopagamento"]);
                        var nomedoBanco = dr["nome"];

                        if (String.IsNullOrEmpty(trocodoBanco))
                        {
                            trocodoBanco = "0";
                        }
                        if (String.IsNullOrEmpty(valorpagodoBanco))
                        {
                            valorpagodoBanco = "0";
                        }

                        v.Id = Convert.ToInt32(iddoBanco);
                        v.Data = Convert.ToString(datadoBanco);
                        v.Usuario = Convert.ToString(usuaruidoBanco);
                        v.ValorTotal = Convert.ToString(valortotaldoBanco);
                        v.ValorPago = Convert.ToString(valorpagodoBanco);
                        v.Troco = Convert.ToString(trocodoBanco);
                        v.TipoPagamento = Convert.ToString(tipopagamentodoBanco);
                        v.nome = Convert.ToString(nomedoBanco);


                        venda.Add(v);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }//EXIBIR TODAS AS VENDAS PAGAS

        public List<VendaModel> ListarVendasPendentes()
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();



            cmd.CommandText = "SELECT * FROM TB_VENDA WHERE status_pagamento = 2";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        VendaModel v = new VendaModel();

                        var iddoBanco = Convert.ToString(dr["id"]);
                        var datadoBanco = Convert.ToString(dr["data"]);
                        var usuaruidoBanco = Convert.ToString(dr["usuario"]);
                        var valortotaldoBanco = Convert.ToString(dr["valortotal"]);
                        var valorpagodoBanco = Convert.ToString(dr["valorpago"]);
                        var trocodoBanco = Convert.ToString(dr["troco"]);
                        var tipopagamentodoBanco = Convert.ToString(dr["tipopagamento"]);
                        var valorpendentedoBanco = Convert.ToString(dr["valor_pendente"]);
                        var nomedoBanco = dr["nome"];


                        if (String.IsNullOrEmpty(trocodoBanco))
                        {
                            trocodoBanco = "0";
                        }
                        if (String.IsNullOrEmpty(valorpagodoBanco))
                        {
                            valorpagodoBanco = "0";
                        }

                        v.Id = Convert.ToInt32(iddoBanco);
                        v.Data = Convert.ToString(datadoBanco);
                        v.Usuario = Convert.ToString(usuaruidoBanco);
                        v.ValorTotal = Convert.ToString(valortotaldoBanco);
                        v.ValorPago = Convert.ToString(valorpagodoBanco);
                        v.Troco = Convert.ToString(trocodoBanco);
                        v.TipoPagamento = Convert.ToString(tipopagamentodoBanco);
                        v.ValorPendente = Convert.ToString(valorpendentedoBanco);
                        v.nome = Convert.ToString(nomedoBanco);

                        venda.Add(v);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }//EXIBIR TODAS AS VENDAS PENDENTES

        public VendaModel ListarVendasPendentesPorId(String id)
        {
            SqlDataReader dr;
            VendaModel venda = new VendaModel();

            cmd.CommandText = "SELECT * FROM TB_VENDA WHERE status_pagamento = 2 and id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                        var iddoBanco = dr["id"];
                        var datadoBanco = Convert.ToString (dr["data"]);
                        var usuaruidoBanco = Convert.ToString(dr["usuario"]);
                        var valortotaldoBanco = Convert.ToString(dr["valortotal"]);
                        var valorpagodoBanco = Convert.ToString(dr["valorpago"]);
                        var trocodoBanco = Convert.ToString(dr["troco"]);
                        var tipopagamentodoBanco = Convert.ToString(dr["tipopagamento"]);
                        var valorpendentedoBanco = Convert.ToString(dr["valor_pendente"]);
                          var nomedoBanco = Convert.ToString( dr["nome"]);

                    if (String.IsNullOrEmpty(trocodoBanco))
                    {
                        trocodoBanco = "0";
                    }
                    if (String.IsNullOrEmpty(valorpagodoBanco))
                    {
                        valorpagodoBanco = "0";
                    }

                    venda.Id = Convert.ToInt32(iddoBanco);
                    venda.Data = Convert.ToString(datadoBanco);
                    venda.Usuario = Convert.ToString(usuaruidoBanco);
                    venda.ValorTotal = Convert.ToString(valortotaldoBanco);
                    venda.ValorPago = Convert.ToString(valorpagodoBanco);
                    venda.Troco = Convert.ToString(trocodoBanco);
                    venda.TipoPagamento = Convert.ToString(tipopagamentodoBanco);
                    venda.ValorPendente = Convert.ToString(valorpendentedoBanco);
                    venda.nome = Convert.ToString(nomedoBanco);


                }

                

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }//EXIBIR VENDAS PENDENTE POR ID

        public Decimal PegarValorPorNome (String nome)
        {
            SqlDataReader dr;
            VendaModel venda = new VendaModel();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE nome = @nome";

            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var nomedoBanco = dr["preco"];
                    venda.ValorParaCalcuar = Convert.ToDecimal( nomedoBanco );
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda.ValorParaCalcuar;
        }//PEGA O VALOR DO PRODUTO PELO NOME DELE

        public void RetirarPendencia(String id)
        {

            cmd.CommandText = "UPDATE TB_VENDA SET status_pagamento = 1, valor_pendente = 0 WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Pendencia retirada com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao retirar pendencia. Erro:  " + e);
            }



        }//RETIRA STATUS DE PENDENCIA

        public void CancelarVenda(String id)
        {
            cmd.CommandText = "DELETE FROM TB_VENDA where id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Venda cancelada com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao cancelar venda. Erro:  " + e);
            }

        }//APAGA VENDA

        public VendaModel PegarUltimaVendaParaGerarRecibo()
        {
            SqlDataReader dr;
            VendaModel venda = new VendaModel();

            cmd.CommandText = "SELECT * FROM TB_VENDA ORDER BY id DESC";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var iddoBanco = dr["id"];
                    var datadoBanco = dr["data"];
                    var usuaruidoBanco = dr["usuario"];
                    var valortotaldoBanco = dr["valortotal"];
                    var valorpagodoBanco = dr["valorpago"];
                    var trocodoBanco = dr["troco"];
                    var tipopagamentodoBanco = dr["tipopagamento"];
                    var nomedoBanco = dr["nome"];


                    venda.Id = Convert.ToInt32(iddoBanco);
                    venda.Data = Convert.ToString(datadoBanco);
                    venda.Usuario = Convert.ToString(usuaruidoBanco);
                    venda.ValorTotal = Convert.ToString(valortotaldoBanco);
                    venda.ValorPago = Convert.ToString(valorpagodoBanco);
                    venda.Troco = Convert.ToString(trocodoBanco);
                    venda.TipoPagamento = Convert.ToString(tipopagamentodoBanco);
                    venda.nome = Convert.ToString(nomedoBanco);

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;
        }//EXIBIR DETALHES DA VENDA

        public double PegarVendaPorUsuarior(string nome , string data)
        {
            SqlDataReader dr;
            double ValorTotal = 0;

            cmd.CommandText = @"SELECT * FROM TB_VENDA WHERE usuario = @nome AND data LIKE '%/" + data + "%'";

            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {

                        string ValorDoBanco = Convert.ToString( dr["valortotal"] );
                        if (string.IsNullOrEmpty(ValorDoBanco))
                        {
                            ValorDoBanco = "0";
                        }
                        
                        var ValorVenda = Convert.ToDouble(ValorDoBanco);

                        ValorTotal = ValorTotal + ValorVenda;
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ValorTotal;

        }//PEGAR VENDA DO VENDEDOR POR ANO

    }
}
