namespace AnimowanaRamka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.btnMain = new AnimowanaRamka.ButtonShape();
            this.label3 = new System.Windows.Forms.Label();
            this.textBtn = new System.Windows.Forms.TextBox();
            this.btnChgText = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Name = "label2";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboColor
            // 
            resources.ApplyResources(this.comboColor, "comboColor");
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            resources.GetString("comboColor.Items"),
            resources.GetString("comboColor.Items1"),
            resources.GetString("comboColor.Items2"),
            resources.GetString("comboColor.Items3"),
            resources.GetString("comboColor.Items4"),
            resources.GetString("comboColor.Items5")});
            this.comboColor.Name = "comboColor";
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.White;
            this.btnMain.BorderThickness = 5F;
            this.btnMain.BtnColor = null;
            this.btnMain.BtnFont = null;
            this.btnMain.BtnShape = null;
            this.btnMain.BtnText = null;
            resources.ApplyResources(this.btnMain, "btnMain");
            this.btnMain.Name = "btnMain";
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // textBtn
            // 
            resources.ApplyResources(this.textBtn, "textBtn");
            this.textBtn.Name = "textBtn";
            // 
            // btnChgText
            // 
            resources.ApplyResources(this.btnChgText, "btnChgText");
            this.btnChgText.Name = "btnChgText";
            this.btnChgText.UseVisualStyleBackColor = true;
            this.btnChgText.Click += new System.EventHandler(this.btnChgText_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Name = "label5";
            // 
            // comboFont
            // 
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Items.AddRange(new object[] {
            resources.GetString("comboFont.Items"),
            resources.GetString("comboFont.Items1"),
            resources.GetString("comboFont.Items2"),
            resources.GetString("comboFont.Items3"),
            resources.GetString("comboFont.Items4")});
            resources.ApplyResources(this.comboFont, "comboFont");
            this.comboFont.Name = "comboFont";
            this.comboFont.SelectedIndexChanged += new System.EventHandler(this.comboFont_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChgText);
            this.Controls.Add(this.textBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.comboColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboColor;
        private ButtonShape btnMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBtn;
        private System.Windows.Forms.Button btnChgText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboFont;
    }
}

