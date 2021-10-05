
namespace os_multiprogramming
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new MaterialSkin.Controls.MaterialButton();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textboxTimeWork = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxAllTasks = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxTaskComplete = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxProbIO = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxDurationIO = new MaterialSkin.Controls.MaterialTextBox();
            this.chartProc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textboxProbTask = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxDurationTask = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxAvgTimeComplete = new MaterialSkin.Controls.MaterialTextBox();
            this.log = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProc)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonStart, 2);
            this.buttonStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonStart.Depth = 0;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.HighEmphasis = true;
            this.buttonStart.Icon = global::os_multiprogramming.Properties.Resources.power_off_solid;
            this.buttonStart.Location = new System.Drawing.Point(660, 16);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(300, 51);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonStart.UseAccentColor = false;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // workTimer
            // 
            this.workTimer.Tick += new System.EventHandler(this.workTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Controls.Add(this.textboxAvgTimeComplete, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.textboxDurationTask, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textboxProbTask, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textboxTimeWork, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textboxAllTasks, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textboxTaskComplete, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textboxProbIO, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.textboxDurationIO, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.chartProc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.log, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.922894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.89909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.75964F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.922894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 536);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textboxTimeWork
            // 
            this.textboxTimeWork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textboxTimeWork, 2);
            this.textboxTimeWork.Depth = 0;
            this.textboxTimeWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxTimeWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxTimeWork.Hint = "Время работы";
            this.textboxTimeWork.LeadingIcon = null;
            this.textboxTimeWork.Location = new System.Drawing.Point(659, 76);
            this.textboxTimeWork.MaxLength = 50;
            this.textboxTimeWork.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxTimeWork.Multiline = false;
            this.textboxTimeWork.Name = "textboxTimeWork";
            this.textboxTimeWork.Size = new System.Drawing.Size(302, 50);
            this.textboxTimeWork.TabIndex = 1;
            this.textboxTimeWork.Text = "00:00:00";
            this.textboxTimeWork.TrailingIcon = null;
            // 
            // textboxAllTasks
            // 
            this.textboxAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxAllTasks.Depth = 0;
            this.textboxAllTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxAllTasks.Hint = "Возникших задач";
            this.textboxAllTasks.LeadingIcon = null;
            this.textboxAllTasks.Location = new System.Drawing.Point(659, 139);
            this.textboxAllTasks.MaxLength = 50;
            this.textboxAllTasks.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxAllTasks.Multiline = false;
            this.textboxAllTasks.Name = "textboxAllTasks";
            this.textboxAllTasks.Size = new System.Drawing.Size(148, 50);
            this.textboxAllTasks.TabIndex = 2;
            this.textboxAllTasks.Text = "0";
            this.textboxAllTasks.TrailingIcon = null;
            // 
            // textboxTaskComplete
            // 
            this.textboxTaskComplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxTaskComplete.Depth = 0;
            this.textboxTaskComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxTaskComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxTaskComplete.Hint = "Выполненных задач";
            this.textboxTaskComplete.LeadingIcon = null;
            this.textboxTaskComplete.Location = new System.Drawing.Point(813, 139);
            this.textboxTaskComplete.MaxLength = 50;
            this.textboxTaskComplete.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxTaskComplete.Multiline = false;
            this.textboxTaskComplete.Name = "textboxTaskComplete";
            this.textboxTaskComplete.Size = new System.Drawing.Size(148, 50);
            this.textboxTaskComplete.TabIndex = 3;
            this.textboxTaskComplete.Text = "0";
            this.textboxTaskComplete.TrailingIcon = null;
            // 
            // textboxProbIO
            // 
            this.textboxProbIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxProbIO.Depth = 0;
            this.textboxProbIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxProbIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxProbIO.Hint = "Вероятность I/O";
            this.textboxProbIO.LeadingIcon = null;
            this.textboxProbIO.Location = new System.Drawing.Point(813, 202);
            this.textboxProbIO.MaxLength = 50;
            this.textboxProbIO.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxProbIO.Multiline = false;
            this.textboxProbIO.Name = "textboxProbIO";
            this.textboxProbIO.Size = new System.Drawing.Size(148, 50);
            this.textboxProbIO.TabIndex = 4;
            this.textboxProbIO.Text = "0.5";
            this.textboxProbIO.TrailingIcon = null;
            // 
            // textboxDurationIO
            // 
            this.textboxDurationIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDurationIO.Depth = 0;
            this.textboxDurationIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxDurationIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxDurationIO.Hint = "MAX I/O (c)";
            this.textboxDurationIO.LeadingIcon = null;
            this.textboxDurationIO.Location = new System.Drawing.Point(813, 265);
            this.textboxDurationIO.MaxLength = 50;
            this.textboxDurationIO.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxDurationIO.Multiline = false;
            this.textboxDurationIO.Name = "textboxDurationIO";
            this.textboxDurationIO.Size = new System.Drawing.Size(148, 50);
            this.textboxDurationIO.TabIndex = 5;
            this.textboxDurationIO.Text = "0";
            this.textboxDurationIO.TrailingIcon = null;
            // 
            // chartProc
            // 
            chartArea1.AxisX.Title = "Очередной выполненный процесс";
            chartArea1.AxisY.Title = "Время выполнения";
            chartArea1.Name = "ChartArea1";
            this.chartProc.ChartAreas.Add(chartArea1);
            this.chartProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartProc.Location = new System.Drawing.Point(32, 13);
            this.chartProc.Name = "chartProc";
            this.chartProc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.tableLayoutPanel1.SetRowSpan(this.chartProc, 6);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.Name = "Process";
            this.chartProc.Series.Add(series1);
            this.chartProc.Size = new System.Drawing.Size(592, 372);
            this.chartProc.TabIndex = 6;
            this.chartProc.Text = "график";
            // 
            // textboxProbTask
            // 
            this.textboxProbTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxProbTask.Depth = 0;
            this.textboxProbTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxProbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxProbTask.Hint = "Вероятность задачи";
            this.textboxProbTask.LeadingIcon = null;
            this.textboxProbTask.Location = new System.Drawing.Point(659, 202);
            this.textboxProbTask.MaxLength = 50;
            this.textboxProbTask.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxProbTask.Multiline = false;
            this.textboxProbTask.Name = "textboxProbTask";
            this.textboxProbTask.Size = new System.Drawing.Size(148, 50);
            this.textboxProbTask.TabIndex = 7;
            this.textboxProbTask.Text = "0.5";
            this.textboxProbTask.TrailingIcon = null;
            // 
            // textboxDurationTask
            // 
            this.textboxDurationTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDurationTask.Depth = 0;
            this.textboxDurationTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxDurationTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxDurationTask.Hint = "MAX TASK (c)";
            this.textboxDurationTask.LeadingIcon = null;
            this.textboxDurationTask.Location = new System.Drawing.Point(659, 265);
            this.textboxDurationTask.MaxLength = 50;
            this.textboxDurationTask.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxDurationTask.Multiline = false;
            this.textboxDurationTask.Name = "textboxDurationTask";
            this.textboxDurationTask.Size = new System.Drawing.Size(148, 50);
            this.textboxDurationTask.TabIndex = 8;
            this.textboxDurationTask.Text = "0";
            this.textboxDurationTask.TrailingIcon = null;
            // 
            // textboxAvgTimeComplete
            // 
            this.textboxAvgTimeComplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textboxAvgTimeComplete, 2);
            this.textboxAvgTimeComplete.Depth = 0;
            this.textboxAvgTimeComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxAvgTimeComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxAvgTimeComplete.Hint = "Среднее время выполнения задачи (c)";
            this.textboxAvgTimeComplete.LeadingIcon = null;
            this.textboxAvgTimeComplete.Location = new System.Drawing.Point(659, 328);
            this.textboxAvgTimeComplete.MaxLength = 50;
            this.textboxAvgTimeComplete.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxAvgTimeComplete.Multiline = false;
            this.textboxAvgTimeComplete.Name = "textboxAvgTimeComplete";
            this.textboxAvgTimeComplete.Size = new System.Drawing.Size(302, 50);
            this.textboxAvgTimeComplete.TabIndex = 9;
            this.textboxAvgTimeComplete.Text = "Не посчитано";
            this.textboxAvgTimeComplete.TrailingIcon = null;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.log, 4);
            this.log.Depth = 0;
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.log.Location = new System.Drawing.Point(32, 391);
            this.log.MouseState = MaterialSkin.MouseState.HOVER;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(929, 126);
            this.log.TabIndex = 10;
            this.log.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonStart;
        private System.Windows.Forms.Timer workTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox textboxTimeWork;
        private MaterialSkin.Controls.MaterialTextBox textboxAllTasks;
        private MaterialSkin.Controls.MaterialTextBox textboxTaskComplete;
        private MaterialSkin.Controls.MaterialTextBox textboxProbIO;
        private MaterialSkin.Controls.MaterialTextBox textboxDurationIO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProc;
        private MaterialSkin.Controls.MaterialTextBox textboxDurationTask;
        private MaterialSkin.Controls.MaterialTextBox textboxProbTask;
        private MaterialSkin.Controls.MaterialTextBox textboxAvgTimeComplete;
        private MaterialSkin.Controls.MaterialMultiLineTextBox log;
    }
}