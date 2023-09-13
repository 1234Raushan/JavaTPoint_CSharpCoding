using System;

class array2
{
static void Main()
{
 Console.WriteLine(" Enter array size: ");
 int n = int.Parse(Console.ReadLine());

int [] arr = new int[n];
 Console.WriteLine("Enter  array elements : ");
for(int i =0; i <arr.Length; i++)
{
arr[i]= int.Parse(Console.ReadLine());
}

 Console.WriteLine("Entered elements are : ");
for(int j=0; j<arr.Length; j++)
{
 Console.WriteLine(arr[j]);
}

}
}