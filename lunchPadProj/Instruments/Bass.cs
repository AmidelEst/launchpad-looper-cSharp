namespace lunchPadProj
{
    using System;
    [Serializable]
    class Bass : StringInstrument
    {
        public Bass()
        {
            NAME = "The Default Bass";
            VOL = 7;
            NUMOFSTRINGS = 5;
            SetAdresses();
        }
        public Bass(string name, int volume, int numOfStrings)
        {
            NAME = name;
            VOL = volume;
            NUMOFSTRINGS = numOfStrings;
            SetAdresses();
        }
        private void SetAdresses()
        {
            PLAYABLEADRESS = new string[] { "noNeed", @"Bass\01.wav", @"Bass\02.wav", @"Bass\03.wav", @"Bass\04.wav", @"Bass\05.wav", @"Bass\06.wav", @"Bass\07.wav", @"Bass\08.wav", @"Bass\09.wav" };
        }

        public override void changePad(int pad, string path) {PLAYABLEADRESS[pad] = path;}

        ~Bass() { }
    }
}
