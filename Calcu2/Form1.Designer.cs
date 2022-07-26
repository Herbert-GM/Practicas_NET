namespace Calcu2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ckSumar = new System.Windows.Forms.CheckBox();
            this.ckRestar = new System.Windows.Forms.CheckBox();
            this.ckMultiplicar = new System.Windows.Forms.CheckBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.rbtn20 = new System.Windows.Forms.RadioButton();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(75, 12);
            this.txtN1.Multiline = true;
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(96, 23);
            this.txtN1.TabIndex = 0;
            // 
            // cbOpciones
            // 
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta"});
            this.cbOpciones.Location = new System.Drawing.Point(52, 126);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(119, 21);
            this.cbOpciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(75, 51);
            this.txtN2.Multiline = true;
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(96, 21);
            this.txtN2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 29);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ckSumar
            // 
            this.ckSumar.AutoSize = true;
            this.ckSumar.Location = new System.Drawing.Point(122, 166);
            this.ckSumar.Name = "ckSumar";
            this.ckSumar.Size = new System.Drawing.Size(32, 17);
            this.ckSumar.TabIndex = 5;
            this.ckSumar.Tag = "+";
            this.ckSumar.Text = "+";
            this.ckSumar.UseVisualStyleBackColor = true;
            // 
            // ckRestar
            // 
            this.ckRestar.AutoSize = true;
            this.ckRestar.Location = new System.Drawing.Point(122, 190);
            this.ckRestar.Name = "ckRestar";
            this.ckRestar.Size = new System.Drawing.Size(29, 17);
            this.ckRestar.TabIndex = 5;
            this.ckRestar.Tag = "-";
            this.ckRestar.Text = "-";
            this.ckRestar.UseVisualStyleBackColor = true;
            // 
            // ckMultiplicar
            // 
            this.ckMultiplicar.AutoSize = true;
            this.ckMultiplicar.Location = new System.Drawing.Point(122, 213);
            this.ckMultiplicar.Name = "ckMultiplicar";
            this.ckMultiplicar.Size = new System.Drawing.Size(31, 17);
            this.ckMultiplicar.TabIndex = 5;
            this.ckMultiplicar.Text = "x";
            this.ckMultiplicar.UseVisualStyleBackColor = true;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(75, 87);
            this.txtN3.Multiline = true;
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(96, 21);
            this.txtN3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número 3:";
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(26, 166);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(37, 17);
            this.rbtn5.TabIndex = 6;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "+5";
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.Location = new System.Drawing.Point(26, 190);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(43, 17);
            this.rbtn10.TabIndex = 6;
            this.rbtn10.TabStop = true;
            this.rbtn10.Text = "+10";
            this.rbtn10.UseVisualStyleBackColor = true;
            // 
            // rbtn20
            // 
            this.rbtn20.AutoSize = true;
            this.rbtn20.Location = new System.Drawing.Point(26, 212);
            this.rbtn20.Name = "rbtn20";
            this.rbtn20.Size = new System.Drawing.Size(43, 17);
            this.rbtn20.TabIndex = 6;
            this.rbtn20.TabStop = true;
            this.rbtn20.Text = "+20";
            this.rbtn20.UseVisualStyleBackColor = true;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(35, 280);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(119, 29);
            this.btnCalcular2.TabIndex = 3;
            this.btnCalcular2.Text = "CALCULAR2";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 321);
            this.Controls.Add(this.rbtn20);
            this.Controls.Add(this.rbtn10);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.ckMultiplicar);
            this.Controls.Add(this.ckRestar);
            this.Controls.Add(this.ckSumar);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOpciones);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.ComboBox cbOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox ckSumar;
        private System.Windows.Forms.CheckBox ckRestar;
        private System.Windows.Forms.CheckBox ckMultiplicar;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.RadioButton rbtn20;
        private System.Windows.Forms.Button btnCalcular2;
    }
}

