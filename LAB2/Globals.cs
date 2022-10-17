using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Globals
{
    private static int _price;
    public static int price
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
}

