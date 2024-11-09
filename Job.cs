namespace Classes
{
    public class Job
    {
        public string Name { get; }
        public int HP { get; }
        public int ATK { get; }
        public int Speed { get; }


        public Job(string name, int hp, int atk, int speed)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            Speed = speed;
        }
    }
}

/*
using System;
using System.Windows.Forms;
using System.Drawing;

Form mainForm = new Form();
mainForm.Width = 400;
mainForm.Height = 400;
Label characterName = new Label()
{
    Text = "Character Name",
    Location = new Point(10, 10),
    TabIndex = 10
};

TextBox characterField = new TextBox()
{
    Location = new Point(characterName.Location.X, characterName.Bounds.Bottom + mainForm.Padding.Top),
    TabIndex = 5,
    Text = "hello",
    ReadOnly = true
};

mainForm.Controls.Add(characterField);
mainForm.Controls.Add(characterName);
Application.Run(mainForm);
*/