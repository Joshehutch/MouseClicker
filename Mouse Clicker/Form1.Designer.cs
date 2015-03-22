namespace Mouse_Clicker
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CursorList = new System.Windows.Forms.ToolStripStatusLabel();
            this.PointX = new System.Windows.Forms.TextBox();
            this.ClickEnabled = new System.Windows.Forms.CheckBox();
            this.rghtClick = new System.Windows.Forms.CheckBox();
            this.PointY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Set = new System.Windows.Forms.Button();
            this.LoopCheck = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pointList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delayLbl = new System.Windows.Forms.Label();
            this.rghtClickLbl = new System.Windows.Forms.Label();
            this.ClickLbl = new System.Windows.Forms.Label();
            this.yCoordLbl = new System.Windows.Forms.Label();
            this.xCoordLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CursorList});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(310, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CursorList
            // 
            this.CursorList.BackColor = System.Drawing.SystemColors.Control;
            this.CursorList.Name = "CursorList";
            this.CursorList.Size = new System.Drawing.Size(133, 17);
            this.CursorList.Text = "Cursor Coordinates: 0, 0";
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(9, 19);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(57, 20);
            this.PointX.TabIndex = 2;
            this.PointX.Text = "0";
            this.PointX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PointX.TextChanged += new System.EventHandler(this.Point1X_TextChanged);
            // 
            // ClickEnabled
            // 
            this.ClickEnabled.AutoSize = true;
            this.ClickEnabled.Checked = true;
            this.ClickEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClickEnabled.Location = new System.Drawing.Point(101, 18);
            this.ClickEnabled.Name = "ClickEnabled";
            this.ClickEnabled.Size = new System.Drawing.Size(49, 17);
            this.ClickEnabled.TabIndex = 3;
            this.ClickEnabled.Text = "Click";
            this.ClickEnabled.UseVisualStyleBackColor = true;
            // 
            // rghtClick
            // 
            this.rghtClick.AutoSize = true;
            this.rghtClick.Location = new System.Drawing.Point(101, 40);
            this.rghtClick.Name = "rghtClick";
            this.rghtClick.Size = new System.Drawing.Size(51, 30);
            this.rghtClick.TabIndex = 4;
            this.rghtClick.Text = "Right\r\nClick";
            this.rghtClick.UseVisualStyleBackColor = true;
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(9, 45);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(57, 20);
            this.PointY.TabIndex = 5;
            this.PointY.Text = "0";
            this.PointY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PointY.TextChanged += new System.EventHandler(this.Point1Y_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(156, 38);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(57, 20);
            this.Delay.TabIndex = 8;
            this.Delay.Text = "150";
            this.Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Delay.TextChanged += new System.EventHandler(this.Delay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delay";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.Set);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PointX);
            this.groupBox1.Controls.Add(this.Delay);
            this.groupBox1.Controls.Add(this.ClickEnabled);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rghtClick);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PointY);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursor Point Entry";
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(221, 13);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(75, 52);
            this.Set.TabIndex = 10;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // LoopCheck
            // 
            this.LoopCheck.AutoSize = true;
            this.LoopCheck.Checked = true;
            this.LoopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoopCheck.Location = new System.Drawing.Point(166, 216);
            this.LoopCheck.Name = "LoopCheck";
            this.LoopCheck.Size = new System.Drawing.Size(50, 17);
            this.LoopCheck.TabIndex = 13;
            this.LoopCheck.Text = "Loop";
            this.LoopCheck.UseVisualStyleBackColor = true;
            this.LoopCheck.CheckedChanged += new System.EventHandler(this.LoopCheck_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(222, 211);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(78, 28);
            this.Start.TabIndex = 14;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pointList
            // 
            this.pointList.FormattingEnabled = true;
            this.pointList.Location = new System.Drawing.Point(10, 84);
            this.pointList.Name = "pointList";
            this.pointList.Size = new System.Drawing.Size(66, 121);
            this.pointList.TabIndex = 15;
            this.pointList.SelectedIndexChanged += new System.EventHandler(this.pointList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.delayLbl);
            this.groupBox2.Controls.Add(this.rghtClickLbl);
            this.groupBox2.Controls.Add(this.ClickLbl);
            this.groupBox2.Controls.Add(this.yCoordLbl);
            this.groupBox2.Controls.Add(this.xCoordLbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(143, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 128);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Point Info";
            // 
            // delayLbl
            // 
            this.delayLbl.AutoSize = true;
            this.delayLbl.Location = new System.Drawing.Point(91, 107);
            this.delayLbl.Name = "delayLbl";
            this.delayLbl.Size = new System.Drawing.Size(33, 13);
            this.delayLbl.TabIndex = 9;
            this.delayLbl.Text = "None";
            // 
            // rghtClickLbl
            // 
            this.rghtClickLbl.AutoSize = true;
            this.rghtClickLbl.Location = new System.Drawing.Point(91, 85);
            this.rghtClickLbl.Name = "rghtClickLbl";
            this.rghtClickLbl.Size = new System.Drawing.Size(21, 13);
            this.rghtClickLbl.TabIndex = 8;
            this.rghtClickLbl.Text = "No";
            // 
            // ClickLbl
            // 
            this.ClickLbl.AutoSize = true;
            this.ClickLbl.Location = new System.Drawing.Point(91, 63);
            this.ClickLbl.Name = "ClickLbl";
            this.ClickLbl.Size = new System.Drawing.Size(21, 13);
            this.ClickLbl.TabIndex = 7;
            this.ClickLbl.Text = "No";
            // 
            // yCoordLbl
            // 
            this.yCoordLbl.AutoSize = true;
            this.yCoordLbl.Location = new System.Drawing.Point(91, 40);
            this.yCoordLbl.Name = "yCoordLbl";
            this.yCoordLbl.Size = new System.Drawing.Size(33, 13);
            this.yCoordLbl.TabIndex = 6;
            this.yCoordLbl.Text = "None";
            // 
            // xCoordLbl
            // 
            this.xCoordLbl.AutoSize = true;
            this.xCoordLbl.Location = new System.Drawing.Point(91, 17);
            this.xCoordLbl.Name = "xCoordLbl";
            this.xCoordLbl.Size = new System.Drawing.Size(33, 13);
            this.xCoordLbl.TabIndex = 5;
            this.xCoordLbl.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Delay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Right Click:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Click:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y Coordinate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Coordinate:";
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(87, 109);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(47, 23);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.Enabled = false;
            this.Clear.Location = new System.Drawing.Point(87, 138);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(47, 23);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Insert = Fill";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Home = Set";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Delete = Stop";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "End = Start";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(310, 266);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pointList);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LoopCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Mouse  Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CursorList;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.CheckBox ClickEnabled;
        private System.Windows.Forms.CheckBox rghtClick;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Delay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LoopCheck;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.ListBox pointList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label delayLbl;
        private System.Windows.Forms.Label rghtClickLbl;
        private System.Windows.Forms.Label ClickLbl;
        private System.Windows.Forms.Label yCoordLbl;
        private System.Windows.Forms.Label xCoordLbl;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;



    }
}

