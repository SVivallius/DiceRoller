namespace DiceRoller
{
    partial class How_many
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
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tbx_amount_Entered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(81, 77);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(82, 22);
            this.OK.TabIndex = 0;
            this.OK.Text = "Ok!";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(169, 77);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 22);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tbx_amount_Entered
            // 
            this.tbx_amount_Entered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_amount_Entered.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_amount_Entered.Location = new System.Drawing.Point(10, 41);
            this.tbx_amount_Entered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_amount_Entered.Name = "tbx_amount_Entered";
            this.tbx_amount_Entered.PlaceholderText = "0";
            this.tbx_amount_Entered.Size = new System.Drawing.Size(241, 32);
            this.tbx_amount_Entered.TabIndex = 2;
            this.tbx_amount_Entered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many to add\r\n(only supports numerics)";
            // 
            // How_many
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(262, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_amount_Entered);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(278, 143);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(278, 143);
            this.Name = "How_many";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "How much will this hurt?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.How_many_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OK;
        private Button cancel;
        private Label label1;
        internal TextBox tbx_amount_Entered;
    }
}