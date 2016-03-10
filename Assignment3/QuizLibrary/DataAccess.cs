using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    class DataAccess
    {
        string[] quizes;
        //Get only short words
        var quiznu = from word in words
                         where word.Length <= 5
                         select word;
	    
	 //Print each word out
	 foreach (var word in shortWords)
	 {
	 	Console.WriteLine(word);
	 }
    Console.ReadLine();
    }
}
