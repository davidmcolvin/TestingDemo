using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
  public partial class Dashboard : Form
  {
    private BindingList<PersonModel> people;

    public Dashboard()
    {
      InitializeComponent();
      people = new BindingList<PersonModel>(DataAccess.GetAllPeople());
      WireUpUsersComboBox();
    }

    private void WireUpUsersComboBox()
    {
      usersComboBox.DataSource = people;
      usersComboBox.DisplayMember = "FullName";
    }

    private void ResetFirstAndSecondNumber()
    {
      numericUpDown1.Value = 0;
      numericUpDown2.Value = 0;
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      var result = Calculator.Add((double)numericUpDown1.Value,(double)numericUpDown2.Value);
      resultsTextBox.Text = result.ToString();

      ResetFirstAndSecondNumber();
    }

    private void subtractButton_Click(object sender, EventArgs e)
    {
      var result = Calculator.Subtract((double)numericUpDown1.Value, (double)numericUpDown2.Value);
      resultsTextBox.Text = result.ToString();

      ResetFirstAndSecondNumber();
    }

    private void multiplyButton_Click(object sender, EventArgs e)
    {
      var result = Calculator.Multiply((double)numericUpDown1.Value, (double)numericUpDown2.Value);
      resultsTextBox.Text = result.ToString();

      ResetFirstAndSecondNumber();
    }

    private void divideButton_Click(object sender, EventArgs e)
    {
      var result = Calculator.Divide((double)numericUpDown1.Value, (double)numericUpDown2.Value);
      resultsTextBox.Text = result.ToString();

      ResetFirstAndSecondNumber();
    }

    private void createPersonButton_Click(object sender, EventArgs e)
    {
      if (firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0)
      {
        PersonModel person = new PersonModel();

        person.FirstName = firstNameTextBox.Text;
        person.LastName = lastNameTextBox.Text;

        DataAccess.AddNewPerson(person); 
      }

      people = new BindingList<PersonModel>(DataAccess.GetAllPeople());
      WireUpUsersComboBox();

      firstNameTextBox.Text = "";
      lastNameTextBox.Text = "";
    }

  }
}
