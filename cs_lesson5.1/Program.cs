﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson5._1
{
    class Program  //类型转换
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;

            Console.WriteLine("Variable Conversion Example\n");
            doubleResult = floatVal * shortVal;    
            Console.WriteLine("Implicit, -> double: {0}*{1} ->{2}",
                floatVal,shortVal,doubleResult);

            shortResult = (short)floatVal;
            Console.WriteLine("Explicit, -> short:{0} -> {1}",
                floatVal, shortResult);

            stringResult = Convert.ToString(boolVal) + 
                Convert.ToString(doubleVal);
            Console.WriteLine("Explicit, -> string: \"{0}\" + \"{1}\" -> {2}",
                boolVal, doubleVal, stringResult);

            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixed, -> long: {0} + {1} -> {2}",
                integerVal, stringVal, longResult);
            Console.ReadKey();        
                         

        }
    }
}
