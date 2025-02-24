namespace zad2_poskx
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.szkolenie_button = new System.Windows.Forms.Button();
            this.test_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.informativeLabel);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_button.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(290, 209);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(227, 72);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_Click);
            // 
            // szkolenie_button
            // 
            this.szkolenie_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.szkolenie_button.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szkolenie_button.Location = new System.Drawing.Point(41, 337);
            this.szkolenie_button.Name = "szkolenie_button";
            this.szkolenie_button.Size = new System.Drawing.Size(227, 109);
            this.szkolenie_button.TabIndex = 2;
            this.szkolenie_button.Text = "rozpocznij szkolenie";
            this.szkolenie_button.UseVisualStyleBackColor = false;
            this.szkolenie_button.Click += new System.EventHandler(this.szkolenie_button_Click);
            // 
            // test_button
            // 
            this.test_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.test_button.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test_button.Location = new System.Drawing.Point(539, 333);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(227, 117);
            this.test_button.TabIndex = 3;
            this.test_button.Text = "rozpocznij test";
            this.test_button.UseVisualStyleBackColor = false;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::zad2_poskx.Properties.Resources.tapetaAuta;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.szkolenie_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button szkolenie_button;
        private System.Windows.Forms.Button test_button;
    }
}

