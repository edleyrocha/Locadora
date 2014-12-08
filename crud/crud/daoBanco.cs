using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace crud
{
    class daoBanco
    {
        private void InserirProduto(string descricao, double preco)
        {
            ConnectionDataBase conexao = new ConnectionDataBase();
            SqlConnection con = conexao._GetConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.sp_inserirProduto";
            try
            {
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@pDescricao", descricao);
                cmd.Parameters.AddWithValue("@pPreco", preco);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }   
        }

        public string _InserirProduto(string descricao, double preco)
        {
            try
            {
                InserirProduto(descricao, preco);
                return "Produto Incluso com sucesso";
            }
            catch
            {
                return "Houve uma falha ao Inserir as informações \n Entre em contato com o suporte!!";
            }
        }

        private DataTable PesquisaAlterarProdutos(string descricao)
        {
            ConnectionDataBase conexao = new ConnectionDataBase();
            SqlConnection con = conexao._GetConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from dbo.produto where upper(descricao) like '%"+@descricao+"%'";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@descricao", descricao);

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable _PesquisaAlterarProdutos(string descricao)
        {
            try
            {
                return PesquisaAlterarProdutos(descricao);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private void AlterarDadosProduto(string descricao, double preco, int id)
        {
            ConnectionDataBase conexao = new ConnectionDataBase();
            SqlConnection con = conexao._GetConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update produto set descricao = @pDescricao, preco = @pPreco where id = @id";
            cmd.Connection = con;
            try
            {
                cmd.Parameters.AddWithValue("@pDescricao", descricao);
                cmd.Parameters.AddWithValue("@pPreco", preco);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        public void _AlteraDadosProduto(string descricao, double preco, int id)
        {
            try
            {
                AlterarDadosProduto(descricao, preco, id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DeletarDadosProduto(string descricao, double preco, int id)
        {
            ConnectionDataBase conexao = new ConnectionDataBase();
            SqlConnection con = conexao._GetConexao();
            SqlCommand cmddelete = new SqlCommand();
            cmddelete.CommandText = "delete from produto where id = @pID";
            cmddelete.Connection = con;
            SqlCommand cmdbackup = new SqlCommand();
            cmdbackup.CommandText = @"insert into produto_deletado(descricao, preco, id)
                                        select descricao, preco, id from produto where id = @pID";
            cmdbackup.Connection = con;

            try
            {
                con.Open();
                cmdbackup.Parameters.AddWithValue("@pID", id);
                cmddelete.Parameters.AddWithValue("@pID", id);
                cmdbackup.ExecuteNonQuery();
                cmddelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public void _DeletarDadosProduto(string descricao, double preco, int id)
        {
            DeletarDadosProduto(descricao, preco, id);
        }

        private void RecuperarRegistroDeletado(int id)
        {
            ConnectionDataBase conexao = new ConnectionDataBase();
            SqlConnection con = conexao._GetConexao();
            SqlCommand cmdDeleteRec = new SqlCommand();
            cmdDeleteRec.Connection = con;
            cmdDeleteRec.CommandText = "delete from produto_deletado where id = @pID";
            SqlCommand cmdDadoRecuperado = new SqlCommand();
            cmdDadoRecuperado.Connection = con;
            cmdDadoRecuperado.CommandText = @"insert into produto(descricao, preco, id)
                                                select descricao, preco, id from produto_deletado where id = @pID";
            SqlCommand comandoloko = new SqlCommand();
            comandoloko.Connection = con;
            comandoloko.CommandText = "SET IDENTITY_INSERT produto ON";

            SqlCommand comandomaisloko = new SqlCommand();
            comandomaisloko.Connection = con;
            comandomaisloko.CommandText = "SET IDENTITY_INSERT produto OFF";

            try
            {
                cmdDeleteRec.Parameters.AddWithValue("@pID", id);
                cmdDadoRecuperado.Parameters.AddWithValue("@pID", id);
                con.Open();
                comandoloko.ExecuteNonQuery();
                cmdDadoRecuperado.ExecuteNonQuery();
                comandomaisloko.ExecuteNonQuery();
                cmdDeleteRec.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public void _RecuperarRegistroDeletado(int id)
        {
            RecuperarRegistroDeletado(id);
        }

        private DataTable PesquisaAlterarProdutosRec(string descricao)
        {
            ConnectionDataBase conexao = new ConnectionDataBase();
            SqlConnection con = conexao._GetConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from dbo.produto_deletado where upper(descricao) like '%"+descricao+"%'";
            cmd.Connection = con;

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable _PesquisaAlterarProdutosRec(string descricao)
        {
            try
            {
                return PesquisaAlterarProdutosRec(descricao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
