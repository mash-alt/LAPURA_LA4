namespace LAPURA_LA4
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void CreatePerson_Click(object sender, EventArgs e)
        {
            try
            {
               
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string address = txtAddress.Text;

                Person newPerson = new Person(name, age, address);

    
                lstDetails.Items.Add(newPerson.GetDetails());

             
            }
            catch (FormatException)
            {
                // Handle case where age is not a valid integer
                MessageBox.Show("Please enter a valid number for Age.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string address = txtAddress.Text;
                string studentID = txtStudentID.Text;

                // Validate student ID is not empty
                if (string.IsNullOrWhiteSpace(studentID))
                {
                    MessageBox.Show("Please enter a Student ID.", "Input Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Student newStudent = new Student(name, age, address, studentID);

                lstDetails.Items.Add(newStudent.GetStudentDetails());

            }
            catch (FormatException)
            {
                // Handle case where age is not a valid integer
                MessageBox.Show("Please enter a valid number for Age.", "Input Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
