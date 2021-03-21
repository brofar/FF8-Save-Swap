using Microsoft.WindowsAPICodePack.Dialogs;
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

namespace FF8_Save_Swapper
{
    public partial class Form1 : Form
    {
        public static string saveFolder;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListSaves();
        }

        private void ListSaves()
        {
            Dictionary<string, string> saves = new Dictionary<string, string>();

            string[] allfiles = Directory.GetFiles(".\\saves", "*.ff8", SearchOption.AllDirectories);
            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                // Do something with the Folder or just add them to a list via nameoflist.add();

                var filename = info.Name;
                var directory = info.Directory.Name;
                var parent = info.Directory.Parent.Name;

                var listItem = (parent != "saves") ? parent + " --- " + directory : directory;
                var listItemWithFileName = listItem + "--" + filename.Substring(0, filename.Length - 4);

                saves.Add(info.FullName, listItemWithFileName);
            }

            // Shutdown the painting of the ListBox as items are added.
            list_saves.BeginUpdate();

            list_saves.DataSource = new BindingSource(saves, null);
            list_saves.DisplayMember = "Value";
            list_saves.ValueMember = "Key";

            // Allow the ListBox to repaint and display the new items.
            list_saves.EndUpdate();
        }

        private void ReplaceSaveFile(string sourceFile)
        {
            // If no save folder, set one first.
            if (String.IsNullOrEmpty(saveFolder))
            {
                MessageBox.Show("Set your FF8 save folder first.");
                SetSaveFolder();
            }

            string FF8SaveFolder = saveFolder + "\\slot2_save28.ff8";
            File.Copy(sourceFile, FF8SaveFolder, true);
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)list_saves.SelectedItem;
            var file = selectedItem.Key;
            ReplaceSaveFile(file);
        }

        private void btn_setSaveFolder_Click(object sender, EventArgs e)
        {
            SetSaveFolder();
        }

        private void SetSaveFolder()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Square Enix\\FINAL FANTASY VIII Steam\\";
            dialog.IsFolderPicker = true;
            dialog.Title = "Select your user_xxxxxxx folder where your FF8 saves are located.";

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                saveFolder = dialog.FileName;
                lbl_saveFolder.Text = dialog.FileName;
            }
        }
    }
}
