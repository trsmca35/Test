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
using System.Threading;

namespace AsyncAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Data\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            System.IO.File.OpenRead("");
            return count;
        }
        //tttsatdysa
        /**/
        /// <summary>
        /// This is btn Process Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblCount.Text = "Processing File.Please wait..";
            //int count = await task;
             Console.WriteLine(await task);
            //lblCount.Text = count.ToString() + " Characters in File";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
