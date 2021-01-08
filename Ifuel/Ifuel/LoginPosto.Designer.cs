namespace Ifuel
{
    partial class LoginPosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPosto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login-Posto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe os  dados para realizar LoginUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuário";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(110, 123);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(178, 20);
            this.textUser.TabIndex = 6;
            this.textUser.Text = "Digite seu usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(110, 186);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(178, 20);
            this.textSenha.TabIndex = 8;
            this.textSenha.Text = "Digite sua senha";
            // 
            // btnLogar
            // 
            this.btnLogar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(141, 225);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(112, 26);
            this.btnLogar.TabIndex = 9;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(87, 272);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 26);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(215, 272);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(87, 26);
            this.btnCadastro.TabIndex = 11;
            this.btnCadastro.Text = "Cadastre-se";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // LoginPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 310);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-Posto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastro;
    }
}