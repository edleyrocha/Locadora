namespace crud
{
    partial class AlterarRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlteraDescricao = new System.Windows.Forms.TextBox();
            this.lblIDprod = new System.Windows.Forms.Label();
            this.txtAlteraPreco = new System.Windows.Forms.TextBox();
            this.BtSalvarAlteracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alteração de Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço: ";
            // 
            // txtAlteraDescricao
            // 
            this.txtAlteraDescricao.Location = new System.Drawing.Point(96, 98);
            this.txtAlteraDescricao.Name = "txtAlteraDescricao";
            this.txtAlteraDescricao.Size = new System.Drawing.Size(431, 20);
            this.txtAlteraDescricao.TabIndex = 4;
            // 
            // lblIDprod
            // 
            this.lblIDprod.AutoSize = true;
            this.lblIDprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDprod.Location = new System.Drawing.Point(52, 64);
            this.lblIDprod.Name = "lblIDprod";
            this.lblIDprod.Size = new System.Drawing.Size(73, 20);
            this.lblIDprod.TabIndex = 5;
            this.lblIDprod.Text = "lblIDprod";
            // 
            // txtAlteraPreco
            // 
            this.txtAlteraPreco.Location = new System.Drawing.Point(76, 132);
            this.txtAlteraPreco.Name = "txtAlteraPreco";
            this.txtAlteraPreco.Size = new System.Drawing.Size(112, 20);
            this.txtAlteraPreco.TabIndex = 6;
            // 
            // BtSalvarAlteracao
            // 
            this.BtSalvarAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtSalvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvarAlteracao.Location = new System.Drawing.Point(16, 170);
            this.BtSalvarAlteracao.Name = "BtSalvarAlteracao";
            this.BtSalvarAlteracao.Size = new System.Drawing.Size(84, 34);
            this.BtSalvarAlteracao.TabIndex = 7;
            this.BtSalvarAlteracao.Text = "Salvar";
            this.BtSalvarAlteracao.UseVisualStyleBackColor = false;
            this.BtSalvarAlteracao.Click += new System.EventHandler(this.BtSalvarAlteracao_Click);
            this.BtSalvarAlteracao.MouseLeave += new System.EventHandler(this.BtSalvarAlteracao_MouseLeave);
            this.BtSalvarAlteracao.MouseHover += new System.EventHandler(this.BtSalvarAlteracao_MouseHover);
            // 
            // AlterarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 216);
            this.Controls.Add(this.BtSalvarAlteracao);
            this.Controls.Add(this.txtAlteraPreco);
            this.Controls.Add(this.lblIDprod);
            this.Controls.Add(this.txtAlteraDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlterarRegistro";
            this.Text = "AlterarRegistro";
            this.Load += new System.EventHandler(this.AlterarRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlteraDescricao;
        private System.Windows.Forms.Label lblIDprod;
        private System.Windows.Forms.TextBox txtAlteraPreco;
        private System.Windows.Forms.Button BtSalvarAlteracao;
    }
}