namespace LAPURA_LA4
{
    partial class MenuPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            panelHeader = new Panel();
            lblHeader = new Label();
            panelForm = new Panel();
            panelActions = new Panel();
            btnCreateStudent = new Button();
            btnCreatePerson = new Button();
            panelStudentFields = new Panel();
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            panelFields = new Panel();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblAge = new Label();
            lblAddress = new Label();
            lblName = new Label();
            panelResults = new Panel();
            lblResults = new Label();
            lstDetails = new ListBox();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelActions.SuspendLayout();
            panelStudentFields.SuspendLayout();
            panelFields.SuspendLayout();
            panelResults.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54))))); // Brown 674636
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 90); // Increased size
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232))))); // Cream FFF8E8
            lblHeader.Location = new Point(30, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(320, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Person Registration";
            // 
            // panelForm
            // 
            panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232))))); // Cream FFF8E8
            panelForm.Controls.Add(panelActions);
            panelForm.Controls.Add(panelStudentFields);
            panelForm.Controls.Add(panelFields);
            panelForm.Controls.Add(panelResults);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 90);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(1000, 610);
            panelForm.TabIndex = 1;
            // 
            // panelActions
            // 
            panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(211))))); // Light beige F7EED3
            panelActions.Controls.Add(btnCreateStudent);
            panelActions.Controls.Add(btnCreatePerson);
            panelActions.Location = new Point(550, 40);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(420, 250);
            panelActions.TabIndex = 9;
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54))))); // Brown 674636
            btnCreateStudent.FlatAppearance.BorderSize = 0;
            btnCreateStudent.FlatStyle = FlatStyle.Flat;
            btnCreateStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232))))); // Cream FFF8E8
            btnCreateStudent.Location = new Point(50, 140);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(320, 55);
            btnCreateStudent.TabIndex = 10;
            btnCreateStudent.Text = "Create Student";
            btnCreateStudent.UseVisualStyleBackColor = false;
            btnCreateStudent.Click += btnCreateStudent_Click;
            // Paint event for gradient and shadow
            btnCreateStudent.Paint += new PaintEventHandler(Button_Paint);
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(179)))), ((int)(((byte)(150))))); // Sage green AAB396
            btnCreatePerson.FlatAppearance.BorderSize = 0;
            btnCreatePerson.FlatStyle = FlatStyle.Flat;
            btnCreatePerson.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232))))); // Cream FFF8E8
            btnCreatePerson.Location = new Point(50, 50);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(320, 55);
            btnCreatePerson.TabIndex = 6;
            btnCreatePerson.Text = "Create Person";
            btnCreatePerson.UseVisualStyleBackColor = false;
            btnCreatePerson.Click += CreatePerson_Click;
            // Paint event for gradient and shadow
            btnCreatePerson.Paint += new PaintEventHandler(Button_Paint);
            // 
            // panelStudentFields
            // 
            panelStudentFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(211))))); // Light beige F7EED3
            panelStudentFields.Controls.Add(txtStudentID);
            panelStudentFields.Controls.Add(lblStudentID);
            panelStudentFields.Location = new Point(30, 230);
            panelStudentFields.Name = "panelStudentFields";
            panelStudentFields.Size = new Size(490, 60);
            panelStudentFields.TabIndex = 8;
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = System.Drawing.Color.White;
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentID.Location = new Point(150, 15);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(320, 37);
            txtStudentID.TabIndex = 9;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54))))); // Brown 674636
            lblStudentID.Location = new Point(15, 17);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(115, 30);
            lblStudentID.TabIndex = 8;
            lblStudentID.Text = "Student ID";
            // 
            // panelFields
            // 
            panelFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(211))))); // Light beige F7EED3
            panelFields.Controls.Add(txtAge);
            panelFields.Controls.Add(txtAddress);
            panelFields.Controls.Add(txtName);
            panelFields.Controls.Add(lblAge);
            panelFields.Controls.Add(lblAddress);
            panelFields.Controls.Add(lblName);
            panelFields.Location = new Point(30, 40);
            panelFields.Name = "panelFields";
            panelFields.Size = new Size(490, 175);
            panelFields.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.BackColor = System.Drawing.Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(150, 75);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 37);
            txtAge.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = System.Drawing.Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(150, 125);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(320, 37);
            txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(150, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 37);
            txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54))))); // Brown 674636
            lblAge.Location = new Point(15, 77);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(54, 30);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54))))); // Brown 674636
            lblAddress.Location = new Point(15, 127);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(90, 30);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(54))))); // Brown 674636
            lblName.Location = new Point(15, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // panelResults
            // 
            panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(179)))), ((int)(((byte)(150))))); // Sage green AAB396
            panelResults.Controls.Add(lblResults);
            panelResults.Controls.Add(lstDetails);
            panelResults.Location = new Point(30, 310);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(940, 270);
            panelResults.TabIndex = 6;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(232))))); // Cream FFF8E8
            lblResults.Location = new Point(15, 15);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(168, 32);
            lblResults.TabIndex = 8;
            lblResults.Text = "Person Details";
            // 
            // lstDetails
            // 
            lstDetails.BackColor = System.Drawing.Color.White;
            lstDetails.BorderStyle = BorderStyle.FixedSingle;
            lstDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lstDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            lstDetails.FormattingEnabled = true;
            lstDetails.ItemHeight = 30;
            lstDetails.Location = new Point(15, 55);
            lstDetails.Name = "lstDetails";
            lstDetails.Size = new Size(910, 200);
            lstDetails.TabIndex = 7;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700); // Increased size
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle; // Fixed border
            MaximizeBox = false; // Prevent maximizing
            Name = "MenuPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Registration System";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelStudentFields.ResumeLayout(false);
            panelStudentFields.PerformLayout();
            panelFields.ResumeLayout(false);
            panelFields.PerformLayout();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelForm;
        private Panel panelResults;
        private Panel panelFields;
        private Panel panelStudentFields;
        private Panel panelActions;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lblAge;
        private Label lblAddress;
        private Label lblName;
        private Button btnCreateStudent;
        private TextBox txtStudentID;
        private Label lblStudentID;
        private ListBox lstDetails;
        private Button btnCreatePerson;
        private Label lblResults;

        // Add custom paint handler for button shadows and gradients
        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Create rounded rectangle for the button
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddRoundedRectangle(new Rectangle(0, 0, btn.Width, btn.Height), 10);
            btn.Region = new Region(path);

            // Create gradient brush based on button background color
            Color baseColor = btn.BackColor;
            Color lighterColor = ControlPaint.Light(baseColor, 0.3f);
            Color darkerColor = ControlPaint.Dark(baseColor, 0.3f);

            // Create gradient with natural earthy tones
            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, btn.Height),
                    lighterColor,
                    darkerColor);

            e.Graphics.FillPath(gradientBrush, path);

            // Draw text
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(btn.Text, btn.Font, new SolidBrush(btn.ForeColor),
                new RectangleF(0, 0, btn.Width, btn.Height), sf);

            // Add shadow effects for depth
            Rectangle shadowRect = new Rectangle(3, 3, btn.Width - 6, btn.Height - 6);
            e.Graphics.DrawRoundedRectangle(new Pen(Color.FromArgb(40, Color.FromArgb(103, 70, 54)), 1), shadowRect, 10);

            // Add bottom highlight for 3D effect
            Rectangle highlightRect = new Rectangle(0, btn.Height - 3, btn.Width, 2);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), highlightRect);
        }
    }

    // Extension methods for rounded rectangles
    public static class GraphicsExtensions
    {
        public static void AddRoundedRectangle(this System.Drawing.Drawing2D.GraphicsPath path, Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            // Top left arc
            path.AddArc(arc, 180, 90);

            // Top right arc
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle rect, int radius)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddRoundedRectangle(rect, radius);
                graphics.DrawPath(pen, path);
            }
        }
    }
}