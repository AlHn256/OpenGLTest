namespace TestWinForm
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
            RTB = new RichTextBox();
            button1 = new Button();
            FilePathTextBox = new TextBox();
            SuspendLayout();
            // 
            // RTB
            // 
            RTB.Font = new Font("Nina", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RTB.Location = new Point(12, 527);
            RTB.Name = "RTB";
            RTB.Size = new Size(804, 117);
            RTB.TabIndex = 0;
            RTB.Text = "Test Text Test Text Test Text Test Text";
            // 
            // button1
            // 
            button1.Location = new Point(379, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Location = new Point(12, 10);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(361, 23);
            FilePathTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 656);
            Controls.Add(FilePathTextBox);
            Controls.Add(button1);
            Controls.Add(RTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RTB;
        private Button button1;
        private TextBox FilePathTextBox;
    }
}
