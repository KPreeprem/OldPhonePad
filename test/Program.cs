using System;
using System.Text;

class PhonePad
{
    static void Main(String[] args)
    {
        while(true) //Infinite Loop until users exit out
        {
            Console.WriteLine("Enter Input:"); 
            string s = Phone.OldPhonePad(Console.ReadLine()); //Input values would be executed in OldPhonePad method
            Console.WriteLine(s);
        }
    }
}