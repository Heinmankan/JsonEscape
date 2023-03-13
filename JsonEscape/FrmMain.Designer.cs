namespace JsonEscape
{
    partial class FrmMain
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
            MainSplitContainer = new SplitContainer();
            label1 = new Label();
            JsonTextBox = new TextBox();
            btnCopy = new Button();
            lbJsonEscaped = new Label();
            EscapedJsonTextBox = new TextBox();
            btnExit = new Button();
            btnClear = new Button();
            btnJsonToEscapedJson = new Button();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainSplitContainer.Location = new Point(12, 12);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(label1);
            MainSplitContainer.Panel1.Controls.Add(JsonTextBox);
            MainSplitContainer.Panel1MinSize = 200;
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(btnCopy);
            MainSplitContainer.Panel2.Controls.Add(lbJsonEscaped);
            MainSplitContainer.Panel2.Controls.Add(EscapedJsonTextBox);
            MainSplitContainer.Panel2MinSize = 200;
            MainSplitContainer.Size = new Size(760, 507);
            MainSplitContainer.SplitterDistance = 379;
            MainSplitContainer.SplitterWidth = 6;
            MainSplitContainer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 10;
            label1.Text = "Json";
            // 
            // JsonTextBox
            // 
            JsonTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JsonTextBox.Location = new Point(3, 18);
            JsonTextBox.Multiline = true;
            JsonTextBox.Name = "JsonTextBox";
            JsonTextBox.Size = new Size(372, 486);
            JsonTextBox.TabIndex = 0;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopy.Location = new Point(304, 473);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(48, 23);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lbJsonEscaped
            // 
            lbJsonEscaped.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbJsonEscaped.AutoSize = true;
            lbJsonEscaped.Location = new Point(286, 0);
            lbJsonEscaped.Name = "lbJsonEscaped";
            lbJsonEscaped.Size = new Size(76, 15);
            lbJsonEscaped.TabIndex = 11;
            lbJsonEscaped.Text = "Escaped Json";
            lbJsonEscaped.TextAlign = ContentAlignment.TopRight;
            // 
            // EscapedJsonTextBox
            // 
            EscapedJsonTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EscapedJsonTextBox.Location = new Point(3, 18);
            EscapedJsonTextBox.Multiline = true;
            EscapedJsonTextBox.Name = "EscapedJsonTextBox";
            EscapedJsonTextBox.Size = new Size(359, 486);
            EscapedJsonTextBox.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(697, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(226, 526);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnJsonToEscapedJson
            // 
            btnJsonToEscapedJson.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnJsonToEscapedJson.Location = new Point(36, 526);
            btnJsonToEscapedJson.Name = "btnJsonToEscapedJson";
            btnJsonToEscapedJson.Size = new Size(156, 23);
            btnJsonToEscapedJson.TabIndex = 10;
            btnJsonToEscapedJson.Text = "Json to Escaped Json >>";
            btnJsonToEscapedJson.UseVisualStyleBackColor = true;
            btnJsonToEscapedJson.Click += btnJsonToEscapedJson_Click_1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnJsonToEscapedJson);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(MainSplitContainer);
            Name = "FrmMain";
            Text = "Json Escape";
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel1.PerformLayout();
            MainSplitContainer.Panel2.ResumeLayout(false);
            MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer MainSplitContainer;
        private TextBox JsonTextBox;
        private TextBox EscapedJsonTextBox;
        private Button btnExit;
        private Button btnClear;
        private Label label1;
        private Label lbJsonEscaped;
        private Button btnJsonToEscapedJson;
        private Button btnCopy;
    }
}