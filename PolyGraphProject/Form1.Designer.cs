namespace PolyGraphProject
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.connectedLabel = new System.Windows.Forms.Label();
            this.connectingLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, -3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart.Size = new System.Drawing.Size(1193, 475);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(1018, 626);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(162, 27);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(1018, 654);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(162, 27);
            this.disconnectBtn.TabIndex = 2;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(12, 631);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(96, 16);
            this.connectedLabel.TabIndex = 3;
            this.connectedLabel.Text = "Not Connected";
            // 
            // connectingLabel
            // 
            this.connectingLabel.AutoSize = true;
            this.connectingLabel.Location = new System.Drawing.Point(12, 654);
            this.connectingLabel.Name = "connectingLabel";
            this.connectingLabel.Size = new System.Drawing.Size(83, 16);
            this.connectingLabel.TabIndex = 4;
            this.connectingLabel.Text = "Connecting...";
            this.connectingLabel.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.m1DataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.m3DataGridViewTextBoxColumn,
            this.m4DataGridViewTextBoxColumn,
            this.m5DataGridViewTextBoxColumn,
            this.m6DataGridViewTextBoxColumn,
            this.m7DataGridViewTextBoxColumn,
            this.m8DataGridViewTextBoxColumn,
            this.m9DataGridViewTextBoxColumn,
            this.m10DataGridViewTextBoxColumn});
            this.dataGridView.Location = new System.Drawing.Point(0, 471);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1193, 150);
            this.dataGridView.TabIndex = 5;
            // 
            // dataLineBindingSource
            // 
            this.dataLineBindingSource.DataSource = typeof(PolyGraphProject.DataLine);
            // 
            // m10DataGridViewTextBoxColumn
            // 
            this.m10DataGridViewTextBoxColumn.DataPropertyName = "M10";
            this.m10DataGridViewTextBoxColumn.HeaderText = "M10";
            this.m10DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m10DataGridViewTextBoxColumn.Name = "m10DataGridViewTextBoxColumn";
            this.m10DataGridViewTextBoxColumn.Width = 125;
            // 
            // m9DataGridViewTextBoxColumn
            // 
            this.m9DataGridViewTextBoxColumn.DataPropertyName = "M9";
            this.m9DataGridViewTextBoxColumn.HeaderText = "M9";
            this.m9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m9DataGridViewTextBoxColumn.Name = "m9DataGridViewTextBoxColumn";
            this.m9DataGridViewTextBoxColumn.Width = 125;
            // 
            // m8DataGridViewTextBoxColumn
            // 
            this.m8DataGridViewTextBoxColumn.DataPropertyName = "M8";
            this.m8DataGridViewTextBoxColumn.HeaderText = "M8";
            this.m8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m8DataGridViewTextBoxColumn.Name = "m8DataGridViewTextBoxColumn";
            this.m8DataGridViewTextBoxColumn.Width = 125;
            // 
            // m7DataGridViewTextBoxColumn
            // 
            this.m7DataGridViewTextBoxColumn.DataPropertyName = "M7";
            this.m7DataGridViewTextBoxColumn.HeaderText = "M7";
            this.m7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m7DataGridViewTextBoxColumn.Name = "m7DataGridViewTextBoxColumn";
            this.m7DataGridViewTextBoxColumn.Width = 125;
            // 
            // m6DataGridViewTextBoxColumn
            // 
            this.m6DataGridViewTextBoxColumn.DataPropertyName = "M6";
            this.m6DataGridViewTextBoxColumn.HeaderText = "M6";
            this.m6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m6DataGridViewTextBoxColumn.Name = "m6DataGridViewTextBoxColumn";
            this.m6DataGridViewTextBoxColumn.Width = 125;
            // 
            // m5DataGridViewTextBoxColumn
            // 
            this.m5DataGridViewTextBoxColumn.DataPropertyName = "M5";
            this.m5DataGridViewTextBoxColumn.HeaderText = "M5";
            this.m5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m5DataGridViewTextBoxColumn.Name = "m5DataGridViewTextBoxColumn";
            this.m5DataGridViewTextBoxColumn.Width = 125;
            // 
            // m4DataGridViewTextBoxColumn
            // 
            this.m4DataGridViewTextBoxColumn.DataPropertyName = "M4";
            this.m4DataGridViewTextBoxColumn.HeaderText = "M4";
            this.m4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m4DataGridViewTextBoxColumn.Name = "m4DataGridViewTextBoxColumn";
            this.m4DataGridViewTextBoxColumn.Width = 125;
            // 
            // m3DataGridViewTextBoxColumn
            // 
            this.m3DataGridViewTextBoxColumn.DataPropertyName = "M3";
            this.m3DataGridViewTextBoxColumn.HeaderText = "M3";
            this.m3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m3DataGridViewTextBoxColumn.Name = "m3DataGridViewTextBoxColumn";
            this.m3DataGridViewTextBoxColumn.Width = 125;
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "M2";
            this.m2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            this.m2DataGridViewTextBoxColumn.Width = 125;
            // 
            // m1DataGridViewTextBoxColumn
            // 
            this.m1DataGridViewTextBoxColumn.DataPropertyName = "M1";
            this.m1DataGridViewTextBoxColumn.HeaderText = "M1";
            this.m1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m1DataGridViewTextBoxColumn.Name = "m1DataGridViewTextBoxColumn";
            this.m1DataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 684);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.connectingLabel);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Label connectingLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dataLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m10DataGridViewTextBoxColumn;
    }
}

