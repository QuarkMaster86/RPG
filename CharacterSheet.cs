using System;
using System.Windows.Forms;
using System.Drawing;

namespace Character
{
    public class CharacterSheet : Form
    {
        //character
        public TextBox characterNameText = new TextBox();
        public Label characterNameLabel = new Label();
        //XP
        public TextBox xPText = new TextBox();
        public Label xPLabel = new Label();
        //Level
        public TextBox levelText = new TextBox();
        public Label levelLabel = new Label();
        //Stats
        public Label stats = new Label();
        public Label strengthLabel = new Label();
        public Label dexterityLabel = new Label();
        public Label constitutionLabel = new Label();
        public Label intelligenceLabel = new Label();
        public Label wisdomLabel = new Label();
        public Label charismaLabel = new Label();
        public TextBox strengthText = new TextBox();
        public TextBox dexterityText = new TextBox();
        public TextBox constitutionText = new TextBox();
        public TextBox intelligenceText = new TextBox();
        public TextBox wisdomText = new TextBox();
        public TextBox charismaText = new TextBox();
        public Label strengthModifier = new Label();
        public Label dexterityModifier = new Label();
        public Label constitutionModifier = new Label();
        public Label intelligenceModifier = new Label();
        public Label wisdomModifier = new Label();
        public Label charismaModifier = new Label();
        //Health n' Things
        public Label healthPointsLabel = new Label();
        public Label armourPointsLabel = new Label();
        public Label staminaLabel = new Label();
        public TextBox healthPointsText = new TextBox();
        public TextBox armourPointsText = new TextBox();
        public TextBox staminaText = new TextBox();
        //Races
        public Label races = new Label();
        public RadioButton humanRace = new RadioButton();
        public RadioButton elfRace = new RadioButton();
        public RadioButton Race1 = new RadioButton();
        public RadioButton Race2 = new RadioButton();
        public RadioButton Race3 = new RadioButton();
        public RadioButton Race4 = new RadioButton();
        public RadioButton Race5 = new RadioButton();
        public RadioButton Race6 = new RadioButton();
        //Classes
        public Label classes = new Label();
        public RadioButton Class1 = new RadioButton();
        public RadioButton Class2 = new RadioButton();
        public RadioButton Class3 = new RadioButton();
        public RadioButton Class4 = new RadioButton();
        public RadioButton Class5 = new RadioButton();
        public RadioButton Class6 = new RadioButton();
        public RadioButton Class7 = new RadioButton();
        //Items
        public Label itemsLabel = new Label();
        public RadioButton Item1 = new RadioButton();
        public RadioButton Item2 = new RadioButton();
        public RadioButton Item3 = new RadioButton();
        public RadioButton Item4 = new RadioButton();
        public RadioButton Item5 = new RadioButton();
        public RadioButton Item6 = new RadioButton();
        public RadioButton Item7 = new RadioButton();
        public TextBox itemDescription = new TextBox();
        
        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //Initializes Form
            this.Width = 500;
            this.Height = 500;
            this.Text = "Character Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

            //Creates TextBox and Label
            int interboxDistance = 15;

            //Character Name
            Info(characterNameLabel, interboxDistance, 0, "Character Name");
            Field(characterNameText, interboxDistance, characterNameLabel.Bottom, characterNameLabel.Width, true);
            
            //XP
            Info(xPLabel, characterNameLabel.Right + interboxDistance, 0, "XP");
            Field(xPText, xPLabel.Location.X, xPLabel.Bottom, xPLabel.Width + 16, false);
            xPText.Text = "0";

            //Level
            Info(levelLabel,xPText.Right + interboxDistance, 0, "Level");
            Field(levelText, levelLabel.Location.X, levelLabel.Bottom, levelLabel.Width, false);
            levelText.Text = "10";

            //Stats
            Info(stats, levelLabel.Right + interboxDistance, 0, "Stats");
            Info(strengthLabel, stats.Location.X, stats.Bottom + 3, "Strength");
            Info(dexterityLabel, strengthLabel.Location.X, strengthLabel.Bottom + 3, "Dexterity");
            Info(constitutionLabel, dexterityLabel.Location.X, dexterityLabel.Bottom + 3, "Constitution");
            Info(intelligenceLabel, constitutionLabel.Location.X, constitutionLabel.Bottom + 3, "Intelligence");
            Info(wisdomLabel, intelligenceLabel.Location.X, intelligenceLabel.Bottom + 3, "Wisdom");
            Info(charismaLabel, wisdomLabel.Location.X, wisdomLabel.Bottom + 3, "Charisma");
            Field(strengthText, constitutionLabel.Right + interboxDistance / 3, strengthLabel.Location.Y, 20, false);
            Field(dexterityText, constitutionLabel.Right + interboxDistance / 3, dexterityLabel.Location.Y, 20, false);
            Field(constitutionText, constitutionLabel.Right + interboxDistance / 3, constitutionLabel.Location.Y, 20, false);
            Field(intelligenceText, constitutionLabel.Right + interboxDistance / 3, intelligenceLabel.Location.Y, 20, false);
            Field(wisdomText, constitutionLabel.Right + interboxDistance / 3, wisdomLabel.Location.Y, 20, false);
            Field(charismaText, constitutionLabel.Right + interboxDistance / 3, charismaLabel.Location.Y, 20, false);
            Info(strengthModifier, strengthText.Right + interboxDistance / 2, strengthText.Location.Y, $"( +1 )");
            Info(dexterityModifier, dexterityText.Right + interboxDistance / 2, dexterityText.Location.Y, $"( +1 )");
            Info(constitutionModifier, constitutionText.Right + interboxDistance / 2, constitutionText.Location.Y, $"( +1 )");
            Info(intelligenceModifier, intelligenceText.Right + interboxDistance / 2, intelligenceText.Location.Y, $"( +1 )");
            Info(wisdomModifier, wisdomText.Right + interboxDistance / 2, wisdomText.Location.Y, $"( +1 )");
            Info(charismaModifier, charismaText.Right + interboxDistance / 2, charismaText.Location.Y, $"( +1 )");

