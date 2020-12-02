using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programming_Project_3
{
    public partial class Form1 : Form
    {
        String filename;
        List<String> list;
        public Form1()
        {
            InitializeComponent();
            filename = "";
            list = new List<string>();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                filename = openFileDialog1.FileName;
            }
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "") list.Add(line);
                }
            }
        }

        private void lowercaseButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        sw.WriteLine(list[i].ToLower());
                    }
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (filename == "") return;
            list.Sort();

            String longestWord = "";
            String mostVowels = "";
            int currentCount = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(countVowels(list[i]));
                if (currentCount < countVowels(list[i]))
                {
                    mostVowels = list[i];
                }
                if (longestWord.Length < list[i].Length)
                {
                    longestWord = list[i];
                }
            }

            firstTxt.Text = "First word alphabetically: " + list[0];
            lastTxt.Text = "Last word alphabetically: " + list[list.Count - 1];
            longestTxt.Text = "Longest word: " + longestWord;
            vowelsTxt.Text = "Most Vowels: " + mostVowels;
        }
        private int countVowels(String input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
