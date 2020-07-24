namespace BillGen
{
    partial class Form3
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
            this.btnRemoveRemove = new System.Windows.Forms.Button();
            this.btnRemoveCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStockIdRemove = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveRemove
            // 
            this.btnRemoveRemove.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRemoveRemove.FlatAppearance.BorderSize = 0;
            this.btnRemoveRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemoveRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRemove.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnRemoveRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRemove.Location = new System.Drawing.Point(141, 84);
            this.btnRemoveRemove.Name = "btnRemoveRemove";
            this.btnRemoveRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRemove.TabIndex = 37;
            this.btnRemoveRemove.Text = "Remove";
            this.btnRemoveRemove.UseVisualStyleBackColor = false;
            this.btnRemoveRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveCancel
            // 
            this.btnRemoveCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRemoveCancel.FlatAppearance.BorderSize = 0;
            this.btnRemoveCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemoveCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCancel.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnRemoveCancel.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCancel.Location = new System.Drawing.Point(141, 123);
            this.btnRemoveCancel.Name = "btnRemoveCancel";
            this.btnRemoveCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCancel.TabIndex = 38;
            this.btnRemoveCancel.Text = "Cancel";
            this.btnRemoveCancel.UseVisualStyleBackColor = false;
            this.btnRemoveCancel.Click += new System.EventHandler(this.btnRemoveCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Select the Stock ID of the item to be removed";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.cbStockIdRemove);
            this.panel1.Controls.Add(this.btnRemoveRemove);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRemoveCancel);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 165);
            this.panel1.TabIndex = 40;
            // 
            // cbStockIdRemove
            // 
            this.cbStockIdRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cbStockIdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStockIdRemove.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStockIdRemove.ForeColor = System.Drawing.Color.White;
            this.cbStockIdRemove.FormattingEnabled = true;
            this.cbStockIdRemove.Location = new System.Drawing.Point(121, 48);
            this.cbStockIdRemove.Name = "cbStockIdRemove";
            this.cbStockIdRemove.Size = new System.Drawing.Size(121, 23);
            this.cbStockIdRemove.TabIndex = 40;
            this.cbStockIdRemove.SelectedIndexChanged += new System.EventHandler(this.cbStockIdRemove_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(369, 177);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Remove Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnRemoveRemove;
        private System.Windows.Forms.Button btnRemoveCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cbStockIdRemove;
    }
}