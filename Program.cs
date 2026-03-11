// //1
//  int a;
//  int cnt = 0;
// System.Console.Write("Raqamhoro vorid kuned : ");
//  a = Convert.ToInt32(Console.ReadLine());
//  for(int i = a; i>0; i/=10)
//  {   
//    if(i % 2 == 0) cnt++;
//  }
//  Console.WriteLine("Raqami juft : " + cnt + " -to");


// //2
// int n = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[n];

// for(int i = 0; i < n; i++)
// {
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }

// nums.Sort();
// int max = int.MinValue;
// for(int i = nums.Length - 1; i >= 0; i--)
// {
//     if(nums[i] > max)
//     {
//         max = nums[i];
//     }
// }
// System.Console.WriteLine();
// for(int i = nums.Length - 1; i >= 0; i--)
// {
//     if(nums[i] < max)
//     {
//         System.Console.WriteLine(nums[i]);
//         break;
//     }
// }


// //3
// int Sum(int f)
// {
//     if(f <= 0)
//     {
//         return 0;
//     }
//      else
//     {
//         return f + Sum(f - 1);
//     }
// }
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(a));


//5
// bool IsPrime(int number)
// {
//     int cnt = 0;
//     for(int i = 1; i <= 10; i++)
//     {
//         if(number % i == 0)
//         {
//             cnt ++;
//         }
//     }
//     if(cnt > 2)
//     {
//         return true;
//     }
//     return false;
// }

// int a = Convert.ToInt32(Console.ReadLine());
// bool res = IsPrime(a);

// if(res == false)
// {
//     System.Console.WriteLine("Prime");
// }
// else
// {
//     System.Console.WriteLine("Not Prime");
// }


// //6
//     int a, max = 0;
//     a = Convert.ToInt32(Console.ReadLine());
//     for(int i = a; i > 0; i/=10){
//     if(max < i % 10) max = i % 10;
//     }
//     Console.WriteLine(max);


// //9
// int Sum(int n)
// {
//     if(n<=0)return 0;
//     else
//     {
//         return n + Sum(n - 1);
//     }
// }
//   int f = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(Sum(f));


//7
// int CountPositive(int[] number)
// {
//     int cnt = 0;
//     for(int i = 0; i < number.Length; i++)
//     {
//         if(number[i] > 0)
//         {
//             cnt ++;
//         }
//     }
//     return cnt;
// }

// int[] numbers = { -1, 2, -3, 4, 6 };
// int result = CountPositive(numbers);
// Console.WriteLine(result);


//8
// bool Contains(int[] arr, int value)
// {
//     int cnt = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == value) cnt++;
//     }
//     if(cnt > 0) return true;
//     else return false;
// }
// int[] numbers = { 3, 7, 10, 2 };
// System.Console.WriteLine(Contains(numbers, 7));

// //10
// int Shumora(int f)
// {
//     if(f == 0)return 0;
//     else
//     {
//         return 1 + Shumora(f / 10);
//     }
// }
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Shumora(a));