            //Health n' things
            Info(healthPointsLabel, charismaLabel.Location.X, charismaLabel.Bottom + 7, "HP");
            Info(armourPointsLabel, healthPointsLabel.Right + (interboxDistance * 3) / 2, healthPointsLabel.Location.Y, "AR");
            Info(staminaLabel, armourPointsLabel.Right + (interboxDistance * 3) / 2, armourPointsLabel.Location.Y, "Stamina");
            Field(healthPointsText, healthPointsLabel.Location.X, healthPointsLabel.Bottom, healthPointsLabel.Width, false);
            Field(armourPointsText, armourPointsLabel.Location.X, armourPointsLabel.Bottom, armourPointsLabel.Width, false);
            Field(staminaText, staminaLabel.Location.X, staminaLabel.Bottom, staminaLabel.Width, false);

            //Races
            Info(races, characterNameText.Location.X, characterNameText.Bottom + 5, "Races");
            RadialButton(humanRace, races.Location.X, races.Bottom, "Human");
            RadialButton(elfRace, humanRace.Location.X, humanRace.Bottom + 8, "Elf");
            RadialButton(Race1, humanRace.Location.X, elfRace.Bottom + 8, "Race1");
            RadialButton(Race3, humanRace.Location.X, Race1.Bottom + 8, "Race2");
            RadialButton(Race2, humanRace.Location.X, Race2.Bottom + 8, "Race3");
            RadialButton(Race4, humanRace.Location.X, Race3.Bottom + 8, "Race4");
            RadialButton(Race5, humanRace.Location.X, Race4.Bottom + 8, "Race5");
            RadialButton(Race6, humanRace.Location.X, Race5.Bottom + 8, "Race6");
            
            //Classes
            Info(classes, races.Location.X + 100, races.Location.Y, "Classes");
            RadialButton(Class1, classes.Location.X, classes.Bottom, "Class1");
            RadialButton(Class2, classes.Location.X, Class1.Bottom + 8, "Class2");
            RadialButton(Class3, classes.Location.X, Class2.Bottom + 8, "Class3");
            RadialButton(Class4, classes.Location.X, Class3.Bottom + 8, "Class4");
            RadialButton(Class5, classes.Location.X, Class4.Bottom + 8, "Class5");
            RadialButton(Class6, classes.Location.X, Class5.Bottom + 8, "Class6");
            RadialButton(Class7, classes.Location.X, Class6.Bottom + 8, "Class7");

            //Items
            Info(itemsLabel, humanRace.Location.X, Race6.Bottom + 8, "Items");
            RectangialButton(Item1, itemsLabel.Location.X, itemsLabel.Bottom, "Item1");
            RectangialButton(Item2, itemsLabel.Location.X, Item1.Bottom, "Item2");
            RectangialButton(Item3, itemsLabel.Location.X, Item2.Bottom, "Item3");
            RectangialButton(Item4, itemsLabel.Location.X, Item3.Bottom, "Item4");
            RectangialButton(Item5, itemsLabel.Location.X, Item4.Bottom, "Item5");
            RectangialButton(Item6, itemsLabel.Location.X, Item5.Bottom, "Item6");
            RectangialButton(Item7, itemsLabel.Location.X, Item6.Bottom, "Item7");

            //Item Description
            itemDescription.Location = new Point(Item1.Right + interboxDistance, Item1.Location.Y);
            itemDescription.Text = "Place Holder";
            itemDescription.Multiline = true;
            itemDescription.ScrollBars = ScrollBars.Vertical;
            itemDescription.WordWrap = true;
            itemDescription.Width = 200;
            itemDescription.Height = Item7.Bottom - Item1.Top;
            itemDescription.ReadOnly = true;
            Controls.Add(itemDescription);
        }

        public void Field(TextBox characterInfo, int x, int y, int size, bool canType)
        {
            //Character Name
            characterInfo.Location = new Point(x, y);
            characterInfo.Text = "";
            characterInfo.Width = size;
            characterInfo.ReadOnly = !canType;
            Controls.Add(characterInfo);
        }

        public void Info(Label characterInfo, int x, int y, string text)
        {
            //Name of the boxes
            characterInfo.Location = new Point(x, y);
            characterInfo.Text = text;
            characterInfo.Width = TextRenderer.MeasureText(text, characterInfo.Font).Width + 2;
            Controls.Add(characterInfo);
        }

        public void RadialButton(RadioButton characterRace, int x, int y, string text)
        {
            characterRace.Location = new Point(x, y + 4);
            characterRace.Size = new Size(10, 10);
            Label characterRaceName = new Label();
            characterRaceName.Text = text;
            characterRaceName.Location = new Point(x + 15, y);
            characterRaceName.AutoSize = true;
            characterRace.AutoSize = true;
            Controls.Add(characterRace);
            Controls.Add(characterRaceName);
        }
        public void RectangialButton(RadioButton itemPlaceHolder, int x, int y, string text)
        {
            itemPlaceHolder.Location = new Point(x, y);
            itemPlaceHolder.Appearance = Appearance.Button;
            itemPlaceHolder.Text = text;
            //itemPlaceHolder.AutoSize = true;
            itemPlaceHolder.Width = levelText.Right - 15;
            Controls.Add(itemPlaceHolder);
        }
    }
}