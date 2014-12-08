namespace crud
{
    partial class formprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.lblCountReg = new System.Windows.Forms.Label();
            this.GridPesqProdutos = new System.Windows.Forms.DataGridView();
            this.txtPesqDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.BtBuscaRegDel = new System.Windows.Forms.Button();
            this.lblQtdRegDel = new System.Windows.Forms.Label();
            this.GridViewDeletaDados = new System.Windows.Forms.DataGridView();
            this.txtPesqDeletaDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.BtBuscarRegRec = new System.Windows.Forms.Button();
            this.lblCountRegRec = new System.Windows.Forms.Label();
            this.GridViewRegRec = new System.Windows.Forms.DataGridView();
            this.txtRecDescricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesqProdutos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDeletaDados)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRegRec)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BtAdicionar);
            this.tabPage1.Controls.Add(this.txtPreco);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADICIONAR REGISTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preencha os Campos Abaixo";
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAdicionar.Image = global::crud.Properties.Resources._1416127607_Drive_Download;
            this.BtAdicionar.Location = new System.Drawing.Point(66, 143);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(78, 77);
            this.BtAdicionar.TabIndex = 5;
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            this.BtAdicionar.MouseLeave += new System.EventHandler(this.BtAdicionar_MouseLeave);
            this.BtAdicionar.MouseHover += new System.EventHandler(this.BtAdicionar_MouseHover);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(65, 107);
            this.txtPreco.MaxLength = 15;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(107, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(66, 75);
            this.txtDescricao.MaxLength = 1000;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(431, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.BtBuscar);
            this.tabPage2.Controls.Add(this.lblCountReg);
            this.tabPage2.Controls.Add(this.GridPesqProdutos);
            this.tabPage2.Controls.Add(this.txtPesqDescricao);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ALTERAR REGISTRO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade de Registros: ";
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(349, 5);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(46, 23);
            this.BtBuscar.TabIndex = 8;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // lblCountReg
            // 
            this.lblCountReg.AutoSize = true;
            this.lblCountReg.Location = new System.Drawing.Point(132, 36);
            this.lblCountReg.Name = "lblCountReg";
            this.lblCountReg.Size = new System.Drawing.Size(13, 13);
            this.lblCountReg.TabIndex = 7;
            this.lblCountReg.Text = "0";
            // 
            // GridPesqProdutos
            // 
            this.GridPesqProdutos.AllowUserToAddRows = false;
            this.GridPesqProdutos.AllowUserToDeleteRows = false;
            this.GridPesqProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPesqProdutos.Location = new System.Drawing.Point(3, 52);
            this.GridPesqProdutos.Name = "GridPesqProdutos";
            this.GridPesqProdutos.ReadOnly = true;
            this.GridPesqProdutos.Size = new System.Drawing.Size(499, 200);
            this.GridPesqProdutos.TabIndex = 6;
            this.GridPesqProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPesqProdutos_CellDoubleClick);
            // 
            // txtPesqDescricao
            // 
            this.txtPesqDescricao.Location = new System.Drawing.Point(68, 6);
            this.txtPesqDescricao.MaxLength = 1000;
            this.txtPesqDescricao.Name = "txtPesqDescricao";
            this.txtPesqDescricao.Size = new System.Drawing.Size(277, 20);
            this.txtPesqDescricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.BtBuscaRegDel);
            this.tabPage3.Controls.Add(this.lblQtdRegDel);
            this.tabPage3.Controls.Add(this.GridViewDeletaDados);
            this.tabPage3.Controls.Add(this.txtPesqDeletaDesc);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(505, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DELETAR REGISTRO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantidade de Registros: ";
            // 
            // BtBuscaRegDel
            // 
            this.BtBuscaRegDel.Location = new System.Drawing.Point(349, 4);
            this.BtBuscaRegDel.Name = "BtBuscaRegDel";
            this.BtBuscaRegDel.Size = new System.Drawing.Size(46, 23);
            this.BtBuscaRegDel.TabIndex = 14;
            this.BtBuscaRegDel.Text = "Buscar";
            this.BtBuscaRegDel.UseVisualStyleBackColor = true;
            this.BtBuscaRegDel.Click += new System.EventHandler(this.BtBuscaRegDel_Click);
            // 
            // lblQtdRegDel
            // 
            this.lblQtdRegDel.AutoSize = true;
            this.lblQtdRegDel.Location = new System.Drawing.Point(132, 35);
            this.lblQtdRegDel.Name = "lblQtdRegDel";
            this.lblQtdRegDel.Size = new System.Drawing.Size(13, 13);
            this.lblQtdRegDel.TabIndex = 13;
            this.lblQtdRegDel.Text = "0";
            // 
            // GridViewDeletaDados
            // 
            this.GridViewDeletaDados.AllowUserToAddRows = false;
            this.GridViewDeletaDados.AllowUserToDeleteRows = false;
            this.GridViewDeletaDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDeletaDados.Location = new System.Drawing.Point(3, 51);
            this.GridViewDeletaDados.Name = "GridViewDeletaDados";
            this.GridViewDeletaDados.ReadOnly = true;
            this.GridViewDeletaDados.Size = new System.Drawing.Size(499, 200);
            this.GridViewDeletaDados.TabIndex = 12;
            this.GridViewDeletaDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDeletaDados_CellDoubleClick);
            // 
            // txtPesqDeletaDesc
            // 
            this.txtPesqDeletaDesc.Location = new System.Drawing.Point(68, 5);
            this.txtPesqDeletaDesc.MaxLength = 1000;
            this.txtPesqDeletaDesc.Name = "txtPesqDeletaDesc";
            this.txtPesqDeletaDesc.Size = new System.Drawing.Size(277, 20);
            this.txtPesqDeletaDesc.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descrição:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.BtBuscarRegRec);
            this.tabPage4.Controls.Add(this.lblCountRegRec);
            this.tabPage4.Controls.Add(this.GridViewRegRec);
            this.tabPage4.Controls.Add(this.txtRecDescricao);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(505, 255);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RECUPERAR REGISTRO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quantidade de Registros: ";
            // 
            // BtBuscarRegRec
            // 
            this.BtBuscarRegRec.Location = new System.Drawing.Point(349, 4);
            this.BtBuscarRegRec.Name = "BtBuscarRegRec";
            this.BtBuscarRegRec.Size = new System.Drawing.Size(46, 23);
            this.BtBuscarRegRec.TabIndex = 20;
            this.BtBuscarRegRec.Text = "Buscar";
            this.BtBuscarRegRec.UseVisualStyleBackColor = true;
            this.BtBuscarRegRec.Click += new System.EventHandler(this.BtBuscarRegRec_Click);
            // 
            // lblCountRegRec
            // 
            this.lblCountRegRec.AutoSize = true;
            this.lblCountRegRec.Location = new System.Drawing.Point(132, 35);
            this.lblCountRegRec.Name = "lblCountRegRec";
            this.lblCountRegRec.Size = new System.Drawing.Size(13, 13);
            this.lblCountRegRec.TabIndex = 19;
            this.lblCountRegRec.Text = "0";
            // 
            // GridViewRegRec
            // 
            this.GridViewRegRec.AllowUserToAddRows = false;
            this.GridViewRegRec.AllowUserToDeleteRows = false;
            this.GridViewRegRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRegRec.Location = new System.Drawing.Point(3, 51);
            this.GridViewRegRec.Name = "GridViewRegRec";
            this.GridViewRegRec.ReadOnly = true;
            this.GridViewRegRec.Size = new System.Drawing.Size(499, 200);
            this.GridViewRegRec.TabIndex = 18;
            this.GridViewRegRec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRegRec_CellDoubleClick);
            // 
            // txtRecDescricao
            // 
            this.txtRecDescricao.Location = new System.Drawing.Point(68, 5);
            this.txtRecDescricao.MaxLength = 1000;
            this.txtRecDescricao.Name = "txtRecDescricao";
            this.txtRecDescricao.Size = new System.Drawing.Size(277, 20);
            this.txtRecDescricao.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descrição:";
            // 
            // formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.tabControl1);
            this.Name = "formprincipal";
            this.Text = "CRUD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesqProdutos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDeletaDados)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRegRec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountReg;
        private System.Windows.Forms.DataGridView GridPesqProdutos;
        private System.Windows.Forms.TextBox txtPesqDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtBuscaRegDel;
        private System.Windows.Forms.Label lblQtdRegDel;
        private System.Windows.Forms.DataGridView GridViewDeletaDados;
        private System.Windows.Forms.TextBox txtPesqDeletaDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtBuscarRegRec;
        private System.Windows.Forms.Label lblCountRegRec;
        private System.Windows.Forms.DataGridView GridViewRegRec;
        private System.Windows.Forms.TextBox txtRecDescricao;
        private System.Windows.Forms.Label label10;
    }
}

