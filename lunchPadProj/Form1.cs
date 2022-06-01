using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace lunchPadProj
{
    using Instrument;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;
        InstrumentList pts = new InstrumentList();
        int curIndex = -1;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        e.Handled = true;
                        BtnKill.FillColor = Color.DarkRed;
                        AudioPlaybackEngine.Instance.Dispose();
                        break;
                    case Keys.NumPad9:
                        e.Handled = true;
                        Pad_num_09.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[9]);
                        break;
                    case Keys.NumPad8:
                        e.Handled = true;
                        Pad_num_08.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[8]);
                        break;
                    case Keys.NumPad7:
                        e.Handled = true;
                        Pad_num_07.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound(pts[curIndex].PLAYABLEADRESS[7]);
                        break;
                    case Keys.NumPad6:
                        e.Handled = true;
                        Pad_num_06.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[6]);
                        break;
                    case Keys.NumPad5:
                        e.Handled = true;
                        Pad_num_05.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[5]);
                        break;
                    case Keys.NumPad4:
                        e.Handled = true;
                        Pad_num_04.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[4]);
                        break;
                    case Keys.NumPad3:
                        e.Handled = true;
                        Pad_num_03.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[3]);
                        break;
                    case Keys.NumPad2:
                        e.Handled = true;
                        Pad_num_02.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[2]);
                        break;
                    case Keys.NumPad1:
                        e.Handled = true;
                        Pad_num_01.FillColor = Color.Aqua;
                        AudioPlaybackEngine.Instance.PlaySound((pts[curIndex]).PLAYABLEADRESS[1]);
                        break;
                }
            }
            catch (ArgumentOutOfRangeException){MessageBox.Show("Please choose an instrument");}catch (FileNotFoundException){} 
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad9:
                    e.Handled = true;
                   Pad_num_09.FillColor = Color.FromArgb(97, 105, 129);   
                    break;
                case Keys.NumPad8:
                    e.Handled = true;
                    Pad_num_08.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad7:
                    e.Handled = true;
                    Pad_num_07.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad6:
                    e.Handled = true;
                    Pad_num_06.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad5:
                    e.Handled = true;
                    Pad_num_05.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad4:
                    e.Handled = true;
                    Pad_num_04.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad3:
                    e.Handled = true;
                    Pad_num_03.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad2:
                    e.Handled = true;
                    Pad_num_02.FillColor = Color.FromArgb(97, 105, 129);
                    break;
                case Keys.NumPad1:
                    e.Handled = true;
                    Pad_num_01.FillColor = Color.FromArgb(97, 105, 129);
                    break;
            }
        }

        private void Pad_num_09_DragEnter(object sender, DragEventArgs e){try{e.Effect = DragDropEffects.All;}
            catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_09_DragDrop(object sender, DragEventArgs e)
        {try{//take drop file and add to array
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop,false);
            (pts[curIndex]).changePad(9, file[0]);
            Pad_num_09.FillColor = Color.DeepPink;
            } catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_08_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(8, file[0]);
                Pad_num_08.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_07_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(7, file[0]);
                Pad_num_07.FillColor = Color.DeepPink;
            }
            catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_06_DragDrop(object sender, DragEventArgs e){try{ //take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(6, file[0]);
                Pad_num_06.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_05_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(5, file[0]);
                Pad_num_05.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_04_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(4, file[0]);
                Pad_num_04.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_03_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(3, file[0]);
                Pad_num_03.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_02_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(2, file[0]);
                Pad_num_02.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void Pad_num_01_DragDrop(object sender, DragEventArgs e){try{//take drop file and add to array
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                (pts[curIndex]).changePad(1, file[0]);
                Pad_num_01.FillColor = Color.DeepPink;
            }catch (ArgumentOutOfRangeException) { }
        }
        private void btnBass_Click(object sender, EventArgs e)
        {
            pts[pts.NextIndex] = new Bass();
            curIndex = pts.NextIndex - 1;
            btnBass.FillColor = Color.Aqua;
            btnGuitar.FillColor = btnLoad.FillColor= btnDrums.FillColor = Color.FromArgb(97, 105, 129);
        }
        private void btnGuitar_Click(object sender, EventArgs e)
        {
            pts[pts.NextIndex] = new Gtr();
            curIndex = pts.NextIndex - 1;
            btnGuitar.FillColor = Color.Aqua;
            btnDrums.FillColor = btnLoad.FillColor=btnBass.FillColor = Color.FromArgb(97, 105, 129);
        }
        private void btnDrums_Click(object sender, EventArgs e)
        {
            pts[pts.NextIndex] = new Drums();
            curIndex = pts.NextIndex - 1;
            btnDrums.FillColor = Color.Aqua;
            btnBass.FillColor =  btnGuitar.FillColor = btnLoad.FillColor= Color.FromArgb(97, 105, 129);
        }
        private void Pad_num_07_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Pad_num_07.Left = e.X + Pad_num_07.Left - MouseDownLocation.X;
                Pad_num_07.Top = e.Y + Pad_num_07.Top - MouseDownLocation.Y;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.FillColor = Color.DarkSlateBlue;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, pts[curIndex]);
                }
            }
            btnSave.FillColor = Color.FromArgb(97, 105, 129);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnBass.FillColor = btnGuitar.FillColor = btnDrums.FillColor = Color.FromArgb(97, 105, 129);
            btnLoad.FillColor = Color.Aqua;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                 pts[pts.NextIndex] = (Instrument)binaryFormatter.Deserialize(stream );
                curIndex = pts.NextIndex - 1;
            }
        }
    }
}
