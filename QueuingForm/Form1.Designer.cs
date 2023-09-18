namespace QueuingForm
{
    partial class Form1
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
            btnCashier = new Button();
            QueuingForm = new Label();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.FromArgb(255, 192, 192);
            btnCashier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashier.Location = new Point(22, 47);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(110, 70);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            QueuingForm.AutoSize = true;
            QueuingForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            QueuingForm.Location = new Point(148, 33);
            QueuingForm.Name = "QueuingForm";
            QueuingForm.Size = new Size(188, 30);
            QueuingForm.TabIndex = 1;
            QueuingForm.Text = "Position in Queue";
            QueuingForm.Click += QueuingForm_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(162, 80);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(139, 37);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10007";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(393, 169);
            Controls.Add(lblQueue);
            Controls.Add(QueuingForm);
            Controls.Add(btnCashier);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label QueuingForm;
        private Label lblQueue;
    }
}