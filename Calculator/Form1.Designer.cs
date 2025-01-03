
namespace Calculator
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
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnMul = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSub = new Button();
            btnDiv = new Button();
            btnEqal = new Button();
            btnClearAll = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(286, 27);
            txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.AccessibleName = "";
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn1.Location = new Point(12, 69);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 68);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.AccessibleName = "";
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn6.Location = new Point(158, 143);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 68);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.AccessibleName = "";
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn5.Location = new Point(85, 143);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 68);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.AccessibleName = "";
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn4.Location = new Point(12, 143);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 68);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAdd.Location = new Point(231, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 68);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.AccessibleName = "";
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn3.Location = new Point(158, 69);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 68);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.AccessibleName = "";
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn2.Location = new Point(85, 69);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 68);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMul.Location = new Point(230, 217);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(67, 68);
            btnMul.TabIndex = 8;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.AccessibleName = "";
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn9.Location = new Point(157, 217);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 68);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.AccessibleName = "";
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn8.Location = new Point(85, 217);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 68);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.AccessibleName = "";
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn7.Location = new Point(12, 217);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 68);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSub.Location = new Point(231, 143);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(67, 68);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnNumber_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDiv.Location = new Point(231, 291);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(67, 68);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnNumber_Click;
            // 
            // btnEqal
            // 
            btnEqal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEqal.Location = new Point(12, 366);
            btnEqal.Name = "btnEqal";
            btnEqal.Size = new Size(212, 68);
            btnEqal.TabIndex = 16;
            btnEqal.Text = "=";
            btnEqal.UseVisualStyleBackColor = true;
            btnEqal.Click += btnEqal_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClearAll.Location = new Point(158, 292);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(67, 68);
            btnClearAll.TabIndex = 17;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btn0
            // 
            btn0.AccessibleName = "";
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn0.Location = new Point(85, 292);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 68);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDot.Location = new Point(12, 291);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(67, 68);
            btnDot.TabIndex = 19;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnNumber_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(230, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 68);
            btnClear.TabIndex = 20;
            btnClear.Text = "D";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 457);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnClearAll);
            Controls.Add(btnEqal);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMul);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnAdd);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
           throw new NotImplementedException();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btnMul;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnSub;
        private Button btnDiv;
        private Button btnEqal;
        private Button btnClearAll;
        private Button btn0;
        private Button btnDot;
        private Button btnClear;
    }
}
