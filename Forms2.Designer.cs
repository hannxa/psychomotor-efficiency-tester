namespace zad2_poskx
{
    partial class Forms2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.ilosci = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.close_button = new System.Windows.Forms.Button();
            this.repeat_button = new System.Windows.Forms.Button();
            this.averageValuesButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.averageValues_label = new System.Windows.Forms.Label();
            this.average_serie_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 101);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(130, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 101);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(257, 269);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 101);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(579, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.BackColor = System.Drawing.SystemColors.Info;
            this.feedbackLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.feedbackLabel.Location = new System.Drawing.Point(400, 380);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 16);
            this.feedbackLabel.TabIndex = 4;
            // 
            // ilosci
            // 
            this.ilosci.AutoSize = true;
            this.ilosci.Location = new System.Drawing.Point(53, 401);
            this.ilosci.Name = "ilosci";
            this.ilosci.Size = new System.Drawing.Size(0, 16);
            this.ilosci.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(403, 21);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Średnie czasy z: ";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(385, 175);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_button.Location = new System.Drawing.Point(648, 402);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(112, 31);
            this.close_button.TabIndex = 8;
            this.close_button.Text = "zamknij";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // repeat_button
            // 
            this.repeat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repeat_button.Location = new System.Drawing.Point(501, 402);
            this.repeat_button.Name = "repeat_button";
            this.repeat_button.Size = new System.Drawing.Size(111, 31);
            this.repeat_button.TabIndex = 9;
            this.repeat_button.Text = "powtórz";
            this.repeat_button.UseVisualStyleBackColor = true;
            this.repeat_button.Click += new System.EventHandler(this.repeat_button_Click);
            // 
            // averageValuesButton
            // 
            this.averageValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averageValuesButton.Location = new System.Drawing.Point(116, 12);
            this.averageValuesButton.Name = "averageValuesButton";
            this.averageValuesButton.Size = new System.Drawing.Size(248, 58);
            this.averageValuesButton.TabIndex = 10;
            this.averageValuesButton.Text = "wyświetl wartości średnie wszystkich wyników";
            this.averageValuesButton.UseVisualStyleBackColor = true;
            this.averageValuesButton.Click += new System.EventHandler(this.averageValuesButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // averageValues_label
            // 
            this.averageValues_label.AutoSize = true;
            this.averageValues_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averageValues_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.averageValues_label.Location = new System.Drawing.Point(400, 199);
            this.averageValues_label.Name = "averageValues_label";
            this.averageValues_label.Size = new System.Drawing.Size(50, 16);
            this.averageValues_label.TabIndex = 11;
            this.averageValues_label.Text = "label2";
            // 
            // average_serie_label
            // 
            this.average_serie_label.AutoSize = true;
            this.average_serie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.average_serie_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.average_serie_label.Location = new System.Drawing.Point(466, 285);
            this.average_serie_label.Name = "average_serie_label";
            this.average_serie_label.Size = new System.Drawing.Size(168, 18);
            this.average_serie_label.TabIndex = 12;
            this.average_serie_label.Text = "Czas reakcji z próby:";
            // 
            // Forms2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::zad2_poskx.Properties.Resources.babelki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.average_serie_label);
            this.Controls.Add(this.averageValues_label);
            this.Controls.Add(this.averageValuesButton);
            this.Controls.Add(this.repeat_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ilosci);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Forms2";
            this.Text = "\\";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label ilosci;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button repeat_button;
        private System.Windows.Forms.Button averageValuesButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label averageValues_label;
        private System.Windows.Forms.Label average_serie_label;
    }
}