namespace AsyncAwait.Task2
{
    partial class RequestManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestManagerForm));
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.sendRequestButton = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.firstRequestTextBox = new System.Windows.Forms.TextBox();
            this.secondRequestTextBox = new System.Windows.Forms.TextBox();
            this.firstRequestResultLabel = new System.Windows.Forms.Label();
            this.secondRequestResultLabel = new System.Windows.Forms.Label();
            this.firstRequestCancelButton = new System.Windows.Forms.Button();
            this.secondRequestCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(28, 56);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(372, 65);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = resources.GetString("debugInstructionsLabel.Text");
            // 
            // sendRequestButton
            // 
            this.sendRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRequestButton.Location = new System.Drawing.Point(288, 147);
            this.sendRequestButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendRequestButton.Name = "sendRequestButton";
            this.sendRequestButton.Size = new System.Drawing.Size(139, 46);
            this.sendRequestButton.TabIndex = 2;
            this.sendRequestButton.Text = "Send request";
            this.sendRequestButton.UseVisualStyleBackColor = true;
            this.sendRequestButton.Click += new System.EventHandler(this.sendRequestButton_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(52, 20);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(76, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Task 2";
            // 
            // firstRequestTextBox
            // 
            this.firstRequestTextBox.Location = new System.Drawing.Point(41, 147);
            this.firstRequestTextBox.Name = "firstRequestTextBox";
            this.firstRequestTextBox.Size = new System.Drawing.Size(193, 20);
            this.firstRequestTextBox.TabIndex = 4;
            // 
            // secondRequestTextBox
            // 
            this.secondRequestTextBox.Location = new System.Drawing.Point(41, 173);
            this.secondRequestTextBox.Name = "secondRequestTextBox";
            this.secondRequestTextBox.Size = new System.Drawing.Size(193, 20);
            this.secondRequestTextBox.TabIndex = 5;
            // 
            // firstRequestResultLabel
            // 
            this.firstRequestResultLabel.AutoSize = true;
            this.firstRequestResultLabel.Location = new System.Drawing.Point(88, 216);
            this.firstRequestResultLabel.Name = "firstRequestResultLabel";
            this.firstRequestResultLabel.Size = new System.Drawing.Size(0, 13);
            this.firstRequestResultLabel.TabIndex = 6;
            // 
            // secondRequestResultLabel
            // 
            this.secondRequestResultLabel.AutoSize = true;
            this.secondRequestResultLabel.Location = new System.Drawing.Point(88, 231);
            this.secondRequestResultLabel.Name = "secondRequestResultLabel";
            this.secondRequestResultLabel.Size = new System.Drawing.Size(0, 13);
            this.secondRequestResultLabel.TabIndex = 7;
            // 
            // firstRequestCancelButton
            // 
            this.firstRequestCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRequestCancelButton.Location = new System.Drawing.Point(239, 147);
            this.firstRequestCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.firstRequestCancelButton.Name = "firstRequestCancelButton";
            this.firstRequestCancelButton.Size = new System.Drawing.Size(18, 20);
            this.firstRequestCancelButton.TabIndex = 8;
            this.firstRequestCancelButton.Text = "X";
            this.firstRequestCancelButton.UseVisualStyleBackColor = true;
            this.firstRequestCancelButton.Visible = false;
            this.firstRequestCancelButton.Click += new System.EventHandler(this.firstRequestCancelButton_Click);
            // 
            // secondRequestCancelButton
            // 
            this.secondRequestCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondRequestCancelButton.Location = new System.Drawing.Point(239, 171);
            this.secondRequestCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.secondRequestCancelButton.Name = "secondRequestCancelButton";
            this.secondRequestCancelButton.Size = new System.Drawing.Size(18, 20);
            this.secondRequestCancelButton.TabIndex = 9;
            this.secondRequestCancelButton.Text = "X";
            this.secondRequestCancelButton.UseVisualStyleBackColor = true;
            this.secondRequestCancelButton.Visible = false;
            this.secondRequestCancelButton.Click += new System.EventHandler(this.secondRequestCancelButton_Click);
            // 
            // RequestManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.secondRequestCancelButton);
            this.Controls.Add(this.firstRequestCancelButton);
            this.Controls.Add(this.secondRequestResultLabel);
            this.Controls.Add(this.firstRequestResultLabel);
            this.Controls.Add(this.secondRequestTextBox);
            this.Controls.Add(this.firstRequestTextBox);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.sendRequestButton);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RequestManagerForm";
            this.Text = "Request Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button sendRequestButton;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox firstRequestTextBox;
        private System.Windows.Forms.TextBox secondRequestTextBox;
        private System.Windows.Forms.Label firstRequestResultLabel;
        private System.Windows.Forms.Label secondRequestResultLabel;
        private System.Windows.Forms.Button firstRequestCancelButton;
        private System.Windows.Forms.Button secondRequestCancelButton;
    }
}

