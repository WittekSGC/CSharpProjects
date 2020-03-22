namespace WFA_Valetova
{
    partial class TheoryShowingForm
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
            this.picker = new System.Windows.Forms.ComboBox();
            this.theoryText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // picker
            // 
            this.picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.picker.FormattingEnabled = true;
            this.picker.Items.AddRange(new object[] {
            "Сборки",
            "Библиотеки",
            "Атрибуты",
            "Директивы"});
            this.picker.Location = new System.Drawing.Point(12, 12);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(235, 33);
            this.picker.TabIndex = 0;
            this.picker.SelectedIndexChanged += new System.EventHandler(this.picker_SelectedIndexChanged);
            // 
            // theoryText
            // 
            this.theoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryText.Location = new System.Drawing.Point(12, 51);
            this.theoryText.Multiline = true;
            this.theoryText.Name = "theoryText";
            this.theoryText.Size = new System.Drawing.Size(870, 495);
            this.theoryText.TabIndex = 1;
            this.theoryText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TheoryShowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 574);
            this.Controls.Add(this.theoryText);
            this.Controls.Add(this.picker);
            this.Name = "TheoryShowingForm";
            this.Text = "TheoryShowingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheoryShowingForm_FormClosing);
            this.Load += new System.EventHandler(this.TheoryShowingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox picker;
        private System.Windows.Forms.TextBox theoryText;
    }
}