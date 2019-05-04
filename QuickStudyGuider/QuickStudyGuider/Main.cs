using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStudyGuider
{
    public partial class Main : Form
    {
        public AnswerKey answerKey = null;
        public FileInfo currentfile = null;
        public TextPrinter TextPrinter = new TextPrinter();
        public DirectoryInfo currentdirectory = new DirectoryInfo(Environment.CurrentDirectory);
        public string defaultsplitkey = "<ans>";
        public string defaultnewline = "<new>";
        AboutBox about;
        public Main()
        {
            InitializeComponent();
            CloseAllPanels();
            about = new AboutBox();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Refresh(object sender, EventArgs e)
        {
            mainpanel.Width = this.Width - 17;
            textBox.Width = this.Width - 17;
            textBox.Height = this.Height - 57;
            InfoLabel.Location = new Point(3, this.Height - InfoLabel.Height-40);
            int row = textBox.GetLineFromCharIndex(textBox.SelectionStart);
            int column = textBox.SelectionStart - textBox.GetFirstCharIndexFromLine(row);
            InfoLabel.Text = "Row: " + row + "    Col: " + column + "   CharCount: "+textBox.Text.Length;
        }

        private void FileLabel_Click(object sender, EventArgs e)
        {
            if(FilePanel.Visible)
            {
                FilePanel.Visible = false;
            }
            else
            {
                CloseAllPanels();
                FilePanel.Visible = true;
            }
        }

        private void ToolsLabel_Click(object sender, EventArgs e)
        {
            if(ToolsPanel.Visible)
            {
                ToolsPanel.Visible = false;
            }
            else
            {
                CloseAllPanels();
                ToolsPanel.Visible = true;
            }
        }

        private void AnswerAllLabel_Click(object sender, EventArgs e)
        {
            if(AnswerPanel.Visible)
            {
                AnswerPanel.Visible = false;
            }
            else
            {
                CloseAllPanels();
                AnswerPanel.Visible = true;
            }
        }

        public void CloseAllPanels()
        {
            FilePanel.Visible = false;
            ToolsPanel.Visible = false;
            AnswerPanel.Visible = false;
        }

        private void Open(object sender, EventArgs e)
        {
            CloseAllPanels();
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentfile = new FileInfo(openFileDialog.FileName);
                textBox.Text = File.ReadAllText(currentfile.FullName);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            CloseAllPanels();
            if(currentfile != null)
            {
                File.WriteAllText(currentfile.FullName, textBox.Text);
            }
            else
            {
                SaveAs(sender, e);
            }
        }

        private void SaveAs(object sender, EventArgs e)
        {
            CloseAllPanels();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentfile = new FileInfo(saveFileDialog.FileName);
                File.WriteAllText(currentfile.FullName, textBox.Text);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportKeyLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (answerKey == null)
                    {
                        answerKey = new AnswerKey(openFileDialog.FileName, defaultsplitkey, defaultnewline);
                    }
                    else
                    {
                        if(MessageBox.Show("An answer key has already been imported. Would you like to join the 2 keys for more answers or overide the current key?","QuickStudyGuider",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            answerKey.AppendKey(new AnswerKey(openFileDialog.FileName, defaultsplitkey, defaultnewline));
                        }
                        else
                        {
                            answerKey = new AnswerKey(openFileDialog.FileName, defaultsplitkey, defaultnewline);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("File is corrupted. The data in the file may not be valid for a key file.");
                    answerKey = null;
                }
            }
        }

        private void ExportKeyLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            openFileDialog.FileName = "";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (answerKey == null)
                {
                    MessageBox.Show("Please import an key to work with.");
                }
                else
                {
                    AnswerKey.ExportKey(answerKey, openFileDialog.FileName);
                }
            }
        }

        private void SaveKeyLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            if (answerKey == null)
            {
                MessageBox.Show("Please import an key to work with.");
            }
            else
            {
                AnswerKey.ExportKey(answerKey, answerKey.filepath);
            }
        }

        private void DumpKeyLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            if(MessageBox.Show("Are you sure you would like to dump this key? Any modifications will be lost. If want to keep modifications, click save key and then dump key.","QuickStudyGuider",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                answerKey = null;
            }
        }

        private void AddAnswerLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            if (answerKey == null)
            {
                MessageBox.Show("Please import an key to work with.");
                return;
            }
            string question = "";
            string answer = "";
            if(InputBox.Show("QuickStudyGuider","Enter the question.",ref question) == DialogResult.OK && InputBox.Show("QucikStudyGuider","Enter the answer.",ref answer) == DialogResult.OK)
            {
                if(!answerKey.AddQuestion(question,answer))
                {
                    MessageBox.Show("The question already exists. Please delete the question, then re-add it.");
                }
            }
        }

        private void DeleteQuestionLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            if (answerKey == null)
            {
                MessageBox.Show("Please import an key to work with.");
                return;
            }
            string question = "";
            if(InputBox.Show("QuickStudyGuider","Enter the question.",ref question) == DialogResult.OK)
            {
                if(!answerKey.DeleteQuestion(question))
                {
                    MessageBox.Show("That question doesn't exist.");
                }
            }
        }

        private void ChangeSplit_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            string value = defaultsplitkey;
            if(InputBox.Show("QuickStudyGuider","Enter a split pattern between definitions and terms.",ref value) == DialogResult.OK)
            {
                string value2 = defaultnewline;
                if (InputBox.Show("QuickStudyGuider", "Enter a split pattern between rows.", ref value2) == DialogResult.OK)
                {
                    if (answerKey != null)
                    {
                        try
                        {
                            answerKey = new AnswerKey(answerKey.filepath, value, value2);
                        }
                        catch
                        {
                            MessageBox.Show("The split change for this key is invalid. Dumping key.");
                            answerKey = null;
                        }
                    }
                    defaultsplitkey = value;
                    defaultnewline = value2;
                }
            }
        }

        private void AnswerLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            if(answerKey == null)
            {
                MessageBox.Show("Please import an key to work with.");
            }
            else
            {
                string newtext = "";
                int questionnum = 0;
                foreach (string question in textBox.Lines)
                {
                    questionnum++;
                    if (InsertQuestions.Checked)
                    {
                        newtext += questionnum.ToString() + ". " + question + "\r\n" + answerKey.GetAnswer(question) + "\r\n\r\n";
                    }
                    else
                    {
                        newtext += questionnum.ToString() + ". "+ answerKey.GetAnswer(question) + "\r\n\r\n";
                    }
                }
                textBox.Text = newtext;
            }
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            if(answerKey != null)
            {
                string toshow = "Name: "+answerKey.GetKeyProperty("name")+"\nAuthor(s): "+answerKey.GetKeyProperty("author")+"\nAnswers: "+answerKey.answers.Count.ToString()+"\nFilePath: "+answerKey.filepath+"\n\n";
                if(answerKey.GetKeyProperty("info") == "N/A")
                {
                    toshow = toshow + "No aditional information availible.";
                }
                else
                {
                    toshow = toshow + answerKey.GetKeyProperty("info");
                }
                MessageBox.Show(toshow,"Answer Key Properties");
            }
            else
            {
                MessageBox.Show("Please import an key to work with.");
            }
        }

        private void PrintLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            TextPrinter.lines = textBox.Lines;
            TextPrinter.currentline = 0;
            TextPrinter.Font = textBox.Font;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            TextPrinter.PrintTextFileHandler(sender, e);
        }

        private void PanelsDiselected(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true)
            {
                if(e.KeyCode == Keys.S)
                {
                    if (e.Shift)
                    {
                        SaveAs(sender, e);
                    }
                    else
                    {
                        Save(sender, e);
                    }
                }
                if(e.KeyCode == Keys.O)
                {
                    Open(sender, e);
                }
                if(e.KeyCode == Keys.P)
                {
                    PrintLabel_Click(sender, e);
                }
            }
        }

        private void QuickImport_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            string name = "";
            string toshow = "Availible QuickImport Keys: ";
            foreach (FileInfo file in currentdirectory.GetFiles())
            {
                if (file.Extension == ".key")
                {
                    toshow += file.Name.Replace(".key","") + ", ";
                }
            }

            if (InputBox.Show("QuickStudyGuider",toshow,ref name) == DialogResult.OK)
            {
                try
                {
                    answerKey = new AnswerKey(Environment.CurrentDirectory + "\\" + name + ".key", "<ans>", "<new>");
                }
                catch
                {
                    MessageBox.Show("There was an error loading in the key");
                }
            }
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            about.ShowDialog();
        }
    }
    public static class InputBox
    {
        public static DialogResult Show(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(12, 1, 372, 13);
            textBox.SetBounds(12, 50, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
