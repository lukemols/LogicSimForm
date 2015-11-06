namespace LogicSimForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.StimuliLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NetListTextBox = new System.Windows.Forms.TextBox();
            this.StimuliTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.NetListBrowseButton = new System.Windows.Forms.Button();
            this.StimuliBrowseButton = new System.Windows.Forms.Button();
            this.OutputBrowseButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.WorkingLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StimuliLabel
            // 
            this.StimuliLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StimuliLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StimuliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StimuliLabel.Location = new System.Drawing.Point(51, 139);
            this.StimuliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StimuliLabel.Name = "StimuliLabel";
            this.StimuliLabel.Size = new System.Drawing.Size(133, 49);
            this.StimuliLabel.TabIndex = 1;
            this.StimuliLabel.Text = "Stimuli";
            this.StimuliLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NetListTextBox
            // 
            this.NetListTextBox.Location = new System.Drawing.Point(227, 64);
            this.NetListTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NetListTextBox.Multiline = true;
            this.NetListTextBox.Name = "NetListTextBox";
            this.NetListTextBox.Size = new System.Drawing.Size(269, 47);
            this.NetListTextBox.TabIndex = 3;
            // 
            // StimuliTextBox
            // 
            this.StimuliTextBox.Location = new System.Drawing.Point(227, 139);
            this.StimuliTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StimuliTextBox.Multiline = true;
            this.StimuliTextBox.Name = "StimuliTextBox";
            this.StimuliTextBox.Size = new System.Drawing.Size(269, 47);
            this.StimuliTextBox.TabIndex = 4;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(227, 229);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(269, 47);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_Changed);
            // 
            // NetListBrowseButton
            // 
            this.NetListBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetListBrowseButton.Location = new System.Drawing.Point(552, 68);
            this.NetListBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NetListBrowseButton.Name = "NetListBrowseButton";
            this.NetListBrowseButton.Size = new System.Drawing.Size(157, 46);
            this.NetListBrowseButton.TabIndex = 6;
            this.NetListBrowseButton.Text = "Browse";
            this.NetListBrowseButton.UseVisualStyleBackColor = true;
            this.NetListBrowseButton.Click += new System.EventHandler(this.NetListBrowseButton_Click);
            // 
            // StimuliBrowseButton
            // 
            this.StimuliBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StimuliBrowseButton.Location = new System.Drawing.Point(552, 143);
            this.StimuliBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StimuliBrowseButton.Name = "StimuliBrowseButton";
            this.StimuliBrowseButton.Size = new System.Drawing.Size(157, 46);
            this.StimuliBrowseButton.TabIndex = 7;
            this.StimuliBrowseButton.Text = "Browse";
            this.StimuliBrowseButton.UseVisualStyleBackColor = true;
            this.StimuliBrowseButton.Click += new System.EventHandler(this.StimuliBrowseButton_Click);
            // 
            // OutputBrowseButton
            // 
            this.OutputBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBrowseButton.Location = new System.Drawing.Point(552, 229);
            this.OutputBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputBrowseButton.Name = "OutputBrowseButton";
            this.OutputBrowseButton.Size = new System.Drawing.Size(157, 46);
            this.OutputBrowseButton.TabIndex = 8;
            this.OutputBrowseButton.Text = "Browse";
            this.OutputBrowseButton.UseVisualStyleBackColor = true;
            this.OutputBrowseButton.Click += new System.EventHandler(this.OutputBrowseButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(552, 320);
            this.RunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(157, 46);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // WorkingLabel
            // 
            this.WorkingLabel.AutoSize = true;
            this.WorkingLabel.Location = new System.Drawing.Point(333, 320);
            this.WorkingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkingLabel.Name = "WorkingLabel";
            this.WorkingLabel.Size = new System.Drawing.Size(0, 17);
            this.WorkingLabel.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(51, 320);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(157, 46);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 404);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WorkingLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.OutputBrowseButton);
            this.Controls.Add(this.StimuliBrowseButton);
            this.Controls.Add(this.NetListBrowseButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.StimuliTextBox);
            this.Controls.Add(this.NetListTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StimuliLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(34, 47);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StimuliLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NetListTextBox;
        private System.Windows.Forms.TextBox StimuliTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button NetListBrowseButton;
        private System.Windows.Forms.Button StimuliBrowseButton;
        private System.Windows.Forms.Button OutputBrowseButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label WorkingLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

