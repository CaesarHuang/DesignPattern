using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPattern.PrototypeDL;

namespace DesignPattern
{
    public partial class Prototype : Form
    {
        public Prototype()
        {
            InitializeComponent();
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Resume userA = new Resume(this.txtName.Text, Convert.ToInt16(this.txtAge.Text));
            userA.SetWorkExperience( Convert.ToInt16(this.txtWorkYear.Text), this.txtCompany.Text); 

            Resume userB = (Resume)userA.Clone();
            userB.SetWorkExperience(Convert.ToInt16(this.txtWorkYear.Text+"0"), this.txtCompany.Text+"B");

            Resume userC = (Resume) userA.Clone();
            userC.SetWorkExperience(Convert.ToInt16(this.txtWorkYear.Text+"00"), this.txtCompany.Text+"C");

            this.txtResult.Text = userA.DisplayResume() + Environment.NewLine + userB.DisplayResume() + Environment.NewLine +
                                  userC.DisplayResume();


        }
    }
}
