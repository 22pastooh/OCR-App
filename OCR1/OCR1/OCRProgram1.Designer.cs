namespace OCR1
{
    partial class OCRProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRProgram));
            PerformOCR = new Button();
            richTextBox1 = new RichTextBox();
            SavePath = new Button();
            ClearPath = new Button();
            SuspendLayout();
            // 
            // PerformOCR
            // 
            PerformOCR.Location = new System.Drawing.Point(345, 75);
            PerformOCR.Name = "PerformOCR";
            PerformOCR.Size = new System.Drawing.Size(75, 23);
            PerformOCR.TabIndex = 0;
            PerformOCR.Text = "OCR";
            PerformOCR.UseVisualStyleBackColor = true;
            PerformOCR.Click += PerformOCR_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(120, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(300, 30);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // SavePath
            // 
            SavePath.Location = new System.Drawing.Point(120, 75);
            SavePath.Name = "SavePath";
            SavePath.Size = new System.Drawing.Size(75, 23);
            SavePath.TabIndex = 3;
            SavePath.Text = "Save Path";
            SavePath.UseVisualStyleBackColor = true;
            SavePath.Click += SavePath_Click;
            // 
            // ClearPath
            // 
            ClearPath.Location = new System.Drawing.Point(120, 104);
            ClearPath.Name = "ClearPath";
            ClearPath.Size = new System.Drawing.Size(75, 23);
            ClearPath.TabIndex = 4;
            ClearPath.Text = "Clear Path";
            ClearPath.UseVisualStyleBackColor = true;
            ClearPath.Click += ClearPath_Click;
            // 
            // OCRProgram
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(524, 293);
            Controls.Add(ClearPath);
            Controls.Add(SavePath);
            Controls.Add(richTextBox1);
            Controls.Add(PerformOCR);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OCRProgram";
            ShowIcon = false;
            Text = "OCR";
            ResumeLayout(false);
        }


        #endregion

        private Button PerformOCR;
        private RichTextBox richTextBox1;
        private Button SavePath;
        private Button ClearPath;
    }
}