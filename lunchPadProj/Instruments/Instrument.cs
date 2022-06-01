namespace Instrument
{
    using System;
    using System.Collections;
    [Serializable]
    public abstract class Instrument
    {
        string name;
        int volume;
        string[] playableAdress;

        public string NAME{ get {return name;} set {name = value; } }
        public int VOL {get { return volume; } set { volume = value; } }
        public string[] PLAYABLEADRESS { get => playableAdress; set => playableAdress = value; }
        public abstract void changePad(int pad,string path);

    }
    [Serializable]
    public class InstrumentList
    {
        protected SortedList instrums;
        public InstrumentList()
        {
            instrums = new SortedList();
        }
        public int NextIndex
        {
            get
            {
                return instrums.Count;
            }
        }
        public Instrument this[int index]
        {
            get
            {
                if (index >= instrums.Count)
                    return (Instrument)null;
                //SortedList internal method
                return (Instrument)instrums.GetByIndex(index);
            }
            set
            {
                if (index <= instrums.Count)
                    instrums[index] = value; //!!!		
            }
        }
        public void Remove(int element)
        {
            if (element >= 0 && element < instrums.Count)
            {
                for (int i = element; i < instrums.Count - 1; i++)
                    instrums[i] = instrums[i + 1];
                instrums.RemoveAt(instrums.Count - 1);
            }
        }
        public void PlayAll()
        {
            Instrument prev, cur;
            for (int i = 1; i < instrums.Count; i++)
            {
                prev = (Instrument)instrums[i - 1];
                cur = (Instrument)instrums[i];
            }
        }
    }
  
}
