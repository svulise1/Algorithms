using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class SearchArray
{
    static void Main(string[] args)
    {
        int [] input = new int [5];
        
        Console.Write("how many numbers you want to enter");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the elements in array");
        for(int i =0;i<n;i++){
            input[i] = int.Parse(Console.ReadLine());
        }
        SearchArray Obj = new SearchArray();
     var maxfrequency =    Obj.max_item(input);
     Console.WriteLine("the item is  "+ maxfrequency);
    }
    public int max_item(int[] args){
        int length = args.Length;
        int max_count = -1;
        int max_item = 0;
       
        Dictionary<int ,int> Count = new Dictionary<int,int>();
        foreach (var item in args)
        {
            if(!Count.ContainsKey(item))
            {
                Count.Add(item,1);
            }
            else
            {
                Count[item] +=1;
            }

            if (Count[item]>max_count)
            {
             max_count = Count[item];   
            max_item = item;
       
            }

        

        
        }
    
        return max_item;
            }
}
