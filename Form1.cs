using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgpa
{
    public partial class Form1 : Form
    {
        double r1, r2, r3, r4, r5, r6,fres,ans;
        double[] r= new double[6];
        double[] fr = new double[6];
        int ce;
        int[] cre= new int [6];


        public Form1()
        {
            r1 = r2 = r3 = r4 = r5 = r6 = 0;
            r[0] = r[1] = r[2] = r[3] = r[4] = r[5] = 0;
            fr[0] = fr[1] = fr[2] = fr[3] = fr[4] = fr[5] = 0;
            cre[0] = cre[1] = cre[2] = cre[3] = cre[4] = cre[5] = 0;
            ce = 0;
            fres = 0;
            ans = 0;
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello\nI am Mujtaba Asif\nThanks for using my software.", "Greetings",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void scgpa_Click(object sender, EventArgs e)
        {
            int i;
            string d;
            fres = 0;
            ce = 0;
            for(i=0;i<6;i++)
            {
                fres += r[i];
                ce += cre[i];
            }
            ans = fres / ce;
            d = string.Format("{0:F2}", ans);
            if (d == "NaN") textBox8.Text = "";
            else textBox8.Text = d;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r1 = r2 = r3 = r4 = r5 = r6 = 0;
            r[0] = r[1] = r[2] = r[3] = r[4] = r[5] = 0;
            ce = 0;
            fres = 0;
            ans = 0;
            textBox1.Text= textBox2.Text = textBox3.Text= textBox4.Text = textBox5.Text= textBox6.Text= textBox7.Text= textBox8.Text="";
            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = comboBox5.Text = comboBox6.Text = comboBox7.Text = comboBox8.Text = comboBox9.Text = comboBox10.Text = comboBox11.Text = comboBox12.Text=cgin.Text=crin.Text="";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgpa_Click(object sender, EventArgs e)
        {
            double cgpa,cg,nm;
            int c;
            int i;
            string d;
            c = 0;
            cgpa = 0;
            cg = 0;
            nm = 0;
            if (cgin.Text == "") cg = 0;
            else
            {
                cg = double.Parse(cgin.Text, System.Globalization.CultureInfo.InvariantCulture);
            }

            if (crin.Text == "") c = 0;
            else
            {
                c = int.Parse(crin.Text);
            }
            //c = int.Parse(crin.Text);
            nm = 1.00 * (ce + c);
            ce = 0;  fres = 0;
            for (i = 0; i < 6; i++)
            {
                fres += r[i];
                ce += cre[i];
            }
            ans = fres / ce;
            cgpa = ((c * cg) + (ans * ce)) / nm;
            d= string.Format("{0:F2}", cgpa);
            if (d == "NaN") textBox7.Text = "";
            else textBox7.Text = d;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            double y, p;
            string a, b;
            a = comboBox1.Text;
            b = comboBox2.Text;
            if (b == "A+") y = 4;
            else if (b == "A") y = 4;
            else if (b == "A-") y = 3.7;
            else if (b == "B+") y = 3.3;
            else if (b == "B") y = 3;
            else if (b == "B-") y = 2.7;
            else if (b == "C+") y = 2.3;
            else if (b == "C") y = 2;
            else if (b == "C-") y = 1.7;
            else if (b == "D+") y = 1.3;
            else if (b == "D") y = 1;
            else y = 0;
            if (a == "") x = 0;
            else x = int.Parse(a);
            r1 = p = x * y;
            r[0] = r1;
            textBox1.Text = string.Format("{0:F2}", p);
            ce += x;
            cre[0] = x;
            fres += r1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            double y,p;
            string a, b;
            a = comboBox3.Text;
            b = comboBox4.Text;
            if (b == "A+") y = 4;
            else if (b == "A") y = 4;
            else if (b == "A-") y = 3.7;
            else if (b == "B+") y = 3.3;
            else if (b == "B") y = 3;
            else if (b == "B-") y = 2.7;
            else if (b == "C+") y = 2.3;
            else if (b == "C") y = 2;
            else if (b == "C-") y = 1.7;
            else if (b == "D+") y = 1.3;
            else if (b == "D") y = 1;
            else y = 0;
            if (a == "") x = 0;
            else x = int.Parse(a);
            r2 =p = x*y;
            r[1] = r2;
            textBox2.Text  = string.Format("{0:F2}", p);
            ce+=x;
            cre[1] = x;
            fres += r2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            double y, p;
            string a, b;
            a = comboBox5.Text;
            b = comboBox6.Text;
            if (b == "A+") y = 4;
            else if (b == "A") y = 4;
            else if (b == "A-") y = 3.7;
            else if (b == "B+") y = 3.3;
            else if (b == "B") y = 3;
            else if (b == "B-") y = 2.7;
            else if (b == "C+") y = 2.3;
            else if (b == "C") y = 2;
            else if (b == "C-") y = 1.7;
            else if (b == "D+") y = 1.3;
            else if (b == "D") y = 1;
            else y = 0;
            if (a == "") x = 0;
            else x = int.Parse(a);
            r3 = p = x * y;
            r[2] = r3;
            textBox3.Text = string.Format("{0:F2}", p);
            ce+=x;
            cre[2] = x;
            fres += r3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            double y, p;
            string a, b;
            a = comboBox7.Text;
            b = comboBox8.Text;
            if (b == "A+") y = 4;
            else if (b == "A") y = 4;
            else if (b == "A-") y = 3.7;
            else if (b == "B+") y = 3.3;
            else if (b == "B") y = 3;
            else if (b == "B-") y = 2.7;
            else if (b == "C+") y = 2.3;
            else if (b == "C") y = 2;
            else if (b == "C-") y = 1.7;
            else if (b == "D+") y = 1.3;
            else if (b == "D") y = 1;
            else y = 0;
            if (a == "") x = 0;
            else x = int.Parse(a);
            r4 = p = x * y;
            r[3] = r4;
            textBox4.Text = string.Format("{0:F2}", p);
            ce+=x;
            cre[3] = x;
            fres += r4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int x;
            double y, p;
            string a, b;
            a = comboBox9.Text;
            b = comboBox10.Text;
            if (b == "A+") y = 4;
            else if (b == "A") y = 4;
            else if (b == "A-") y = 3.7;
            else if (b == "B+") y = 3.3;
            else if (b == "B") y = 3;
            else if (b == "B-") y = 2.7;
            else if (b == "C+") y = 2.3;
            else if (b == "C") y = 2;
            else if (b == "C-") y = 1.7;
            else if (b == "D+") y = 1.3;
            else if (b == "D") y = 1;
            else y = 0;
            if (a == "") x = 0;
            else x = int.Parse(a);
            r5 = p = x * y;
            r[4] = r5;
            textBox5.Text = string.Format("{0:F2}", p);
            ce+=x;
            cre[4] = x;
            fres += r5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int x;
            double y, p;
            string a, b;
            a = comboBox11.Text;
            b = comboBox12.Text;
            if (b == "A+") y = 4;
            else if (b == "A") y = 4;
            else if (b == "A-") y = 3.7;
            else if (b == "B+") y = 3.3;
            else if (b == "B") y = 3;
            else if (b == "B-") y = 2.7;
            else if (b == "C+") y = 2.3;
            else if (b == "C") y = 2;
            else if (b == "C-") y = 1.7;
            else if (b == "D+") y = 1.3;
            else if (b == "D") y = 1;
            else y = 0;
            if (a == "") x = 0;
            else x = int.Parse(a);
            r6 = p = x * y;
            r[5] = r6;
            textBox6.Text = string.Format("{0:F2}", p);
            ce+=x;
            cre[5] = x;
            fres += r6;
        }
    }
}
