namespace VivaBem_Vanzelli
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pctSenha = new System.Windows.Forms.Panel();
            this.pctMostrar = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlSenha = new System.Windows.Forms.PictureBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pctSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSenha)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtEmail.Location = new System.Drawing.Point(50, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 24);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(198, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.pctSenha);
            this.panel1.Controls.Add(this.pnlEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pctFechar);
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(5)))));
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnEntrar.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.btnEntrar.Location = new System.Drawing.Point(100, 350);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(300, 50);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pctSenha
            // 
            this.pctSenha.BackColor = System.Drawing.Color.White;
            this.pctSenha.Controls.Add(this.pctMostrar);
            this.pctSenha.Controls.Add(this.txtSenha);
            this.pctSenha.Controls.Add(this.pnlSenha);
            this.pctSenha.Location = new System.Drawing.Point(79, 232);
            this.pctSenha.Name = "pctSenha";
            this.pctSenha.Size = new System.Drawing.Size(340, 50);
            this.pctSenha.TabIndex = 10;
            // 
            // pctMostrar
            // 
            this.pctMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pctMostrar.Image")));
            this.pctMostrar.Location = new System.Drawing.Point(320, 35);
            this.pctMostrar.Name = "pctMostrar";
            this.pctMostrar.Size = new System.Drawing.Size(20, 15);
            this.pctMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMostrar.TabIndex = 2;
            this.pctMostrar.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtSenha.Location = new System.Drawing.Point(50, 13);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(286, 24);
            this.txtSenha.TabIndex = 1;
            // 
            // pnlSenha
            // 
            this.pnlSenha.Image = ((System.Drawing.Image)(resources.GetObject("pnlSenha.Image")));
            this.pnlSenha.Location = new System.Drawing.Point(5, 5);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(40, 40);
            this.pnlSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlSenha.TabIndex = 0;
            this.pnlSenha.TabStop = false;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.pctEmail);
            this.pnlEmail.Location = new System.Drawing.Point(79, 123);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(340, 50);
            this.pnlEmail.TabIndex = 10;
            // 
            // pctEmail
            // 
            this.pctEmail.Image = ((System.Drawing.Image)(resources.GetObject("pctEmail.Image")));
            this.pctEmail.Location = new System.Drawing.Point(5, 5);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(40, 40);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmail.TabIndex = 0;
            this.pctEmail.TabStop = false;
            // 
            // pctFechar
            // 
            this.pctFechar.Image = ((System.Drawing.Image)(resources.GetObject("pctFechar.Image")));
            this.pctFechar.Location = new System.Drawing.Point(453, 3);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(44, 41);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFechar.TabIndex = 0;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(50, 150);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(400, 166);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pctSenha.ResumeLayout(false);
            this.pctSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSenha)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel pctSenha;
        private System.Windows.Forms.PictureBox pctMostrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pnlSenha;
        private System.Windows.Forms.Panel pnlEmail;
    }
}