namespace AutoClicker
{
    partial class FRM_AutoClicker
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
            this.BTN_SetLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_FirstPoint = new System.Windows.Forms.GroupBox();
            this.LBL_Ms = new System.Windows.Forms.Label();
            this.LBL_delay = new System.Windows.Forms.Label();
            this.NUD_Delay = new System.Windows.Forms.NumericUpDown();
            this.LBL_Y1 = new System.Windows.Forms.Label();
            this.LBL_X1 = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.NUD_Repetitions = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_EstimatedTime = new System.Windows.Forms.Label();
            this.GB_FirstPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_SetLocation
            // 
            this.BTN_SetLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SetLocation.Location = new System.Drawing.Point(447, 9);
            this.BTN_SetLocation.Name = "BTN_SetLocation";
            this.BTN_SetLocation.Size = new System.Drawing.Size(114, 29);
            this.BTN_SetLocation.TabIndex = 0;
            this.BTN_SetLocation.Text = "Set Location";
            this.BTN_SetLocation.UseVisualStyleBackColor = true;
            this.BTN_SetLocation.Click += new System.EventHandler(this.BTN_SetLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point 1:";
            // 
            // GB_FirstPoint
            // 
            this.GB_FirstPoint.Controls.Add(this.LBL_Ms);
            this.GB_FirstPoint.Controls.Add(this.LBL_delay);
            this.GB_FirstPoint.Controls.Add(this.NUD_Delay);
            this.GB_FirstPoint.Controls.Add(this.LBL_Y1);
            this.GB_FirstPoint.Controls.Add(this.BTN_SetLocation);
            this.GB_FirstPoint.Controls.Add(this.LBL_X1);
            this.GB_FirstPoint.Controls.Add(this.label1);
            this.GB_FirstPoint.Location = new System.Drawing.Point(12, 74);
            this.GB_FirstPoint.Name = "GB_FirstPoint";
            this.GB_FirstPoint.Size = new System.Drawing.Size(561, 38);
            this.GB_FirstPoint.TabIndex = 2;
            this.GB_FirstPoint.TabStop = false;
            // 
            // LBL_Ms
            // 
            this.LBL_Ms.AutoSize = true;
            this.LBL_Ms.Location = new System.Drawing.Point(387, 13);
            this.LBL_Ms.Name = "LBL_Ms";
            this.LBL_Ms.Size = new System.Drawing.Size(28, 20);
            this.LBL_Ms.TabIndex = 7;
            this.LBL_Ms.Text = "ms";
            // 
            // LBL_delay
            // 
            this.LBL_delay.AutoSize = true;
            this.LBL_delay.Location = new System.Drawing.Point(236, 13);
            this.LBL_delay.Name = "LBL_delay";
            this.LBL_delay.Size = new System.Drawing.Size(48, 20);
            this.LBL_delay.TabIndex = 6;
            this.LBL_delay.Text = "delay:";
            // 
            // NUD_Delay
            // 
            this.NUD_Delay.Location = new System.Drawing.Point(284, 10);
            this.NUD_Delay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUD_Delay.Name = "NUD_Delay";
            this.NUD_Delay.Size = new System.Drawing.Size(102, 27);
            this.NUD_Delay.TabIndex = 5;
            this.NUD_Delay.ValueChanged += new System.EventHandler(this.NUD_Delay_ValueChanged);
            // 
            // LBL_Y1
            // 
            this.LBL_Y1.AutoSize = true;
            this.LBL_Y1.Location = new System.Drawing.Point(119, 13);
            this.LBL_Y1.Name = "LBL_Y1";
            this.LBL_Y1.Size = new System.Drawing.Size(31, 20);
            this.LBL_Y1.TabIndex = 3;
            this.LBL_Y1.Text = "y: 0";
            // 
            // LBL_X1
            // 
            this.LBL_X1.AutoSize = true;
            this.LBL_X1.Location = new System.Drawing.Point(66, 13);
            this.LBL_X1.Name = "LBL_X1";
            this.LBL_X1.Size = new System.Drawing.Size(31, 20);
            this.LBL_X1.TabIndex = 2;
            this.LBL_X1.Text = "x: 0";
            // 
            // BTN_Start
            // 
            this.BTN_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Start.Location = new System.Drawing.Point(479, 21);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(94, 29);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Location = new System.Drawing.Point(379, 21);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(94, 29);
            this.BTN_Add.TabIndex = 4;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // NUD_Repetitions
            // 
            this.NUD_Repetitions.Location = new System.Drawing.Point(105, 23);
            this.NUD_Repetitions.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUD_Repetitions.Name = "NUD_Repetitions";
            this.NUD_Repetitions.Size = new System.Drawing.Size(102, 27);
            this.NUD_Repetitions.TabIndex = 8;
            this.NUD_Repetitions.ValueChanged += new System.EventHandler(this.NUD_Repetitions_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Repetitions:";
            // 
            // LBL_EstimatedTime
            // 
            this.LBL_EstimatedTime.AutoSize = true;
            this.LBL_EstimatedTime.Location = new System.Drawing.Point(12, 53);
            this.LBL_EstimatedTime.Name = "LBL_EstimatedTime";
            this.LBL_EstimatedTime.Size = new System.Drawing.Size(124, 20);
            this.LBL_EstimatedTime.TabIndex = 9;
            this.LBL_EstimatedTime.Text = "Estimated time: 0";
            // 
            // FRM_AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.LBL_EstimatedTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_Repetitions);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.GB_FirstPoint);
            this.Name = "FRM_AutoClicker";
            this.Text = "Auto Clicker";
            this.Deactivate += new System.EventHandler(this.FRM_AutoClicker_Deactivate);
            this.GB_FirstPoint.ResumeLayout(false);
            this.GB_FirstPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repetitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_SetLocation;
        private Label label1;
        private GroupBox GB_FirstPoint;
        private Label LBL_Y1;
        private Label LBL_X1;
        private Button BTN_Start;
        private Button BTN_Add;
        private Label LBL_Ms;
        private Label LBL_delay;
        private NumericUpDown NUD_Delay;
        private NumericUpDown NUD_Repetitions;
        private Label label2;
        private Label LBL_EstimatedTime;
    }
}