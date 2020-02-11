/*   LAB # 3   
 *   ‘SEMESTER NAME WINTER 2019
 *   ‘STUDENT’S FIRST NAME Marisa, LAST NAME Wade
 *   ‘I fully understand the following statement. 
 *   ‘OU PLAGIARISM POLICY ‘All members of the academic community at Oakland are expected to practice and uphold 
 *   ‘standards of academic integrity and honesty. An instructor is expected to inform and instruct 
 *   ‘students about the procedures and standards of research and documentation required of students 
 *   ‘in fulfilling course work. A student is expected to follow such instructions and be sure the rules 
 *   ‘and procedures are understood in order to avoid inadvertent misrepresentation of his/her work. 
 *   ‘Students must assume that individual (unaided) work on exams and lab reports and documentation 
 *   ‘of sources is expected unless the instructor specifically says that is not necessary. 
 
‘The following definitions are some examples of academic dishonesty:  
‘Plagiarizing from work of others. Plagiarism is using someone else's work or ideas without 
‘giving the other person credit; by doing this, a student is, in effect, claiming credit for 
‘someone else's thinking. Whether the student has read or heard the information he/she uses, 
‘the student must document the source of information. When dealing with written sources, 
‘a clear distinction would be made between quotations (which reproduce information from 
‘the source word-for-word within quotation marks) and paraphrases (which digest the 
‘source information and produce it in the student's own words). Both direct quotations and 
‘paraphrases must be documented. Just because a student rephrases, condenses or selects 
‘from another person's work, the ideas are still the other person's, and failure to give 
‘credit constitutes misrepresentation of the student's actual work and plagiarism of 
‘another's ideas. Naturally, buying a paper and handing it in as one's own work is 
‘plagiarism.  ‘Cheating on lab reports falsifying data or submitting data not based on student's own work. 
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Marisa_Wade
{
    public partial class frmMain : Form
    {

        int percent;
        double lard;
        double lean;
        double maleUnder;
        double idWeight;
        



        private void grpResults_Enter(object sender, EventArgs e)
        {

        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            lblWaist.Text = "WAIST - Measure at greatest circumfrence; relaxed and comfortable.";
            lblForearm.Text = "FOREARM - Clench fist, measure widest part between wrist and elbow.";
            lblHips.Visible = true;
            lblWrist.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, x5;
            x1 = double.Parse(txtWaist.Text);
            x2 = double.Parse(txtHips.Text);
            x3 = double.Parse(txtForearm.Text);
            x4 = double.Parse(txtWrist.Text);
            x5 = double.Parse(txtWeight.Text);
            


            if (rdoMale.Checked&& rdo30Under.Checked)
              
            {
               
                maleUnder = ((x1 + (0.5 * x2)-(3 * x3)-x4) / 100);

                lard = (x5 * maleUnder);

                lean = (x5 - lard);

                idWeight = (lean / 0.85);

                percent = (15);

            }

            if(rdoMale.Checked&&rdo30Over.Checked)
            {

                maleUnder = ((x1 + (0.5 * x2)-(2.7 * x3)-x4) / 100);

                lard = (x5 * maleUnder);

                lean = (x5 - lard);

                idWeight = (lean / 0.85);

                percent = (15);

            }
           


            if (rdoFemale.Checked&&rdo30Under.Checked)
            {
                maleUnder = ((x2 + (.80 * x3) - (2 * x1) - x4) / 100);

                lard = (x5 * maleUnder);

                lean = (x5 - lard);

                idWeight = (lean / 0.78);

                percent = (22);
            }

            if (rdoFemale.Checked&&rdo30Over.Checked)
            {
                maleUnder = (((x2 + x3) - (2 * x1) - x4) /100);

                lard = (x5 * maleUnder);

                lean = (x5 - lard);

                idWeight = (lean / 0.78);

                percent = (22);
            }


            grpResults.Text = "You have about " + lean.ToString("N0") + " lbs of lean body weight with " + lard.ToString("N0") + " lbs of fat (" + maleUnder.ToString("#.00") + " %). You should weigh no more than " + idWeight.ToString("N0") + " lbs (" + percent + "% fat).";
             


            //You have about xxx lbs of lean body weight with xxx lbs of fat(xx %).  You should weight no more than xxx lbs
            //(15 % fat for males, 22 % fat for females).





        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            lblForearm.Text = "THIGH - Stand with feet 12 inches apart, measure widest part of upper thigh.";
            lblWaist.Text = "CALF - Stand with weight on both feet, widest part midway between knee and ankle.";



        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            rdo30Over.Checked = false;
            rdo30Under.Checked = false;
            txtWaist.Text = "";
            txtForearm.Text = "";
            txtHips.Text = "";
            txtWrist.Text = "";
            txtWeight.Text = "";
            grpResults.Text = "";

        }
    }
    }

