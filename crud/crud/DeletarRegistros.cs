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
    public partial class DeletarRegistros : Form
    {
        public DeletarRegistros()
        {
            InitializeComponent();
        }

        private void DeletarRegistros_Load(object sender, EventArgs e)
        {
            try
            {
                double id = Produtos._Id;
                double preco = Produtos._Preco;
                lblidDel.Text = Convert.ToString(id);
                lblDelDescricao.Text = Produtos._Descricao;
                lblDelPreco.Text = Convert.ToString(preco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve Problemas ao Carregar os dados para alteração!! \n Acionar o Suporte!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BizLayer biz = new BizLayer();
            MessageBox.Show(biz._DeletarRegistroProduto(Convert.ToInt32(lblidDel.Text), lblDelDescricao.Text, Convert.ToDouble(lblDelPreco.Text)));
            this.Close();
        }
    }
}
