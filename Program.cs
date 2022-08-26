

 using System.Text;

namespace Test
{


    public class Program

    {

    

        static void Main(string[] args)

        {
            Console.Write("input = ");
            string str = Console.ReadLine();
            string strrev = "";
            char[] punctuation = new char[] { ' ', ',', '.', ':', '\'', '?', '!', '@', '#','\"' }; 

          
            char[] inputAsChars = str.ToCharArray();

            
            string temp = "";
            foreach (char c in inputAsChars)
            {
                if (punctuation.Contains(c))
                {
                
                char[] tx = temp.ToCharArray();
                Array.Reverse(tx);
                temp = new string(tx);
                strrev += temp + c;    
                temp = "";
                }
                else
                temp += c; 
            }

            Console.WriteLine("Output= {0}", strrev);
        }


    }
}

//     public class Program
//     {
  

  
//         static string wordReverser(string sentence)
//         {
//             string str, str1 = "";
//             int j, l;

        
//             if (sentence == null)
//                 return " ";
//             var words = sentence.Trim().Split(" ");
//             StringBuilder output = new StringBuilder();

//             for (var i = 0; i <= words.Length; i++)
//             // for (var i = words.Length -1; i >= 0; i--)
//             {
//                 // output.Append(words[i]).Append(" ");
//                 // Console.WriteLine(words[i]);
//                 str = words[i];

//                 l=str.Length-1;
//                 for (j=l;j>=0;i--)
//                 {
//                     str1 = str + str[j];
//                     return str1;
//                 }

//             }
//             Console.WriteLine(str1);
//             // Console.WriteLine(words);
//             return output.ToString() .Trim();
//         }



//         public static void Main(string[] args)
//         {
//             Console.WriteLine("please insert your input!");
//             string userInput = Console.ReadLine();

//             var result = wordReverser(userInput);
//             Console.WriteLine(result);
            
//         }

// }
// }







//     public class Program
//     {
  

  
        
//         public static string wordReverser(string sentence)
//         {
            
//             string str1 = "";
//             var words = sentence.Split(" ");
//             StringBuilder output = new StringBuilder(str1);

//             for (var i = 0; i < sentence.Length; i++)
//             {
                
//                 // l=words.Length-1;
//                 // for (j=l;j>=0;i--)
//                 for( var l = words.Length;l >= 0; l--)
//                 {
//                     str1 += words;
//                     // return str1;
//                     Console.WriteLine(str1.ToString());
//                 }
//                 // output.Insert(str1);
//             }

//             return output.ToString() .Trim();
//             // return str1.ToString();
//              Console.WriteLine(output.ToString());
//         }



//         public static void Main(string[] args)
//         {
//             Console.WriteLine("please insert your input!");
//             string userInput = Console.ReadLine();
//             var result = wordReverser(userInput);
//             Console.WriteLine(result);
//             Console.WriteLine("test");
           
//         }

// }

//     public class Program
//     {
  

  
        
//         public static string wordReverser(string sentence)
//         {
            
//             string str1 = "";
//             var words = sentence.Split();
//             string newSentence = " "; 
//             // StringBuilder output = new StringBuilder(str1);
//             string output = " ";
          
//                 // l=words.Length-1;
//                 // for (j=l;j>=0;i--)
//                 for( var l = words.Length;l >= 0; l--)
//                 {
//                     str1 += words;
//                     return newSentence.ToString();
//                     return str1;
//                     // Console.WriteLine(newSentence.ToString());
//                 }
//                 // output.Insert(str1);

//             // return output.ToString() .Trim();
//             return null;
//             // return str1.ToString();
//             //  Console.WriteLine(output.ToString());
//         }



//         public static void Main(string[] args)
//         {
//             Console.WriteLine("please insert your input!");
//             string userInput = Console.ReadLine();
//             var result = wordReverser(userInput);
//             Console.WriteLine(result.ToString());
//             Console.WriteLine("test");
           
//         }

// }
// }


// namespace Test
// {
//     public class Program
//     {
  

  
//         static string wordReverser(string sentence)
//         {
//             string str, newStr = "";
//             int j, l;

        
//             if (sentence == null)
//                 return " ";
//             var word = sentence.Trim().Split(" ");
//             StringBuilder output = new StringBuilder();

//             // for (var i = 0; i <= words.Length; i++)
//             for (var i = word.Length -1; i >= 0; i--)
//             {
//                 // output.Append(words[i]).Append(" ");
//                 // Console.WriteLine(words[i]);
//                 str = word[i];

//                 l=str.Length-1;
//                 for (j=l;j>=0;l--)
//                 {
//                     newStr = str + str[j];
//                     return newStr;
//                     // return null;
//                 }

//             }
//             // Console.WriteLine(str1);
//             // Console.WriteLine(words);
//             // return output.ToString() .Trim();
//             return null;
//         }



//         public static void Main(string[] args)
//         {
//             Console.WriteLine("please insert your input!");
//             string userInput = Console.ReadLine();

//             var result = wordReverser(userInput);
//             Console.WriteLine(result);
            
//         }


// }



// public class Program

//     {

    

//         static string wordReverse(string str)

//         {

//             string result = "";

//             if (str == null)
//                  return " ";
//             else if (str == ",")
//                 return "1";
//             else if (str == ".")
//                 return "2";
//             else if (str == "'")
//                 return "3";

//             for (int i = str.Length - 1; i >= 0; i--)

//             {

//                 result += str[i];

//             }

//             return result;

//         }


//     static void Main(string[] args)

//         {

//             Console.Write("input = ");

//             string str = Console.ReadLine();



//             string result=string.Empty;

//             string[] arr = str.Trim().Split(' ',',','.');

//             for (int i = 0; i < arr.Length; i++)

//             {

//                 if (i != arr.Length - 1)

//                 {

//                     result += wordReverse(arr[i]) + " ";

//                 }
//                 else
//                 {

//                     result += wordReverse(arr[i]);

//                 }

//             }

//             Console.WriteLine("Output= {0} ",result);

//             Console.ReadLine();

//         }


//     }
// }

// public class Program

//     {

    

//         static string wordReverse(string str)

//         {

//             string result = "";

//             if (str == null)
//                  return " ";
//             else if (str == ",")
//                 return "1";
//             else if (str == ".")
//                 return "2";
//             else if (str == "'")
//                 return "3";

//             for (int i = str.Length - 1; i >= 0; i--)

//             {

//                 result += str[i];

//             }

//             return result;

//         }


//     static void Main(string[] args)

//         {

//             Console.Write("input = ");

//             string str = Console.ReadLine();



//             string result=string.Empty;

//             string[] arr = str.Trim().Split(' ',',','.');

//             for (int i = 0; i < arr.Length; i++)

//             {

//                 if (i != arr.Length - 1)

//                 {

//                     result += wordReverse(arr[i]) + " ";
//                     if()
//                 }
//                 else
//                 {

//                     result += wordReverse(arr[i]);

//                 }

//             }

//             Console.WriteLine("Output= {0} ",result);

//             Console.ReadLine();

//         }


//     }
// }





