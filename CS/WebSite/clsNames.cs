using System;
using System.Collections.Generic;
using System.Text;

public class clsNames : List<clsName>
{
    public clsNames()
    {
        this.Add(new clsName("A", "Arnold", "Apple"));
        this.Add(new clsName("B", "Barney", "Bagle"));
        this.Add(new clsName("C", "Charlie", "Chipman"));
        this.Add(new clsName("D", "Doug", "Doggle"));
        this.Add(new clsName("E", "Elizabeth", "Einstein"));
        this.Add(new clsName("F", "Frank", "Flanery"));
        this.Add(new clsName("G", "Gilbert", "Guzman"));
        this.Add(new clsName("H", "Hillary", "Harvey"));
        this.Add(new clsName("I", "Isadora", "Ingleman"));
        this.Add(new clsName("J", "Jacob", "James"));
        this.Add(new clsName("K", "Kevin", "Krantz"));
    }
}
