using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hotel
{
    int hotel_id;
    string name;
    string address;
    double contact;
    public static void Main()
    {
        Hotel h = new Hotel();
        h.hotel_id= 1;
        h.name = "Jagdamb";
        h.address = "Khed Shivapur";
        h.contact = 7350448724;
        Console.WriteLine("Hotel ID=" + h.hotel_id);
        Console.WriteLine("Hotel Name=" + h.name);
        Console.WriteLine("Hotel Address=" + h.address);
        Console.WriteLine("Hotel Number=" + h.contact);
    }
}