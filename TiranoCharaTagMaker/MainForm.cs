using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiranoCharaTagMaker
{
    public partial class MainForm : Form
    {
        private readonly string[] partsKind = { "base", "eyebrow", "eye", "mouth" , "emotion" ,"option1","option2","hair"};
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonrefer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;

            if(Directory.Exists(textBoxTargetDir.Text))
            {
                fbd.SelectedPath = textBoxTargetDir.Text;
            }

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                textBoxTargetDir.Text = fbd.SelectedPath;
            }
            Properties.Settings.Default.TargetDirectory = fbd.SelectedPath;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Directory.Exists(textBoxTargetDir.Text))
            {
                Properties.Settings.Default.TargetDirectory = textBoxTargetDir.Text;
            }

            Properties.Settings.Default.Save();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateComboboxItems();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach(var item in partsKind)
            {
                listBoxParts.Items.Add(item);
                comboBoxPartsParents.Items.Add(item);
            }
            if (Directory.Exists(Properties.Settings.Default.TargetDirectory))
            {
                textBoxTargetDir.Text = Properties.Settings.Default.TargetDirectory;
            }

            // 共通設定もパーツとしては足す
            foreach (var item in listBoxCommonparts.Items)
            {
                comboBoxPartsParents.Items.Add(item);
            }

            listBoxParts.SelectedIndex = 0;
            UpdateComboboxItems();
        }

        private void buttonGenerateDefine_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxTargetDir.Text))
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            int baseNo = 20;
            int commonBaseNo = 10;
            string dir;
            int count = 0;
            foreach (var item in listBoxParts.Items)
            {
                dir = (string)item;
                // ベース用
                if (string.Compare(dir, "base") == 0)
                {
                    sb.AppendLine($"[chara_new name = \"{comboBoxTargetDirectory.SelectedItem}\" storage = \"chara/{comboBoxTargetDirectory.SelectedItem}/{dir}/1.png\" ]");
                }
                //通常用
                else
                {
                    // フォルダ内ファイルを列挙
                    var targetdir = Path.Combine(textBoxTargetDir.Text,comboBoxTargetDirectory.Text,dir);
                    var files = System.IO.Directory.GetFiles(targetdir, "*", System.IO.SearchOption.AllDirectories);
                    for(int i = 1; i<=files.Count();i++)
                    {
                        sb.AppendLine($"[chara_layer name=\"{comboBoxTargetDirectory.SelectedItem}\" part=\"{dir}\" id=\"{i}\" storage=\"chara/{comboBoxTargetDirectory.SelectedItem}/{dir}/{Path.GetFileName(files[i-1])}\" zindex={count+ baseNo} ]");
                    }
                }
                count++;
            }

            count = 0;
            // 共通パーツ用
            foreach (var item in listBoxCommonparts.Items)
            {
                dir = (string)item;
                // フォルダ内ファイルを列挙
                var targetdir = Path.Combine(textBoxTargetDir.Text, "common", dir);
                var files = System.IO.Directory.GetFiles(targetdir, "*", System.IO.SearchOption.TopDirectoryOnly);
                for (int i = 1; i <= files.Count(); i++)
                {
                    sb.AppendLine($"[chara_layer name=\"{comboBoxTargetDirectory.SelectedItem}\" part=\"{dir}\" id=\"{i}\" storage=\"chara/common/{dir}/{Path.GetFileName(files[i - 1])}\" zindex={count + commonBaseNo} ]");
                }
                count++;
            }


            textBoxOutput.Clear();

            textBoxOutput.Text = sb.ToString();
        }

        private void UpdateComboboxItems()
        {

            if (Directory.Exists(textBoxTargetDir.Text))
            {
                comboBoxTargetDirectory.Items.Clear();

                DirectoryInfo di = new DirectoryInfo(textBoxTargetDir.Text);
                DirectoryInfo[] dis = di.GetDirectories();

                foreach (var dir in dis)
                {
                    // Commonは除く
                    if (string.Compare(dir.Name, "common") != 0)
                    {
                        comboBoxTargetDirectory.Items.Add(dir.Name);
                    }
                }

                if (comboBoxTargetDirectory.Items.Count > 0)
                {
                    comboBoxTargetDirectory.SelectedIndex = 0;
                    comboBoxPartsParents.SelectedIndex = 0;
                    comboBoxPartsChildren.SelectedIndex = 0;
                }
            }
        }

        private void buttonGenerateTestTag_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            string testlabelName = $"*{comboBoxTargetDirectory.Text}_face_test";

            sb2.AppendLine(testlabelName);
            //sb2.AppendLine("[cm]\n[nowait]");

            sb2.AppendLine("[cm]");
            string dir;

            int buttonX = 10;
            int buttonXInit = 10;
            int buttonY = 40;
            int buttonYZouka = 35;
            int buttonXZouka = 55;
            int size = 10;
            int wide_button = 100;

            foreach (var item in listBoxParts.Items)
            {
                dir = (string)item;
                // ベース以外
                if (string.Compare(dir, "base") != 0)
                {
                    // フォルダ内ファイルを列挙
                    var targetdir = Path.Combine(textBoxTargetDir.Text, comboBoxTargetDirectory.Text, dir);
                    var files = System.IO.Directory.GetFiles(targetdir, "*", System.IO.SearchOption.TopDirectoryOnly);
                    if(files.Count() > 0)
                    {
                        buttonX = buttonXInit;
                        buttonY += buttonYZouka;
                        // [chara_part_reset name="yuko" part="face" ]
                        // リセット用ラベル
                        sb.AppendLine($"*{comboBoxTargetDirectory.Text}_{dir}_reset");
                        sb.AppendLine($"[chara_part_reset name= \"{comboBoxTargetDirectory.SelectedItem}\" part = \"{dir}\"]");
                        sb.AppendLine($"@jump target={testlabelName}");

                        sb2.AppendLine($"[glink target=\"*{comboBoxTargetDirectory.Text}_{dir}_reset\" color=\"blue\" text=\"{dir}デフォルト\" size=\"{size}\" x=\"{buttonX}\" y=\"{buttonY}\" width=\"{ wide_button}\"]");
                        buttonY += buttonYZouka;
                    }
                    for (int i = 1; i <= files.Count(); i++)
                    {
                        // ラベル
                        sb.AppendLine($"*{comboBoxTargetDirectory.Text}_{dir}_{i}");
                        sb.AppendLine($"[chara_part name= \"{comboBoxTargetDirectory.SelectedItem}\" {dir} = \"{i}\"]");
                        sb.AppendLine($"@jump target={testlabelName}");

                        string option = "";
                        // 画像なし用
                        if(Path.GetFileName(files[i - 1]).Contains("noimage"))
                        {
                            option = ("*");
                        }

                        // ラベルジャンプ用
                        //sb2.AppendLine($"[link target=*{comboBoxTargetDirectory.Text}_{dir}_{i}] {i}{option}[endlink]");
                        sb2.AppendLine($"[glink target=\"*{comboBoxTargetDirectory.Text}_{dir}_{i}\" color=\"blue\" text=\"{i}{option}\" size=\"{size}\" x=\"{buttonX}\" y=\"{buttonY}\"]");

                        buttonX += buttonXZouka;
                    }
                }
            }

            // 共通パーツ用
            foreach (var item in listBoxCommonparts.Items)
            {
                dir = (string)item;
                // フォルダ内ファイルを列挙
                var targetdir = Path.Combine(textBoxTargetDir.Text, "common", dir);
                var files = System.IO.Directory.GetFiles(targetdir, "*", System.IO.SearchOption.TopDirectoryOnly);
                if (files.Count() > 0)
                {
                    //sb2.Append($"【{dir}】");

                    buttonX = buttonXInit;
                    buttonY += buttonYZouka;

                    // リセット用ラベル
                    sb.AppendLine($"*{comboBoxTargetDirectory.Text}_{dir}_reset");
                    sb.AppendLine($"[chara_part_reset name= \"{comboBoxTargetDirectory.SelectedItem}\" part = \"{dir}\"]");
                    sb.AppendLine($"@jump target={testlabelName}");

                    sb2.AppendLine($"[glink target=\"*{comboBoxTargetDirectory.Text}_{dir}_reset\" color=\"blue\" text=\"{dir}デフォルト\" size=\"{size}\" x=\"{buttonX}\" y=\"{buttonY}\" width=\"{wide_button}\"]");

                    buttonY += buttonYZouka;
                }
                for (int i = 1; i <= files.Count(); i++)
                {
                    // ラベル
                    sb.AppendLine($"*{comboBoxTargetDirectory.SelectedItem}_{dir}_{i}");
                    sb.AppendLine($"[chara_part name= \"{comboBoxTargetDirectory.SelectedItem}\" {dir} = \"{i}\"]");
                    sb.AppendLine($"@jump target={testlabelName}");

                    string option = "";
                    // 画像なし用
                    if (Path.GetFileName(files[i - 1]).Contains("noimage"))
                    {
                        option = ("*");
                    }

                    // ラベルジャンプ用
                    //sb2.AppendLine($"[link target=*{comboBoxTargetDirectory.Text}_{dir}_{i}] {i}{option}[endlink]");

                    sb2.AppendLine($"[glink target=\"*{comboBoxTargetDirectory.Text}_{dir}_{i}\" color=\"blue\" text=\"{i}{option}\" size=\"{size}\" x=\"{buttonX}\" y=\"{buttonY}\"]");

                    buttonX += buttonXZouka;
                }
            }

            // テスト終了用ラベル追加
            sb.AppendLine("*end_emotion_test");

            // テスト終了用選択肢追加
            //sb2.AppendLine($"[r]=>[link target=*end_emotion_test]テスト終了[endlink]");
            //sb2.AppendLine("[endnowait]\n[s]\n");

            buttonX = buttonXInit;
            buttonY += buttonYZouka;

            sb2.AppendLine($"[glink target=\"*end_emotion_test\" color=\"blue\" text=\"テスト終了\" size=\"{size}\" x=\"{buttonX}\" y=\"{buttonY}\"]");

            sb2.AppendLine("[s]");

            textBoxOutput.Clear();
            textBoxOutput.Text = sb2.ToString() + sb.ToString();
        }

        private void comboBoxPartsParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 親のパーツ選択が変わったとき
            comboBoxPartsChildren.Items.Clear();
            // フォルダ内ファイルを列挙
            string targetdir;
            if (!isCommonParts(comboBoxPartsParents.SelectedItem.ToString()))
            {
                targetdir = Path.Combine(textBoxTargetDir.Text, comboBoxTargetDirectory.Text, comboBoxPartsParents.SelectedItem.ToString());
            }
            else
            {
                // 共通パーツのとき
                targetdir = Path.Combine(textBoxTargetDir.Text, "common", comboBoxPartsParents.SelectedItem.ToString());
            }
            var files = System.IO.Directory.GetFiles(targetdir, "*", System.IO.SearchOption.TopDirectoryOnly);
            if (files.Count() > 0)
            {
                for(int i = 1; i<=files.Count();i++)
                {

                    comboBoxPartsChildren.Items.Add(i.ToString());
                }
                comboBoxPartsChildren.SelectedIndex = 0;
            }
        }

        private void buttonAddMacroParts_Click(object sender, EventArgs e)
        {
            string targetParts = $"part=\"{comboBoxPartsParents.SelectedItem.ToString()}\"";
            // 同じパーツがあったら削除する
            Object target = null;
            foreach (var item in listBoxPartsCollection.Items)
            {
                if(item.ToString().Contains(targetParts)==true)
                {
                    target = item;
                    break;
                }
            }

            if(target != null)
            {
                listBoxPartsCollection.Items.Remove(target);
            }

            listBoxPartsCollection.Items.Add($"part=\"{comboBoxPartsParents.SelectedItem.ToString()}\" id=\"{comboBoxPartsChildren.SelectedItem.ToString()}\"");
            updatePictureBox();
        }

        private void buttonDeletePartsSelect_Click(object sender, EventArgs e)
        {
            if(listBoxPartsCollection.SelectedIndex != -1)
            {
                listBoxPartsCollection.Items.RemoveAt(listBoxPartsCollection.SelectedIndex);
                updatePictureBox();
            }
        }

        private void buttonGenerateImgMacro_Click(object sender, EventArgs e)
        {
            if(listBoxPartsCollection.Items.Count>0)
            {
                if(textBoxMacroId.Text =="")
                {
                    MessageBox.Show("マクロ名を入力してください。");
                    return;
                }
                StringBuilder sb = new StringBuilder();

                sb.Append($"[chara_part name=\"{comboBoxTargetDirectory.Text}\" ");
                foreach (var items in listBoxPartsCollection.Items)
                {
                    sb.Append(items.ToString()+" ");
                }
                sb.Append($"]");

                textBoxOutput.Clear();
                textBoxOutput.Text = sb.ToString();
            }
        }

        private void updatePictureBox()
        {
            if(!Directory.Exists(textBoxTargetDir.Text))
            {
                return;
            }
            //var basePath = Path.Combine(textBoxTargetDir.Text, comboBoxTargetDirectory.Text, "base", "1.png");
            Bitmap backBmp = new Bitmap(200,200);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics gr = Graphics.FromImage(backBmp);
            //全体を黒で塗りつぶす
            gr.FillRectangle(Brushes.Black, gr.VisibleClipBounds);

            foreach (var item in listBoxPartsCollection.Items)
            {
                var slist = item.ToString().Split('\"');
                string partsName = slist[1];
                string id = slist[3];
                string targetFile= "";
                if (!isCommonParts(partsName))
                {
                    string targetDir = Path.Combine(textBoxTargetDir.Text, comboBoxTargetDirectory.Text, partsName);
                    var files = System.IO.Directory.GetFiles(targetDir, $"{id}*", System.IO.SearchOption.TopDirectoryOnly);                    
                    targetFile = Path.Combine(textBoxTargetDir.Text, comboBoxTargetDirectory.Text, partsName, $"{Path.GetFileName(files[0])}");
                }
                else
                {
                    // 共通パーツのとき
                    string targetDir = Path.Combine(textBoxTargetDir.Text, "common", partsName);
                    var files = System.IO.Directory.GetFiles(targetDir, $"{id}*", System.IO.SearchOption.TopDirectoryOnly);

                    targetFile = Path.Combine(textBoxTargetDir.Text, "common", partsName, $"{Path.GetFileName(files[0])}");
                }

                Bitmap bmp = new Bitmap(targetFile);

                //背景の画像に描画する
                Graphics g = Graphics.FromImage(backBmp);
                g.DrawImage(bmp, 0, 0, 200, 200);
                g.Dispose();
                bmp.Dispose();
            }

            pictureBoxImage.Image = backBmp;
        }

        private bool isCommonParts(string partsParentsName)
        {
            bool isExist = false;
            if(listBoxCommonparts.FindStringExact(partsParentsName, 0) != -1)
            {
                isExist = true;
            }
            return isExist;
        }

        private void buttonDeleteAllParts_Click(object sender, EventArgs e)
        {
            listBoxPartsCollection.Items.Clear();
            if (pictureBoxImage.Image != null)
            {
                pictureBoxImage.Image.Dispose();
            }
        }
    }
}
