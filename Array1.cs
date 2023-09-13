using System;

class Array1
{
static void Main()
{
//Creation of an array
int [] arr = new int[5];

//Initialization of an array
arr[0]=1;
arr[1]=2;
arr[2]=22;
arr[3]=12;
arr[4]=29;

 Console.WriteLine("Array elements are : ");
// Traversing of an array

for(int i=0; i<arr.Length; i++)
{
 Console.Write(arr[i] + " ");
}

}
}