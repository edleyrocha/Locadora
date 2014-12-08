using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace crud
{
    class BizLayer
    {
        private string ValidaInputDados(string descricao, string preco)
        {
            if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(preco))
            {
                return "Favor preencher os campos de descrição e preço!!";
            }
            else
            {
                try
                {
                    if (preco.Contains("."))
                        return "Favor utilizar a vírgula para separar os numeros inteiros dos numeros decimais";

                    double valor = Convert.ToDouble(preco);
                    
                    if (valor > 999999999999.99)
                        return "O valor não pode ultrapassar: 999999999999.99";

                    return "OK";
                }
                catch(Exception)
                {
                    return "Preço digitado inválido!!";
                }
            }
        }

        public string _ValidaInputDados(string descricao, string preco)
        {
            return ValidaInputDados(descricao, preco);
        }

        private string InsereDadosBD(string descricao, double preco)
        {
            daoBanco dao = new daoBanco();
            return dao._InserirProduto(descricao, preco);
        }

        public string _InsereDadosBD(string descricao, double preco)
        {
            return InsereDadosBD(descricao, preco);
        }

        private DataTable PesquisaAlterarProdutos(string descricao)
        {
            descricao = descricao.ToUpper();
            daoBanco dao = new daoBanco();
            return dao._PesquisaAlterarProdutos(descricao);
        }

        public DataTable _PesquisaAlterarProdutos(string descricao)
        {
            try
            {
                return PesquisaAlterarProdutos(descricao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private string AlterarDadosProduto(string descricao, double preco, int id)
        {
            daoBanco dao = new daoBanco();
            try
            {
                dao._AlteraDadosProduto(descricao, preco, id);
                return "Dados Alterados com sucesso!!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar os dados: "+ex.Message;
            }
            
        }

        public string _AlterarDadosProduto(string descricao, double preco, int id)
        {
            return AlterarDadosProduto(descricao, preco, id);
        }

        private string DeletarRegistroProduto(int id, string descricao, double preco)
        {
            daoBanco dao = new daoBanco();
            try
            {
                dao._DeletarDadosProduto(descricao, preco, id);
                return "Dados Deletados com sucesso!!";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string _DeletarRegistroProduto(int id, string descricao, double preco)
        {
            return DeletarRegistroProduto(id, descricao, preco);
        }

        private DataTable PesquisaAlterarProdutosRec(string descricao)
        {
            descricao = descricao.ToUpper();
            daoBanco dao = new daoBanco();
            return dao._PesquisaAlterarProdutosRec(descricao);
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

        private string RecuperarRegistroDeletado(int id)
        {
            daoBanco dao = new daoBanco();
            try
            {
                dao._RecuperarRegistroDeletado(id);
                return "Dados Recuperados com sucesso!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string _RecuperarRegistroDeletado(int id)
        {
            return RecuperarRegistroDeletado(id);
        }

    }
}
