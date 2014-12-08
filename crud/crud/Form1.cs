using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class formprincipal : Form
    {
        public formprincipal()
        {
            InitializeComponent();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            BizLayer biz = new BizLayer();
            if (biz._ValidaInputDados(txtDescricao.Text, txtPreco.Text) == "OK")
            {
                MessageBox.Show(biz._InsereDadosBD(txtDescricao.Text, Convert.ToDouble(txtPreco.Text)));
                txtDescricao.Clear();
                txtPreco.Clear();
            }
            else
            {
                MessageBox.Show(biz._ValidaInputDados(txtDescricao.Text, txtPreco.Text));
            }
        }

        private void BtAdicionar_MouseHover(object sender, EventArgs e)
        {
            BtAdicionar.Width = 85;
            BtAdicionar.Height = 85;
        }

        private void BtAdicionar_MouseLeave(object sender, EventArgs e)
        {
            BtAdicionar.Width = 78;
            BtAdicionar.Height = 77;
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesqDescricao.Text))
            {
                BizLayer biz = new BizLayer();
                try
                {
                    GridPesqProdutos.DataSource = null;
                    GridPesqProdutos.DataSource = biz._PesquisaAlterarProdutos(txtPesqDescricao.Text);
                    lblCountReg.Text = GridPesqProdutos.Rows.Count.ToString();

                    if (lblCountReg.Text == "0")
                        MessageBox.Show("Nenhum registro encontrado com os dados informados!!");
                }
                catch(Exception)
                {
                    MessageBox.Show("Falha ao carregar registros, \n favor acionar o suporte!!");
                }
            }
            else 
            {
                MessageBox.Show("Favor preencher a descrição do Produto para pesquisa!!");
            }
        }

        private void GridPesqProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Produtos._Id = Convert.ToInt32(GridPesqProdutos.Rows[e.RowIndex].Cells[0].Value.ToString());
                Produtos._Descricao = GridPesqProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
                Produtos._Preco = Convert.ToDouble(GridPesqProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
                AlterarRegistro telaAlterarRegistro = new AlterarRegistro();
                telaAlterarRegistro.ShowDialog();
                
                
            }
            catch (Exception ex)
            {
               
            }

            
        }

        private void BtBuscaRegDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesqDeletaDesc.Text))
            {
                BizLayer biz = new BizLayer();
                try
                {
                    GridViewDeletaDados.DataSource = null;
                    GridViewDeletaDados.DataSource = biz._PesquisaAlterarProdutos(txtPesqDeletaDesc.Text);
                    lblQtdRegDel.Text = GridViewDeletaDados.Rows.Count.ToString();

                    if (lblQtdRegDel.Text == "0")
                        MessageBox.Show("Nenhum registro encontrado com os dados informados!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar registros, \n favor acionar o suporte!!");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher a descrição do Produto para pesquisa!!");
            }
        }

        private void GridViewDeletaDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Produtos._Id = Convert.ToInt32(GridViewDeletaDados.Rows[e.RowIndex].Cells[0].Value.ToString());
                Produtos._Descricao = GridViewDeletaDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                Produtos._Preco = Convert.ToDouble(GridViewDeletaDados.Rows[e.RowIndex].Cells[2].Value.ToString());
                DeletarRegistros telaDeletarRegistro = new DeletarRegistros();
                telaDeletarRegistro.ShowDialog();


            }
            catch (Exception ex)
            {
                
            }
        }

        private void BtBuscarRegRec_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecDescricao.Text))
            {
                BizLayer biz = new BizLayer();
                try
                {
                    GridViewRegRec.DataSource = null;
                    GridViewRegRec.DataSource = biz._PesquisaAlterarProdutosRec(txtRecDescricao.Text);
                    lblCountRegRec.Text = GridViewRegRec.Rows.Count.ToString();

                    if (lblCountRegRec.Text == "0")
                        MessageBox.Show("Nenhum registro encontrado com os dados informados!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar registros, \n favor acionar o suporte!!");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher a descrição do Produto para pesquisa!!");
            }
        }

        private void GridViewRegRec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BizLayer biz = new BizLayer();
                string id = GridViewRegRec.Rows[e.RowIndex].Cells[1].Value.ToString();
                int _id = Convert.ToInt32(id);
                MessageBox.Show(biz._RecuperarRegistroDeletado(_id));
            }
            catch
            { }

        }


    }
}
