using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            string methodName = "HelloMsg";
            var typeString = "FormUI.DataAccess";
            Type t = Type.GetType(typeString);
            MethodInfo mi = t.GetMethod(methodName);

            DataAccess daccess = new DataAccess();
            string results = "";
            if (mi != null)
            {
                results = (string)mi.Invoke(daccess, null);
            }


            DataAccess db = new DataAccess();

            db.TestSQL_IN_Clause();
            people = db.GetPeople(lastNametextBox.Text);
            Person person = new Person();
            person.FirstName = results;
            person.LastName = "Reflection Test";
            person.EmailAddress = "test@test.com";
            people.Add(person);
            UpdateBinding();
        }

        public void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(firstNameAddtextBox.Text, lastNameAddtextBox.Text, EmailAddtextBox.Text, PhoneNumAddtextBox.Text);

            firstNameAddtextBox.Text = "";
            lastNameAddtextBox.Text = "";
            EmailAddtextBox.Text = "";
            PhoneNumAddtextBox.Text = "";
        }
    }
}
