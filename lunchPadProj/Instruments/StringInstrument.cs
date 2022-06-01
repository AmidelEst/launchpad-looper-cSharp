namespace lunchPadProj
{
    using Instrument;
    using System;
    [Serializable]
    public abstract class StringInstrument:Instrument
    {
        int numOfStrings;
        public int NUMOFSTRINGS { get { return numOfStrings; } set { numOfStrings = value; } }
    }
}
