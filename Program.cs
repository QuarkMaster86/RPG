using System;
using System.Windows.Forms;
using System.Drawing;

Form mainForm = new Form();
Label lblFirst = new Label();
mainForm.Width = 400;
mainForm.Height = 400;
lblFirst.Text = "1";
lblFirst.Location = new Point(100, 200);
mainForm.Controls.Add(lblFirst);
Application.Run(mainForm);
