using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;


namespace MovieWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //IsAnime
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if(!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("You need to select an option (anime or not)!");
                    return;
                }
                else if (radioButton1.Checked)
                {
                    //isAnime
                    string target = @"https://hianime.to/search?keyword=" + textBox1.Text;

                    try
                    {
                        Process.Start(target);
                    }
                    catch
                    {
                        // hack because of this: https://github.com/dotnet/corefx/issues/10361
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            target = target.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                        {
                            Process.Start("xdg-open", target);
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        {
                            Process.Start("open", target);
                        }
                        else
                        {
                            throw;
                        }
                    }

                }
                else if (radioButton2.Checked)
                {
                    //isNotAnime
                    
                    string target = @"https://ww25.soap2day.day/?s=" + textBox1.Text;

                    try
                    {
                        Process.Start(target);
                    }
                    catch
                    {
                        // hack because of this: https://github.com/dotnet/corefx/issues/10361
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            target = target.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                        {
                            Process.Start("xdg-open", target);
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        {
                            Process.Start("open", target);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The field can not be empty!!");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //IsNotAnime
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
