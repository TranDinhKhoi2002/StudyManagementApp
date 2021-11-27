
namespace StudyManagementApp
{
    partial class ProgressForm
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
            this.pieChartToDo = new LiveCharts.WinForms.PieChart();
            this.dtgvTodo = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartToDo
            // 
            this.pieChartToDo.Location = new System.Drawing.Point(12, 12);
            this.pieChartToDo.Name = "pieChartToDo";
            this.pieChartToDo.Size = new System.Drawing.Size(452, 414);
            this.pieChartToDo.TabIndex = 1;
            this.pieChartToDo.Text = "pieChart1";
            // 
            // dtgvTodo
            // 
            this.dtgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatus,
            this.colTotal});
            this.dtgvTodo.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgvTodo.Location = new System.Drawing.Point(498, 0);
            this.dtgvTodo.Name = "dtgvTodo";
            this.dtgvTodo.Size = new System.Drawing.Size(346, 497);
            this.dtgvTodo.TabIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 150;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.dtgvTodo);
            this.Controls.Add(this.pieChartToDo);
            this.MaximizeBox = false;
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.PieChart pieChartToDo;
        private System.Windows.Forms.DataGridView dtgvTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}