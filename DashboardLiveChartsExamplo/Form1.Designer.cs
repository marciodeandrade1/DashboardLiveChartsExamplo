namespace DashboardLiveChartsExamplo
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
            labelKpi1 = new Label();
            labelKpi1Desc = new Label();
            labelKpi2Desc = new Label();
            labelKpi2 = new Label();
            labelKpi3Desc = new Label();
            labelKpi3 = new Label();
            labelKpi4Desc = new Label();
            labelKpi4 = new Label();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // labelKpi1
            // 
            labelKpi1.AutoSize = true;
            labelKpi1.Location = new Point(46, 48);
            labelKpi1.Name = "labelKpi1";
            labelKpi1.Size = new Size(44, 15);
            labelKpi1.TabIndex = 0;
            labelKpi1.Text = "R$ 0,00";
            // 
            // labelKpi1Desc
            // 
            labelKpi1Desc.AutoSize = true;
            labelKpi1Desc.Location = new Point(46, 21);
            labelKpi1Desc.Name = "labelKpi1Desc";
            labelKpi1Desc.Size = new Size(106, 15);
            labelKpi1Desc.TabIndex = 1;
            labelKpi1Desc.Text = "Receita Total (Mês)";
            // 
            // labelKpi2Desc
            // 
            labelKpi2Desc.AutoSize = true;
            labelKpi2Desc.Location = new Point(191, 21);
            labelKpi2Desc.Name = "labelKpi2Desc";
            labelKpi2Desc.Size = new Size(88, 15);
            labelKpi2Desc.TabIndex = 2;
            labelKpi2Desc.Text = "Total de Vendas";
            // 
            // labelKpi2
            // 
            labelKpi2.AutoSize = true;
            labelKpi2.Location = new Point(191, 48);
            labelKpi2.Name = "labelKpi2";
            labelKpi2.Size = new Size(13, 15);
            labelKpi2.TabIndex = 2;
            labelKpi2.Text = "0";
            // 
            // labelKpi3Desc
            // 
            labelKpi3Desc.AutoSize = true;
            labelKpi3Desc.Location = new Point(306, 21);
            labelKpi3Desc.Name = "labelKpi3Desc";
            labelKpi3Desc.Size = new Size(75, 15);
            labelKpi3Desc.TabIndex = 2;
            labelKpi3Desc.Text = "Ticket Médio";
            // 
            // labelKpi3
            // 
            labelKpi3.AutoSize = true;
            labelKpi3.Location = new Point(306, 48);
            labelKpi3.Name = "labelKpi3";
            labelKpi3.Size = new Size(44, 15);
            labelKpi3.TabIndex = 2;
            labelKpi3.Text = "R$ 0,00";
            // 
            // labelKpi4Desc
            // 
            labelKpi4Desc.AutoSize = true;
            labelKpi4Desc.Location = new Point(411, 21);
            labelKpi4Desc.Name = "labelKpi4Desc";
            labelKpi4Desc.Size = new Size(108, 15);
            labelKpi4Desc.TabIndex = 2;
            labelKpi4Desc.Text = "Crescimento Anual";
            // 
            // labelKpi4
            // 
            labelKpi4.AutoSize = true;
            labelKpi4.Location = new Point(411, 48);
            labelKpi4.Name = "labelKpi4";
            labelKpi4.Size = new Size(32, 15);
            labelKpi4.TabIndex = 2;
            labelKpi4.Text = "0.0%";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(50, 99);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(469, 335);
            cartesianChart1.TabIndex = 3;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 462);
            Controls.Add(cartesianChart1);
            Controls.Add(labelKpi2);
            Controls.Add(labelKpi3);
            Controls.Add(labelKpi4);
            Controls.Add(labelKpi4Desc);
            Controls.Add(labelKpi3Desc);
            Controls.Add(labelKpi2Desc);
            Controls.Add(labelKpi1Desc);
            Controls.Add(labelKpi1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKpi1;
        private Label labelKpi1Desc;
        private Label labelKpi2Desc;
        private Label labelKpi2;
        private Label labelKpi3Desc;
        private Label labelKpi3;
        private Label labelKpi4Desc;
        private Label labelKpi4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
