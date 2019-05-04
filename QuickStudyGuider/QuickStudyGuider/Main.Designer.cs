namespace QuickStudyGuider
{
    partial class Main
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.AnswerAllLabel = new System.Windows.Forms.Label();
            this.KeyToolsLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FilePanel = new System.Windows.Forms.Panel();
            this.ExitFileLabel = new System.Windows.Forms.Label();
            this.PrintLabel = new System.Windows.Forms.Label();
            this.SaveAsFileLabel = new System.Windows.Forms.Label();
            this.SaveFileLabel = new System.Windows.Forms.Label();
            this.OpenFileLabel = new System.Windows.Forms.Label();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.QuickImport = new System.Windows.Forms.Label();
            this.DumpKeyLabel = new System.Windows.Forms.Label();
            this.GetInfo = new System.Windows.Forms.Label();
            this.ChangeSplit = new System.Windows.Forms.Label();
            this.SaveKeyLabel = new System.Windows.Forms.Label();
            this.ExportKeyLabel = new System.Windows.Forms.Label();
            this.ImportKeyLabel = new System.Windows.Forms.Label();
            this.DeleteQuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AddAnswerLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.InsertQuestions = new System.Windows.Forms.CheckBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.FilePanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.AnswerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Refresh);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(0, 18);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(800, 563);
            this.textBox.TabIndex = 0;
            this.textBox.Click += new System.EventHandler(this.PanelsDiselected);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.AnswerAllLabel);
            this.mainpanel.Controls.Add(this.KeyToolsLabel);
            this.mainpanel.Controls.Add(this.FileLabel);
            this.mainpanel.Location = new System.Drawing.Point(0, 1);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(800, 17);
            this.mainpanel.TabIndex = 1;
            this.mainpanel.Click += new System.EventHandler(this.PanelsDiselected);
            // 
            // AnswerAllLabel
            // 
            this.AnswerAllLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerAllLabel.Location = new System.Drawing.Point(162, 0);
            this.AnswerAllLabel.Name = "AnswerAllLabel";
            this.AnswerAllLabel.Size = new System.Drawing.Size(81, 16);
            this.AnswerAllLabel.TabIndex = 2;
            this.AnswerAllLabel.Text = "Answers";
            this.AnswerAllLabel.Click += new System.EventHandler(this.AnswerAllLabel_Click);
            // 
            // KeyToolsLabel
            // 
            this.KeyToolsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyToolsLabel.Location = new System.Drawing.Point(81, 0);
            this.KeyToolsLabel.Name = "KeyToolsLabel";
            this.KeyToolsLabel.Size = new System.Drawing.Size(81, 16);
            this.KeyToolsLabel.TabIndex = 1;
            this.KeyToolsLabel.Text = "KeyTools";
            this.KeyToolsLabel.Click += new System.EventHandler(this.ToolsLabel_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileLabel.Location = new System.Drawing.Point(0, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(81, 16);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File";
            this.FileLabel.Click += new System.EventHandler(this.FileLabel_Click);
            // 
            // FilePanel
            // 
            this.FilePanel.BackColor = System.Drawing.Color.White;
            this.FilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePanel.Controls.Add(this.AboutLabel);
            this.FilePanel.Controls.Add(this.ExitFileLabel);
            this.FilePanel.Controls.Add(this.PrintLabel);
            this.FilePanel.Controls.Add(this.SaveAsFileLabel);
            this.FilePanel.Controls.Add(this.SaveFileLabel);
            this.FilePanel.Controls.Add(this.OpenFileLabel);
            this.FilePanel.Location = new System.Drawing.Point(1, 17);
            this.FilePanel.Name = "FilePanel";
            this.FilePanel.Size = new System.Drawing.Size(80, 115);
            this.FilePanel.TabIndex = 2;
            // 
            // ExitFileLabel
            // 
            this.ExitFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitFileLabel.Location = new System.Drawing.Point(3, 92);
            this.ExitFileLabel.Name = "ExitFileLabel";
            this.ExitFileLabel.Size = new System.Drawing.Size(74, 18);
            this.ExitFileLabel.TabIndex = 3;
            this.ExitFileLabel.Text = "Exit";
            this.ExitFileLabel.Click += new System.EventHandler(this.Exit);
            // 
            // PrintLabel
            // 
            this.PrintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrintLabel.Location = new System.Drawing.Point(3, 58);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(74, 18);
            this.PrintLabel.TabIndex = 6;
            this.PrintLabel.Text = "Print";
            this.PrintLabel.Click += new System.EventHandler(this.PrintLabel_Click);
            // 
            // SaveAsFileLabel
            // 
            this.SaveAsFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveAsFileLabel.Location = new System.Drawing.Point(3, 40);
            this.SaveAsFileLabel.Name = "SaveAsFileLabel";
            this.SaveAsFileLabel.Size = new System.Drawing.Size(74, 18);
            this.SaveAsFileLabel.TabIndex = 2;
            this.SaveAsFileLabel.Text = "SaveAs";
            this.SaveAsFileLabel.Click += new System.EventHandler(this.SaveAs);
            // 
            // SaveFileLabel
            // 
            this.SaveFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveFileLabel.Location = new System.Drawing.Point(3, 22);
            this.SaveFileLabel.Name = "SaveFileLabel";
            this.SaveFileLabel.Size = new System.Drawing.Size(74, 18);
            this.SaveFileLabel.TabIndex = 1;
            this.SaveFileLabel.Text = "SaveFile";
            this.SaveFileLabel.Click += new System.EventHandler(this.Save);
            // 
            // OpenFileLabel
            // 
            this.OpenFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpenFileLabel.Location = new System.Drawing.Point(3, 4);
            this.OpenFileLabel.Name = "OpenFileLabel";
            this.OpenFileLabel.Size = new System.Drawing.Size(74, 18);
            this.OpenFileLabel.TabIndex = 0;
            this.OpenFileLabel.Text = "OpenFile";
            this.OpenFileLabel.Click += new System.EventHandler(this.Open);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.White;
            this.ToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsPanel.Controls.Add(this.QuickImport);
            this.ToolsPanel.Controls.Add(this.DumpKeyLabel);
            this.ToolsPanel.Controls.Add(this.GetInfo);
            this.ToolsPanel.Controls.Add(this.ChangeSplit);
            this.ToolsPanel.Controls.Add(this.SaveKeyLabel);
            this.ToolsPanel.Controls.Add(this.ExportKeyLabel);
            this.ToolsPanel.Controls.Add(this.ImportKeyLabel);
            this.ToolsPanel.Location = new System.Drawing.Point(82, 17);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(81, 133);
            this.ToolsPanel.TabIndex = 3;
            // 
            // QuickImport
            // 
            this.QuickImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuickImport.Location = new System.Drawing.Point(3, 111);
            this.QuickImport.Name = "QuickImport";
            this.QuickImport.Size = new System.Drawing.Size(74, 18);
            this.QuickImport.TabIndex = 11;
            this.QuickImport.Text = "QuickImport";
            this.QuickImport.Click += new System.EventHandler(this.QuickImport_Click);
            // 
            // DumpKeyLabel
            // 
            this.DumpKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DumpKeyLabel.Location = new System.Drawing.Point(3, 57);
            this.DumpKeyLabel.Name = "DumpKeyLabel";
            this.DumpKeyLabel.Size = new System.Drawing.Size(74, 18);
            this.DumpKeyLabel.TabIndex = 10;
            this.DumpKeyLabel.Text = "DumpKey";
            this.DumpKeyLabel.Click += new System.EventHandler(this.DumpKeyLabel_Click);
            // 
            // GetInfo
            // 
            this.GetInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GetInfo.Location = new System.Drawing.Point(3, 93);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(74, 18);
            this.GetInfo.TabIndex = 9;
            this.GetInfo.Text = "GetInfo";
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // ChangeSplit
            // 
            this.ChangeSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangeSplit.Location = new System.Drawing.Point(3, 75);
            this.ChangeSplit.Name = "ChangeSplit";
            this.ChangeSplit.Size = new System.Drawing.Size(74, 18);
            this.ChangeSplit.TabIndex = 8;
            this.ChangeSplit.Text = "ChangeSplit";
            this.ChangeSplit.Click += new System.EventHandler(this.ChangeSplit_Click);
            // 
            // SaveKeyLabel
            // 
            this.SaveKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveKeyLabel.Location = new System.Drawing.Point(3, 39);
            this.SaveKeyLabel.Name = "SaveKeyLabel";
            this.SaveKeyLabel.Size = new System.Drawing.Size(74, 18);
            this.SaveKeyLabel.TabIndex = 3;
            this.SaveKeyLabel.Text = "SaveKey";
            this.SaveKeyLabel.Click += new System.EventHandler(this.SaveKeyLabel_Click);
            // 
            // ExportKeyLabel
            // 
            this.ExportKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportKeyLabel.Location = new System.Drawing.Point(3, 21);
            this.ExportKeyLabel.Name = "ExportKeyLabel";
            this.ExportKeyLabel.Size = new System.Drawing.Size(74, 18);
            this.ExportKeyLabel.TabIndex = 2;
            this.ExportKeyLabel.Text = "ExportKey";
            this.ExportKeyLabel.Click += new System.EventHandler(this.ExportKeyLabel_Click);
            // 
            // ImportKeyLabel
            // 
            this.ImportKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImportKeyLabel.Location = new System.Drawing.Point(3, 3);
            this.ImportKeyLabel.Name = "ImportKeyLabel";
            this.ImportKeyLabel.Size = new System.Drawing.Size(74, 18);
            this.ImportKeyLabel.TabIndex = 1;
            this.ImportKeyLabel.Text = "ImportKey";
            this.ImportKeyLabel.Click += new System.EventHandler(this.ImportKeyLabel_Click);
            // 
            // DeleteQuestionLabel
            // 
            this.DeleteQuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeleteQuestionLabel.Location = new System.Drawing.Point(3, 39);
            this.DeleteQuestionLabel.Name = "DeleteQuestionLabel";
            this.DeleteQuestionLabel.Size = new System.Drawing.Size(102, 18);
            this.DeleteQuestionLabel.TabIndex = 7;
            this.DeleteQuestionLabel.Text = "DelQuestion";
            this.DeleteQuestionLabel.Click += new System.EventHandler(this.DeleteQuestionLabel_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Location = new System.Drawing.Point(3, 3);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(102, 18);
            this.AnswerLabel.TabIndex = 5;
            this.AnswerLabel.Text = "AnswerAll";
            this.AnswerLabel.Click += new System.EventHandler(this.AnswerLabel_Click);
            // 
            // AddAnswerLabel
            // 
            this.AddAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddAnswerLabel.Location = new System.Drawing.Point(3, 21);
            this.AddAnswerLabel.Name = "AddAnswerLabel";
            this.AddAnswerLabel.Size = new System.Drawing.Size(102, 18);
            this.AddAnswerLabel.TabIndex = 4;
            this.AddAnswerLabel.Text = "AddQuestion";
            this.AddAnswerLabel.Click += new System.EventHandler(this.AddAnswerLabel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.BackColor = System.Drawing.Color.White;
            this.AnswerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerPanel.Controls.Add(this.InsertQuestions);
            this.AnswerPanel.Controls.Add(this.AnswerLabel);
            this.AnswerPanel.Controls.Add(this.DeleteQuestionLabel);
            this.AnswerPanel.Controls.Add(this.AddAnswerLabel);
            this.AnswerPanel.Location = new System.Drawing.Point(162, 17);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(108, 77);
            this.AnswerPanel.TabIndex = 4;
            // 
            // InsertQuestions
            // 
            this.InsertQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertQuestions.Checked = true;
            this.InsertQuestions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InsertQuestions.Location = new System.Drawing.Point(3, 57);
            this.InsertQuestions.Name = "InsertQuestions";
            this.InsertQuestions.Size = new System.Drawing.Size(102, 17);
            this.InsertQuestions.TabIndex = 8;
            this.InsertQuestions.Text = "ShowQuestions";
            this.InsertQuestions.UseVisualStyleBackColor = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(-2, 568);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 13);
            this.InfoLabel.TabIndex = 5;
            // 
            // AboutLabel
            // 
            this.AboutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AboutLabel.Location = new System.Drawing.Point(3, 76);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(74, 18);
            this.AboutLabel.TabIndex = 7;
            this.AboutLabel.Text = "AboutMe";
            this.AboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AnswerPanel);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.FilePanel);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.textBox);
            this.Name = "Main";
            this.Text = "QuickStudyGuider";
            this.mainpanel.ResumeLayout(false);
            this.FilePanel.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.AnswerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Panel FilePanel;
        private System.Windows.Forms.Label OpenFileLabel;
        private System.Windows.Forms.Label ExitFileLabel;
        private System.Windows.Forms.Label SaveAsFileLabel;
        private System.Windows.Forms.Label SaveFileLabel;
        private System.Windows.Forms.Label KeyToolsLabel;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Label PrintLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label AddAnswerLabel;
        private System.Windows.Forms.Label SaveKeyLabel;
        private System.Windows.Forms.Label ExportKeyLabel;
        private System.Windows.Forms.Label ImportKeyLabel;
        private System.Windows.Forms.Label ChangeSplit;
        private System.Windows.Forms.Label DeleteQuestionLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label AnswerAllLabel;
        private System.Windows.Forms.Panel AnswerPanel;
        private System.Windows.Forms.Label GetInfo;
        private System.Windows.Forms.CheckBox InsertQuestions;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label DumpKeyLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label QuickImport;
        private System.Windows.Forms.Label AboutLabel;
    }
}

