using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
       
    }
}

//I don't know which kind of 'Control' you need. However in multiple forms environment, communication between forms is trivial. There are many ways to do communicate, like one can be as

//Create public properties of type Form in your Parent form,

//public Form propForm1 { get; set; }
//When on menu item click you open form1, store it's object to that public property.

//var form1 = New yourchildformname();
//form1.MdiParent = this;
//propForm1 = form1; // Add this line.
//form1.Show();
//Now every time when you will click an other button to open the form2, you will have propForm1 object, which you can use to set some data on that form.

//EDIT: On form2, you can access controls of form1 as

//private void button1_Click(object sender, EventArgs e)
//{
//    this.parent.propForm1.txtUserName = "Yokohama";
//}
//Remember the above code is on form2. Also set 'access modifier' property of txtUserName from private to public.