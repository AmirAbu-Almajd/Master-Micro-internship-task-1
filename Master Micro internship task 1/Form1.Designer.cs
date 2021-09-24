namespace Master_Micro_internship_task_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.equationBox = new System.Windows.Forms.TextBox();
            this.plotBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.minX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxX = new System.Windows.Forms.TextBox();
            this.eqLabel = new System.Windows.Forms.Label();
            this.eqlbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // equationBox
            // 
            this.equationBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationBox.Location = new System.Drawing.Point(402, 90);
            this.equationBox.Multiline = true;
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(262, 43);
            this.equationBox.TabIndex = 0;
            this.equationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plotBtn
            // 
            this.plotBtn.BackColor = System.Drawing.Color.IndianRed;
            this.plotBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.plotBtn.Location = new System.Drawing.Point(346, 253);
            this.plotBtn.Name = "plotBtn";
            this.plotBtn.Size = new System.Drawing.Size(179, 44);
            this.plotBtn.TabIndex = 3;
            this.plotBtn.Text = "Plot";
            this.plotBtn.UseVisualStyleBackColor = false;
            this.plotBtn.Click += new System.EventHandler(this.plotBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your equation";
            // 
            // chart
            // 
            this.chart.BorderSkin.BorderColor = System.Drawing.Color.DarkSeaGreen;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(185, 309);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(500, 230);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter the minimum value of X";
            // 
            // minX
            // 
            this.minX.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minX.Location = new System.Drawing.Point(485, 189);
            this.minX.Multiline = true;
            this.minX.Name = "minX";
            this.minX.Size = new System.Drawing.Size(179, 43);
            this.minX.TabIndex = 2;
            this.minX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the maximum value of X";
            // 
            // maxX
            // 
            this.maxX.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxX.Location = new System.Drawing.Point(485, 140);
            this.maxX.Multiline = true;
            this.maxX.Name = "maxX";
            this.maxX.Size = new System.Drawing.Size(179, 43);
            this.maxX.TabIndex = 1;
            this.maxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eqLabel
            // 
            this.eqLabel.AutoSize = true;
            this.eqLabel.Location = new System.Drawing.Point(140, 42);
            this.eqLabel.Name = "eqLabel";
            this.eqLabel.Size = new System.Drawing.Size(46, 17);
            this.eqLabel.TabIndex = 11;
            this.eqLabel.Text = "label4";
            // 
            // eqlbl2
            // 
            this.eqlbl2.AutoSize = true;
            this.eqlbl2.Location = new System.Drawing.Point(482, 42);
            this.eqlbl2.Name = "eqlbl2";
            this.eqlbl2.Size = new System.Drawing.Size(46, 17);
            this.eqlbl2.TabIndex = 12;
            this.eqlbl2.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(870, 623);
            this.Controls.Add(this.eqlbl2);
            this.Controls.Add(this.eqLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minX);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plotBtn);
            this.Controls.Add(this.equationBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equationBox;
        private System.Windows.Forms.Button plotBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxX;
        private System.Windows.Forms.Label eqLabel;
        private System.Windows.Forms.Label eqlbl2;
    }
}

