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
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repetitions)).BeginInit();
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
            this.NUD_Repetitions.Leave += new System.EventHandler(this.NUD_Repetitions_Leave);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_AutoClicker";
            this.Text = "Auto Clicker";
            this.Deactivate += new System.EventHandler(this.FRM_AutoClicker_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repetitions)).EndInit();
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
    }
}