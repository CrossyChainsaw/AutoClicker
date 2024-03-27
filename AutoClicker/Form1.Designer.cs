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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AutoClicker));
            BTN_Start = new Button();
            BTN_AddMouseAction = new Button();
            NUD_Repetitions = new NumericUpDown();
            LBL_Repetitions = new Label();
            LBL_EstimatedTime = new Label();
            BTN_Save = new Button();
            BTN_Load = new Button();
            BTN_AddButtonAction = new Button();
            BTN_Save_As = new Button();
            BTN_AddText = new Button();
            ((System.ComponentModel.ISupportInitialize)NUD_Repetitions).BeginInit();
            SuspendLayout();
            // 
            // BTN_Start
            // 
            BTN_Start.Cursor = Cursors.Hand;
            BTN_Start.Location = new Point(588, 25);
            BTN_Start.Name = "BTN_Start";
            BTN_Start.Size = new Size(94, 29);
            BTN_Start.TabIndex = 3;
            BTN_Start.Text = "Start";
            BTN_Start.UseVisualStyleBackColor = true;
            BTN_Start.Click += BTN_Start_Click;
            // 
            // BTN_AddMouseAction
            // 
            BTN_AddMouseAction.BackColor = SystemColors.ControlLight;
            BTN_AddMouseAction.Cursor = Cursors.Hand;
            BTN_AddMouseAction.Location = new Point(214, 23);
            BTN_AddMouseAction.Name = "BTN_AddMouseAction";
            BTN_AddMouseAction.Size = new Size(126, 31);
            BTN_AddMouseAction.TabIndex = 4;
            BTN_AddMouseAction.Text = "Add MouseClick";
            BTN_AddMouseAction.UseVisualStyleBackColor = false;
            BTN_AddMouseAction.Click += BTN_AddMouseAction_Click;
            // 
            // NUD_Repetitions
            // 
            NUD_Repetitions.Location = new Point(105, 23);
            NUD_Repetitions.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NUD_Repetitions.Name = "NUD_Repetitions";
            NUD_Repetitions.Size = new Size(102, 27);
            NUD_Repetitions.TabIndex = 8;
            NUD_Repetitions.ValueChanged += NUD_Repetitions_ValueChanged;
            NUD_Repetitions.Leave += NUD_Repetitions_Leave;
            // 
            // LBL_Repetitions
            // 
            LBL_Repetitions.AutoSize = true;
            LBL_Repetitions.Location = new Point(11, 25);
            LBL_Repetitions.Name = "LBL_Repetitions";
            LBL_Repetitions.Size = new Size(87, 20);
            LBL_Repetitions.TabIndex = 8;
            LBL_Repetitions.Text = "Repetitions:";
            LBL_Repetitions.Click += LBL_Repetitions_Click;
            // 
            // LBL_EstimatedTime
            // 
            LBL_EstimatedTime.AutoSize = true;
            LBL_EstimatedTime.Location = new Point(11, 53);
            LBL_EstimatedTime.Name = "LBL_EstimatedTime";
            LBL_EstimatedTime.Size = new Size(124, 20);
            LBL_EstimatedTime.TabIndex = 9;
            LBL_EstimatedTime.Text = "Estimated time: 0";
            LBL_EstimatedTime.Click += LBL_EstimatedTime_Click;
            // 
            // BTN_Save
            // 
            BTN_Save.Cursor = Cursors.Hand;
            BTN_Save.Location = new Point(789, 25);
            BTN_Save.Name = "BTN_Save";
            BTN_Save.Size = new Size(94, 29);
            BTN_Save.TabIndex = 10;
            BTN_Save.Text = "Save";
            BTN_Save.UseVisualStyleBackColor = true;
            BTN_Save.Click += BTN_Save_Click;
            // 
            // BTN_Load
            // 
            BTN_Load.Cursor = Cursors.Hand;
            BTN_Load.Location = new Point(689, 25);
            BTN_Load.Name = "BTN_Load";
            BTN_Load.Size = new Size(94, 29);
            BTN_Load.TabIndex = 11;
            BTN_Load.Text = "Load";
            BTN_Load.UseVisualStyleBackColor = true;
            BTN_Load.Click += BTN_Load_Click;
            // 
            // BTN_AddButtonAction
            // 
            BTN_AddButtonAction.Cursor = Cursors.Hand;
            BTN_AddButtonAction.Location = new Point(346, 23);
            BTN_AddButtonAction.Name = "BTN_AddButtonAction";
            BTN_AddButtonAction.Size = new Size(126, 31);
            BTN_AddButtonAction.TabIndex = 12;
            BTN_AddButtonAction.Text = "Add ButtonPress";
            BTN_AddButtonAction.UseVisualStyleBackColor = true;
            BTN_AddButtonAction.Click += BTN_AddButtonAction_Click;
            // 
            // BTN_Save_As
            // 
            BTN_Save_As.Cursor = Cursors.Hand;
            BTN_Save_As.Location = new Point(890, 25);
            BTN_Save_As.Name = "BTN_Save_As";
            BTN_Save_As.Size = new Size(94, 29);
            BTN_Save_As.TabIndex = 13;
            BTN_Save_As.Text = "Save As...";
            BTN_Save_As.UseVisualStyleBackColor = true;
            BTN_Save_As.Click += BTN_Save_As_Click;
            // 
            // BTN_AddText
            // 
            BTN_AddText.Cursor = Cursors.Hand;
            BTN_AddText.Location = new Point(478, 25);
            BTN_AddText.Name = "BTN_AddText";
            BTN_AddText.Size = new Size(104, 29);
            BTN_AddText.TabIndex = 14;
            BTN_AddText.Text = "Add Text";
            BTN_AddText.UseVisualStyleBackColor = true;
            BTN_AddText.Click += BTN_AddText_Click;
            // 
            // FRM_AutoClicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(995, 451);
            Controls.Add(BTN_AddText);
            Controls.Add(BTN_Save_As);
            Controls.Add(BTN_AddButtonAction);
            Controls.Add(BTN_Load);
            Controls.Add(BTN_Save);
            Controls.Add(LBL_EstimatedTime);
            Controls.Add(LBL_Repetitions);
            Controls.Add(NUD_Repetitions);
            Controls.Add(BTN_AddMouseAction);
            Controls.Add(BTN_Start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_AutoClicker";
            Text = "Auto Clicker";
            Deactivate += FRM_AutoClicker_Deactivate;
            ((System.ComponentModel.ISupportInitialize)NUD_Repetitions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTN_Start;
        private Button BTN_AddMouseAction;
        private NumericUpDown NUD_Repetitions;
        private Label LBL_Repetitions;
        private Label LBL_EstimatedTime;
        private Button BTN_Save;
        private Button BTN_Load;
        private Button BTN_AddButtonAction;
        private Button BTN_Save_As;
        private Button BTN_AddText;
    }
}