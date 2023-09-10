﻿class binar
{
    public int x, y, z;
    public bool boolx, booly, boolz;

    public binar(int x = 0, int y = 0, int z = 0, bool boolx = true, bool booly = true, bool boolz = true)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.boolx = boolx;
        this.booly = booly;
        this.boolz = boolz;
    }
    public static binar operator ==(binar obj1, binar obj2)
    {
        binar arr = new binar();
        arr.boolx = obj1.x == obj2.x;
        arr.booly = obj1.y == obj2.y;
        arr.boolz = obj1.z == obj2.z;
        return arr;
    }
    public static binar operator !=(binar obj1, binar obj2)
    {
        binar arr = new binar();
        arr.boolx = obj1.x != obj2.x;
        arr.booly = obj1.y != obj2.y;
        arr.boolz = obj1.z != obj2.z;
        return arr;
    }
}
class Programm
{
    static void Main(string[] args)
    {
        binar point1 = new binar(1, 2, 3);
        binar point2 = new binar(3, 2, 1);
        binar point3 = point1 == point2;
        Console.WriteLine($"{point3.boolx}{point3.booly}{point3.boolz}");

        b00ly point11 = new b00ly(1, 2, 3);
        b00ly point22 = new b00ly(3, 2, 1);
        Console.WriteLine($"{point11.tf}{point22.tf}");



    }
}


class b00ly
{
    public int x, y, z;
    public bool tf;

    public b00ly(int x = 0, int y = 0, int z = 0, bool tf = true)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.tf = tf;

    }

    public static bool operator true(b00ly obj)
    {
        b00ly arr = new b00ly();
        arr.tf = ((obj.x % 2 == 0) && (obj.y % 2 == 0) && (obj.z % 2 == 0));
        return arr.tf;
    }

    public static bool operator false(b00ly obj)
    {
        b00ly arr = new b00ly();
        arr.tf = ((obj.x % 2 == 0) || (obj.y % 2 != 0) || (obj.z % 2 != 0));
        return arr.tf;
    }


}