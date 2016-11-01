namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dGVResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(67, 29);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(150, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(21, 189);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(88, 39);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(67, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(150, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "postgres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(67, 126);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "abracadabra";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(67, 292);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(88, 39);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "&Enviar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(138, 189);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 39);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dGVResult
            // 
            this.dGVResult.AllowUserToOrderColumns = true;
            this.dGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVResult.Location = new System.Drawing.Point(251, 12);
            this.dGVResult.Name = "dGVResult";
            this.dGVResult.Size = new System.Drawing.Size(326, 319);
            this.dGVResult.TabIndex = 12;
            this.dGVResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVResult_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 343);
            this.Controls.Add(this.dGVResult);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paperiun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dGVResult;
    }
}

