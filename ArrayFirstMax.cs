using System;

class ArrayFirstMax
{
static void Main()
{
int i, j=0;
int [] arr = new int [4];
arr[0]=10;
arr[0]=11;
arr[0]=12;
arr[0]=13;

int max= 0;


for(i=0; i<arr.Length; i++)
{
  if(arr[i]>max)
{
 max=arr[i];
 j = i;
}
}
Console.WriteLine(" max value is "+max );

int Smax=0;
for( i=0; i<arr.Length; i++)
{
 if (i == j)
            {
                i++;  //ignoring the largest element 
                i--;
            }
            else
            {
                if (Smax < arr[i])
                {
                    Smax= arr[i];
                }
            }
}
Console.WriteLine(" max value is "+max );


}
}