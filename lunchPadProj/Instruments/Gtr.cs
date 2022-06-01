using System;

namespace lunchPadProj
{
    [Serializable]
    class Gtr:StringInstrument
    {
        public Gtr()
        {
            NAME = "The Default Bass";
            VOL = 7;
            NUMOFSTRINGS = 5;
            SetAdresses();
        }
        public Gtr(string name, int volume, int numOfStrings)
        {
            NAME = name;
            VOL = volume;
            NUMOFSTRINGS = numOfStrings;
            SetAdresses();
        }
        private void SetAdresses()
        {
            PLAYABLEADRESS = new string[] { "noNeed", @"Guitar\01.wav", @"Guitar\02.wav", @"Guitar\03.wav", @"Guitar\04.wav", @"Guitar\05.wav", @"Guitar\06.wav", @"Guitar\07.wav", @"Guitar\08.wav", @"Guitar\09.wav"};
        }
        public override void changePad(int pad, string path) { PLAYABLEADRESS[pad] = path; }
        ~Gtr() { }
    }
}
