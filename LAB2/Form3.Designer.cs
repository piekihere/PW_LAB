namespace LAB2
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.partialPriceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(68, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // partialPriceLabel
            // 
            this.partialPriceLabel.AutoSize = true;
            this.partialPriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.partialPriceLabel.Location = new System.Drawing.Point(119, 150);
            this.partialPriceLabel.Name = "partialPriceLabel";
            this.partialPriceLabel.Size = new System.Drawing.Size(13, 15);
            this.partialPriceLabel.TabIndex = 2;
            this.partialPriceLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zastosuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partialPriceLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label partialPriceLabel;
        private Button button1;
        private int partialPrice = 0;
        private Dictionary<int, int> comboBox1Map = new Dictionary<int, int>();
        private int formerComboBox1 = 3;
        private Dictionary<int, int> comboBox2Map = new Dictionary<int, int>();
        private int formerComboBox2 = 3;
    }
}