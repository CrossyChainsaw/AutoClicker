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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.NUD_Repetitions = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_EstimatedTime = new System.Windows.Forms.Label();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_AddButtonPress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_X1 = new System.Windows.Forms.Label();
            this.BTN_SetLocation = new System.Windows.Forms.Button();
            this.LBL_Y1 = new System.Windows.Forms.Label();
            this.NUD_Delay = new System.Windows.Forms.NumericUpDown();
            this.LBL_delay = new System.Windows.Forms.Label();
            this.LBL_Ms = new System.Windows.Forms.Label();
            this.GB_FirstPoint = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Delay)).BeginInit();
            this.GB_FirstPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Start.Location = new System.Drawing.Point(420, 17);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(82, 23);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.Location = new System.Drawing.Point(187, 17);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(110, 23);
            this.BTN_Add.TabIndex = 4;
            this.BTN_Add.Text = "Add MouseClick";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // NUD_Repetitions
            // 
            this.NUD_Repetitions.Location = new System.Drawing.Point(92, 17);
            this.NUD_Repetitions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUD_Repetitions.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUD_Repetitions.Name = "NUD_Repetitions";
            this.NUD_Repetitions.Size = new System.Drawing.Size(89, 23);
            this.NUD_Repetitions.TabIndex = 8;
            this.NUD_Repetitions.ValueChanged += new System.EventHandler(this.NUD_Repetitions_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Repetitions:";
            // 
            // LBL_EstimatedTime
            // 
            this.LBL_EstimatedTime.AutoSize = true;
            this.LBL_EstimatedTime.Location = new System.Drawing.Point(10, 40);
            this.LBL_EstimatedTime.Name = "LBL_EstimatedTime";
            this.LBL_EstimatedTime.Size = new System.Drawing.Size(98, 15);
            this.LBL_EstimatedTime.TabIndex = 9;
            this.LBL_EstimatedTime.Text = "Estimated time: 0";
            // 
            // BTN_Save
            // 
            this.BTN_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save.Location = new System.Drawing.Point(508, 17);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(82, 23);
            this.BTN_Save.TabIndex = 10;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Load
            // 
            this.BTN_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Load.Location = new System.Drawing.Point(596, 17);
            this.BTN_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(82, 23);
            this.BTN_Load.TabIndex = 11;
            this.BTN_Load.Text = "Load";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_AddButtonPress
            // 
            this.BTN_AddButtonPress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddButtonPress.Location = new System.Drawing.Point(303, 17);
            this.BTN_AddButtonPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_AddButtonPress.Name = "BTN_AddButtonPress";
            this.BTN_AddButtonPress.Size = new System.Drawing.Size(110, 23);
            this.BTN_AddButtonPress.TabIndex = 12;
            this.BTN_AddButtonPress.Text = "Add ButtonPress";
            this.BTN_AddButtonPress.UseVisualStyleBackColor = true;
            this.BTN_AddButtonPress.Click += new System.EventHandler(this.BTN_AddButtonPress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point 1:";
            // 
            // LBL_X1
            // 
            this.LBL_X1.AutoSize = true;
            this.LBL_X1.Location = new System.Drawing.Point(58, 10);
            this.LBL_X1.Name = "LBL_X1";
            this.LBL_X1.Size = new System.Drawing.Size(25, 15);
            this.LBL_X1.TabIndex = 2;
            this.LBL_X1.Text = "x: 0";
            // 
            // BTN_SetLocation
            // 
            this.BTN_SetLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SetLocation.Location = new System.Drawing.Point(391, 7);
            this.BTN_SetLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SetLocation.Name = "BTN_SetLocation";
            this.BTN_SetLocation.Size = new System.Drawing.Size(100, 22);
            this.BTN_SetLocation.TabIndex = 0;
            this.BTN_SetLocation.Text = "Set Location";
            this.BTN_SetLocation.UseVisualStyleBackColor = true;
            this.BTN_SetLocation.Click += new System.EventHandler(this.BTN_SetLocation_Click);
            // 
            // LBL_Y1
            // 
            this.LBL_Y1.AutoSize = true;
            this.LBL_Y1.Location = new System.Drawing.Point(104, 10);
            this.LBL_Y1.Name = "LBL_Y1";
            this.LBL_Y1.Size = new System.Drawing.Size(25, 15);
            this.LBL_Y1.TabIndex = 3;
            this.LBL_Y1.Text = "y: 0";
            // 
            // NUD_Delay
            // 
            this.NUD_Delay.Location = new System.Drawing.Point(248, 8);
            this.NUD_Delay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUD_Delay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUD_Delay.Name = "NUD_Delay";
            this.NUD_Delay.Size = new System.Drawing.Size(89, 23);
            this.NUD_Delay.TabIndex = 5;
            this.NUD_Delay.ValueChanged += new System.EventHandler(this.NUD_Delay_ValueChanged);
            // 
            // LBL_delay
            // 
            this.LBL_delay.AutoSize = true;
            this.LBL_delay.Location = new System.Drawing.Point(206, 10);
            this.LBL_delay.Name = "LBL_delay";
            this.LBL_delay.Size = new System.Drawing.Size(38, 15);
            this.LBL_delay.TabIndex = 6;
            this.LBL_delay.Text = "delay:";
            // 
            // LBL_Ms
            // 
            this.LBL_Ms.AutoSize = true;
            this.LBL_Ms.Location = new System.Drawing.Point(339, 10);
            this.LBL_Ms.Name = "LBL_Ms";
            this.LBL_Ms.Size = new System.Drawing.Size(23, 15);
            this.LBL_Ms.TabIndex = 7;
            this.LBL_Ms.Text = "ms";
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
            this.GB_FirstPoint.Location = new System.Drawing.Point(10, 56);
            this.GB_FirstPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_FirstPoint.Name = "GB_FirstPoint";
            this.GB_FirstPoint.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_FirstPoint.Size = new System.Drawing.Size(491, 28);
            this.GB_FirstPoint.TabIndex = 2;
            this.GB_FirstPoint.TabStop = false;
            // 
            // FRM_AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 338);
            this.Controls.Add(this.BTN_AddButtonPress);
            this.Controls.Add(this.BTN_Load);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.LBL_EstimatedTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_Repetitions);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.GB_FirstPoint);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_AutoClicker";
            this.Text = "Auto Clicker";
            this.Deactivate += new System.EventHandler(this.FRM_AutoClicker_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Delay)).EndInit();
            this.GB_FirstPoint.ResumeLayout(false);
            this.GB_FirstPoint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BTN_Start;
        private Button BTN_Add;
        private NumericUpDown NUD_Repetitions;
        private Label label2;
        private Label LBL_EstimatedTime;
        private Button BTN_Save;
        private Button BTN_Load;
        private Button BTN_AddButtonPress;
        private Label label1;
        private Label LBL_X1;
        private Button BTN_SetLocation;
        private Label LBL_Y1;
        private NumericUpDown NUD_Delay;
        private Label LBL_delay;
        private Label LBL_Ms;
        private GroupBox GB_FirstPoint;
    }
}