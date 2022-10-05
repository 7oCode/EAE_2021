using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOTD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string tboxage = tbox1.Text;

            string[] L1 = new string[5] { "Computer", "Laptop", "Desktop", "Keyboard", "Mouse" };
            string[] mL1 = new string[5]
            {
                "An electronic device that can store, retrieve, and process data.", 
                "A portable computer with a built-in screen and keyboard, small enough to rest on the user's lap.", 
                "A full-sized computer used on/near a desk, connected to a monitor, mouse and keyboard.", 
                "Where all the letters, numbers and other buttons are located. When typed on, symbols appear on the monitor", 
                "A device moved with your hand, which then moves the cursor on the screen."};


            string[] L2 = new string[5] { "Virus", "Homepage", "Interface", "Software", "Spam" };
            string[] mL2 = new string[5]
            {
                "A computer program that is usually disguised as a harmless program of file, that produces copies of itself and inserts them into other programs that when run usually performs a malicious action(e.g destroying data),",
                "The page typically encountered first on a website containing links to other pages of the site.",
                "A point of interaction between a computer system and a user.",
                "Written programs for a computer designed to do different things(e.g Microsoft Word, Zoom)",
                "Unwanted messages(email/text/internet posts) sent to a large number of users or posted in a large number of places."};

            string[] L3 = new string[5] { "Gigabyte", "Server", "Backup", "Domain", "Malware" };
            string[] mL3 = new string[5]
            {
                "A unit of information equal to 1000 megabytes or 10^9 bytes.",
                "A computer in a network that is used to provide services(e.g access to files/routing of email) to other computers in the network.",
                "A copy of a file or directory on a separate storage device.(e.g USB Drive)",
                "Domain names serve to identify Internet resources, such as computers, networks, and services, with an easy to remember text-based label.",
                "Software intended to damage a computer, mobile device or network. It interferes with a computer's normal functioning and may even take partial control of its operation."};

            string[] L4 = new string[5] { "Database", "Algorithm", "Firewall", "Binary", "Mainframe"};
            string[] mL4 = new string[5]
            {
                "A database is an organized collection of data stored electronically(e.g hard disk in server) and accessed by end users to view and edit.",
                "An algorithm is a procedure or formula for solving a problem, based on conducting a sequence of specified actions.",
                "A security device(hardware(Router)/software(Avast) that can help protect a network by filtering traffic and blocking unauthorized access to private data.",
                "The numbering scheme where there are only two possible values for each digit: 0 and 1. A single binary digit is the smallest unit of data on a computer.",
                "Known for its large size, mainframes are primarily used for mission-critical applications requiring high volumes of data processing. A single mainframe can replace dozens or even hundreds of smaller servers."
            };


            Random n = new Random();
            int num = n.Next(0, 5);

            if (String.IsNullOrEmpty(tbox1.Text)||String.IsNullOrWhiteSpace(tbox1.Text))
            {
                MessageBox.Show("Please input a number!");
            }
            else try
            {
                    int age = Int32.Parse(tboxage);            
                     if (age == 0 || age < 0)
                     {
                        MessageBox.Show("Are you sure about that?");
                        wotd.Text = " ";
                     }
                     else if(age > 0 && age <= 6)
                     {
                        wotd.Text = L1[num];
                        wmeaning.Text = mL1[num];

                     }
                     else if(age >= 7 && age <= 12)
                     {
                        wotd.Text = L2[num];
                        wmeaning.Text = mL2[num];
                     }
                     else if(age >=13 && age <= 19)
                     {
                        wotd.Text = L3[num];
                        wmeaning.Text = mL3[num];
                     }
                     else if(age >= 20 && age <= 85)
                     {
                        wotd.Text = L4[num];
                        wmeaning.Text = mL4[num];
                     }
                     else
                     {
                        MessageBox.Show("Are you really that old?");
                        wotd.Text = " ";
                     }
            }
            catch(System.FormatException)
                {
                    MessageBox.Show("Numbers only!");
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    /*Sources: 
    Google
    Wikipedia
    https://www.merriam-webster.com/
    https://www.dictionary.com/
    https://www.vocabulary.com/lists/1508422
    https://grammar.yourdictionary.com/word-lists/computer-terms-for-children.html
    https://whatis.techtarget.com/definition/binary
    Paraphrasing
    */
}
