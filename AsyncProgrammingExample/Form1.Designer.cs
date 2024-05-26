namespace AsyncProgrammingExample
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
            Repeat_Tb = new TextBox();
            synchron_Bt = new Button();
            Async_Bt = new Button();
            Logger_Rtb = new RichTextBox();
            SuspendLayout();
            // 
            // Repeat_Tb
            // 
            Repeat_Tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Repeat_Tb.Location = new Point(220, 73);
            Repeat_Tb.Margin = new Padding(3, 2, 3, 2);
            Repeat_Tb.Name = "Repeat_Tb";
            Repeat_Tb.Size = new Size(82, 29);
            Repeat_Tb.TabIndex = 0;
            // 
            // synchron_Bt
            // 
            synchron_Bt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            synchron_Bt.Location = new Point(66, 67);
            synchron_Bt.Margin = new Padding(3, 2, 3, 2);
            synchron_Bt.Name = "synchron_Bt";
            synchron_Bt.Size = new Size(106, 37);
            synchron_Bt.TabIndex = 1;
            synchron_Bt.Text = "Synchron";
            synchron_Bt.UseVisualStyleBackColor = true;
            synchron_Bt.Click += synchron_Bt_Click;
            // 
            // Async_Bt
            // 
            Async_Bt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Async_Bt.Location = new Point(360, 68);
            Async_Bt.Margin = new Padding(3, 2, 3, 2);
            Async_Bt.Name = "Async_Bt";
            Async_Bt.Size = new Size(91, 35);
            Async_Bt.TabIndex = 2;
            Async_Bt.Text = "Async";
            Async_Bt.UseVisualStyleBackColor = true;
            Async_Bt.Click += Async_Bt_Click;
            // 
            // Logger_Rtb
            // 
            Logger_Rtb.Location = new Point(66, 124);
            Logger_Rtb.Margin = new Padding(3, 2, 3, 2);
            Logger_Rtb.Name = "Logger_Rtb";
            Logger_Rtb.Size = new Size(385, 91);
            Logger_Rtb.TabIndex = 3;
            Logger_Rtb.Text = "";
            Logger_Rtb.TextChanged += Logger_Rtb_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 237);
            Controls.Add(Logger_Rtb);
            Controls.Add(Async_Bt);
            Controls.Add(synchron_Bt);
            Controls.Add(Repeat_Tb);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Async & Await";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Repeat_Tb;
        private Button synchron_Bt;
        private Button Async_Bt;
        private RichTextBox Logger_Rtb;
    }
}