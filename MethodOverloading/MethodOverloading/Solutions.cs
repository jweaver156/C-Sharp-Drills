using System;
class Solutions
{


    //Method takes in an int and multiplies by 2.
    public int Eval(int a)
    {
        return a * 2;
    }

    //Method takes in a decimal and adds 10.
    public int Eval(double a)
    {
        return (int)a + 10;
    }

    //Method converts string to int and subtracts by 2.
    public int Eval(string a)
    {

        int num = Convert.ToInt32(a);
        num = num - 2;
        return num;       
       
    }
}
