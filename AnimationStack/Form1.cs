using System.Diagnostics;

namespace AnimationStack
{
    public partial class frmBase : Form
    {
        public List<string> Folders = new List<string>();
        public List<int> FoldersLength = new List<int>();
        public List<int> FoldersCurrentFileIndex = new List<int>();

        public string ExportPath = "";
        public int MainFolderIndex = 0;




        public frmBase()
        {
            InitializeComponent();
        }




        // --- FOLDER SELECTION FUNCTIONS ---
        public void SelectFolder()
        {
            DialogResult selectedFolder = fdbImages.ShowDialog();
            if (selectedFolder == DialogResult.OK && fdbImages.SelectedPath != "")
            {
                LoadImagesFromFolder(fdbImages.SelectedPath);
            }

            GroupByFolder(0);
            lstFolders.SelectedIndex = 0;
        }

        public void SelectExportPath()
        {
            DialogResult selectedFolder = fdbImages.ShowDialog();
            if (selectedFolder == DialogResult.OK && fdbImages.SelectedPath != "")
            {
                ExportPath = fdbImages.SelectedPath + "\\";
                txtExportPath.Text = ExportPath;
            }
        }




        // --- FOLDER LIST FUNCTIONS ---
        public void SelectedFolderCall(Action<int> func)
        {
            int selectedIndex = lstFolders.SelectedIndex;

            if (selectedIndex >= 0)
            {
                func(selectedIndex);
            }
            else MessageBox.Show("No Folder was selected");
        }

        public void GroupByFolder(int index)
        {
            MainFolderIndex = index;
            txtGroupByFolder.Text = Folders[index];
        }

        public void DeleteFolder(int index)
        {
            lstFolders.Items.RemoveAt(index);
            Folders.RemoveAt(index);

            lstFolders.SelectedIndex = index - 1;

            if (index == MainFolderIndex)
            {
                MainFolderIndex = lstFolders.SelectedIndex;
                txtGroupByFolder.Text = "";
            }
        }




        // --- IMAGE LOAD FUNCTIONS ---
        public void LoadImagesFromFolder(string folderPath)
        {
            bool folderHasFiles = Directory.GetFiles(folderPath, "*.*").Where(img => img.EndsWith(".png") || img.EndsWith(".jpg")).Any();
            if (folderHasFiles)
            {
                lstFolders.Items.Insert(0, fdbImages.SelectedPath);
                Folders.Insert(0, fdbImages.SelectedPath);
            }
            else MessageBox.Show("Selected Folder does not contain images");
        }





        // --- ERROR CONDITIONS CHECK ---
        public string ComputeErrorMessage(bool[] conditions, string[] messages)
        {
            string message = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    try
                    {
                        message += messages[i] + "\n";
                    }
                    catch
                    {
                        message += $"ERROR for condition {i}" + "\n";
                    }
                }
            }

