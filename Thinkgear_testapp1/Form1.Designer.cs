namespace Thinkgear_testapp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAttention = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.pbAttention = new System.Windows.Forms.ProgressBar();
            this.pbMeditation = new System.Windows.Forms.ProgressBar();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableBlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableBlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbSignal = new System.Windows.Forms.ProgressBar();
            this.lblSignal = new System.Windows.Forms.Label();
            this.nudAttWanted = new System.Windows.Forms.NumericUpDown();
            this.lblAttWanted = new System.Windows.Forms.Label();
            this.nudMeditWanted = new System.Windows.Forms.NumericUpDown();
            this.lblMeditWanted = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.piMedit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.piB1 = new System.Windows.Forms.PictureBox();
            this.piB_Ball = new System.Windows.Forms.PictureBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_maxheight = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttWanted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeditWanted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piMedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Font = new System.Drawing.Font("NI7SEG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttention.ForeColor = System.Drawing.Color.Red;
            this.lblAttention.Location = new System.Drawing.Point(291, 53);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(107, 15);
            this.lblAttention.TabIndex = 0;
            this.lblAttention.Text = "Attention";
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.Font = new System.Drawing.Font("NI7SEG", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(91, 43);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(175, 20);
            this.cboPort.TabIndex = 0;
            // 
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.Font = new System.Drawing.Font("NI7SEG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeditation.ForeColor = System.Drawing.Color.Blue;
            this.lblMeditation.Location = new System.Drawing.Point(639, 53);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(111, 15);
            this.lblMeditation.TabIndex = 1;
            this.lblMeditation.Text = "Meditation";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(12, 95);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(251, 296);
            this.txtState.TabIndex = 7;
            // 
            // pbAttention
            // 
            this.pbAttention.Location = new System.Drawing.Point(439, 49);
            this.pbAttention.Name = "pbAttention";
            this.pbAttention.Size = new System.Drawing.Size(190, 23);
            this.pbAttention.TabIndex = 13;
            // 
            // pbMeditation
            // 
            this.pbMeditation.BackColor = System.Drawing.SystemColors.Control;
            this.pbMeditation.Location = new System.Drawing.Point(789, 49);
            this.pbMeditation.Name = "pbMeditation";
            this.pbMeditation.Size = new System.Drawing.Size(190, 23);
            this.pbMeditation.TabIndex = 14;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1228, 24);
            this.menuStrip3.TabIndex = 18;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableBlinkToolStripMenuItem,
            this.disableBlinkToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // enableBlinkToolStripMenuItem
            // 
            this.enableBlinkToolStripMenuItem.Name = "enableBlinkToolStripMenuItem";
            this.enableBlinkToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.enableBlinkToolStripMenuItem.Text = "Enable Blink";
            this.enableBlinkToolStripMenuItem.Click += new System.EventHandler(this.enableBlinkToolStripMenuItem_Click);
            // 
            // disableBlinkToolStripMenuItem
            // 
            this.disableBlinkToolStripMenuItem.Name = "disableBlinkToolStripMenuItem";
            this.disableBlinkToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.disableBlinkToolStripMenuItem.Text = "Disable Blink";
            this.disableBlinkToolStripMenuItem.Click += new System.EventHandler(this.disableBlinkToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NI7SEG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose PORT then click Connection->Connect";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(12, 45);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(73, 18);
            this.lblPort.TabIndex = 20;
            this.lblPort.Text = "PORT :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(319, 273);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 191);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pbSignal
            // 
            this.pbSignal.Location = new System.Drawing.Point(1155, 24);
            this.pbSignal.Maximum = 4;
            this.pbSignal.Name = "pbSignal";
            this.pbSignal.Size = new System.Drawing.Size(67, 23);
            this.pbSignal.TabIndex = 22;
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Font = new System.Drawing.Font("NI7SEG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignal.Location = new System.Drawing.Point(1036, 27);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(79, 15);
            this.lblSignal.TabIndex = 23;
            this.lblSignal.Text = "Signal :";
            // 
            // nudAttWanted
            // 
            this.nudAttWanted.AutoSize = true;
            this.nudAttWanted.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAttWanted.ForeColor = System.Drawing.Color.Red;
            this.nudAttWanted.Location = new System.Drawing.Point(844, 358);
            this.nudAttWanted.Name = "nudAttWanted";
            this.nudAttWanted.Size = new System.Drawing.Size(66, 27);
            this.nudAttWanted.TabIndex = 24;
            this.nudAttWanted.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudAttWanted.ValueChanged += new System.EventHandler(this.nudAttWanted_ValueChanged);
            // 
            // lblAttWanted
            // 
            this.lblAttWanted.AutoSize = true;
            this.lblAttWanted.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttWanted.ForeColor = System.Drawing.Color.Red;
            this.lblAttWanted.Location = new System.Drawing.Point(622, 363);
            this.lblAttWanted.Name = "lblAttWanted";
            this.lblAttWanted.Size = new System.Drawing.Size(213, 18);
            this.lblAttWanted.TabIndex = 25;
            this.lblAttWanted.Text = "Attention Wanted";
            // 
            // nudMeditWanted
            // 
            this.nudMeditWanted.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMeditWanted.ForeColor = System.Drawing.Color.Blue;
            this.nudMeditWanted.Location = new System.Drawing.Point(845, 391);
            this.nudMeditWanted.Name = "nudMeditWanted";
            this.nudMeditWanted.Size = new System.Drawing.Size(66, 27);
            this.nudMeditWanted.TabIndex = 26;
            this.nudMeditWanted.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudMeditWanted.ValueChanged += new System.EventHandler(this.nudMeditWanted_ValueChanged);
            // 
            // lblMeditWanted
            // 
            this.lblMeditWanted.AutoSize = true;
            this.lblMeditWanted.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeditWanted.ForeColor = System.Drawing.Color.Blue;
            this.lblMeditWanted.Location = new System.Drawing.Point(622, 393);
            this.lblMeditWanted.Name = "lblMeditWanted";
            this.lblMeditWanted.Size = new System.Drawing.Size(218, 18);
            this.lblMeditWanted.TabIndex = 27;
            this.lblMeditWanted.Text = "Meditation Wanted";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(78, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 37);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // piMedit
            // 
            this.piMedit.BackgroundImage = global::Thinkgear_testapp1.Properties.Resources.Meditation;
            this.piMedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.piMedit.Location = new System.Drawing.Point(625, 82);
            this.piMedit.Name = "piMedit";
            this.piMedit.Size = new System.Drawing.Size(343, 271);
            this.piMedit.TabIndex = 11;
            this.piMedit.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Thinkgear_testapp1.Properties.Resources.keriyo_emoticons_18;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(453, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 153);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // piB1
            // 
            this.piB1.BackgroundImage = global::Thinkgear_testapp1.Properties.Resources._35;
            this.piB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.piB1.Location = new System.Drawing.Point(288, 82);
            this.piB1.Name = "piB1";
            this.piB1.Size = new System.Drawing.Size(165, 153);
            this.piB1.TabIndex = 9;
            this.piB1.TabStop = false;
            // 
            // piB_Ball
            // 
            this.piB_Ball.Image = global::Thinkgear_testapp1.Properties.Resources.ball;
            this.piB_Ball.Location = new System.Drawing.Point(1014, 473);
            this.piB_Ball.Name = "piB_Ball";
            this.piB_Ball.Size = new System.Drawing.Size(123, 114);
            this.piB_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piB_Ball.TabIndex = 29;
            this.piB_Ball.TabStop = false;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.Location = new System.Drawing.Point(830, 473);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(22, 18);
            this.lbl_Height.TabIndex = 30;
            this.lbl_Height.Text = "0";
            // 
            // lbl_maxheight
            // 
            this.lbl_maxheight.AutoSize = true;
            this.lbl_maxheight.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxheight.Location = new System.Drawing.Point(830, 504);
            this.lbl_maxheight.Name = "lbl_maxheight";
            this.lbl_maxheight.Size = new System.Drawing.Size(22, 18);
            this.lbl_maxheight.TabIndex = 31;
            this.lbl_maxheight.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Actual Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NI7SEG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Max Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 599);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_maxheight);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.piB_Ball);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMeditWanted);
            this.Controls.Add(this.nudMeditWanted);
            this.Controls.Add(this.lblAttWanted);
            this.Controls.Add(this.nudAttWanted);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.pbSignal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMeditation);
            this.Controls.Add(this.pbAttention);
            this.Controls.Add(this.piMedit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.lblMeditation);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.piB1);
            this.Controls.Add(this.menuStrip3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Thinkgear :) beta2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttWanted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeditWanted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piMedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label lblMeditation;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.PictureBox piB1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbAttention;
        private System.Windows.Forms.ProgressBar pbMeditation;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableBlinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableBlinkToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piMedit;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar pbSignal;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.NumericUpDown nudAttWanted;
        private System.Windows.Forms.Label lblAttWanted;
        private System.Windows.Forms.NumericUpDown nudMeditWanted;
        private System.Windows.Forms.Label lblMeditWanted;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox piB_Ball;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_maxheight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

