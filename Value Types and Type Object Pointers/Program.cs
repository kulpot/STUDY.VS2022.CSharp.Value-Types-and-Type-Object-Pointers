using System;

//ref link:https://www.youtube.com/watch?v=8kkB9l4za-4&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=35
//

//class Cow
struct Cow
{
    public int mooCount;
}

class Mainclass
{
    static void Main()
    {
        Cow betsy = new Cow();
        betsy.mooCount = 9;
        betsy.GetType();
        Cow georgy = new Cow();
        georgy.mooCount = 3;
    }
}