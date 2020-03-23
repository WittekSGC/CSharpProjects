namespace WFA_Valetova
{
    partial class AlgPrimaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgPrimaForm));
            this.table = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findBTN = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pickRowCol = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickRowCol)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.ColumnHeadersVisible = false;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.table.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.table.Location = new System.Drawing.Point(177, 0);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(547, 486);
            this.table.TabIndex = 0;
            // 
            // col1
            // 
            this.col1.HeaderText = "1";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "2";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "3";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "4";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "5";
            this.col5.Name = "col5";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 258);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // findBTN
            // 
            this.findBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBTN.Location = new System.Drawing.Point(12, 12);
            this.findBTN.Name = "findBTN";
            this.findBTN.Size = new System.Drawing.Size(158, 33);
            this.findBTN.TabIndex = 2;
            this.findBTN.Text = "Вычислить";
            this.findBTN.UseVisualStyleBackColor = true;
            this.findBTN.Click += new System.EventHandler(this.findBTN_Click);
            // 
            // outBox
            // 
            this.outBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outBox.Location = new System.Drawing.Point(12, 51);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(158, 26);
            this.outBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Настройки таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Столбцы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Строки";
            // 
            // pickRowCol
            // 
            this.pickRowCol.Location = new System.Drawing.Point(88, 145);
            this.pickRowCol.Name = "pickRowCol";
            this.pickRowCol.Size = new System.Drawing.Size(83, 20);
            this.pickRowCol.TabIndex = 8;
            this.pickRowCol.ValueChanged += new System.EventHandler(this.pickCol_ValueChanged);
            // 
            // AlgPrimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 486);
            this.Controls.Add(this.pickRowCol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.findBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.table);
            this.MinimumSize = new System.Drawing.Size(740, 525);
            this.Name = "AlgPrimaForm";
            this.Text = "AlgPrimaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlgPrimaForm_FormClosing);
            this.Load += new System.EventHandler(this.AlgPrimaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickRowCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button findBTN;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pickRowCol;
    }
}