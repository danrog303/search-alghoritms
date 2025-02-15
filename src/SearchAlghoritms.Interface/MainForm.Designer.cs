﻿
namespace SearchAlgorithms.Interface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.richTextBoxLookingString = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTime = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageIndex = new System.Windows.Forms.TabPage();
            this.dataGridViewIndex = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxLongString = new System.Windows.Forms.RichTextBox();
            this.textBoxMarkAlgo = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProviderLong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLooking = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderChart = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabPageIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndex)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(61, 24);
            this.toolStripButtonOpen.Text = "Otwórz";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.Event_toolStripButtonOpen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 494);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxLookingString, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 35);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Location = new System.Drawing.Point(227, 4);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.MinimumSize = new System.Drawing.Size(111, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 31);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.Event_buttonSearch_Click);
            // 
            // richTextBoxLookingString
            // 
            this.richTextBoxLookingString.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxLookingString.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxLookingString.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxLookingString.Multiline = false;
            this.richTextBoxLookingString.Name = "richTextBoxLookingString";
            this.richTextBoxLookingString.Size = new System.Drawing.Size(188, 31);
            this.richTextBoxLookingString.TabIndex = 2;
            this.richTextBoxLookingString.Text = "tu wpisz tekst szukany";
            this.richTextBoxLookingString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_richTextBoxLookingString_KeyUp);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTime);
            this.tabControl.Controls.Add(this.tabPageIndex);
            this.tabControl.Location = new System.Drawing.Point(348, 47);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(715, 443);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.Event_tabControl_SelectedIndexChanged);
            // 
            // tabPageTime
            // 
            this.tabPageTime.Controls.Add(this.chart);
            this.tabPageTime.Location = new System.Drawing.Point(4, 25);
            this.tabPageTime.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTime.Name = "tabPageTime";
            this.tabPageTime.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTime.Size = new System.Drawing.Size(707, 414);
            this.tabPageTime.TabIndex = 0;
            this.tabPageTime.Text = "Czas";
            this.tabPageTime.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(4, 4);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(661, 406);
            this.chart.TabIndex = 3;
            this.chart.TabStop = false;
            this.chart.Text = "chart1";
            // 
            // tabPageIndex
            // 
            this.tabPageIndex.Controls.Add(this.dataGridViewIndex);
            this.tabPageIndex.Location = new System.Drawing.Point(4, 25);
            this.tabPageIndex.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageIndex.Name = "tabPageIndex";
            this.tabPageIndex.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageIndex.Size = new System.Drawing.Size(707, 414);
            this.tabPageIndex.TabIndex = 1;
            this.tabPageIndex.Text = "Zwrócone indeksy";
            this.tabPageIndex.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIndex
            // 
            this.dataGridViewIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIndex.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewIndex.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIndex.Name = "dataGridViewIndex";
            this.dataGridViewIndex.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewIndex.Size = new System.Drawing.Size(699, 406);
            this.dataGridViewIndex.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.35821F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64179F));
            this.tableLayoutPanel3.Controls.Add(this.progressBar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(348, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(4, 4);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(552, 26);
            this.progressBar.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.richTextBoxLongString, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxMarkAlgo, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 47);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.38889F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.611111F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(336, 443);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // richTextBoxLongString
            // 
            this.richTextBoxLongString.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxLongString.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxLongString.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxLongString.Name = "richTextBoxLongString";
            this.richTextBoxLongString.Size = new System.Drawing.Size(304, 396);
            this.richTextBoxLongString.TabIndex = 3;
            this.richTextBoxLongString.Text = "tu wpisz tekst źródłowy\n(możesz go też wczytać z pliku)";
            this.richTextBoxLongString.WordWrap = false;
            this.richTextBoxLongString.Enter += new System.EventHandler(this.Event_richTextBoxLongString_Enter);
            // 
            // textBoxMarkAlgo
            // 
            this.textBoxMarkAlgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMarkAlgo.Enabled = false;
            this.textBoxMarkAlgo.Location = new System.Drawing.Point(4, 408);
            this.textBoxMarkAlgo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarkAlgo.Name = "textBoxMarkAlgo";
            this.textBoxMarkAlgo.Size = new System.Drawing.Size(328, 22);
            this.textBoxMarkAlgo.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errorProviderLong
            // 
            this.errorProviderLong.ContainerControl = this;
            // 
            // errorProviderLooking
            // 
            this.errorProviderLooking.ContainerControl = this;
            // 
            // errorProviderChart
            // 
            this.errorProviderChart.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Porównywarka Algorytmów";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabPageIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndex)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.RichTextBox richTextBoxLookingString;
        private System.Windows.Forms.ErrorProvider errorProviderLong;
        private System.Windows.Forms.ErrorProvider errorProviderLooking;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabPage tabPageIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox richTextBoxLongString;
        private System.Windows.Forms.TextBox textBoxMarkAlgo;
        private System.Windows.Forms.DataGridView dataGridViewIndex;
        private System.Windows.Forms.ErrorProvider errorProviderChart;
    }
}

