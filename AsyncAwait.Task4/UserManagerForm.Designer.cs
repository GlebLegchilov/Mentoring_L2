namespace AsyncAwait.Task4
{
    partial class UserManagerForm
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
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.userNameInfoTitleLabel = new System.Windows.Forms.Label();
            this.userInfoTitleLabel = new System.Windows.Forms.Label();
            this.userListTitleLabel = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userAgeInfoTitleLabel = new System.Windows.Forms.Label();
            this.userSecondNameInfoTitleLabel = new System.Windows.Forms.Label();
            this.userNameAddTextBox = new System.Windows.Forms.TextBox();
            this.userAgeAddTextBox = new System.Windows.Forms.TextBox();
            this.userSecondNameAddTextBox = new System.Windows.Forms.TextBox();
            this.userNameInfoTextBox = new System.Windows.Forms.TextBox();
            this.userSecondNameInfoTextBox = new System.Windows.Forms.TextBox();
            this.userAgeInfoTextBox = new System.Windows.Forms.TextBox();
            this.userNameAddLabel = new System.Windows.Forms.Label();
            this.userAgeAddLabel = new System.Windows.Forms.Label();
            this.userSecondNameAddLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(60, 238);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(324, 199);
            this.usersListBox.TabIndex = 31;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // userNameInfoTitleLabel
            // 
            this.userNameInfoTitleLabel.AutoSize = true;
            this.userNameInfoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInfoTitleLabel.Location = new System.Drawing.Point(476, 274);
            this.userNameInfoTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameInfoTitleLabel.Name = "userNameInfoTitleLabel";
            this.userNameInfoTitleLabel.Size = new System.Drawing.Size(71, 26);
            this.userNameInfoTitleLabel.TabIndex = 29;
            this.userNameInfoTitleLabel.Text = "Name";
            // 
            // userInfoTitleLabel
            // 
            this.userInfoTitleLabel.AutoSize = true;
            this.userInfoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoTitleLabel.Location = new System.Drawing.Point(531, 199);
            this.userInfoTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userInfoTitleLabel.Name = "userInfoTitleLabel";
            this.userInfoTitleLabel.Size = new System.Drawing.Size(99, 26);
            this.userInfoTitleLabel.TabIndex = 28;
            this.userInfoTitleLabel.Text = "User info";
            // 
            // userListTitleLabel
            // 
            this.userListTitleLabel.AutoSize = true;
            this.userListTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListTitleLabel.Location = new System.Drawing.Point(155, 199);
            this.userListTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userListTitleLabel.Name = "userListTitleLabel";
            this.userListTitleLabel.Size = new System.Drawing.Size(102, 26);
            this.userListTitleLabel.TabIndex = 27;
            this.userListTitleLabel.Text = "Users list";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Enabled = false;
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.Location = new System.Drawing.Point(592, 423);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(90, 30);
            this.deleteUserButton.TabIndex = 26;
            this.deleteUserButton.Text = "Delete user";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(71, 30);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 26);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "Task 4";
            // 
            // editUserButton
            // 
            this.editUserButton.Enabled = false;
            this.editUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserButton.Location = new System.Drawing.Point(488, 423);
            this.editUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(90, 30);
            this.editUserButton.TabIndex = 24;
            this.editUserButton.Text = "Edit user";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(47, 66);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(337, 52);
            this.descriptionLabel.TabIndex = 23;
            this.descriptionLabel.Text = "   У вас есть Entity, которое описывает класс пользователя,\r\nхранящийся в БД. Пол" +
    "ьзователь хранит информацию об Имени,\r\nФамилии, Возрасте. Напишите пример асинхр" +
    "онных CRUD\r\nопераций для этого класса.";
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(310, 482);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(74, 29);
            this.addUserButton.TabIndex = 32;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userAgeInfoTitleLabel
            // 
            this.userAgeInfoTitleLabel.AutoSize = true;
            this.userAgeInfoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAgeInfoTitleLabel.Location = new System.Drawing.Point(476, 366);
            this.userAgeInfoTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userAgeInfoTitleLabel.Name = "userAgeInfoTitleLabel";
            this.userAgeInfoTitleLabel.Size = new System.Drawing.Size(51, 26);
            this.userAgeInfoTitleLabel.TabIndex = 33;
            this.userAgeInfoTitleLabel.Text = "Age";
            // 
            // userSecondNameInfoTitleLabel
            // 
            this.userSecondNameInfoTitleLabel.AutoSize = true;
            this.userSecondNameInfoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSecondNameInfoTitleLabel.Location = new System.Drawing.Point(476, 321);
            this.userSecondNameInfoTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userSecondNameInfoTitleLabel.Name = "userSecondNameInfoTitleLabel";
            this.userSecondNameInfoTitleLabel.Size = new System.Drawing.Size(147, 26);
            this.userSecondNameInfoTitleLabel.TabIndex = 35;
            this.userSecondNameInfoTitleLabel.Text = "Second name";
            // 
            // userNameAddTextBox
            // 
            this.userNameAddTextBox.Location = new System.Drawing.Point(61, 491);
            this.userNameAddTextBox.Name = "userNameAddTextBox";
            this.userNameAddTextBox.Size = new System.Drawing.Size(74, 20);
            this.userNameAddTextBox.TabIndex = 37;
            this.userNameAddTextBox.TextChanged += new System.EventHandler(this.userNameAddTextBox_TextChanged);
            // 
            // userAgeAddTextBox
            // 
            this.userAgeAddTextBox.Location = new System.Drawing.Point(221, 491);
            this.userAgeAddTextBox.Name = "userAgeAddTextBox";
            this.userAgeAddTextBox.Size = new System.Drawing.Size(74, 20);
            this.userAgeAddTextBox.TabIndex = 38;
            this.userAgeAddTextBox.TextChanged += new System.EventHandler(this.userAgeAddTextBox_TextChanged);
            // 
            // userSecondNameAddTextBox
            // 
            this.userSecondNameAddTextBox.Location = new System.Drawing.Point(141, 491);
            this.userSecondNameAddTextBox.Name = "userSecondNameAddTextBox";
            this.userSecondNameAddTextBox.Size = new System.Drawing.Size(74, 20);
            this.userSecondNameAddTextBox.TabIndex = 39;
            this.userSecondNameAddTextBox.TextChanged += new System.EventHandler(this.userSecondNameAddTextBox_TextChanged);
            // 
            // userNameInfoTextBox
            // 
            this.userNameInfoTextBox.Location = new System.Drawing.Point(636, 280);
            this.userNameInfoTextBox.Name = "userNameInfoTextBox";
            this.userNameInfoTextBox.Size = new System.Drawing.Size(74, 20);
            this.userNameInfoTextBox.TabIndex = 40;
            // 
            // userSecondNameInfoTextBox
            // 
            this.userSecondNameInfoTextBox.Location = new System.Drawing.Point(636, 327);
            this.userSecondNameInfoTextBox.Name = "userSecondNameInfoTextBox";
            this.userSecondNameInfoTextBox.Size = new System.Drawing.Size(74, 20);
            this.userSecondNameInfoTextBox.TabIndex = 41;
            // 
            // userAgeInfoTextBox
            // 
            this.userAgeInfoTextBox.Location = new System.Drawing.Point(636, 372);
            this.userAgeInfoTextBox.Name = "userAgeInfoTextBox";
            this.userAgeInfoTextBox.Size = new System.Drawing.Size(74, 20);
            this.userAgeInfoTextBox.TabIndex = 42;
            // 
            // userNameAddLabel
            // 
            this.userNameAddLabel.AutoSize = true;
            this.userNameAddLabel.Location = new System.Drawing.Point(72, 475);
            this.userNameAddLabel.Name = "userNameAddLabel";
            this.userNameAddLabel.Size = new System.Drawing.Size(35, 13);
            this.userNameAddLabel.TabIndex = 43;
            this.userNameAddLabel.Text = "Name";
            // 
            // userAgeAddLabel
            // 
            this.userAgeAddLabel.AutoSize = true;
            this.userAgeAddLabel.Location = new System.Drawing.Point(237, 475);
            this.userAgeAddLabel.Name = "userAgeAddLabel";
            this.userAgeAddLabel.Size = new System.Drawing.Size(26, 13);
            this.userAgeAddLabel.TabIndex = 44;
            this.userAgeAddLabel.Text = "Age";
            // 
            // userSecondNameAddLabel
            // 
            this.userSecondNameAddLabel.AutoSize = true;
            this.userSecondNameAddLabel.Location = new System.Drawing.Point(142, 475);
            this.userSecondNameAddLabel.Name = "userSecondNameAddLabel";
            this.userSecondNameAddLabel.Size = new System.Drawing.Size(73, 13);
            this.userSecondNameAddLabel.TabIndex = 45;
            this.userSecondNameAddLabel.Text = "Second name";
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 572);
            this.Controls.Add(this.userSecondNameAddLabel);
            this.Controls.Add(this.userAgeAddLabel);
            this.Controls.Add(this.userNameAddLabel);
            this.Controls.Add(this.userAgeInfoTextBox);
            this.Controls.Add(this.userSecondNameInfoTextBox);
            this.Controls.Add(this.userNameInfoTextBox);
            this.Controls.Add(this.userSecondNameAddTextBox);
            this.Controls.Add(this.userAgeAddTextBox);
            this.Controls.Add(this.userNameAddTextBox);
            this.Controls.Add(this.userSecondNameInfoTitleLabel);
            this.Controls.Add(this.userAgeInfoTitleLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.userNameInfoTitleLabel);
            this.Controls.Add(this.userInfoTitleLabel);
            this.Controls.Add(this.userListTitleLabel);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.descriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagerForm";
            this.Text = "User Mannager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label userNameInfoTitleLabel;
        private System.Windows.Forms.Label userInfoTitleLabel;
        private System.Windows.Forms.Label userListTitleLabel;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label userAgeInfoTitleLabel;
        private System.Windows.Forms.Label userSecondNameInfoTitleLabel;
        private System.Windows.Forms.TextBox userNameAddTextBox;
        private System.Windows.Forms.TextBox userAgeAddTextBox;
        private System.Windows.Forms.TextBox userSecondNameAddTextBox;
        private System.Windows.Forms.TextBox userNameInfoTextBox;
        private System.Windows.Forms.TextBox userSecondNameInfoTextBox;
        private System.Windows.Forms.TextBox userAgeInfoTextBox;
        private System.Windows.Forms.Label userNameAddLabel;
        private System.Windows.Forms.Label userAgeAddLabel;
        private System.Windows.Forms.Label userSecondNameAddLabel;
    }
}

