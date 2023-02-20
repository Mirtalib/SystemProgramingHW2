namespace SystemProgramingHW2
{
    public partial class Form1 : Form
    {

        Thread? thread = null;

        public Form1()
        {
            InitializeComponent();
            thread = new(CopyFileMethod);
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            thread?.Suspend();
            MessageBox.Show("Thread Suspend");
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            thread?.Resume();
            MessageBox.Show("Thread Resume");
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            thread?.Abort();
            MessageBox.Show("Thread Abort");
        }
        private void btnfrom_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxFileName1.Text = openFileDialog1.FileName;
            }
        }


        private void btnTo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxFileName2.Text = openFileDialog2.FileName;
            }
        }

        private void CopyFileMethod()
        {
            progressBar1.Value = 0;

            using (FileStream fsRead = new FileStream(txtBoxFileName1.Text, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(txtBoxFileName2.Text, FileMode.Create, FileAccess.Write))
                {
                    var len = 10;
                    var fileSize = fsRead.Length;
                    byte[] buffer = new byte[len];
                    var copyBytes = 0;
                    var bytesLength = buffer.Length;
                    
                    do
                    {
                        
                        fsRead.Read(buffer, 0, buffer.Length);
                        fsWrite.Write(buffer, 0, bytesLength);
                        copyBytes += bytesLength;
                        var progress = Convert.ToInt32((copyBytes * 100 / fileSize));

                        if (IsHandleCreated)
                        {
                            progressBar1.Invoke(new MethodInvoker(delegate{ progressBar1.Value = progress;}));

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }



                        Thread.Sleep(700);
                    } while (copyBytes < fileSize);

                }
            }

            MessageBox.Show("Sucefull");
        }




        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtBoxFileName1.Text))
            {
                MessageBox.Show("Enter wrong file");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxFileName1.Text) || string.IsNullOrWhiteSpace(txtBoxFileName2.Text))
            {
                MessageBox.Show("Enter information");
                return;
            }


            if (!txtBoxFileName2.Text.Contains(".txt"))
                txtBoxFileName2.Text += (".txt");


            thread?.Start();
        }

    }
}