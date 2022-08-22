//string s1 = "hello";

//string s2 = new String('a', 6);

//string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
//string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3);

//Console.WriteLine(s1);  // hello
//Console.WriteLine(s2);  // aaaaaaa
//Console.WriteLine(s3);  // world
//Console.WriteLine(s4);  // orl


//string message = "hello";


//char firstChar = message[1];


//Console.WriteLine(firstChar);

//for (var i = 0; i < message.Length; i++)
//{
//    Console.WriteLine(message[i]);
//}
//foreach (var ch in message)
//{
//    Console.WriteLine(ch);
//}

//string message1 = "hello";
//string message2 = "hello";
//Console.WriteLine(message1 == message2);

//string s1 = "hello";
//string s2 = "world";
//string s3 = s1 + " " + s2;

//string s4 = string.Concat(s3, "!!!");

//Console.WriteLine(s4);

//string s5 = "apple";
//string s6 = "a day";
//string s7 = "keeps";
//string s8 = "a doctor";
//string s9 = "away";
//string[] values = new string[] { s5, s6, s7, s8, s9 };

//string s10 = string.Join(" ", values);
//Console.WriteLine(s10);


//string s1 = "hello";
//string s2 = "world";
//int result = string.Compare(s1, s2);
//if (result < 0)
//{
//    Console.WriteLine("String s1 before string s2");
//}
//else if (result > 0)
//{
//    Console.WriteLine("String s1 is after string s2");
//}
//else
//{
//    Console.WriteLine("Strings s1 and s2 are identical");
//}


//string s1 = "hello world";
//char ch = 'o';
//int indexOfChar = s1.IndexOf(ch);

//Console.WriteLine(indexOfChar);

//string substring = "wor";
//int indexOfSubstring = s1.IndexOf(substring);

//Console.WriteLine(indexOfSubstring);

//var files = new string[]
//{
//    "myapp.exe",
//    "forest.jpg",
//    "main.exe",
//    "book.pdf",
//    "river.png"
//};
//for (int i = 0; i < files.Length; i++)
//{
//    if (files[i].EndsWith(".exe"))
//        Console.WriteLine(files[i]);
//}

//for (int i = 0; i < files.Length; i++)
//{
//    if (files[i].StartsWith("main"))
//        Console.WriteLine(files[i]);
//}

//string text = "And thus all happened in such manner, And thus all happened in such manner";
//string[] words = text.Split(new char[] { ','  });
//foreach (string s in words)
//{
//    Console.WriteLine(s);
//}
using System.Text;
//StringBuilder sb = new StringBuilder();

//var sb1 = new StringBuilder("Hello World");

//Console.WriteLine(sb1.ToString());

//StringBuilder sb = new StringBuilder("Hello World");
//Console.WriteLine($"Length: {sb.Length}");       // Длина: 10
//Console.WriteLine($"Capacity: {sb.Capacity}");


//var sb = new StringBuilder("Hello world");
//sb.Append("!");
//sb.Insert(6, "computer ");
//Console.WriteLine(sb);


//sb.Replace("world", "universe");
//Console.WriteLine(sb);

//sb.Remove(7, 13);



string s1 = "Hello";
string s2 = "Hello";
string s3 = "HJIOUHkfg./";

int result = string.Compare(s1, s2);
if (result < 0)
{
    Console.WriteLine(" s1 not equal s2");
}
else if (result > 0)
{
    Console.WriteLine(" s1 not equal s2");
}
else
{
    Console.WriteLine("Strings s1 and s2 are equal");
}
//big whitespace


static string Sort(string s1)
{
    string s2 = s1.ToLower();

    char[] alphabet = s2.ToCharArray();

    for (int b = 0; b < s1.Length; b++)
    {
        for (int i = 1; i < s1.Length; i++)
        {
            int cmpVal = s1[i].CompareTo(s1[i - 1]);

            if (cmpVal < 0)
            {
                char x = alphabet[i];
                alphabet[i] = alphabet[i - 1];
                alphabet[i - 1] = x;
            }
            s1 = new string(alphabet);
        }
    }
    Console.WriteLine(s1);
    return s1;
}

Sort(s3);


static void Dublicate()
{
    
    var Word1 = Convert.ToString(Console.ReadLine());
    var  Word2 = Convert.ToString(Console.ReadLine());

    for (int i = 0; i < Word1.Length; i++)
    {
        for (int j = 0; j < Word2.Length; j++)
        {
            if (Word1[i] == Word2[j])
            {
                Console.Write(Word1[i]);
            }
        }
    }
}



Dublicate();



static void Analyze()
{
    string Word1 = "e98203tu?,&*3";
    string Word2 = "greighherh";


    Console.WriteLine(Word1.Length);

    Console.WriteLine(Word2.Length);

}

Analyze();

//checked
