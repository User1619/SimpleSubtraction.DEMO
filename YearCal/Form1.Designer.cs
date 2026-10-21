namespace YearCal
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
            btnResult = new Button();
            lblFnum = new Label();
            label2 = new Label();
            txtFirstNum = new TextBox();
            txtSecondNum = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            label3 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnResult
            // 
            btnResult.Location = new Point(186, 350);
            btnResult.Margin = new Padding(3, 4, 3, 4);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(137, 68);
            btnResult.TabIndex = 0;
            btnResult.Text = "CHECK RESULT: ";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // lblFnum
            // 
            lblFnum.AutoSize = true;
            lblFnum.Location = new Point(132, 108);
            lblFnum.Name = "lblFnum";
            lblFnum.Size = new Size(93, 20);
            lblFnum.TabIndex = 1;
            lblFnum.Text = "First Number: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 184);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Second Number: ";
            // 
            // txtFirstNum
            // 
            txtFirstNum.BackColor = SystemColors.GrayText;
            txtFirstNum.BorderStyle = BorderStyle.FixedSingle;
            txtFirstNum.Location = new Point(132, 131);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(263, 26);
            txtFirstNum.TabIndex = 3;
            txtFirstNum.KeyPress += txtFirstNum_KeyPress;
            // 
            // txtSecondNum
            // 
            txtSecondNum.BackColor = SystemColors.GrayText;
            txtSecondNum.BorderStyle = BorderStyle.FixedSingle;
            txtSecondNum.Location = new Point(132, 207);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(263, 26);
            txtSecondNum.TabIndex = 4;
            txtSecondNum.KeyPress += txtSecondNum_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(229, 290);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(18, 19);
            lblResult.TabIndex = 5;
            lblResult.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 289);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "Result:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(202, 32);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 7;
            label3.Text = "Subtraction";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(363, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 52);
            btnClear.TabIndex = 8;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 539);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(txtSecondNum);
            Controls.Add(txtFirstNum);
            Controls.Add(label2);
            Controls.Add(lblFnum);
            Controls.Add(btnResult);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResult;
        private Label lblFnum;
        private Label label2;
        private TextBox txtFirstNum;
        private TextBox txtSecondNum;
        private Label lblResult;
        private Label label1;
        private Label label3;
        private Button btnClear;
    }
}
