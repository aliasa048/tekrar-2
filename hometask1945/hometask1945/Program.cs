using System;

namespace hometask1945
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Fuad , Nermin , Abdulla , Malik " } ;
            {
                int counter = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length>5)
                    {
                        counter++;
                        
                    }

                    

                }
                Console.WriteLine(counter);
            }

            string[] names1 = { "rasim , FUad , Arif , Nazim , Eli" };
            {
                int counter = 0;
                for (int i = 0; i < names1.Length; i++)
                {
                    if (names1[i][0] == 'A')
                    {
                        counter++;
                    }



                }

                if (counter == names1.Length)
                {
                    
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");

                }
                
            }


            int[] numbers44 = {34 , 45, 56, 456};
            numbers44= value(numbers44, 67);

            foreach (var item in numbers44)
            {
                Console.WriteLine(item);
            }

            
            
             
        }

        static int[] value(int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = num;

            return arr;
           
        }
        
    }
}
