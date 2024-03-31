
namespace IMC
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            resulLB = new System.Windows.Forms.Label();
            pesoTB = new System.Windows.Forms.TextBox();
            alturaTB = new System.Windows.Forms.TextBox();
            calcular = new System.Windows.Forms.Button();
            mensagemTB = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(158, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 28);
            label1.TabIndex = 0;
            label1.Text = "IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(73, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "Peso:";
            label2.Click += Peso_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(50, 212);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // resulLB
            // 
            resulLB.AutoSize = true;
            resulLB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            resulLB.Location = new System.Drawing.Point(126, 392);
            resulLB.Name = "resulLB";
            resulLB.Size = new System.Drawing.Size(142, 28);
            resulLB.TabIndex = 3;
            resulLB.Text = "Resultado:";
            // 
            // pesoTB
            // 
            pesoTB.Location = new System.Drawing.Point(154, 142);
            pesoTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pesoTB.Name = "pesoTB";
            pesoTB.Size = new System.Drawing.Size(114, 27);
            pesoTB.TabIndex = 4;
            pesoTB.TextChanged += peso_TextChanged;
            // 
            // alturaTB
            // 
            alturaTB.Location = new System.Drawing.Point(154, 215);
            alturaTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            alturaTB.Name = "alturaTB";
            alturaTB.Size = new System.Drawing.Size(114, 27);
            alturaTB.TabIndex = 5;
            // 
            // calcular
            // 
            calcular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            calcular.Location = new System.Drawing.Point(137, 313);
            calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            calcular.Name = "calcular";
            calcular.Size = new System.Drawing.Size(114, 44);
            calcular.TabIndex = 6;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += button1_Click;
            // 
            // mensagemTB
            // 
            mensagemTB.AutoSize = true;
            mensagemTB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mensagemTB.Location = new System.Drawing.Point(126, 453);
            mensagemTB.Name = "mensagemTB";
            mensagemTB.Size = new System.Drawing.Size(129, 28);
            mensagemTB.TabIndex = 7;
            mensagemTB.Text = "Mensagem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(402, 513);
            Controls.Add(mensagemTB);
            Controls.Add(calcular);
            Controls.Add(alturaTB);
            Controls.Add(pesoTB);
            Controls.Add(resulLB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "IMC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resulLB;
        private System.Windows.Forms.TextBox pesoTB;
        private System.Windows.Forms.TextBox alturaTB;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label mensagemTB;
    }
}

