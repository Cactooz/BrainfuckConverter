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
            // 
            // encodeButton
            // 
            this.encodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.encodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeButton.Location = new System.Drawing.Point(275, 205);
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
            this.inputLabel.Size = new System.Drawing.Size(165, 20);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Extended ASCII Input";
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.outputLabel.Size = new System.Drawing.Size(144, 20);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "BRAINFUCK Code";
            this.outputLabel.Visible = false;
            // 
            // ConverterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.inputText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(375, 500);
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
    }
}

