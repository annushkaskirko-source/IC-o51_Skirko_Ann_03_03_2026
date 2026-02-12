namespace IC_o51_Skirko_Ann_08_02_2026
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
            this.questTextBox = new System.Windows.Forms.TextBox();
            this.addQuestButton = new System.Windows.Forms.Button();
            this.questListBox = new System.Windows.Forms.ListBox();
            this.completeQuestButton = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.xpLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.xpProgressBar = new System.Windows.Forms.ProgressBar();
            this.list = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questTextBox
            // 
            this.questTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questTextBox.Location = new System.Drawing.Point(70, 47);
            this.questTextBox.Name = "questTextBox";
            this.questTextBox.Size = new System.Drawing.Size(390, 30);
            this.questTextBox.TabIndex = 0;
            this.questTextBox.Text = "Введіть квест...";
            // 
            // addQuestButton
            // 
            this.addQuestButton.BackColor = System.Drawing.Color.Wheat;
            this.addQuestButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestButton.Location = new System.Drawing.Point(512, 47);
            this.addQuestButton.Name = "addQuestButton";
            this.addQuestButton.Size = new System.Drawing.Size(162, 88);
            this.addQuestButton.TabIndex = 1;
            this.addQuestButton.Text = "Додати квест";
            this.addQuestButton.UseVisualStyleBackColor = false;
            this.addQuestButton.Click += new System.EventHandler(this.addQuestButton_Click);
            // 
            // questListBox
            // 
            this.questListBox.BackColor = System.Drawing.SystemColors.Window;
            this.questListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questListBox.FormattingEnabled = true;
            this.questListBox.ItemHeight = 22;
            this.questListBox.Location = new System.Drawing.Point(70, 229);
            this.questListBox.Name = "questListBox";
            this.questListBox.Size = new System.Drawing.Size(390, 224);
            this.questListBox.TabIndex = 2;
            // 
            // completeQuestButton
            // 
            this.completeQuestButton.BackColor = System.Drawing.Color.Wheat;
            this.completeQuestButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeQuestButton.Location = new System.Drawing.Point(512, 229);
            this.completeQuestButton.Name = "completeQuestButton";
            this.completeQuestButton.Size = new System.Drawing.Size(162, 88);
            this.completeQuestButton.TabIndex = 3;
            this.completeQuestButton.Text = "Виконати квест";
            this.completeQuestButton.UseVisualStyleBackColor = false;
            this.completeQuestButton.Click += new System.EventHandler(this.completeQuestButton_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Wheat;
            this.levelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLabel.Location = new System.Drawing.Point(66, 516);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(86, 22);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Рівень: 1";
            // 
            // xpLabel
            // 
            this.xpLabel.AutoSize = true;
            this.xpLabel.BackColor = System.Drawing.Color.Wheat;
            this.xpLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xpLabel.Location = new System.Drawing.Point(66, 574);
            this.xpLabel.Name = "xpLabel";
            this.xpLabel.Size = new System.Drawing.Size(56, 22);
            this.xpLabel.TabIndex = 5;
            this.xpLabel.Text = "XP: 0";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(70, 105);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(163, 30);
            this.categoryComboBox.TabIndex = 6;
            this.categoryComboBox.Text = "Категорія";
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Location = new System.Drawing.Point(297, 105);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(163, 30);
            this.difficultyComboBox.TabIndex = 7;
            this.difficultyComboBox.Text = "Складність";
            // 
            // xpProgressBar
            // 
            this.xpProgressBar.Location = new System.Drawing.Point(200, 516);
            this.xpProgressBar.Name = "xpProgressBar";
            this.xpProgressBar.Size = new System.Drawing.Size(474, 80);
            this.xpProgressBar.TabIndex = 8;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.BackColor = System.Drawing.Color.Wheat;
            this.list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.Location = new System.Drawing.Point(66, 170);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(140, 22);
            this.list.TabIndex = 9;
            this.list.Text = "Список квестів";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(735, 631);
            this.Controls.Add(this.list);
            this.Controls.Add(this.xpProgressBar);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.xpLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.completeQuestButton);
            this.Controls.Add(this.questListBox);
            this.Controls.Add(this.addQuestButton);
            this.Controls.Add(this.questTextBox);
            this.Name = "Form1";
            this.Text = "LifeRPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questTextBox;
        private System.Windows.Forms.Button addQuestButton;
        private System.Windows.Forms.ListBox questListBox;
        private System.Windows.Forms.Button completeQuestButton;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label xpLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.ProgressBar xpProgressBar;
        private System.Windows.Forms.Label list;
    }
}

