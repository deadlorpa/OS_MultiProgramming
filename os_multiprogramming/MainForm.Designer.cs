
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
            this.buttonStart = new MaterialSkin.Controls.MaterialButton();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textboxTimeWork = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxAllTasks = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxTaskComplete = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxProbIO = new MaterialSkin.Controls.MaterialTextBox();
            this.textboxDurationIO = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBoxGraphic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonStart.Depth = 0;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.HighEmphasis = true;
            this.buttonStart.Icon = global::os_multiprogramming.Properties.Resources.power_off_solid;
            this.buttonStart.Location = new System.Drawing.Point(541, 73);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(244, 46);
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
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textboxTimeWork, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textboxAllTasks, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textboxTaskComplete, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textboxProbIO, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.textboxDurationIO, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxGraphic, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.941561F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.941561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 483);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textboxTimeWork
            // 
            this.textboxTimeWork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxTimeWork.Depth = 0;
            this.textboxTimeWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxTimeWork.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textboxTimeWork.Hint = "Время работы";
            this.textboxTimeWork.LeadingIcon = null;
            this.textboxTimeWork.Location = new System.Drawing.Point(540, 128);
            this.textboxTimeWork.MaxLength = 50;
            this.textboxTimeWork.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxTimeWork.Multiline = false;
            this.textboxTimeWork.Name = "textboxTimeWork";
            this.textboxTimeWork.Size = new System.Drawing.Size(246, 50);
            this.textboxTimeWork.TabIndex = 1;
            this.textboxTimeWork.Text = "00:00:00";
            this.textboxTimeWork.TrailingIcon = null;
            // 
            // textboxAllTasks
            // 
            this.textboxAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxAllTasks.Depth = 0;
            this.textboxAllTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxAllTasks.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textboxAllTasks.Hint = "Возникших задач";
            this.textboxAllTasks.LeadingIcon = null;
            this.textboxAllTasks.Location = new System.Drawing.Point(540, 186);
            this.textboxAllTasks.MaxLength = 50;
            this.textboxAllTasks.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxAllTasks.Multiline = false;
            this.textboxAllTasks.Name = "textboxAllTasks";
            this.textboxAllTasks.Size = new System.Drawing.Size(246, 50);
            this.textboxAllTasks.TabIndex = 2;
            this.textboxAllTasks.Text = "0";
            this.textboxAllTasks.TrailingIcon = null;
            // 
            // textboxTaskComplete
            // 
            this.textboxTaskComplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxTaskComplete.Depth = 0;
            this.textboxTaskComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxTaskComplete.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textboxTaskComplete.Hint = "Выполненных задач";
            this.textboxTaskComplete.LeadingIcon = null;
            this.textboxTaskComplete.Location = new System.Drawing.Point(540, 244);
            this.textboxTaskComplete.MaxLength = 50;
            this.textboxTaskComplete.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxTaskComplete.Multiline = false;
            this.textboxTaskComplete.Name = "textboxTaskComplete";
            this.textboxTaskComplete.Size = new System.Drawing.Size(246, 50);
            this.textboxTaskComplete.TabIndex = 3;
            this.textboxTaskComplete.Text = "0";
            this.textboxTaskComplete.TrailingIcon = null;
            // 
            // textboxProbIO
            // 
            this.textboxProbIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxProbIO.Depth = 0;
            this.textboxProbIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxProbIO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textboxProbIO.Hint = "Вероятность I/O";
            this.textboxProbIO.LeadingIcon = null;
            this.textboxProbIO.Location = new System.Drawing.Point(540, 302);
            this.textboxProbIO.MaxLength = 50;
            this.textboxProbIO.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxProbIO.Multiline = false;
            this.textboxProbIO.Name = "textboxProbIO";
            this.textboxProbIO.Size = new System.Drawing.Size(246, 50);
            this.textboxProbIO.TabIndex = 4;
            this.textboxProbIO.Text = "0.5";
            this.textboxProbIO.TrailingIcon = null;
            // 
            // textboxDurationIO
            // 
            this.textboxDurationIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDurationIO.Depth = 0;
            this.textboxDurationIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxDurationIO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textboxDurationIO.Hint = "Продолжительность I/O (MAX)";
            this.textboxDurationIO.LeadingIcon = null;
            this.textboxDurationIO.Location = new System.Drawing.Point(540, 360);
            this.textboxDurationIO.MaxLength = 50;
            this.textboxDurationIO.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxDurationIO.Multiline = false;
            this.textboxDurationIO.Name = "textboxDurationIO";
            this.textboxDurationIO.Size = new System.Drawing.Size(246, 50);
            this.textboxDurationIO.TabIndex = 5;
            this.textboxDurationIO.Text = "0";
            this.textboxDurationIO.TrailingIcon = null;
            // 
            // pictureBoxGraphic
            // 
            this.pictureBoxGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGraphic.Location = new System.Drawing.Point(27, 70);
            this.pictureBoxGraphic.Name = "pictureBoxGraphic";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxGraphic, 6);
            this.pictureBoxGraphic.Size = new System.Drawing.Size(483, 342);
            this.pictureBoxGraphic.TabIndex = 6;
            this.pictureBoxGraphic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphic)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxGraphic;
    }
}