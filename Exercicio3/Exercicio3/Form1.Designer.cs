namespace Exercicio3
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
            this.txtPreenche = new System.Windows.Forms.Label();
            this.npCode = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.Label();
            this.npSalario = new System.Windows.Forms.NumericUpDown();
            this.txtSalario = new System.Windows.Forms.Label();
            this.butCadastrar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.npCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreenche
            // 
            this.txtPreenche.AutoSize = true;
            this.txtPreenche.Location = new System.Drawing.Point(26, 28);
            this.txtPreenche.Name = "txtPreenche";
            this.txtPreenche.Size = new System.Drawing.Size(155, 13);
            this.txtPreenche.TabIndex = 0;
            this.txtPreenche.Text = "Preencha os Dados Solicitados";
            // 
            // npCode
            // 
            this.npCode.Location = new System.Drawing.Point(102, 64);
            this.npCode.Name = "npCode";
            this.npCode.Size = new System.Drawing.Size(120, 20);
            this.npCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "v";
            // 
            // txtCode
            // 
            this.txtCode.AutoSize = true;
            this.txtCode.Location = new System.Drawing.Point(12, 66);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(40, 13);
            this.txtCode.TabIndex = 3;
            this.txtCode.Text = "Codigo";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 102);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(12, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Nome";
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(102, 147);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(120, 20);
            this.tbRG.TabIndex = 6;
            // 
            // txtRG
            // 
            this.txtRG.AutoSize = true;
            this.txtRG.Location = new System.Drawing.Point(12, 150);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(23, 13);
            this.txtRG.TabIndex = 7;
            this.txtRG.Text = "RG";
            // 
            // npSalario
            // 
            this.npSalario.Location = new System.Drawing.Point(102, 194);
            this.npSalario.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.npSalario.Name = "npSalario";
            this.npSalario.Size = new System.Drawing.Size(120, 20);
            this.npSalario.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.AutoSize = true;
            this.txtSalario.Location = new System.Drawing.Point(12, 201);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(39, 13);
            this.txtSalario.TabIndex = 9;
            this.txtSalario.Text = "Salario";
            // 
            // butCadastrar
            // 
            this.butCadastrar.Location = new System.Drawing.Point(66, 266);
            this.butCadastrar.Name = "butCadastrar";
            this.butCadastrar.Size = new System.Drawing.Size(75, 23);
            this.butCadastrar.TabIndex = 10;
            this.butCadastrar.Text = "Cadastrar";
            this.butCadastrar.UseVisualStyleBackColor = true;
            this.butCadastrar.Click += new System.EventHandler(this.butCadastrar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(469, 64);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(260, 150);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(466, 48);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(49, 13);
            this.txtResultado.TabIndex = 12;
            this.txtResultado.Text = "Cadastro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.butCadastrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.npSalario);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.npCode);
            this.Controls.Add(this.txtPreenche);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.npCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPreenche;
        private System.Windows.Forms.NumericUpDown npCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.Label txtRG;
        private System.Windows.Forms.NumericUpDown npSalario;
        private System.Windows.Forms.Label txtSalario;
        private System.Windows.Forms.Button butCadastrar;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label txtResultado;
    }
}

