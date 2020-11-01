namespace Skyhoshi.App.TimeMarker.Forms
{
    partial class frmKeyBindingRecorder
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
            this.btnSetKeyBinding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetKeyBinding
            // 
            this.btnSetKeyBinding.Location = new System.Drawing.Point(190, 315);
            this.btnSetKeyBinding.Name = "btnSetKeyBinding";
            this.btnSetKeyBinding.Size = new System.Drawing.Size(75, 23);
            this.btnSetKeyBinding.TabIndex = 0;
            this.btnSetKeyBinding.Text = "Set Key Binding";
            this.btnSetKeyBinding.UseVisualStyleBackColor = true;
            this.btnSetKeyBinding.Click += new System.EventHandler(this.btnSetKeyBinding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmKeyBindingRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetKeyBinding);
            this.Name = "frmKeyBindingRecorder";
            this.Text = "Set KeyBinding";
            this.Leave += new System.EventHandler(this.frmKeyBindingRecorder_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetKeyBinding;
        private System.Windows.Forms.Label label1;
    }
}