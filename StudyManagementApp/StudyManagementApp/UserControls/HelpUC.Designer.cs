
namespace StudyManagementApp.UserControls
{
    partial class HelpUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.Lb_Instruction = new System.Windows.Forms.Label();
            this.HelpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpPanel
            // 
            this.HelpPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpPanel.Controls.Add(this.Lb_Instruction);
            this.HelpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpPanel.Location = new System.Drawing.Point(0, 0);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(1067, 554);
            this.HelpPanel.TabIndex = 16;
            // 
            // Lb_Instruction
            // 
            this.Lb_Instruction.AutoSize = true;
            this.Lb_Instruction.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Instruction.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Instruction.ForeColor = System.Drawing.Color.Black;
            this.Lb_Instruction.Location = new System.Drawing.Point(63, 38);
            this.Lb_Instruction.Name = "Lb_Instruction";
            this.Lb_Instruction.Size = new System.Drawing.Size(353, 78);
            this.Lb_Instruction.TabIndex = 0;
            this.Lb_Instruction.Text = "Instruction";
            // 
            // HelpUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HelpPanel);
            this.Name = "HelpUC";
            this.Size = new System.Drawing.Size(1067, 554);
            this.HelpPanel.ResumeLayout(false);
            this.HelpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HelpPanel;
        private System.Windows.Forms.Label Lb_Instruction;
    }
}
