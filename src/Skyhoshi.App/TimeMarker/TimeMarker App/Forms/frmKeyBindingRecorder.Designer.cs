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
            this.SuspendLayout();
            // 
            // btnSetKeyBinding
            // 
            this.btnSetKeyBinding.Location = new System.Drawing.Point(190, 315);
            this.btnSetKeyBinding.Name = "btnSetKeyBinding";
            this.btnSetKeyBinding.Size = new System.Drawing.Size(75, 23);
            this.btnSetKeyBinding.TabIndex = 0;
            this.btnSetKeyBinding.Text = "button1";
            this.btnSetKeyBinding.UseVisualStyleBackColor = true;
            this.btnSetKeyBinding.Click += new System.EventHandler(this.btnSetKeyBinding_Click);
            // 
            // frmKeyBindingRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.btnSetKeyBinding);
            this.Name = "frmKeyBindingRecorder";
            this.Text = "Set KeyBinding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetKeyBinding;
    }
}