
namespace Projeto.Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Soma = new System.Windows.Forms.Button();
            this.subitrair = new System.Windows.Forms.Button();
            this.vezes = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Soma
            // 
            this.Soma.AccessibleDescription = "Botão Utilizado para soma";
            this.Soma.AccessibleName = "Soma";
            this.Soma.BackColor = System.Drawing.Color.White;
            this.Soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Soma.BackgroundImage")));
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soma.Location = new System.Drawing.Point(277, 107);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(74, 42);
            this.Soma.TabIndex = 0;
            this.Soma.Text = "button1";
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // subitrair
            // 
            this.subitrair.AccessibleName = "subitração";
            this.subitrair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subitrair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subitrair.BackgroundImage")));
            this.subitrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subitrair.Location = new System.Drawing.Point(400, 107);
            this.subitrair.Name = "subitrair";
            this.subitrair.Size = new System.Drawing.Size(78, 42);
            this.subitrair.TabIndex = 1;
            this.subitrair.UseVisualStyleBackColor = false;
            this.subitrair.Click += new System.EventHandler(this.subitrair_Click);
            // 
            // vezes
            // 
            this.vezes.AccessibleName = "vezes ";
            this.vezes.BackColor = System.Drawing.Color.White;
            this.vezes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vezes.BackgroundImage")));
            this.vezes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vezes.Location = new System.Drawing.Point(277, 202);
            this.vezes.Name = "vezes";
            this.vezes.Size = new System.Drawing.Size(74, 39);
            this.vezes.TabIndex = 3;
            this.vezes.UseVisualStyleBackColor = false;
            this.vezes.Click += new System.EventHandler(this.vezes_Click);
            // 
            // raiz
            // 
            this.raiz.AccessibleName = "raiz";
            this.raiz.BackColor = System.Drawing.Color.White;
            this.raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raiz.BackgroundImage")));
            this.raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.raiz.Location = new System.Drawing.Point(401, 203);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(77, 38);
            this.raiz.TabIndex = 4;
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // potencia
            // 
            this.potencia.AccessibleName = "potencia";
            this.potencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potencia.BackgroundImage")));
            this.potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.potencia.Location = new System.Drawing.Point(526, 202);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(75, 38);
            this.potencia.TabIndex = 5;
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // divisao
            // 
            this.divisao.AccessibleName = "Divisão";
            this.divisao.BackColor = System.Drawing.Color.White;
            this.divisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divisao.BackgroundImage")));
            this.divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.divisao.ForeColor = System.Drawing.Color.White;
            this.divisao.Location = new System.Drawing.Point(526, 107);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(75, 42);
            this.divisao.TabIndex = 6;
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "Primeiro Numero";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primero Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "segundo numero";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segundo Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.AccessibleName = "resultado";
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(309, 272);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(250, 55);
            this.Resultado.TabIndex = 11;
            this.Resultado.Text = "Resultado";
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.vezes);
            this.Controls.Add(this.subitrair);
            this.Controls.Add(this.Soma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button subitrair;
        private System.Windows.Forms.Button vezes;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Resultado;
    }
}

