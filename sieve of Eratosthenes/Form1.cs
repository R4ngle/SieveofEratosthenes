using System.Diagnostics;
using System.Security.Policy;

namespace sieve_of_Eratosthenes
{
    public partial class Form1 : Form
    {
        public int two = 2;
        public int three = 3;

        public Form1()
        {
            InitializeComponent();
            Sol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Sol()
        {
            for (int i = 2; i < 100; i++)
            {
                List<string> list = new List<string>();
                list.Add(i.ToString());
                //  richTextBox1.AppendText(i.ToString());
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    list.Add(i.ToString());
                   // listBox1.Items.Add(list);
                   // listView1.Items.Add(list.ToString());
                    richTextBox1.AppendText("\n" + i.ToString());

                }

                if (i == 100)
                {
                    //listBox1.Items.Add(list);
                   // listView1.Items.Add(list.ToString());
                }

            }
        }
    }
}