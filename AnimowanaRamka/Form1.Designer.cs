namespace RamkaAnimowana
{
    partial class Form1
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
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboGradColor1 = new System.Windows.Forms.ComboBox();
            this.comboGradColor2 = new System.Windows.Forms.ComboBox();
            this.comboAnimDirection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBtn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChgText = new System.Windows.Forms.Button();
            this.btnShape = new ButtonShape.ButtonShape();
            this.SuspendLayout();
            // 
            // comboFont
            // 
            this.comboFont.AutoCompleteCustomSource.AddRange(new string[] {
            "Arial",
            "Calibri",
            "Comic Sans",
            "Roboto",
            "Times New Roman"});
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Comic Sans",
            "Roboto",
            "Times New Roman"});
            this.comboFont.Location = new System.Drawing.Point(81, 277);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(121, 21);
            this.comboFont.TabIndex = 3;
            this.comboFont.SelectedIndexChanged += new System.EventHandler(this.comboFont_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Elipsa",
            "Koło",
            "Kwadrat",
            "Prostokąt"});
            this.comboBox1.Location = new System.Drawing.Point(226, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboGradColor1
            // 
            this.comboGradColor1.FormattingEnabled = true;
            this.comboGradColor1.Items.AddRange(new object[] {
            "beżowy",
            "biały",
            "czarny",
            "czerwony",
            "niebieski",
            "pomarańczowy",
            "różowy",
            "zielony",
            "żółty"});
            this.comboGradColor1.Location = new System.Drawing.Point(81, 327);
            this.comboGradColor1.Name = "comboGradColor1";
            this.comboGradColor1.Size = new System.Drawing.Size(121, 21);
            this.comboGradColor1.TabIndex = 5;
            this.comboGradColor1.SelectedIndexChanged += new System.EventHandler(this.comboGradColor1_SelectedIndexChanged);
            // 
            // comboGradColor2
            // 
            this.comboGradColor2.FormattingEnabled = true;
            this.comboGradColor2.Items.AddRange(new object[] {
            "beżowy",
            "biały",
            "czarny",
            "czerwony",
            "niebieski",
            "pomarańczowy",
            "różowy",
            "zielony",
            "żółty"});
            this.comboGradColor2.Location = new System.Drawing.Point(226, 327);
            this.comboGradColor2.Name = "comboGradColor2";
            this.comboGradColor2.Size = new System.Drawing.Size(121, 21);
            this.comboGradColor2.TabIndex = 6;
            this.comboGradColor2.SelectedIndexChanged += new System.EventHandler(this.comboGradColor2_SelectedIndexChanged);
            // 
            // comboAnimDirection
            // 
            this.comboAnimDirection.FormattingEnabled = true;
            this.comboAnimDirection.Items.AddRange(new object[] {
            "Prawo",
            "Lewo"});
            this.comboAnimDirection.Location = new System.Drawing.Point(81, 376);
            this.comboAnimDirection.Name = "comboAnimDirection";
            this.comboAnimDirection.Size = new System.Drawing.Size(121, 21);
            this.comboAnimDirection.TabIndex = 7;
            this.comboAnimDirection.SelectedIndexChanged += new System.EventHandler(this.comboAnimDirection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FONT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "KSZTAŁT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "RAMKA: KOLOR #1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RAMKA: KOLOR #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "KIERUNEK ANIMACJI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Podgląd na przycisk";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBtn
            // 
            this.textBtn.Location = new System.Drawing.Point(80, 214);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(200, 20);
            this.textBtn.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "TEKST DO WYŚWIETLENIA";
            // 
            // btnChgText
            // 
            this.btnChgText.Location = new System.Drawing.Point(291, 212);
            this.btnChgText.Name = "btnChgText";
            this.btnChgText.Size = new System.Drawing.Size(56, 23);
            this.btnChgText.TabIndex = 16;
            this.btnChgText.Text = "Zapisz";
            this.btnChgText.UseVisualStyleBackColor = true;
            this.btnChgText.Click += new System.EventHandler(this.btnChgText_Click);
            // 
            // btnShape
            // 
            this.btnShape.Angle = 0F;
            this.btnShape.AnimDirection = 0;
            this.btnShape.BorderColor1 = System.Drawing.Color.White;
            this.btnShape.BorderColor2 = System.Drawing.Color.White;
            this.btnShape.BorderThickness = 2F;
            this.btnShape.BtnFont = null;
            this.btnShape.BtnShape = null;
            this.btnShape.BtnText = null;
            this.btnShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShape.Location = new System.Drawing.Point(83, 73);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(265, 84);
            this.btnShape.TabIndex = 17;
            this.btnShape.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 424);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.btnChgText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAnimDirection);
            this.Controls.Add(this.comboGradColor2);
            this.Controls.Add(this.comboGradColor1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonShape.ButtonShape buttonShape1;
        private System.Windows.Forms.ComboBox comboFont;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboGradColor1;
        private System.Windows.Forms.ComboBox comboGradColor2;
        private System.Windows.Forms.ComboBox comboAnimDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChgText;
        private ButtonShape.ButtonShape btnShape;
    }
}

