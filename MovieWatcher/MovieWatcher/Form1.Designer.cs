namespace MovieWatcher
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(281, 20);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 0;
            label1.Text = "Movie Manager";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(49, 187);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 2;
            label2.Text = "Movie to search for :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(49, 234);
            label3.Name = "label3";
            label3.Size = new Size(351, 15);
            label3.TabIndex = 3;
            label3.Text = "Pro Tip: Write only parts of the movie name to find it more easily!";
            // 
            // button1
            // 
            button1.Location = new Point(610, 378);
            button1.Name = "button1";
            button1.Size = new Size(156, 47);
            button1.TabIndex = 4;
            button1.Text = "Search!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 13F);
            radioButton1.Location = new Point(541, 154);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "is an anime";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 13F);
            radioButton2.Location = new Point(541, 201);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(134, 29);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "not an anime";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
