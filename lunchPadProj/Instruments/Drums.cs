namespace lunchPadProj
{
    using System;
    using Instrument;
    [Serializable]
    class Drums: Instrument
    {
        private int num_of_percs;
        public int NUMOFPERCS { get { return num_of_percs; } set { num_of_percs = value; } }
        public Drums()
        {
            NAME = "Amit's Defualt Drum";
            VOL = 7;
            NUMOFPERCS = 7;
            SetPlayableAdress();
        }
        public Drums(string name, int volume, int percs)
        {
            NAME = name;
            VOL = volume;
            NUMOFPERCS = percs;
            SetPlayableAdress();
        }
        private void SetPlayableAdress()
        {
            PLAYABLEADRESS = new string[] { "noNeed",@"Drum\01.wav", @"Drum\02.wav", @"Drum\03.wav", @"Drum\04.wav", @"Drum\05.wav", @"Drum\06.wav", @"Drum\07.wav", @"Drum\08.wav", @"Drum\09.wav" };
        }
        public override void changePad(int pad, string path) { PLAYABLEADRESS[pad] = path; }
    }
}
