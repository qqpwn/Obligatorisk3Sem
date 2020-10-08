using System;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Obligatorisk_opgave1
{
    public class FanOutput
    {
        private int _id;
        private string _name;
        private int _temp;
        private int _fugt;

        public FanOutput(int id, string name, int temp, int fugt)
        {
            _id = id;
            _name = name;
            _temp = temp;
            _fugt = fugt;
        }

        public FanOutput()
        {
            
        }

        public int Id
        {
            get { return _id;}
            set { _id = value;}
        }

        public string Name
        {
            get { return _name;}
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException("Navn ikke langt nok"); 
                _name = value;
            }
        }

        public int Temp
        {
            get { return _temp;}
            set
            {
                if(15 < value && value > 25) throw new ArgumentOutOfRangeException("Temp er ikke inden for rammerne");
                _temp = value;
            }
            
        }

        public int Fugt
        {
            get { return _fugt;}
            set
            {
                if(30 < value && value > 80) throw new ArgumentOutOfRangeException("Fugt er ikke iden for rammerne");
                _fugt = value;
            }
        }

      
    }   
}