            return message;
        }

        public bool CanStack()
        {
            bool[] errorConditions = {
                Folders.Count <= 1,
                String.IsNullOrEmpty(ExportPath),
                !String.IsNullOrEmpty(ExportPath) && !Directory.Exists(ExportPath)
            };

            string[] errorMessages = {
                "Not enough Folders to sample from",
                "Export Folder was not selected",
                "Export Folder does not exist"
            };

            string errorMessage = ComputeErrorMessage(errorConditions, errorMessages);

            if (String.IsNullOrEmpty(errorMessage)) return true;
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            }
        }




        // --- STACK FUNCTIONS ---
        public bool UpdateFolderCurrentFileIndex(int index) // Update the index to be used when sampling from images
        {
            FoldersCurrentFileIndex[index] += 1;
            if (FoldersCurrentFileIndex[index] >= FoldersLength[index] && index > 0)
            {
                FoldersCurrentFileIndex[index] = 0;
                return UpdateFolderCurrentFileIndex(index - 1);
            }

            if (index == 0) return true;
            return false;
        }

        public Bitmap StackImages(Bitmap baseBitmap, List<String[]> images, int foldersCount)
        {
            Bitmap stackedBitmap = new Bitmap(baseBitmap, baseBitmap.Size);
            using (Graphics g = Graphics.FromImage(stackedBitmap))
            {
                for (int f = 1; f <= foldersCount; f++)
                {
                    g.DrawImage(Image.FromFile(images[f][FoldersCurrentFileIndex[f]]), 0, 0, stackedBitmap.Width, stackedBitmap.Height);
                }
            }

            return stackedBitmap;
        }

        public void StackImagesDataSave(Bitmap baseBitmap, List<String[]> images, int foldersCount, string savePath, string fileName)
        {
            Bitmap stackedBitmap = new Bitmap(baseBitmap, baseBitmap.Size);

            using (Graphics g = Graphics.FromImage(stackedBitmap))
            {
                for (int f = 1; f <= foldersCount; f++)
                {
                    g.DrawImage(Image.FromFile(images[f][FoldersCurrentFileIndex[f]]), 0, 0, stackedBitmap.Width, stackedBitmap.Height);
                    fileName += Path.GetFileNameWithoutExtension(images[f][FoldersCurrentFileIndex[f]]);
                }
            }
            stackedBitmap.Save(savePath + fileName + ".png");
        }

        public void Stack()
        {
            // Image Data
            List<string[]> images = new List<string[]>();
            int imagesCount = 1;


            // Gather Images and Folder Data
            int folderLastIndex = Folders.Count - 1;

            for (int i = 0; i < Folders.Count; i++)
            {
                images.Add(Directory.GetFiles(Folders[i], "*.*").Where(img => img.EndsWith(".png") || img.EndsWith(".jpg")).ToArray());
                int folderCurrentLength = images[i].Length;

                imagesCount *= folderCurrentLength; // To account all possible image combinations
                FoldersLength.Add(folderCurrentLength);
                FoldersCurrentFileIndex.Add(0); 
            }


            // Export Options
            string savePath = "";
            bool createFolderForEachImage = chkCreateFolders.Checked;


            // Output File Prefix 
            string filePrefix = txtOutputPrefix.Text;


            // Index Data
            int indexLength = (int)numIndexLength.Value;
            int startIndex = (int)numStartIndex.Value;


            // Progress Data
            int stackedImageIndex = startIndex;
            prgAnimationStack.Maximum = imagesCount;


            if (createFolderForEachImage)
            {
                string fileName = "";

                for (int i = 0; i < images[0].Length; i++)
                {
                    Bitmap currentBitmap = (Bitmap)Image.FromFile(images[0][i]);

                    do
                    {
                        fileName = filePrefix + stackedImageIndex.ToString().PadLeft(indexLength, '0');

                        // Stack Images
                        Bitmap stackedBitmap = StackImages(currentBitmap, images, folderLastIndex);

                        // Save Path
                        string folderPath = ExportPath + fileName;
                        Directory.CreateDirectory(folderPath);
                        savePath = folderPath + "\\";

                        stackedBitmap.Save(savePath + fileName + ".png");

                        stackedImageIndex++;
                        prgAnimationStack.Value++;
                    }
                    while (!UpdateFolderCurrentFileIndex(folderLastIndex));
                }
            }
            else
            {
                int mainFileIndex = -1; // Used to keep track of current file from folder to group by

                for (int i = 0; i < images[0].Length; i++)
                {
                    Bitmap currentBitmap = (Bitmap)Image.FromFile(images[0][i]);
                    string fileNameRoot = Path.GetFileNameWithoutExtension(images[0][i]); 

                    do
                    {
                        // Update save directory when file to group by changes
                        if (mainFileIndex != FoldersCurrentFileIndex[MainFolderIndex])
                        {
                            mainFileIndex = FoldersCurrentFileIndex[MainFolderIndex];

                            // Export Path + Folder Name (prefix + main file name)
                            string folderPath = ExportPath + filePrefix + Path.GetFileNameWithoutExtension(images[MainFolderIndex][mainFileIndex]);
                            Directory.CreateDirectory(folderPath);

                            savePath = folderPath + "\\";
                        }

                        StackImagesDataSave(currentBitmap, images, folderLastIndex, savePath, fileNameRoot);

                        prgAnimationStack.Value++;
                    }
                    while (!UpdateFolderCurrentFileIndex(folderLastIndex));
                }
            }

            FoldersCurrentFileIndex.Clear();
            FoldersLength.Clear();

            MessageBox.Show("Animations Stacked");
            prgAnimationStack.Value = 0;
        }




        // --- FORM CONTROLS EVENTS ---
        private void lstFolders_DoubleClick(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void btnSelectExportPath_Click(object sender, EventArgs e)
        {
            SelectExportPath();
        }


        private void btnGroupBySelected_Click(object sender, EventArgs e)
        {
            SelectedFolderCall(GroupByFolder);
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            SelectedFolderCall(DeleteFolder);
        }


        private void btnStack_Click(object sender, EventArgs e)
        {
            if (CanStack())
            {
                Stack();
            }
        }


        private void txtGroupByFolder_TextChanged(object sender, EventArgs e)
        {
            txtGroupByFolder.Select(txtGroupByFolder.Text.Length, 0);
        }

        private void txtExportPath_TextChanged(object sender, EventArgs e)
        {
            txtExportPath.Select(txtExportPath.Text.Length, 0);
        }


        private void chkCreateFolders_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkCreateFolders.Checked;

            numStartIndex.Enabled = isChecked;
            numIndexLength.Enabled = isChecked;
        }
    }
}