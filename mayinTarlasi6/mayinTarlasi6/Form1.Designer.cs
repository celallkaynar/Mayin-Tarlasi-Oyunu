namespace mayinTarlasi6
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            labelSkor = new Label();
            label2 = new Label();
            labelCan = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(683, 12);
            button1.Name = "button1";
            button1.Size = new Size(146, 63);
            button1.TabIndex = 0;
            button1.Tag = "false";
            button1.Text = "Oyuna Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(606, 383);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(683, 125);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 2;
            label1.Text = "Skor:";
            // 
            // labelSkor
            // 
            labelSkor.AutoSize = true;
            labelSkor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSkor.Location = new Point(745, 125);
            labelSkor.Name = "labelSkor";
            labelSkor.Size = new Size(24, 28);
            labelSkor.TabIndex = 3;
            labelSkor.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(683, 174);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 4;
            label2.Text = "Can:";
            // 
            // labelCan
            // 
            labelCan.AutoSize = true;
            labelCan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCan.Location = new Point(745, 174);
            labelCan.Name = "labelCan";
            labelCan.Size = new Size(24, 28);
            labelCan.TabIndex = 5;
            labelCan.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(labelCan);
            Controls.Add(label2);
            Controls.Add(labelSkor);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label labelSkor;
        private Label label2;
        private Label labelCan;
    }
}