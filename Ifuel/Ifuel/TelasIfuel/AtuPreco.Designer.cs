namespace Ifuel
{
    partial class AtuPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtuPreco));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorN = new System.Windows.Forms.MaskedTextBox();
            this.selectComb1 = new System.Windows.Forms.CheckBox();
            this.selectComb2 = new System.Windows.Forms.CheckBox();
            this.selectComb3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atualizar Preço";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(32, 234);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 26);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(192, 234);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 26);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecione o Combustível";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite o novo valor(Ex: 2.50)";
            // 
            // txtValorN
            // 
            this.txtValorN.Location = new System.Drawing.Point(134, 165);
            this.txtValorN.Mask = "0.00";
            this.txtValorN.Name = "txtValorN";
            this.txtValorN.Size = new System.Drawing.Size(46, 20);
            this.txtValorN.TabIndex = 9;
            // 
            // selectComb1
            // 
            this.selectComb1.AutoSize = true;
            this.selectComb1.Location = new System.Drawing.Point(71, 104);
            this.selectComb1.Name = "selectComb1";
            this.selectComb1.Size = new System.Drawing.Size(15, 14);
            this.selectComb1.TabIndex = 10;
            this.selectComb1.UseVisualStyleBackColor = true;
            // 
            // selectComb2
            // 
            this.selectComb2.AutoSize = true;
            this.selectComb2.Location = new System.Drawing.Point(151, 104);
            this.selectComb2.Name = "selectComb2";
            this.selectComb2.Size = new System.Drawing.Size(15, 14);
            this.selectComb2.TabIndex = 11;
            this.selectComb2.UseVisualStyleBackColor = true;
            // 
            // selectComb3
            // 
            this.selectComb3.AutoSize = true;
            this.selectComb3.Location = new System.Drawing.Point(233, 104);
            this.selectComb3.Name = "selectComb3";
            this.selectComb3.Size = new System.Drawing.Size(15, 14);
            this.selectComb3.TabIndex = 12;
            this.selectComb3.UseVisualStyleBackColor = true;
            // 
            // AtuPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(316, 271);
            this.Controls.Add(this.selectComb3);
            this.Controls.Add(this.selectComb2);
            this.Controls.Add(this.selectComb1);
            this.Controls.Add(this.txtValorN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtuPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Preço";
            this.Load += new System.EventHandler(this.AtuPreco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtValorN;
        private System.Windows.Forms.CheckBox selectComb1;
        private System.Windows.Forms.CheckBox selectComb2;
        private System.Windows.Forms.CheckBox selectComb3;
    }
}