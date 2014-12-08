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
    public partial class AlterarRegistro : Form
    {
        public AlterarRegistro()
        {
            InitializeComponent();
        }

        private void BtSalvarAlteracao_MouseHover(object sender, EventArgs e)
        {
            BtSalvarAlteracao.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void BtSalvarAlteracao_MouseLeave(object sender, EventArgs e)
        {
            BtSalvarAlteracao.BackColor = System.Drawing.Color.LightGreen;
        }

        private void AlterarRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                double id = Produtos._Id;
                double preco = Produtos._Preco;
                lblIDprod.Text = Convert.ToString(id);
                txtAlteraDescricao.Text = Produtos._Descricao;
                txtAlteraPreco.Text = Convert.ToString(preco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve Problemas ao Carregar os dados para alteração!! \n Acionar o Suporte!!");
            }


        }

        private void BtSalvarAlteracao_Click(object sender, EventArgs e)
        {
            BizLayer biz = new BizLayer();

            if (biz._ValidaInputDados(txtAlteraDescricao.Text, txtAlteraPreco.Text) == "OK")
            {
                MessageBox.Show(biz._AlterarDadosProduto(txtAlteraDescricao.Text, Convert.ToDouble(txtAlteraPreco.Text), Convert.ToInt32(lblIDprod.Text)));
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor conferir os dados digitados para a alteração!!");
            }
        }



    }
}
