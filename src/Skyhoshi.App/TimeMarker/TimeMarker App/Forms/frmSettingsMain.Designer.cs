namespace Skyhoshi.App.TimeMarker
{
    partial class frmSettingsMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimeMakerSettingsTabControl = new System.Windows.Forms.TabControl();
            this.tbpgKeyBinding = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestHotkey = new System.Windows.Forms.Button();
            this.tbpgAudioRecording = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AudioSettingsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.TimeMakerSettingsTabControl.SuspendLayout();
            this.tbpgKeyBinding.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbpgAudioRecording.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimeMakerSettingsTabControl
            // 
            this.TimeMakerSettingsTabControl.Controls.Add(this.tbpgKeyBinding);
            this.TimeMakerSettingsTabControl.Controls.Add(this.tbpgAudioRecording);
            this.TimeMakerSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeMakerSettingsTabControl.Location = new System.Drawing.Point(0, 25);
            this.TimeMakerSettingsTabControl.Name = "TimeMakerSettingsTabControl";
            this.TimeMakerSettingsTabControl.SelectedIndex = 0;
            this.TimeMakerSettingsTabControl.Size = new System.Drawing.Size(800, 403);
            this.TimeMakerSettingsTabControl.TabIndex = 3;
            // 
            // tbpgKeyBinding
            // 
            this.tbpgKeyBinding.Controls.Add(this.flowLayoutPanel1);
            this.tbpgKeyBinding.Location = new System.Drawing.Point(4, 24);
            this.tbpgKeyBinding.Name = "tbpgKeyBinding";
            this.tbpgKeyBinding.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgKeyBinding.Size = new System.Drawing.Size(792, 375);
            this.tbpgKeyBinding.TabIndex = 0;
            this.tbpgKeyBinding.Text = "KeyBinding";
            this.tbpgKeyBinding.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 369);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(792, 375);
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTestHotkey, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(792, 375);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(399, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnTestHotkey
            // 
            this.btnTestHotkey.Location = new System.Drawing.Point(3, 3);
            this.btnTestHotkey.Name = "btnTestHotkey";
            this.btnTestHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnTestHotkey.TabIndex = 1;
            this.btnTestHotkey.Text = "button1";
            this.btnTestHotkey.UseVisualStyleBackColor = true;
            // 
            // tbpgAudioRecording
            // 
            this.tbpgAudioRecording.Controls.Add(this.flowLayoutPanel2);
            this.tbpgAudioRecording.Location = new System.Drawing.Point(4, 24);
            this.tbpgAudioRecording.Name = "tbpgAudioRecording";
            this.tbpgAudioRecording.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAudioRecording.Size = new System.Drawing.Size(792, 375);
            this.tbpgAudioRecording.TabIndex = 1;
            this.tbpgAudioRecording.Text = "Audio Recordings";
            this.tbpgAudioRecording.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.AudioSettingsPropertyGrid);
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 369);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // AudioSettingsPropertyGrid
            // 
            this.AudioSettingsPropertyGrid.LargeButtons = true;
            this.AudioSettingsPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.AudioSettingsPropertyGrid.Name = "AudioSettingsPropertyGrid";
            this.AudioSettingsPropertyGrid.Size = new System.Drawing.Size(344, 366);
            this.AudioSettingsPropertyGrid.TabIndex = 0;
            this.AudioSettingsPropertyGrid.TabStop = false;
            this.AudioSettingsPropertyGrid.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.AudioSettingsPropertyGrid_SelectedGridItemChanged);
            this.AudioSettingsPropertyGrid.SelectedObjectsChanged += new System.EventHandler(this.AudioSettingsPropertyGrid_SelectedObjectsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(353, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings Addtional Details";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(408, 344);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // frmSettingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeMakerSettingsTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSettingsMain";
            this.ShowInTaskbar = false;
            this.Text = "Time Marker Settings";
            this.Load += new System.EventHandler(this.frmSettingsMain_Load);
            this.TimeMakerSettingsTabControl.ResumeLayout(false);
            this.tbpgKeyBinding.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbpgAudioRecording.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl TimeMakerSettingsTabControl;
        private System.Windows.Forms.TabPage tbpgKeyBinding;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tbpgAudioRecording;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PropertyGrid AudioSettingsPropertyGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestHotkey;
    }
}