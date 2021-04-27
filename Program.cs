using System;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Arrays are collections of similar datatypes
           // it is index based and Starts at 0

            // int[] evenNumbers=new int[3];
            // evenNumbers[0]=2;
            // evenNumbers[1]=4;
            // evenNumbers[2]=6;
            // Console.WriteLine(evenNumbers[1]);


        //     string[] students=new string[3];
        //    students[0]="Eli";
        //    students[1]="Presh";
        //    students[2]="Mick";
        //     Console.WriteLine(students[3]);
//  string[] students={"Mick","Pre","Shu"};

// Console.WriteLine(2);

//  string[] students={"Mick","Pre","Shu"};

//  foreach(var i in students)
//  {
//      Console.WriteLine(i + "hello");
//  }

//        
//  int [] evenNo={2,4,6,8};

//  foreach(int i in evenNo)
//  {
//      Console.WriteLine(i);
//  }

//  int [] evenNo={2,4,6,8,10,12,14,16,18};

//  for (int i=0;i<9;i+=2)
//  {
// Console.WriteLine(evenNo[i]);
//  }
 //Do same for string

 int[,] goodnumbers=new int[4,4] {{0,1,2,3},
                                {4,5,6,7},
                                {8,9,10,11},
                                {12,13,14,15}};

for(int i=0;i<4;i++)
{
    Console.WriteLine();
Console.WriteLine($"This is row: {i}");

    for(int j=0;j<4;j++)
    {
        Console.WriteLine(goodnumbers[i,j]);
    
}

}                       
        }
    }
}
