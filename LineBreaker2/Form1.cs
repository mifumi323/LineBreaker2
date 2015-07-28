using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LineBreaker2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnDo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) LineBreak((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void LineBreak(string[] files)
        {
            string s = "";
            if (cmbText.Text == "") return;
            //if (cmbBreakCode.Text == "") return;
            // 初期化
            byte[] target = Encoding.GetEncodings()[cmbCharCode.SelectedIndex].GetEncoding().GetBytes(cmbText.Text);
            byte[] breakCode = new byte[] { (byte)'\n' };
            // 全てのファイルに対して操作
            foreach (string filename in files)
            {
                s += filename + "\n";
                // バックアップファイルを作成する
                string backup = filename + ".bak";
                int i = 0;
                while (File.Exists(backup))
                {
                    backup = filename + "." + i.ToString("D3");
                    i++;
                }
                File.Move(filename, backup);
                // バックアップを読み込んで元のファイルに書き出し
                FileStream fsIn = new FileStream(backup, FileMode.Open, FileAccess.Read);
                BinaryReader brIn = new BinaryReader(fsIn);
                FileStream fsOut = new FileStream(filename, FileMode.CreateNew);
                BinaryWriter bwOut = new BinaryWriter(fsOut);
                // １バイトごとの処理
                byte[] buf = new byte[4096];
                int x = 0;
                bool isBreak;
                bool isMatch = false;
                try
                {
                    // 最高のパフォーマンスではないがさしあたり問題なかろう
                    while (true)
                    {
                        buf[x++] = brIn.ReadByte();
                        // テキストがマッチするかどうか調べる
                        if (!isMatch && x >= target.Length)
                        {
                            isMatch = true;
                            for (i = 0; i < target.Length; i++)
                            {
                                if (target[i] != buf[x - target.Length + i])
                                {
                                    isMatch = false;
                                    break;
                                }
                            }
                        }
                        // 一行が終わったか
                        if (x >= breakCode.Length)
                        {
                            isBreak = true;
                            for (i = 0; i < breakCode.Length; i++)
                            {
                                if (breakCode[i] != buf[x - breakCode.Length + i])
                                {
                                    isBreak = false;
                                    break;
                                }
                            }
                        }
                        else
                            isBreak = false;
                        if (isBreak)
                        {
                            // 一行終わり
                            if (isMatch)
                                isMatch = false;
                            else
                                bwOut.Write(buf, 0, x);
                            x = 0;
                        }
                    }
                }
                catch (EndOfStreamException)
                {
                    x--;    // 最後の１バイトは読み込まれないため
                    if (isMatch)
                        isMatch = false;    // この場合次のファイルのための初期化となる
                    else
                        bwOut.Write(buf, 0, x);
                }
                // １ファイル終了。後処理
                bwOut.Close();
                fsOut.Close();
                brIn.Close();
                fsIn.Close();
            }
            MessageBox.Show(s);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void LoadSetting()
        {
            Encoding encoding = Encoding.ASCII;
            int i;
            foreach (EncodingInfo ei in Encoding.GetEncodings())
            {
                Encoding e = ei.GetEncoding();
                i = cmbCharCode.Items.Add(e.EncodingName);
                if (e == encoding) cmbCharCode.SelectedIndex = i;
            }

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            ;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}