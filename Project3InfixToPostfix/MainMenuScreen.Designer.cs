namespace Project3InfixToPostfix
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputInfixDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutInfixToPoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infixLbl = new System.Windows.Forms.Label();
            this.postfixLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textboxsPanel = new System.Windows.Forms.Panel();
            this.generatePostfixBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainscreenButtons = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.textboxsPanel.SuspendLayout();
            this.mainscreenButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(782, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputInfixDataFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputInfixDataFileToolStripMenuItem
            // 
            this.inputInfixDataFileToolStripMenuItem.Name = "inputInfixDataFileToolStripMenuItem";
            this.inputInfixDataFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inputInfixDataFileToolStripMenuItem.Text = "Input Infix Data File";
            this.inputInfixDataFileToolStripMenuItem.Click += new System.EventHandler(this.inputInfixDataFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfixToPoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutInfixToPoToolStripMenuItem
            // 
            this.aboutInfixToPoToolStripMenuItem.Name = "aboutInfixToPoToolStripMenuItem";
            this.aboutInfixToPoToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.aboutInfixToPoToolStripMenuItem.Text = "About Infix to Postfix";
            this.aboutInfixToPoToolStripMenuItem.Click += new System.EventHandler(this.aboutInfixToPoToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(40, 20);
            this.textBox1.MinimumSize = new System.Drawing.Size(700, 250);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 250);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // infixLbl
            // 
            this.infixLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infixLbl.AutoSize = true;
            this.infixLbl.Location = new System.Drawing.Point(36, 288);
            this.infixLbl.Margin = new System.Windows.Forms.Padding(0);
            this.infixLbl.Name = "infixLbl";
            this.infixLbl.Size = new System.Drawing.Size(105, 17);
            this.infixLbl.TabIndex = 2;
            this.infixLbl.Text = "Infix Expression";
            this.infixLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // postfixLbl
            // 
            this.postfixLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postfixLbl.AutoSize = true;
            this.postfixLbl.Location = new System.Drawing.Point(36, 323);
            this.postfixLbl.Name = "postfixLbl";
            this.postfixLbl.Size = new System.Drawing.Size(122, 17);
            this.postfixLbl.TabIndex = 4;
            this.postfixLbl.Text = "Postfix Expression";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(201, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(539, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(201, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(539, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textboxsPanel
            // 
            this.textboxsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxsPanel.Controls.Add(this.textBox3);
            this.textboxsPanel.Controls.Add(this.textBox2);
            this.textboxsPanel.Controls.Add(this.postfixLbl);
            this.textboxsPanel.Controls.Add(this.infixLbl);
            this.textboxsPanel.Controls.Add(this.textBox1);
            this.textboxsPanel.Location = new System.Drawing.Point(0, 25);
            this.textboxsPanel.Name = "textboxsPanel";
            this.textboxsPanel.Size = new System.Drawing.Size(780, 360);
            this.textboxsPanel.TabIndex = 10;
            // 
            // generatePostfixBtn
            // 
            this.generatePostfixBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.generatePostfixBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generatePostfixBtn.Location = new System.Drawing.Point(40, 17);
            this.generatePostfixBtn.Name = "generatePostfixBtn";
            this.generatePostfixBtn.Size = new System.Drawing.Size(200, 30);
            this.generatePostfixBtn.TabIndex = 6;
            this.generatePostfixBtn.Text = "Generate Postfix";
            this.generatePostfixBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.Location = new System.Drawing.Point(290, 17);
            this.clearBtn.MinimumSize = new System.Drawing.Size(200, 30);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(200, 30);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitBtn.Location = new System.Drawing.Point(540, 17);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 30);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainscreenButtons
            // 
            this.mainscreenButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainscreenButtons.Controls.Add(this.exitBtn);
            this.mainscreenButtons.Controls.Add(this.clearBtn);
            this.mainscreenButtons.Controls.Add(this.generatePostfixBtn);
            this.mainscreenButtons.Location = new System.Drawing.Point(0, 385);
            this.mainscreenButtons.MinimumSize = new System.Drawing.Size(780, 65);
            this.mainscreenButtons.Name = "mainscreenButtons";
            this.mainscreenButtons.Size = new System.Drawing.Size(780, 65);
            this.mainscreenButtons.TabIndex = 9;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.mainscreenButtons);
            this.Controls.Add(this.textboxsPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainScreen";
            this.Text = "Project 3 - Infix to Postfix, Catherine Kilpatrick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.textboxsPanel.ResumeLayout(false);
            this.textboxsPanel.PerformLayout();
            this.mainscreenButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputInfixDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutInfixToPoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label infixLbl;
        private System.Windows.Forms.Label postfixLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel textboxsPanel;
        private System.Windows.Forms.Button generatePostfixBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel mainscreenButtons;
    }
}

