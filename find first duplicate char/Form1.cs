using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace find_first_duplicate_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int count=0,firstdup=0;
            int min = 0;
            //Compare the array with itself
            for (int i = 0; i < text.Length; i++)
            {
                count = 0;
                for (int j = i + 1; j < text.Length; j++)
                {
                    //if find similar letters
                    if (text[i] == text[j])
                    {
                        firstdup++;
                        //Calculate the distance between similar letters and choose the least distancetance
                        for (int s = i + 1; s <= j - 1; s++)
                        {
                            count++;

                        }
                    }
                    //Put the first smallest distance in min
                    if (firstdup == 1)
                    {
                        min = count;
                    }
                    //if the next distance is smaller than current distance swap the current distance with next distance and print the letter and break
                    if (count < min)
                    {
                        min = count;
                        label1.Text = Convert.ToString(text[i]);
                        break;
                    }
                }
                      
                       
                    
                }
          

            }

    }
    }

