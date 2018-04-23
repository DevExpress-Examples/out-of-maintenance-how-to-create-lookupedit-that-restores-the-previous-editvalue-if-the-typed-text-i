using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList myUsers;
        private void Form1_Load(object sender, EventArgs e)
        {
            myUsers = new ArrayList();
            myUsers.Add(new User("Albert", 17));
            myUsers.Add(new User("Bill", 21));
            myUsers.Add(new User("Charli", 34));
            myUsers.Add(new User("Billy", 7));
            myUsers.Add(new User("Chen", 56));
            customLookUpEdit1.Properties.DataSource = myUsers;
            customLookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            customLookUpEdit1.Properties.DisplayMember = "Name";
            customLookUpEdit1.Properties.ValueMember = "Name";
        }
        public class User
        {
            string name;
            int age;
            public User(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public string Name
            { get { return name; } }
            public int Age
            { get { return age; } }
        }
    }
}