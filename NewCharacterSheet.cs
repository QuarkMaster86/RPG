using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace CharacterSheet
{
    public partial class NewCharacterSheet : Form
    {
        public int characterPanelHeight = 64;
        public int statsPanelWidth = 200;
        public int racePanelWidth = 400;
        public int classPanelWidth = 400;
        public int itemsPanelHeight = 230;
        public NewCharacterSheet()
        {
            InitializeComponent();

            racePanel();
            classPanel();
            characterPanel();
            ItemsPanel();
            statsPanel();
        }
        public void characterPanel()
        {
            Panel p_characterPanel = new Panel();
            TextBox CharacterNameText = new TextBox();
            Label CharacterNameLabel = new Label();
            Label XPLabel = new Label();
            TextBox XPText = new TextBox();
            Label LevelLabel = new Label();
            TextBox LevelText = new TextBox();

            //p_characterPanel.BorderStyle = BorderStyle.Fixed3D;
            p_characterPanel.Dock = DockStyle.Top;
            p_characterPanel.Height = characterPanelHeight;

            CharacterNameLabel.Text = "Character Name";
            CharacterNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            CharacterNameLabel.AutoSize = true;

            CharacterNameText.Location = new Point(CharacterNameLabel.Location.X + 2, CharacterNameLabel.Bottom);
            CharacterNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            LevelLabel.Text = "Level";
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(ClientSize.Width - 40, 0);
            LevelLabel.Anchor = AnchorStyles.Right;

            LevelText.Location = new Point(LevelLabel.Location.X, LevelLabel.Bottom);
            LevelText.ReadOnly = true;
            LevelText.BackColor = Color.White;
            LevelText.Width = 35;
            LevelText.Anchor = AnchorStyles.Right;

            XPLabel.Text = "XP    ";
            XPLabel.Location = new Point(ClientSize.Width / 2, 0);
            XPLabel.Anchor = AnchorStyles.Top;
            XPLabel.AutoSize = true;

            XPText.Location = new Point(XPLabel.Location.X, XPLabel.Bottom);
            XPText.Anchor = AnchorStyles.Top;
            XPText.ReadOnly = true;
            XPText.BackColor = Color.White;
            XPText.Width = 35;


            this.Controls.Add(p_characterPanel);
            p_characterPanel.Controls.Add(CharacterNameLabel);
            p_characterPanel.Controls.Add(CharacterNameText);
            p_characterPanel.Controls.Add(XPLabel);
            p_characterPanel.Controls.Add(XPText);
            p_characterPanel.Controls.Add(LevelLabel);
            p_characterPanel.Controls.Add(LevelText);
        }

        public void statsPanel()
        {
            Panel p_statsPanel = new Panel();
            Label StatsLabel = new Label();
            Label StrengthLabel = new Label();
            Label DexterityLabel = new Label();
            Label ConstitutionLabel = new Label();
            Label IntelligenceLabel = new Label();
            Label WisdomLabel = new Label();
            Label CharismaLabel = new Label();
            TextBox StrengthText = new TextBox();
            TextBox DexterityText = new TextBox();
            TextBox ConstitutionText = new TextBox();
            TextBox IntelligenceText = new TextBox();
            TextBox WisdomText = new TextBox();
            TextBox CharismaText = new TextBox();

            //p_statsPanel.BorderStyle = BorderStyle.Fixed3D;
            p_statsPanel.Dock = DockStyle.Right;

            StatsLabel.Text = "Stats";
            StatsLabel.AutoSize = true;
            StatsLabel.Location = new Point((p_statsPanel.Width - StatsLabel.Width) / 4, 0);

            StrengthLabel.Text = "Strength";
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point((p_statsPanel.Width - StrengthLabel.Width) / 4, (ClientSize.Height - StrengthLabel.Height) / 6);
            StrengthLabel.Anchor = AnchorStyles.Left;

            DexterityLabel.Text = "Dexterity";
            DexterityLabel.AutoSize = true;
            DexterityLabel.Location = new Point((p_statsPanel.Width - DexterityLabel.Width) / 4, (ClientSize.Height - DexterityLabel.Height) * 2 / 6);
            DexterityLabel.Anchor = AnchorStyles.Left;

            ConstitutionLabel.Text = "Constitution";
            ConstitutionLabel.AutoSize = true;
            ConstitutionLabel.Location = new Point((p_statsPanel.Width - ConstitutionLabel.Width) / 4, (ClientSize.Height - ConstitutionLabel.Height) * 3 / 6);
            ConstitutionLabel.Anchor = AnchorStyles.Left;

            IntelligenceLabel.Text = "Intelligence";
            IntelligenceLabel.AutoSize = true;
            IntelligenceLabel.Location = new Point((p_statsPanel.Width - IntelligenceLabel.Width) / 4, (ClientSize.Height - IntelligenceLabel.Height) * 4 / 6);
            IntelligenceLabel.Anchor = AnchorStyles.Left;

            WisdomLabel.Text = "Wisdom";
            WisdomLabel.AutoSize = true;
            WisdomLabel.Location = new Point((p_statsPanel.Width - WisdomLabel.Width) / 4, (ClientSize.Height - WisdomLabel.Height) * 5 / 6);
            WisdomLabel.Anchor = AnchorStyles.Left;

            CharismaLabel.Text = "Charisma";
            CharismaLabel.AutoSize = true;
            CharismaLabel.Location = new Point((p_statsPanel.Width - CharismaLabel.Width) / 4, ClientSize.Height - CharismaLabel.Height - 5);
            CharismaLabel.Anchor = AnchorStyles.Left;

            StrengthText.Text = "0";
            StrengthText.Width = 20;
            StrengthText.Location = new Point(StrengthLabel.Right, StrengthLabel.Location.Y);
            StrengthText.ReadOnly = true;
            StrengthText.BackColor = Color.White;
            StrengthText.Anchor = AnchorStyles.Left;

            DexterityText.Text = "0";
            DexterityText.Width = 20;
            DexterityText.Location = new Point(DexterityLabel.Right, DexterityLabel.Location.Y);
            DexterityText.ReadOnly = true;
            DexterityText.BackColor = Color.White;
            DexterityText.Anchor = AnchorStyles.Left;

            ConstitutionText.Text = "0";
            ConstitutionText.Width = 20;
            ConstitutionText.Location = new Point(ConstitutionLabel.Right, ConstitutionLabel.Location.Y);
            ConstitutionText.ReadOnly = true;
            ConstitutionText.BackColor = Color.White;
            ConstitutionText.Anchor = AnchorStyles.Left;

            IntelligenceText.Text = "0";
            IntelligenceText.Width = 20;
            IntelligenceText.Location = new Point(IntelligenceLabel.Right, IntelligenceLabel.Location.Y);
            IntelligenceText.ReadOnly = true;
            IntelligenceText.BackColor = Color.White;
            IntelligenceText.Anchor = AnchorStyles.Left;

            WisdomText.Text = "0";
            WisdomText.Width = 20;
            WisdomText.Location = new Point(WisdomLabel.Right, WisdomLabel.Location.Y);
            WisdomText.ReadOnly = true;
            WisdomText.BackColor = Color.White;
            WisdomText.Anchor = AnchorStyles.Left;

            CharismaText.Text = "0";
            CharismaText.Width = 20;
            CharismaText.Location = new Point(CharismaLabel.Right, CharismaLabel.Location.Y - 2);
            CharismaText.ReadOnly = true;
            CharismaText.BackColor = Color.White;
            CharismaText.Anchor = AnchorStyles.Left;

            this.Controls.Add(p_statsPanel);
            p_statsPanel.Controls.Add(StatsLabel);
            p_statsPanel.Controls.Add(StrengthLabel);
            p_statsPanel.Controls.Add(DexterityLabel);
            p_statsPanel.Controls.Add(ConstitutionLabel);
            p_statsPanel.Controls.Add(IntelligenceLabel);
            p_statsPanel.Controls.Add(WisdomLabel);
            p_statsPanel.Controls.Add(CharismaLabel);
            p_statsPanel.Controls.Add(StrengthText);
            p_statsPanel.Controls.Add(DexterityText);
            p_statsPanel.Controls.Add(ConstitutionText);
            p_statsPanel.Controls.Add(IntelligenceText);
            p_statsPanel.Controls.Add(WisdomText);
            p_statsPanel.Controls.Add(CharismaText);

        }

        public void racePanel()
        {
            Panel p_racePanel = new Panel();

            p_racePanel.Dock = DockStyle.Left;
            //p_racePanel.BorderStyle = BorderStyle.Fixed3D;
            p_racePanel.Width = racePanelWidth;

            Label RaceLabel = new Label();
            RaceLabel.Location = new Point(20, 150);
            RaceLabel.Text = "Race";
            RaceLabel.AutoSize = true;
            RaceLabel.Anchor = AnchorStyles.Left;

            RadioButton Human = new RadioButton();
            Human.Location = new Point(RaceLabel.Location.X + 5, RaceLabel.Bottom);
            Human.Text = "Human";
            Human.AutoSize = true;
            Human.Anchor = AnchorStyles.Left;

            RadioButton Elf = new RadioButton();
            Elf.Location = new Point(RaceLabel.Location.X + 5, Human.Bottom);
            Elf.Text = "Elf";
            Elf.AutoSize = true;
            Elf.Anchor = AnchorStyles.Left;

            RadioButton UndeadTurkey = new RadioButton();
            UndeadTurkey.Location = new Point(RaceLabel.Location.X + 5, Elf.Bottom);
            UndeadTurkey.Text = "Undead Turkey";
            UndeadTurkey.AutoSize = true;
            UndeadTurkey.Anchor = AnchorStyles.Left;

            RadioButton LivingLollipop = new RadioButton();
            LivingLollipop.Location = new Point(RaceLabel.Location.X + 5, UndeadTurkey.Bottom);
            LivingLollipop.Text = "Living Lollipop";
            LivingLollipop.AutoSize = true;
            LivingLollipop.Anchor = AnchorStyles.Left;

            RadioButton PetRock = new RadioButton();
            PetRock.Location = new Point(RaceLabel.Location.X + 5, LivingLollipop.Bottom);
            PetRock.Text = "Pet Rock";
            PetRock.AutoSize = true;
            PetRock.Anchor = AnchorStyles.Left;

            RadioButton BillMurry = new RadioButton();
            BillMurry.Location = new Point(RaceLabel.Location.X + 5, PetRock.Bottom);
            BillMurry.Text = "Bill Murry";
            BillMurry.AutoSize = true;
            BillMurry.Anchor = AnchorStyles.Left;

            RadioButton Jedi = new RadioButton();
            Jedi.Location = new Point(RaceLabel.Location.X + 5, BillMurry.Bottom);
            Jedi.Text = "Jedi";
            Jedi.AutoSize = true;
            Jedi.Anchor = AnchorStyles.Left;

            RadioButton IAmSteve = new RadioButton();
            IAmSteve.Location = new Point(RaceLabel.Location.X + 5, Jedi.Bottom);
            IAmSteve.Text = "I... Am Steve!";
            IAmSteve.AutoSize = true;
            IAmSteve.Anchor = AnchorStyles.Left;

            RadioButton Hectorthewellendowed = new RadioButton();
            Hectorthewellendowed.Location = new Point(RaceLabel.Location.X + 150, RaceLabel.Location.Y);
            Hectorthewellendowed.Text = "Hector The Well Endowed";
            Hectorthewellendowed.AutoSize = true;
            Hectorthewellendowed.Anchor = AnchorStyles.Left;

            RadioButton Dunkel = new RadioButton();
            Dunkel.Location = new Point(RaceLabel.Location.X + 150, Hectorthewellendowed.Bottom);
            Dunkel.Text = "Dunkel";
            Dunkel.AutoSize = true;
            Dunkel.Anchor = AnchorStyles.Left;

            RadioButton DaisyofUnknownOrigin = new RadioButton();
            DaisyofUnknownOrigin.Location = new Point(RaceLabel.Location.X + 150, Dunkel.Bottom);
            DaisyofUnknownOrigin.Text = "Daisy of Unknown Origin";
            DaisyofUnknownOrigin.AutoSize = true;
            DaisyofUnknownOrigin.Anchor = AnchorStyles.Left;

            RadioButton Damrod = new RadioButton();
            Damrod.Location = new Point(RaceLabel.Location.X + 150, DaisyofUnknownOrigin.Bottom);
            Damrod.Text = "Damrod the Troll";
            Damrod.AutoSize = true;
            Damrod.Anchor = AnchorStyles.Left;

            RadioButton Yams = new RadioButton();
            Yams.Location = new Point(RaceLabel.Location.X + 150, Damrod.Bottom);
            Yams.Text = "Yams";
            Yams.AutoSize = true;
            Yams.Anchor = AnchorStyles.Left;

            RadioButton Vortigaunt = new RadioButton();
            Vortigaunt.Location = new Point(RaceLabel.Location.X + 150, Yams.Bottom);
            Vortigaunt.Text = "Vortigaunt";
            Vortigaunt.AutoSize = true;
            Vortigaunt.Anchor = AnchorStyles.Left;

            RadioButton HeadCrab = new RadioButton();
            HeadCrab.Location = new Point(RaceLabel.Location.X + 150, Vortigaunt.Bottom);
            HeadCrab.Text = "Headcrab";
            HeadCrab.AutoSize = true;
            HeadCrab.Anchor = AnchorStyles.Left;

            RadioButton CthulhusEye = new RadioButton();
            CthulhusEye.Location = new Point(RaceLabel.Location.X + 150, HeadCrab.Bottom);
            CthulhusEye.Text = "The Eye of Cthulhu";
            CthulhusEye.AutoSize = true;
            CthulhusEye.Anchor = AnchorStyles.Left;

            RadioButton MarshmellowPeople = new RadioButton();
            MarshmellowPeople.Location = new Point(RaceLabel.Location.X + 150, CthulhusEye.Bottom);
            MarshmellowPeople.Text = "Marshmellow People";
            MarshmellowPeople.AutoSize = true;
            MarshmellowPeople.Anchor = AnchorStyles.Left;

            this.Controls.Add(p_racePanel);
            p_racePanel.Controls.Add(RaceLabel);
            p_racePanel.Controls.Add(Human);
            p_racePanel.Controls.Add(Elf);
            p_racePanel.Controls.Add(UndeadTurkey);
            p_racePanel.Controls.Add(LivingLollipop);
            p_racePanel.Controls.Add(PetRock);
            p_racePanel.Controls.Add(BillMurry);
            p_racePanel.Controls.Add(Jedi);
            p_racePanel.Controls.Add(IAmSteve);
            p_racePanel.Controls.Add(Hectorthewellendowed);
            p_racePanel.Controls.Add(Dunkel);
            p_racePanel.Controls.Add(DaisyofUnknownOrigin);
            p_racePanel.Controls.Add(Damrod);
            p_racePanel.Controls.Add(Yams);
            p_racePanel.Controls.Add(Vortigaunt);
            p_racePanel.Controls.Add(HeadCrab);
            p_racePanel.Controls.Add(CthulhusEye);
            p_racePanel.Controls.Add(MarshmellowPeople);


        }
        public void classPanel()
        {
            Panel p_classPanel = new Panel();

            p_classPanel.Dock = DockStyle.Fill;
            //p_classPanel.BorderStyle = BorderStyle.Fixed3D;
            p_classPanel.Width = classPanelWidth;


            Label ClassLabel = new Label();
            ClassLabel.Location = new Point(425, 150);
            ClassLabel.Text = "Class";
            ClassLabel.AutoSize = true;
            ClassLabel.Anchor = AnchorStyles.Left;

            RadioButton Rogue = new RadioButton();
            Rogue.Location = new Point(ClassLabel.Location.X + 5, ClassLabel.Bottom);
            Rogue.Text = "Rogue";
            Rogue.AutoSize = true;
            Rogue.Anchor = AnchorStyles.Left;

            RadioButton ReformedSentari = new RadioButton();
            ReformedSentari.Location = new Point(ClassLabel.Location.X + 5, Rogue.Bottom);
            ReformedSentari.Text = "Reformed Sentari";
            ReformedSentari.AutoSize = true;
            ReformedSentari.Anchor = AnchorStyles.Left;

            RadioButton PoultryFaction = new RadioButton();
            PoultryFaction.Location = new Point(ClassLabel.Location.X + 5, ReformedSentari.Bottom);
            PoultryFaction.Text = "Poultry Faction";
            PoultryFaction.AutoSize = true;
            PoultryFaction.Anchor = AnchorStyles.Left;

            RadioButton CandyMakers = new RadioButton();
            CandyMakers.Location = new Point(ClassLabel.Location.X + 5, PoultryFaction.Bottom);
            CandyMakers.Text = "Candy Makers";
            CandyMakers.AutoSize = true;
            CandyMakers.Anchor = AnchorStyles.Left;

            RadioButton BoulderBro = new RadioButton();
            BoulderBro.Location = new Point(ClassLabel.Location.X + 5, CandyMakers.Bottom);
            BoulderBro.Text = "Boulder Bro";
            BoulderBro.AutoSize = true;
            BoulderBro.Anchor = AnchorStyles.Left;

            RadioButton TimeLoopers = new RadioButton();
            TimeLoopers.Location = new Point(ClassLabel.Location.X + 5, BoulderBro.Bottom);
            TimeLoopers.Text = "Time Loopers";
            TimeLoopers.AutoSize = true;
            TimeLoopers.Anchor = AnchorStyles.Left;

            RadioButton Acolyte = new RadioButton();
            Acolyte.Location = new Point(ClassLabel.Location.X + 5, TimeLoopers.Bottom);
            Acolyte.Text = "Acolyte";
            Acolyte.AutoSize = true;
            Acolyte.Anchor = AnchorStyles.Left;

            RadioButton FollowerofJean = new RadioButton();
            FollowerofJean.Location = new Point(ClassLabel.Location.X + 5, Acolyte.Bottom);
            FollowerofJean.Text = "Follower of Jean";
            FollowerofJean.AutoSize = true;
            FollowerofJean.Anchor = AnchorStyles.Left;

            RadioButton TheEye = new RadioButton();
            TheEye.Location = new Point(ClassLabel.Location.X + 160, ClassLabel.Location.Y);
            TheEye.Text = "The Eye";
            TheEye.AutoSize = true;
            TheEye.Anchor = AnchorStyles.Left;

            RadioButton CultofHofbräu = new RadioButton();
            CultofHofbräu.Location = new Point(ClassLabel.Location.X + 160, TheEye.Bottom);
            CultofHofbräu.Text = "Cult of Hofbräu";
            CultofHofbräu.AutoSize = true;
            CultofHofbräu.Anchor = AnchorStyles.Left;

            RadioButton DogBarbarian = new RadioButton();
            DogBarbarian.Location = new Point(ClassLabel.Location.X + 160, CultofHofbräu.Bottom);
            DogBarbarian.Text = "Dog Barbarian";
            DogBarbarian.AutoSize = true;
            DogBarbarian.Anchor = AnchorStyles.Left;

            RadioButton MercenaryofAdar = new RadioButton();
            MercenaryofAdar.Location = new Point(ClassLabel.Location.X + 160, DogBarbarian.Bottom);
            MercenaryofAdar.Text = "Mercenary of Adar";
            MercenaryofAdar.AutoSize = true;
            MercenaryofAdar.Anchor = AnchorStyles.Left;

            RadioButton NightshadeClan = new RadioButton();
            NightshadeClan.Location = new Point(ClassLabel.Location.X + 160, MercenaryofAdar.Bottom);
            NightshadeClan.Text = "Nightshade Clan";
            NightshadeClan.AutoSize = true;
            NightshadeClan.Anchor = AnchorStyles.Left;

            RadioButton TheCombine = new RadioButton();
            TheCombine.Location = new Point(ClassLabel.Location.X + 160, NightshadeClan.Bottom);
            TheCombine.Text = "The Combine";
            TheCombine.AutoSize = true;
            TheCombine.Anchor = AnchorStyles.Left;

            RadioButton UsersoftheCrowbar = new RadioButton();
            UsersoftheCrowbar.Location = new Point(ClassLabel.Location.X + 160, TheCombine.Bottom);
            UsersoftheCrowbar.Text = "Users of the Crowbar";
            UsersoftheCrowbar.AutoSize = true;
            UsersoftheCrowbar.Anchor = AnchorStyles.Left;

            RadioButton LunaticCultists = new RadioButton();
            LunaticCultists.Location = new Point(ClassLabel.Location.X + 160, UsersoftheCrowbar.Bottom);
            LunaticCultists.Text = "Lunatic Cultists";
            LunaticCultists.AutoSize = true;
            LunaticCultists.Anchor = AnchorStyles.Left;

            RadioButton WorshipersoftheMellow = new RadioButton();
            WorshipersoftheMellow.Location = new Point(ClassLabel.Location.X + 160, LunaticCultists.Bottom);
            WorshipersoftheMellow.Text = "Worshipers of the Mellow";
            WorshipersoftheMellow.AutoSize = true;
            WorshipersoftheMellow.Anchor = AnchorStyles.Left;

            this.Controls.Add(p_classPanel);
            p_classPanel.Controls.Add(ClassLabel);
            p_classPanel.Controls.Add(Rogue);
            p_classPanel.Controls.Add(ReformedSentari);
            p_classPanel.Controls.Add(PoultryFaction);
            p_classPanel.Controls.Add(CandyMakers);
            p_classPanel.Controls.Add(BoulderBro);
            p_classPanel.Controls.Add(TimeLoopers);
            p_classPanel.Controls.Add(Acolyte);
            p_classPanel.Controls.Add(FollowerofJean);
            p_classPanel.Controls.Add(TheEye);
            p_classPanel.Controls.Add(CultofHofbräu);
            p_classPanel.Controls.Add(DogBarbarian);
            p_classPanel.Controls.Add(MercenaryofAdar);
            p_classPanel.Controls.Add(NightshadeClan);
            p_classPanel.Controls.Add(TheCombine);
            p_classPanel.Controls.Add(UsersoftheCrowbar);
            p_classPanel.Controls.Add(LunaticCultists);
            p_classPanel.Controls.Add(WorshipersoftheMellow);
        }
        public void ItemsPanel()
        {
            Panel p_itemsPanel = new Panel();
            p_itemsPanel.Dock = DockStyle.Bottom;
            p_itemsPanel.Height = itemsPanelHeight;

            Label itemsLabel = new Label();
            itemsLabel.Text = "Items";
            itemsLabel.Location = new Point(10, 10);
            itemsLabel.AutoSize = true;

            RadioButton PackofTools = new RadioButton();
            PackofTools.Location = new Point(itemsLabel.Location.X, itemsLabel.Bottom);
            PackofTools.Text = "Pack of Tools";
            PackofTools.Width = 125;
            PackofTools.Appearance = Appearance.Button;
            PackofTools.Anchor = AnchorStyles.Left;

            RadioButton RogueAttire = new RadioButton();
            RogueAttire.Location = new Point(itemsLabel.Location.X, PackofTools.Bottom);
            RogueAttire.Text = "Rogue Attire";
            RogueAttire.Width = 125;
            RogueAttire.Appearance = Appearance.Button;
            RogueAttire.Anchor = AnchorStyles.Left;

            RadioButton CandyKit = new RadioButton();
            CandyKit.Location = new Point(itemsLabel.Location.X, RogueAttire.Bottom);
            CandyKit.Text = "Candy Making Kit";
            CandyKit.Width = 125;
            CandyKit.Appearance = Appearance.Button;
            CandyKit.Anchor = AnchorStyles.Left;

            RadioButton JustARock = new RadioButton();
            JustARock.Location = new Point(itemsLabel.Location.X, CandyKit.Bottom);
            JustARock.Text = "Just a Rock";
            JustARock.Width = 125;
            JustARock.Appearance = Appearance.Button;
            JustARock.Anchor = AnchorStyles.Left;

            RadioButton TheOneRing = new RadioButton();
            TheOneRing.Location = new Point(itemsLabel.Location.X, JustARock.Bottom);
            TheOneRing.Text = "The One Ring";
            TheOneRing.Width = 125;
            TheOneRing.Appearance = Appearance.Button;
            TheOneRing.Anchor = AnchorStyles.Left;

            RadioButton DiamondSword = new RadioButton();
            DiamondSword.Location = new Point(itemsLabel.Location.X, TheOneRing.Bottom);
            DiamondSword.Text = "Diamond Sword";
            DiamondSword.Width = 125;
            DiamondSword.Appearance = Appearance.Button;
            DiamondSword.Anchor = AnchorStyles.Left;
            
            RadioButton Crowbar = new RadioButton();
            Crowbar.Location = new Point(itemsLabel.Location.X, DiamondSword.Bottom);
            Crowbar.Text = "A Crowbar";
            Crowbar.Width = 125;
            Crowbar.Appearance = Appearance.Button;
            Crowbar.Anchor = AnchorStyles.Left;

            RadioButton JediEquipment = new RadioButton();
            JediEquipment.Location = new Point(itemsLabel.Location.X, Crowbar.Bottom);
            JediEquipment.Text = "Jedi Equipment";
            JediEquipment.Width = 125;
            JediEquipment.Appearance = Appearance.Button;
            JediEquipment.Anchor = AnchorStyles.Left;


            Label Description = new Label();
            Description.Location = new Point(275, 10);
            Description.Text = "Item Description/Stats";
            Description.AutoSize = true;
            Description.Anchor = AnchorStyles.Top;

            TextBox DescriptionBox = new TextBox();
            DescriptionBox.Location = new Point(Description.Location.X, Description.Bottom);
            DescriptionBox.Size = new Size(400, 193);
            DescriptionBox.ReadOnly = true;
            DescriptionBox.BackColor = Color.White;
            DescriptionBox.Multiline = true;
            DescriptionBox.ScrollBars = ScrollBars.Vertical;
            DescriptionBox.Anchor = AnchorStyles.Top;


            Label WhatistoCome = new Label();
            WhatistoCome.Location = new Point(685, 10);
            WhatistoCome.Text = "You are an adventurer who has a desire to be the best in the land. One day at the local tavern an elderly man in a hood and a cane approaches. I hear you have desires, I require your service in retreiving an item. Come to my study so we may have privacy. You will bring me my scying orb stollen by bandits and I will pay you generously.";
            WhatistoCome.Size = new Size(205, 175);
            WhatistoCome.Anchor = AnchorStyles.Top;

            Button Create = new Button();
            Create.Location = new Point(685, WhatistoCome.Bottom + 10);
            Create.Text = "Create Your Adventurer";
            Create.Width = 205;
            Create.Anchor = AnchorStyles.Top;
            
            this.Controls.Add(p_itemsPanel);
            p_itemsPanel.Controls.Add(itemsLabel);
            p_itemsPanel.Controls.Add(PackofTools);
            p_itemsPanel.Controls.Add(RogueAttire);
            p_itemsPanel.Controls.Add(CandyKit);
            p_itemsPanel.Controls.Add(JustARock);
            p_itemsPanel.Controls.Add(TheOneRing);
            p_itemsPanel.Controls.Add(DiamondSword);
            p_itemsPanel.Controls.Add(Crowbar);
            p_itemsPanel.Controls.Add(JediEquipment);
            p_itemsPanel.Controls.Add(Description);
            p_itemsPanel.Controls.Add(DescriptionBox);
            p_itemsPanel.Controls.Add(WhatistoCome);
            p_itemsPanel.Controls.Add(Create);
        }
    }
}