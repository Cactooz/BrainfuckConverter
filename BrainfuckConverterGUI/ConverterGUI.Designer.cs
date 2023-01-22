namespace BrainfuckConverterGUI {
    partial class ConverterGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(100, 80);
            this.inputText.MinimumSize = new System.Drawing.Size(100, 40);
            this.inputText.Name = "inputText";
            this.inputText.ShowSelectionMargin = true;
            this.inputText.Size = new System.Drawing.Size(450, 100);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // encodeButton
            // 
            this.encodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeButton.Enabled = false;
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.encodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeButton.Location = new System.Drawing.Point(200, 205);
            this.encodeButton.MinimumSize = new System.Drawing.Size(80, 40);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Padding = new System.Windows.Forms.Padding(5);
            this.encodeButton.Size = new System.Drawing.Size(100, 50);
            this.encodeButton.TabIndex = 1;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(95, 60);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(46, 20);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input";
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(100, 320);
            this.outputText.MinimumSize = new System.Drawing.Size(100, 40);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(450, 100);
            this.outputText.TabIndex = 3;
            this.outputText.Text = "";
            this.outputText.Visible = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(95, 300);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(58, 20);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Output";
            this.outputLabel.Visible = false;
            // 
            // decodeButton
            // 
            this.decodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decodeButton.Enabled = false;
            this.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.decodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeButton.Location = new System.Drawing.Point(350, 205);
            this.decodeButton.MinimumSize = new System.Drawing.Size(80, 40);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Padding = new System.Windows.Forms.Padding(5);
            this.decodeButton.Size = new System.Drawing.Size(100, 50);
            this.decodeButton.TabIndex = 5;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(265, 440);
            this.copyButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.copyButton.Name = "copyButton";
            this.copyButton.Padding = new System.Windows.Forms.Padding(5);
            this.copyButton.Size = new System.Drawing.Size(120, 50);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy Output";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Visible = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // ConverterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.inputText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "ConverterGUI";
            this.Text = "BRAINFUCK Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button copyButton;
    }
}

