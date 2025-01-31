namespace Demo
{
    // class 
    // interface 
    // enum 
    // struct 
    // delegate

    // Step 01: Create New Datatype (Delegate)
    public delegate int StringFuncDelegate(String s);

    /// <summary>
    /// //NEW Delegate (Class): Reference (Pointer) Can Refer To Function or More (Pointer Of Function)
    // These Function Must Be Have The Same Signature Of The Delegate: int(string) 
    // Regardless Function Name, Parameters Names Or, Access Modifiers
    /// </summary>


    internal class Program
    {
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write(value: $"{item} ");
            }
            Console.WriteLine();
        }
        static void Main()
        {

            #region Delegate Overview

            // Delegate: C# Feature 

            // C# Pure OOP 

            // Functional Programming 
            // Event-Driven Programming 

            // Java: Pure OOP 
            // DP:

            #endregion

            #region Delegate Ex01

            // Step 02; Use Delegate
            //StringFuncDelegate X;
            //X = StringFunctions.GetCountOfUpperCaseChars;
            ////X.

            //StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars) 

            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar 

            //X += StringFunctions.GetCountOfLowerCaseChars;

            ////int Count X. Invoke("Hello World"); 
            //int Count = X(s: "Hello World"); // Syntax Sugar 
            //Console.WriteLine(Count);

            #endregion

            #region Delegate Ex02 Without Generic

            // int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };

            //  PrintArray(Numbers);

            //SortingAlgorithms.BubbleSortAscending (Numbers); // Sorting Ascending 
            ////SortingAlgorithms.Bubble SortDescending (Numbers); // Sorting Descending 

            //SortingFuncDelegate X = SortingConditions.CompareLess;

            //SortingAlgorithms.BubbleSort(Numbers, X); // Sorting Ascending 

            //  SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareGtr); // Sorting Descending 

            // PrintArray(Numbers);

            #endregion

            #region Delegate Ex02 With Generic
            //string[] Names = { "Mohammed", "Narges", "Ali", "Ahmed", "Omer" };
            //SortingAlgorithms.BubbleSort(Names , SortingFunctions.SortAscending);

            //foreach (string item in Names)
            //{

            //    Console.Write(item + " ");

            //}

            //int[] Number = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            //SortingAlgorithms.BubbleSort(Number, SortingFunctions.SortAscending);

            //foreach (int item in Number)
            //{

            //    Console.Write(item + " ");

            //}

            #endregion

            #region Delegate Ex03
            //List<int> list = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumber = FindNumbers(list, ConditionsFunctions.CheckOdd);
            //List<int> EvenNumber = FindNumbers(list, ConditionsFunctions.CheckEven);
            //List<int> DivisalbeBy4Numbers = FindNumbers(list, ConditionsFunctions.CheckDivisalbeBy4Numbers);

            //List<int> OddNumber = FindOddNumbers(list);
            //List<int> EvenNumber = FindEvenNumbers(list);
            //List<int> DivisalbeBy4Numbers = FindDivisalbeBy4Numbers(list);

            //foreach (int item in OddNumber)
            //{

            //    Console.WriteLine(item + " ");

            //}

            #endregion

            #region Delegate Ex03 With Generics
            //List<string> Names = new List<string> { "Mohammed", "Narges", "Ali", "Ahmed", "Omer" };

            //List<string> Result =  FindElements(Names, ConditionsFunctionsV2.CheckLengthGtr3);
            //List<string> result = FindElements(Names, ConditionsFunctionsV2.CheckLengthLess3);

            //foreach (string item in Result) {

            //    Console.WriteLine(item);

            //}

            // ******************************************************

            //List<int> list = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumber = FindElements(list, ConditionsFunctions.CheckOdd);
            //List<int> EvenNumber = FindElements(list, ConditionsFunctions.CheckEven);
            //List<int> DivisalbeBy4Numbers = FindElements(list, ConditionsFunctions.CheckDivisalbeBy4Numbers);

            //foreach (int item in OddNumber)
            //{

            //    Console.WriteLine(item + " ");

            //}

            #endregion

            #region Built-in Delegate
            //Predicate<int> predicate = ConditionsFunctions.CheckEven;


            //Func<int , bool> func = ConditionsFunctions.CheckEven;

            ////Action action = ConditionsFunctionsV3.Welcome;

            //Action<string> action = ConditionsFunctionsV3.Print;
            //action.Invoke("Hello");
            //action("Hello");
            #endregion

            #region  Anonymous Method & Lambda Expression
            // C# 2.0 2005

            //Predicate<int> predicate = delegate (int X) { return X % 2 != 0; }; // Anonymous Methods
            //Predicate<int> predicate = delegate (int X) { return X % 2 == 0; }; // Anonymous Methods

            //predicate.Invoke(5);
            //predicate(2);

            // C# 3.0 2007
            // Lmbda Expression
            // FatArrow --> Read as "Goes To"

            //Predicate<int> predicate =  (int X) => { return X % 2 == 0; }; // Lmbda Expression
            //Predicate<int> predicate = (X) => { return X % 2 == 0; }; // Lmbda Expression
            //Predicate<int> predicate = X =>   X % 2 == 0; ; // Lmbda Expression
            //FindElements(, X => X % 2 == 0);

            #endregion

            #region  C# Keyword - var
            //Predicate<int> predicate = ConditionsFunctionsV4.CheckEven;
            //var X = 12;
            #endregion

            #region Function Returns Function - FP Feature

            //var X = Fun01();
            //Action X = Fun01();

            //X.Invoke();

            //Fun01()();


            #endregion

        }
    }
}

