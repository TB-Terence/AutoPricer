using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for info
/// </summary>
public class Carinfo
{
    public int carID { get; set; }
    public int garageID { get; set; }
    public string model { get; set; }
    public string make { get; set; }
    public string milage { get; set; }
    public string engine { get; set; }
    public string condition { get; set; }

    public Carinfo(int carID, int garageID, string model, string make, string milage, string engine, string condition)
    {

    }
}