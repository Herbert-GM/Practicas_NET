namespace appDota
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMMR = new System.Windows.Forms.TextBox();
            this.chkHC = new System.Windows.Forms.CheckBox();
            this.chkMID = new System.Windows.Forms.CheckBox();
            this.chkSupport = new System.Windows.Forms.CheckBox();
            this.rbtnJBien = new System.Windows.Forms.RadioButton();
            this.rbtnJNormal = new System.Windows.Forms.RadioButton();
            this.rbtnJMal = new System.Windows.Forms.RadioButton();
            this.labelx = new System.Windows.Forms.Label();
            this.txtMedalla = new System.Windows.Forms.TextBox();
            this.chkHCMuji = new System.Windows.Forms.CheckBox();
            this.chkMIDMuji = new System.Windows.Forms.CheckBox();
            this.chkSupportMuji = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMMR2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedalla2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMMR3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedalla3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player:";
            // 
            // cbPlayer
            // 
            this.cbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(79, 31);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(208, 21);
            this.cbPlayer.TabIndex = 1;
            this.cbPlayer.SelectedIndexChanged += new System.EventHandler(this.cbPlayer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MMR:";
            // 
            // txtMMR
            // 
            this.txtMMR.Location = new System.Drawing.Point(79, 122);
            this.txtMMR.Name = "txtMMR";
            this.txtMMR.ReadOnly = true;
            this.txtMMR.Size = new System.Drawing.Size(208, 20);
            this.txtMMR.TabIndex = 3;
            // 
            // chkHC
            // 
            this.chkHC.AutoSize = true;
            this.chkHC.Location = new System.Drawing.Point(32, 205);
            this.chkHC.Name = "chkHC";
            this.chkHC.Size = new System.Drawing.Size(41, 17);
            this.chkHC.TabIndex = 4;
            this.chkHC.Text = "HC";
            this.chkHC.UseVisualStyleBackColor = true;
            this.chkHC.CheckedChanged += new System.EventHandler(this.chkHC_CheckedChanged);
            // 
            // chkMID
            // 
            this.chkMID.AutoSize = true;
            this.chkMID.Location = new System.Drawing.Point(125, 205);
            this.chkMID.Name = "chkMID";
            this.chkMID.Size = new System.Drawing.Size(46, 17);
            this.chkMID.TabIndex = 4;
            this.chkMID.Text = "MID";
            this.chkMID.UseVisualStyleBackColor = true;
            this.chkMID.CheckedChanged += new System.EventHandler(this.chkMID_CheckedChanged);
            // 
            // chkSupport
            // 
            this.chkSupport.AutoSize = true;
            this.chkSupport.Location = new System.Drawing.Point(224, 205);
            this.chkSupport.Name = "chkSupport";
            this.chkSupport.Size = new System.Drawing.Size(63, 17);
            this.chkSupport.TabIndex = 4;
            this.chkSupport.Text = "Support";
            this.chkSupport.UseVisualStyleBackColor = true;
            this.chkSupport.CheckedChanged += new System.EventHandler(this.chkSupport_CheckedChanged);
            // 
            // rbtnJBien
            // 
            this.rbtnJBien.AutoSize = true;
            this.rbtnJBien.Location = new System.Drawing.Point(18, 356);
            this.rbtnJBien.Name = "rbtnJBien";
            this.rbtnJBien.Size = new System.Drawing.Size(78, 17);
            this.rbtnJBien.TabIndex = 5;
            this.rbtnJBien.TabStop = true;
            this.rbtnJBien.Text = "Juega Bien";
            this.rbtnJBien.UseVisualStyleBackColor = true;
            // 
            // rbtnJNormal
            // 
            this.rbtnJNormal.AutoSize = true;
            this.rbtnJNormal.Location = new System.Drawing.Point(113, 356);
            this.rbtnJNormal.Name = "rbtnJNormal";
            this.rbtnJNormal.Size = new System.Drawing.Size(90, 17);
            this.rbtnJNormal.TabIndex = 5;
            this.rbtnJNormal.TabStop = true;
            this.rbtnJNormal.Text = "Juega Normal";
            this.rbtnJNormal.UseVisualStyleBackColor = true;
            // 
            // rbtnJMal
            // 
            this.rbtnJMal.AutoSize = true;
            this.rbtnJMal.Location = new System.Drawing.Point(224, 356);
            this.rbtnJMal.Name = "rbtnJMal";
            this.rbtnJMal.Size = new System.Drawing.Size(74, 17);
            this.rbtnJMal.TabIndex = 5;
            this.rbtnJMal.TabStop = true;
            this.rbtnJMal.Text = "Juega Mal";
            this.rbtnJMal.UseVisualStyleBackColor = true;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(26, 167);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(47, 13);
            this.labelx.TabIndex = 2;
            this.labelx.Text = "Medalla:";
            // 
            // txtMedalla
            // 
            this.txtMedalla.Location = new System.Drawing.Point(79, 160);
            this.txtMedalla.Name = "txtMedalla";
            this.txtMedalla.ReadOnly = true;
            this.txtMedalla.Size = new System.Drawing.Size(208, 20);
            this.txtMedalla.TabIndex = 3;
            // 
            // chkHCMuji
            // 
            this.chkHCMuji.AutoSize = true;
            this.chkHCMuji.Location = new System.Drawing.Point(18, 238);
            this.chkHCMuji.Name = "chkHCMuji";
            this.chkHCMuji.Size = new System.Drawing.Size(63, 17);
            this.chkHCMuji.TabIndex = 4;
            this.chkHCMuji.Text = "HC-Muji";
            this.chkHCMuji.UseVisualStyleBackColor = true;
            this.chkHCMuji.CheckedChanged += new System.EventHandler(this.chkHCMuji_CheckedChanged);
            // 
            // chkMIDMuji
            // 
            this.chkMIDMuji.AutoSize = true;
            this.chkMIDMuji.Location = new System.Drawing.Point(113, 238);
            this.chkMIDMuji.Name = "chkMIDMuji";
            this.chkMIDMuji.Size = new System.Drawing.Size(68, 17);
            this.chkMIDMuji.TabIndex = 4;
            this.chkMIDMuji.Text = "MID-Muji";
            this.chkMIDMuji.UseVisualStyleBackColor = true;
            // 
            // chkSupportMuji
            // 
            this.chkSupportMuji.AutoSize = true;
            this.chkSupportMuji.Location = new System.Drawing.Point(213, 238);
            this.chkSupportMuji.Name = "chkSupportMuji";
            this.chkSupportMuji.Size = new System.Drawing.Size(85, 17);
            this.chkSupportMuji.TabIndex = 4;
            this.chkSupportMuji.Text = "Support-Muji";
            this.chkSupportMuji.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MMR Rol:";
            // 
            // txtMMR2
            // 
            this.txtMMR2.Location = new System.Drawing.Point(79, 274);
            this.txtMMR2.Name = "txtMMR2";
            this.txtMMR2.ReadOnly = true;
            this.txtMMR2.Size = new System.Drawing.Size(208, 20);
            this.txtMMR2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Medalla Rol:";
            // 
            // txtMedalla2
            // 
            this.txtMedalla2.Location = new System.Drawing.Point(79, 312);
            this.txtMedalla2.Name = "txtMedalla2";
            this.txtMedalla2.ReadOnly = true;
            this.txtMedalla2.Size = new System.Drawing.Size(208, 20);
            this.txtMedalla2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "MMR Juego:";
            // 
            // txtMMR3
            // 
            this.txtMMR3.Location = new System.Drawing.Point(79, 390);
            this.txtMMR3.Name = "txtMMR3";
            this.txtMMR3.ReadOnly = true;
            this.txtMMR3.Size = new System.Drawing.Size(208, 20);
            this.txtMMR3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Medalla:";
            // 
            // txtMedalla3
            // 
            this.txtMedalla3.Location = new System.Drawing.Point(79, 428);
            this.txtMedalla3.Name = "txtMedalla3";
            this.txtMedalla3.ReadOnly = true;
            this.txtMedalla3.Size = new System.Drawing.Size(208, 20);
            this.txtMedalla3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 480);
            this.Controls.Add(this.rbtnJMal);
            this.Controls.Add(this.rbtnJNormal);
            this.Controls.Add(this.rbtnJBien);
            this.Controls.Add(this.chkSupportMuji);
            this.Controls.Add(this.chkSupport);
            this.Controls.Add(this.chkMIDMuji);
            this.Controls.Add(this.chkMID);
            this.Controls.Add(this.chkHCMuji);
            this.Controls.Add(this.chkHC);
            this.Controls.Add(this.txtMedalla3);
            this.Controls.Add(this.txtMedalla2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedalla);
            this.Controls.Add(this.txtMMR3);
            this.Controls.Add(this.txtMMR2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMMR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tiendita Dotera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMMR;
        private System.Windows.Forms.CheckBox chkHC;
        private System.Windows.Forms.CheckBox chkMID;
        private System.Windows.Forms.CheckBox chkSupport;
        private System.Windows.Forms.RadioButton rbtnJBien;
        private System.Windows.Forms.RadioButton rbtnJNormal;
        private System.Windows.Forms.RadioButton rbtnJMal;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.TextBox txtMedalla;
        private System.Windows.Forms.CheckBox chkHCMuji;
        private System.Windows.Forms.CheckBox chkMIDMuji;
        private System.Windows.Forms.CheckBox chkSupportMuji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMMR2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedalla2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMMR3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedalla3;
    }
}

