﻿namespace VivaBem_Vanzelli
{
    partial class frmInstrutor
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
            this.pnlInstrutor = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvInstrutor = new System.Windows.Forms.DataGridView();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInstrutor = new System.Windows.Forms.Label();
            this.pnlInstrutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInstrutor
            // 
            this.pnlInstrutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlInstrutor.Controls.Add(this.btnAlterar);
            this.pnlInstrutor.Controls.Add(this.btnExcluir);
            this.pnlInstrutor.Controls.Add(this.btnCadastrar);
            this.pnlInstrutor.Controls.Add(this.dgvInstrutor);
            this.pnlInstrutor.Controls.Add(this.pctSair);
            this.pnlInstrutor.Controls.Add(this.cbStatus);
            this.pnlInstrutor.Controls.Add(this.lblStatus);
            this.pnlInstrutor.Controls.Add(this.txtNome);
            this.pnlInstrutor.Controls.Add(this.lblNome);
            this.pnlInstrutor.Controls.Add(this.lblInstrutor);
            this.pnlInstrutor.Location = new System.Drawing.Point(5, 5);
            this.pnlInstrutor.Name = "pnlInstrutor";
            this.pnlInstrutor.Size = new System.Drawing.Size(1220, 655);
            this.pnlInstrutor.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnAlterar.Location = new System.Drawing.Point(620, 570);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(185, 45);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnExcluir.Location = new System.Drawing.Point(885, 570);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(185, 45);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCadastrar.Location = new System.Drawing.Point(330, 570);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 45);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvInstrutor
            // 
            this.dgvInstrutor.AllowUserToAddRows = false;
            this.dgvInstrutor.AllowUserToDeleteRows = false;
            this.dgvInstrutor.AllowUserToResizeColumns = false;
            this.dgvInstrutor.AllowUserToResizeRows = false;
            this.dgvInstrutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInstrutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.dgvInstrutor.ColumnHeadersHeight = 50;
            this.dgvInstrutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInstrutor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.dgvInstrutor.Location = new System.Drawing.Point(300, 111);
            this.dgvInstrutor.Name = "dgvInstrutor";
            this.dgvInstrutor.RowTemplate.Height = 25;
            this.dgvInstrutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrutor.Size = new System.Drawing.Size(802, 453);
            this.dgvInstrutor.TabIndex = 40;
            this.dgvInstrutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrutor_CellClick);
            this.dgvInstrutor.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInstrutor_ColumnHeaderMouseClick);
            // 
            // pctSair
            // 
            this.pctSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pctSair.Image = global::VivaBem_Vanzelli.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(1045, 50);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(55, 55);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 39;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.cbStatus.Location = new System.Drawing.Point(910, 63);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(104, 34);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.Text = "Ativo?";
            this.cbStatus.UseVisualStyleBackColor = true;
            this.cbStatus.CheckedChanged += new System.EventHandler(this.cbStatus_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblStatus.Location = new System.Drawing.Point(812, 58);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(308, 42);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtNome.Location = new System.Drawing.Point(379, 63);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(427, 32);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNome.Location = new System.Drawing.Point(295, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(397, 42);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInstrutor
            // 
            this.lblInstrutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblInstrutor.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblInstrutor.Location = new System.Drawing.Point(0, 0);
            this.lblInstrutor.Name = "lblInstrutor";
            this.lblInstrutor.Size = new System.Drawing.Size(146, 655);
            this.lblInstrutor.TabIndex = 0;
            this.lblInstrutor.Text = "I\r\nN\r\nS\r\nT\r\nR\r\nU\r\nT\r\nO\r\nR\r\nE\r\nS";
            this.lblInstrutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInstrutor.UseMnemonic = false;
            // 
            // frmInstrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlInstrutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstrutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_03_Instrutror";
            this.Load += new System.EventHandler(this.frmInstrutor_Load);
            this.pnlInstrutor.ResumeLayout(false);
            this.pnlInstrutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInstrutor;
        private System.Windows.Forms.Label lblInstrutor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.DataGridView dgvInstrutor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}