using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3InfixToPostfix
{
    public static class Toolbox
    {

        public static string GetFileContents(string filepath = null)
        {
            string fileContents = "";
            StreamReader rdr = null;
            try
            {
                rdr = new StreamReader(filepath);
                fileContents = rdr.ReadToEnd();
            }
            catch
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.InitialDirectory = Directory.GetCurrentDirectory() + "..\\..\\";
                dlg.Title = "Select text file to be processed...";
                dlg.Filter = "text files (*.txt)|*.txt|text files (*.text)|*.text|all files|*.*";

                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    rdr = new StreamReader(dlg.FileName);
                    fileContents = rdr.ReadToEnd();
                }
                else
                {
                    MessageBox.Show("File Open cancelled", "File Open Error");
                }

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return fileContents;
        }
        public static List<string> GetSentencesFromFile(string filepath = null)
        {
            List<string> sentenceList = new List<string>();

            StreamReader rdr = null;
            try
            {
                rdr = new StreamReader(filepath);
                while(!rdr.EndOfStream)
                {
                    sentenceList.Add(rdr.ReadLine());
                }
            }
            catch
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.InitialDirectory = Directory.GetCurrentDirectory() + "..\\..\\";
                dlg.Title = "Select text file to be processed...";
                dlg.Filter = "text files (*.txt)|*.txt|text files (*.text)|*.text|all files|*.*";

                var result = dlg.ShowDialog();

                string extension = Path.GetExtension(dlg.FileName);
                Console.WriteLine(extension);


                if (result == DialogResult.OK && (extension == ".txt" || extension == ".text"))
                {
                    if(result == DialogResult.OK)
                    {
                        rdr = new StreamReader(dlg.FileName);
                        while (!rdr.EndOfStream)
                        {
                            sentenceList.Add(rdr.ReadLine());
                        }
                    }
                    else
                    {
                        MessageBox.Show("File Open cancelled", "File Open Error");
                    }
                }
                else
                {
                    MessageBox.Show(extension+" is not a valid file extension. Please select a text file.", "File Open Error");
                }


            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }

            return sentenceList;
        }
    }
}
