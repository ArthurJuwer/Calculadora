namespace Calculadora
{
    partial class Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(19, 12);
            this.txtResultado.MaxLength = 9;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(358, 95);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnAC
            // 
            this.btnAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Location = new System.Drawing.Point(113, 125);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(84, 70);
            this.btnAC.TabIndex = 2;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(23, 125);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(84, 70);
            this.btnMaisMenos.TabIndex = 3;
            this.btnMaisMenos.Text = "+/-";
            this.btnMaisMenos.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(293, 125);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 70);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "< -";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(203, 505);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(84, 70);
            this.btnVirgula.TabIndex = 4;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(293, 201);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(84, 70);
            this.btnMultiplicacao.TabIndex = 9;
            this.btnMultiplicacao.Tag = "*";
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(203, 201);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(84, 70);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Tag = "/";
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(113, 201);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(84, 70);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Tag = "-";
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(23, 201);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(84, 70);
            this.btnAdicao.TabIndex = 6;
            this.btnAdicao.Tag = "+";
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(23, 505);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(174, 70);
            this.btn00.TabIndex = 13;
            this.btn00.Text = "0";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn09
            // 
            this.btn09.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn09.Location = new System.Drawing.Point(203, 277);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(84, 70);
            this.btn09.TabIndex = 12;
            this.btn09.Text = "9";
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn08
            // 
            this.btn08.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn08.Location = new System.Drawing.Point(113, 277);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(84, 70);
            this.btn08.TabIndex = 11;
            this.btn08.Text = "8";
            this.btn08.UseVisualStyleBackColor = true;
            this.btn08.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn07
            // 
            this.btn07.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn07.Location = new System.Drawing.Point(23, 277);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(84, 70);
            this.btn07.TabIndex = 10;
            this.btn07.Text = "7";
            this.btn07.UseVisualStyleBackColor = true;
            this.btn07.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(293, 429);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(84, 146);
            this.btnEnter.TabIndex = 21;
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn03
            // 
            this.btn03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn03.Location = new System.Drawing.Point(203, 429);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(84, 70);
            this.btn03.TabIndex = 20;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(113, 429);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(84, 70);
            this.btn02.TabIndex = 19;
            this.btn02.Text = "2";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(23, 429);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(84, 70);
            this.btn01.TabIndex = 18;
            this.btn01.Text = "1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn06
            // 
            this.btn06.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn06.Location = new System.Drawing.Point(203, 353);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(84, 70);
            this.btn06.TabIndex = 16;
            this.btn06.Text = "6";
            this.btn06.UseVisualStyleBackColor = true;
            this.btn06.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn05
            // 
            this.btn05.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn05.Location = new System.Drawing.Point(113, 353);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(84, 70);
            this.btn05.TabIndex = 15;
            this.btn05.Text = "5";
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn04
            // 
            this.btn04.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn04.Location = new System.Drawing.Point(23, 353);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(84, 70);
            this.btn04.TabIndex = 14;
            this.btn04.Text = "4";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(293, 353);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(84, 70);
            this.btnRaiz.TabIndex = 22;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(203, 125);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(84, 70);
            this.btnC.TabIndex = 23;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.Location = new System.Drawing.Point(293, 277);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(84, 70);
            this.btnPorcentagem.TabIndex = 24;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 597);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPorcentagem;
    }
}

