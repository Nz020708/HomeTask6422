using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6422.Utilities
{
    public class Dresses : Boutique
    {
        private int _size;
        private int _price;
        private string _colour;
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                if (_size < 40)
                {
                    throw new SizeNotFoundException("Size is not found!");
                }
                else
                {
                    _size = value;
                }
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }

        }
    }
}

