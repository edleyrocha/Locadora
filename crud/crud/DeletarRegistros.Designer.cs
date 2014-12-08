namespace crud
{
    partial class DeletarRegistros
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
            this.lblidDel = new System.Windows.Forms.Label();
            this.lblDelDescricao = new System.Windows.Forms.Label();
            this.lblDelPreco = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deletar Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço: ";
            // 
            // lblidDel
            // 
            this.lblidDel.AutoSize = true;
            this.lblidDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidDel.Location = new System.Drawing.Point(54, 77);
            this.lblidDel.Name = "lblidDel";
            this.lblidDel.Size = new System.Drawing.Size(68, 20);
            this.lblidDel.TabIndex = 4;
            this.lblidDel.Text = "lblidDel";
            // 
            // lblDelDescricao
            // 
            this.lblDelDescricao.AutoSize = true;
            this.lblDelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelDescricao.Location = new System.Drawing.Point(115, 109);
            this.lblDelDescricao.Name = "lblDelDescricao";
            this.lblDelDescricao.Size = new System.Drawing.Size(134, 20);
            this.lblDelDescricao.TabIndex = 5;
            this.lblDelDescricao.Text = "lblDelDescricao";
            // 
            // lblDelPreco
            // 
            this.lblDelPreco.AutoSize = true;
            this.lblDelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelPreco.Location = new System.Drawing.Point(75, 139);
            this.lblDelPreco.Name = "lblDelPreco";
            this.lblDelPreco.Size = new System.Drawing.Size(100, 20);
            this.lblDelPreco.TabIndex = 6;
            this.lblDelPreco.Text = "lblDelPreco";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeletarRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDelPreco);
            this.Controls.Add(this.lblDelDescricao);
            this.Controls.Add(this.lblidDel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeletarRegistros";
            this.Text = "DeletarRegistros";
            this.Load += new System.EventHandler(this.DeletarRegistros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblidDel;
        private System.Windows.Forms.Label lblDelDescricao;
        private System.Windows.Forms.Label lblDelPreco;
        private System.Windows.Forms.Button button1;
    }
}