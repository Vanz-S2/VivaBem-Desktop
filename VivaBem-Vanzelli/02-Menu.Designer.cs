﻿namespace VivaBem_Vanzelli
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlPlanos = new System.Windows.Forms.Panel();
            this.lblValorPlano = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGeral = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnExercicio = new System.Windows.Forms.Button();
            this.btnBanner = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnTreino = new System.Windows.Forms.Button();
            this.btnPlanos = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnInstrutor = new System.Windows.Forms.Button();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.lblExercicios = new System.Windows.Forms.Label();
            this.lblNumexercicios = new System.Windows.Forms.Label();
            this.lblMatriculas = new System.Windows.Forms.Label();
            this.lblNumMarticulas = new System.Windows.Forms.Label();
            this.lblTreinos = new System.Windows.Forms.Label();
            this.lblNumTreinos = new System.Windows.Forms.Label();
            this.lblPlanos = new System.Windows.Forms.Label();
            this.lblNumPlanos = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblNumAlunos = new System.Windows.Forms.Label();
            this.lblInstrutores = new System.Windows.Forms.Label();
            this.lblNumInstrutores = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.dgvValorPlanos = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlPlanos.SuspendLayout();
            this.pnlCont.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValorPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.dataGridView1);
            this.pnlMenu.Controls.Add(this.pnlPlanos);
            this.pnlMenu.Controls.Add(this.btnEmail);
            this.pnlMenu.Controls.Add(this.btnPagamento);
            this.pnlMenu.Controls.Add(this.btnExercicio);
            this.pnlMenu.Controls.Add(this.btnBanner);
            this.pnlMenu.Controls.Add(this.btnMatricula);
            this.pnlMenu.Controls.Add(this.btnAjuda);
            this.pnlMenu.Controls.Add(this.btnTreino);
            this.pnlMenu.Controls.Add(this.btnPlanos);
            this.pnlMenu.Controls.Add(this.btnAluno);
            this.pnlMenu.Controls.Add(this.btnInstrutor);
            this.pnlMenu.Controls.Add(this.pnlCont);
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlMenu.Controls.Add(this.pctLogo);
            this.pnlMenu.Location = new System.Drawing.Point(5, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1220, 655);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlPlanos
            // 
            this.pnlPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.pnlPlanos.Controls.Add(this.dgvValorPlanos);
            this.pnlPlanos.Controls.Add(this.lblValorPlano);
            this.pnlPlanos.Controls.Add(this.label4);
            this.pnlPlanos.Controls.Add(this.lblGeral);
            this.pnlPlanos.Location = new System.Drawing.Point(880, 305);
            this.pnlPlanos.Name = "pnlPlanos";
            this.pnlPlanos.Size = new System.Drawing.Size(335, 345);
            this.pnlPlanos.TabIndex = 13;
            // 
            // lblValorPlano
            // 
            this.lblValorPlano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblValorPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorPlano.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPlano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblValorPlano.Location = new System.Drawing.Point(5, 80);
            this.lblValorPlano.Name = "lblValorPlano";
            this.lblValorPlano.Size = new System.Drawing.Size(325, 35);
            this.lblValorPlano.TabIndex = 34;
            this.lblValorPlano.Text = "R$ / PLANO";
            this.lblValorPlano.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 35);
            this.label4.TabIndex = 33;
            this.label4.Text = "R$ GERAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGeral
            // 
            this.lblGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGeral.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblGeral.Location = new System.Drawing.Point(5, 5);
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(325, 70);
            this.lblGeral.TabIndex = 32;
            this.lblGeral.Text = "000";
            this.lblGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnEmail.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnEmail;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Location = new System.Drawing.Point(705, 480);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(170, 170);
            this.btnEmail.TabIndex = 12;
            this.btnEmail.UseVisualStyleBackColor = false;
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnPagamento.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnPagamento;
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Location = new System.Drawing.Point(530, 480);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(170, 170);
            this.btnPagamento.TabIndex = 11;
            this.btnPagamento.UseVisualStyleBackColor = false;
            // 
            // btnExercicio
            // 
            this.btnExercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnExercicio.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnExercicios;
            this.btnExercicio.FlatAppearance.BorderSize = 0;
            this.btnExercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercicio.Location = new System.Drawing.Point(355, 480);
            this.btnExercicio.Name = "btnExercicio";
            this.btnExercicio.Size = new System.Drawing.Size(170, 170);
            this.btnExercicio.TabIndex = 10;
            this.btnExercicio.UseVisualStyleBackColor = false;
            // 
            // btnBanner
            // 
            this.btnBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnBanner.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnBanner;
            this.btnBanner.FlatAppearance.BorderSize = 0;
            this.btnBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanner.Location = new System.Drawing.Point(180, 480);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(170, 170);
            this.btnBanner.TabIndex = 9;
            this.btnBanner.UseVisualStyleBackColor = false;
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnMatricula.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnMatricula;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Location = new System.Drawing.Point(5, 480);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(170, 170);
            this.btnMatricula.TabIndex = 8;
            this.btnMatricula.UseVisualStyleBackColor = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnAjuda.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnAjuda;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Location = new System.Drawing.Point(705, 305);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(170, 170);
            this.btnAjuda.TabIndex = 7;
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // btnTreino
            // 
            this.btnTreino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnTreino.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnTreino;
            this.btnTreino.FlatAppearance.BorderSize = 0;
            this.btnTreino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreino.Location = new System.Drawing.Point(530, 305);
            this.btnTreino.Name = "btnTreino";
            this.btnTreino.Size = new System.Drawing.Size(170, 170);
            this.btnTreino.TabIndex = 6;
            this.btnTreino.UseVisualStyleBackColor = false;
            // 
            // btnPlanos
            // 
            this.btnPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnPlanos.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnPlanos;
            this.btnPlanos.FlatAppearance.BorderSize = 0;
            this.btnPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanos.Location = new System.Drawing.Point(355, 305);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(170, 170);
            this.btnPlanos.TabIndex = 5;
            this.btnPlanos.UseVisualStyleBackColor = false;
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnAluno.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnAlunos;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Location = new System.Drawing.Point(180, 305);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(170, 170);
            this.btnAluno.TabIndex = 4;
            this.btnAluno.UseVisualStyleBackColor = false;
            // 
            // btnInstrutor
            // 
            this.btnInstrutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnInstrutor.BackgroundImage = global::VivaBem_Vanzelli.Properties.Resources.btnInstrutor;
            this.btnInstrutor.FlatAppearance.BorderSize = 0;
            this.btnInstrutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstrutor.Location = new System.Drawing.Point(5, 305);
            this.btnInstrutor.Name = "btnInstrutor";
            this.btnInstrutor.Size = new System.Drawing.Size(170, 170);
            this.btnInstrutor.TabIndex = 3;
            this.btnInstrutor.UseVisualStyleBackColor = false;
            // 
            // pnlCont
            // 
            this.pnlCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.pnlCont.Controls.Add(this.lblExercicios);
            this.pnlCont.Controls.Add(this.lblNumexercicios);
            this.pnlCont.Controls.Add(this.lblMatriculas);
            this.pnlCont.Controls.Add(this.lblNumMarticulas);
            this.pnlCont.Controls.Add(this.lblTreinos);
            this.pnlCont.Controls.Add(this.lblNumTreinos);
            this.pnlCont.Controls.Add(this.lblPlanos);
            this.pnlCont.Controls.Add(this.lblNumPlanos);
            this.pnlCont.Controls.Add(this.lblAlunos);
            this.pnlCont.Controls.Add(this.lblNumAlunos);
            this.pnlCont.Controls.Add(this.lblInstrutores);
            this.pnlCont.Controls.Add(this.lblNumInstrutores);
            this.pnlCont.Location = new System.Drawing.Point(5, 150);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(657, 150);
            this.pnlCont.TabIndex = 2;
            // 
            // lblExercicios
            // 
            this.lblExercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblExercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExercicios.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblExercicios.Location = new System.Drawing.Point(437, 76);
            this.lblExercicios.Name = "lblExercicios";
            this.lblExercicios.Size = new System.Drawing.Size(215, 35);
            this.lblExercicios.TabIndex = 31;
            this.lblExercicios.Text = "EXERCÍCIOS";
            this.lblExercicios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumexercicios
            // 
            this.lblNumexercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNumexercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumexercicios.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumexercicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblNumexercicios.Location = new System.Drawing.Point(437, 76);
            this.lblNumexercicios.Name = "lblNumexercicios";
            this.lblNumexercicios.Size = new System.Drawing.Size(215, 70);
            this.lblNumexercicios.TabIndex = 30;
            this.lblNumexercicios.Text = "000";
            this.lblNumexercicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMatriculas
            // 
            this.lblMatriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMatriculas.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblMatriculas.Location = new System.Drawing.Point(437, 5);
            this.lblMatriculas.Name = "lblMatriculas";
            this.lblMatriculas.Size = new System.Drawing.Size(215, 35);
            this.lblMatriculas.TabIndex = 29;
            this.lblMatriculas.Text = "MATRÍCULAS";
            this.lblMatriculas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumMarticulas
            // 
            this.lblNumMarticulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNumMarticulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumMarticulas.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMarticulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblNumMarticulas.Location = new System.Drawing.Point(437, 5);
            this.lblNumMarticulas.Name = "lblNumMarticulas";
            this.lblNumMarticulas.Size = new System.Drawing.Size(215, 70);
            this.lblNumMarticulas.TabIndex = 28;
            this.lblNumMarticulas.Text = "000";
            this.lblNumMarticulas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTreinos
            // 
            this.lblTreinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblTreinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTreinos.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTreinos.Location = new System.Drawing.Point(221, 76);
            this.lblTreinos.Name = "lblTreinos";
            this.lblTreinos.Size = new System.Drawing.Size(215, 35);
            this.lblTreinos.TabIndex = 27;
            this.lblTreinos.Text = "TREINOS";
            this.lblTreinos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumTreinos
            // 
            this.lblNumTreinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNumTreinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumTreinos.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTreinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblNumTreinos.Location = new System.Drawing.Point(221, 76);
            this.lblNumTreinos.Name = "lblNumTreinos";
            this.lblNumTreinos.Size = new System.Drawing.Size(215, 70);
            this.lblNumTreinos.TabIndex = 26;
            this.lblNumTreinos.Text = "000";
            this.lblNumTreinos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPlanos
            // 
            this.lblPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlanos.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblPlanos.Location = new System.Drawing.Point(221, 5);
            this.lblPlanos.Name = "lblPlanos";
            this.lblPlanos.Size = new System.Drawing.Size(215, 35);
            this.lblPlanos.TabIndex = 25;
            this.lblPlanos.Text = "PLANOS";
            this.lblPlanos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumPlanos
            // 
            this.lblNumPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNumPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumPlanos.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlanos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblNumPlanos.Location = new System.Drawing.Point(221, 5);
            this.lblNumPlanos.Name = "lblNumPlanos";
            this.lblNumPlanos.Size = new System.Drawing.Size(215, 70);
            this.lblNumPlanos.TabIndex = 24;
            this.lblNumPlanos.Text = "000";
            this.lblNumPlanos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAlunos
            // 
            this.lblAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlunos.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblAlunos.Location = new System.Drawing.Point(5, 76);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(215, 35);
            this.lblAlunos.TabIndex = 23;
            this.lblAlunos.Text = "ALUNOS";
            this.lblAlunos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumAlunos
            // 
            this.lblNumAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNumAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumAlunos.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblNumAlunos.Location = new System.Drawing.Point(5, 76);
            this.lblNumAlunos.Name = "lblNumAlunos";
            this.lblNumAlunos.Size = new System.Drawing.Size(215, 70);
            this.lblNumAlunos.TabIndex = 22;
            this.lblNumAlunos.Text = "000";
            this.lblNumAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblInstrutores
            // 
            this.lblInstrutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblInstrutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInstrutores.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblInstrutores.Location = new System.Drawing.Point(5, 5);
            this.lblInstrutores.Name = "lblInstrutores";
            this.lblInstrutores.Size = new System.Drawing.Size(215, 35);
            this.lblInstrutores.TabIndex = 21;
            this.lblInstrutores.Text = "INSTRUTORES";
            this.lblInstrutores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumInstrutores
            // 
            this.lblNumInstrutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNumInstrutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumInstrutores.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInstrutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblNumInstrutores.Location = new System.Drawing.Point(5, 5);
            this.lblNumInstrutores.Name = "lblNumInstrutores";
            this.lblNumInstrutores.Size = new System.Drawing.Size(215, 70);
            this.lblNumInstrutores.TabIndex = 15;
            this.lblNumInstrutores.Text = "000";
            this.lblNumInstrutores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.pnlUsuario.Controls.Add(this.pctSair);
            this.pnlUsuario.Controls.Add(this.lblHoras);
            this.pnlUsuario.Controls.Add(this.lblData);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Location = new System.Drawing.Point(360, 5);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(855, 140);
            this.pnlUsuario.TabIndex = 1;
            // 
            // lblHoras
            // 
            this.lblHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoras.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblHoras.Location = new System.Drawing.Point(5, 95);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(290, 40);
            this.lblHoras.TabIndex = 37;
            this.lblHoras.Text = "00:00";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblData.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblData.Location = new System.Drawing.Point(5, 50);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(290, 40);
            this.lblData.TabIndex = 36;
            this.lblData.Text = "00/00/0000";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 40);
            this.label1.TabIndex = 35;
            this.label1.Text = "USUÁRIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::VivaBem_Vanzelli.Properties.Resources.logoVivaBem;
            this.pctLogo.Location = new System.Drawing.Point(5, 5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(350, 140);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // dgvValorPlanos
            // 
            this.dgvValorPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValorPlanos.Location = new System.Drawing.Point(5, 115);
            this.dgvValorPlanos.Name = "dgvValorPlanos";
            this.dgvValorPlanos.Size = new System.Drawing.Size(325, 225);
            this.dgvValorPlanos.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(668, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 244);
            this.dataGridView1.TabIndex = 35;
            // 
            // pctSair
            // 
            this.pctSair.BackColor = System.Drawing.Color.White;
            this.pctSair.Image = global::VivaBem_Vanzelli.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(805, 3);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(46, 44);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 38;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlPlanos.ResumeLayout(false);
            this.pnlCont.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValorPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnInstrutor;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnExercicio;
        private System.Windows.Forms.Button btnBanner;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnTreino;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Panel pnlPlanos;
        private System.Windows.Forms.Label lblNumInstrutores;
        private System.Windows.Forms.Label lblInstrutores;
        private System.Windows.Forms.Label lblExercicios;
        private System.Windows.Forms.Label lblNumexercicios;
        private System.Windows.Forms.Label lblMatriculas;
        private System.Windows.Forms.Label lblNumMarticulas;
        private System.Windows.Forms.Label lblTreinos;
        private System.Windows.Forms.Label lblNumTreinos;
        private System.Windows.Forms.Label lblPlanos;
        private System.Windows.Forms.Label lblNumPlanos;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblNumAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGeral;
        private System.Windows.Forms.Label lblValorPlano;
        private System.Windows.Forms.DataGridView dgvValorPlanos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pctSair;
    }
}

