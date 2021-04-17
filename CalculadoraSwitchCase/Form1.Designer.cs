
namespace CalculadoraSwitchCase
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.txtb_valor1 = new System.Windows.Forms.TextBox();
            this.txtb_valor2 = new System.Windows.Forms.TextBox();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_operadores = new System.Windows.Forms.GroupBox();
            this.rb_porcento = new System.Windows.Forms.RadioButton();
            this.rb_dividir = new System.Windows.Forms.RadioButton();
            this.rb_multiplicar = new System.Windows.Forms.RadioButton();
            this.rb_subtrair = new System.Windows.Forms.RadioButton();
            this.rb_somar = new System.Windows.Forms.RadioButton();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txtb_resuldado = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.gb_operadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_valor1
            // 
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor1.Location = new System.Drawing.Point(184, 21);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(67, 21);
            this.lbl_valor1.TabIndex = 0;
            this.lbl_valor1.Text = "Valor 1:";
            // 
            // txtb_valor1
            // 
            this.txtb_valor1.Location = new System.Drawing.Point(38, 55);
            this.txtb_valor1.Name = "txtb_valor1";
            this.txtb_valor1.Size = new System.Drawing.Size(358, 23);
            this.txtb_valor1.TabIndex = 2;
            // 
            // txtb_valor2
            // 
            this.txtb_valor2.Location = new System.Drawing.Point(38, 127);
            this.txtb_valor2.Name = "txtb_valor2";
            this.txtb_valor2.Size = new System.Drawing.Size(358, 23);
            this.txtb_valor2.TabIndex = 4;
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor2.Location = new System.Drawing.Point(184, 93);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(67, 21);
            this.lbl_valor2.TabIndex = 3;
            this.lbl_valor2.Text = "Valor 2:";
            // 
            // backgroundWorker1
            // 
            // 
            // gb_operadores
            // 
            this.gb_operadores.Controls.Add(this.rb_porcento);
            this.gb_operadores.Controls.Add(this.rb_dividir);
            this.gb_operadores.Controls.Add(this.rb_multiplicar);
            this.gb_operadores.Controls.Add(this.rb_subtrair);
            this.gb_operadores.Controls.Add(this.rb_somar);
            this.gb_operadores.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_operadores.Location = new System.Drawing.Point(38, 178);
            this.gb_operadores.Name = "gb_operadores";
            this.gb_operadores.Size = new System.Drawing.Size(358, 113);
            this.gb_operadores.TabIndex = 5;
            this.gb_operadores.TabStop = false;
            this.gb_operadores.Text = "Selecione a Operação";
            // 
            // rb_porcento
            // 
            this.rb_porcento.AutoSize = true;
            this.rb_porcento.Location = new System.Drawing.Point(119, 77);
            this.rb_porcento.Name = "rb_porcento";
            this.rb_porcento.Size = new System.Drawing.Size(123, 19);
            this.rb_porcento.TabIndex = 4;
            this.rb_porcento.TabStop = true;
            this.rb_porcento.Text = "Porcentagem ( % )";
            this.rb_porcento.UseVisualStyleBackColor = true;
            // 
            // rb_dividir
            // 
            this.rb_dividir.AutoSize = true;
            this.rb_dividir.Location = new System.Drawing.Point(192, 52);
            this.rb_dividir.Name = "rb_dividir";
            this.rb_dividir.Size = new System.Drawing.Size(82, 19);
            this.rb_dividir.TabIndex = 3;
            this.rb_dividir.TabStop = true;
            this.rb_dividir.Text = "Dividir ( / )";
            this.rb_dividir.UseVisualStyleBackColor = true;
            // 
            // rb_multiplicar
            // 
            this.rb_multiplicar.AutoSize = true;
            this.rb_multiplicar.Location = new System.Drawing.Point(82, 52);
            this.rb_multiplicar.Name = "rb_multiplicar";
            this.rb_multiplicar.Size = new System.Drawing.Size(104, 19);
            this.rb_multiplicar.TabIndex = 2;
            this.rb_multiplicar.TabStop = true;
            this.rb_multiplicar.Text = "Multiplicar ( * )";
            this.rb_multiplicar.UseVisualStyleBackColor = true;
            // 
            // rb_subtrair
            // 
            this.rb_subtrair.AutoSize = true;
            this.rb_subtrair.Location = new System.Drawing.Point(192, 27);
            this.rb_subtrair.Name = "rb_subtrair";
            this.rb_subtrair.Size = new System.Drawing.Size(89, 19);
            this.rb_subtrair.TabIndex = 1;
            this.rb_subtrair.TabStop = true;
            this.rb_subtrair.Text = "Subtrair ( - )";
            this.rb_subtrair.UseVisualStyleBackColor = true;
            // 
            // rb_somar
            // 
            this.rb_somar.AutoSize = true;
            this.rb_somar.Location = new System.Drawing.Point(82, 27);
            this.rb_somar.Name = "rb_somar";
            this.rb_somar.Size = new System.Drawing.Size(85, 19);
            this.rb_somar.TabIndex = 0;
            this.rb_somar.TabStop = true;
            this.rb_somar.Text = "Somar ( + )";
            this.rb_somar.UseVisualStyleBackColor = true;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(38, 314);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(358, 49);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txtb_resuldado
            // 
            this.txtb_resuldado.Location = new System.Drawing.Point(38, 413);
            this.txtb_resuldado.Name = "txtb_resuldado";
            this.txtb_resuldado.Size = new System.Drawing.Size(358, 23);
            this.txtb_resuldado.TabIndex = 8;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(172, 379);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(90, 21);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 451);
            this.Controls.Add(this.txtb_resuldado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.gb_operadores);
            this.Controls.Add(this.txtb_valor2);
            this.Controls.Add(this.lbl_valor2);
            this.Controls.Add(this.txtb_valor1);
            this.Controls.Add(this.lbl_valor1);
            this.Name = "Calculadora";
            this.Text = "Calculadora SwitchCase";
            this.gb_operadores.ResumeLayout(false);
            this.gb_operadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.TextBox txtb_valor1;
        private System.Windows.Forms.TextBox txtb_valor2;
        private System.Windows.Forms.Label lbl_valor2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_operadores;
        private System.Windows.Forms.RadioButton rb_somar;
        private System.Windows.Forms.RadioButton rb_dividir;
        private System.Windows.Forms.RadioButton rb_multiplicar;
        private System.Windows.Forms.RadioButton rb_subtrair;
        private System.Windows.Forms.RadioButton rb_porcento;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txtb_resuldado;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

