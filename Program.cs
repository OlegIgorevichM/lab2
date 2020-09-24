using System;
using System.Text;

namespace OOP1 {
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            byte byteNumber = 5;
            sbyte byteSignNumber = -5;
            char charSymbol = 'a';
            decimal decimalNumber = 666999666;
            double doubleNumber = 66.66;
            float floatNumber = 66.6f;
            int intNumber = -666;
            uint intUnsingedNumber = 5;
            long longNumber = -9999999999;
            ulong longUnsignedNumber = 5555;
            short shortNumber = -30000;
            ushort shortUnsignedNumber = 30000;
            Console.WriteLine("--------------------------");
            Console.WriteLine("bool :" + flag);
            Console.WriteLine("byte :" + byteNumber);
            Console.WriteLine("sbyte :" + byteSignNumber);
            Console.WriteLine("char :" + charSymbol);
            Console.WriteLine("decimal :" + decimalNumber);
            Console.WriteLine("double :" + doubleNumber);
            Console.WriteLine("float : " + floatNumber);
            Console.WriteLine("int :" + intNumber);
            Console.WriteLine("uint :" + intUnsingedNumber);
            Console.WriteLine("long :" + longNumber);
            Console.WriteLine("ulong :" + longUnsignedNumber);
            Console.WriteLine("short :" + shortNumber);
            Console.WriteLine("ushort :" + shortUnsignedNumber);
            Console.WriteLine("-------------------- неявные преобразования : ");
            intNumber = shortNumber;
            Console.WriteLine("int :" + intNumber);
            intUnsingedNumber = byteNumber;
            Console.WriteLine("uint :" + intUnsingedNumber);
            shortNumber = byteSignNumber;
            Console.WriteLine("short :" + shortNumber);
            doubleNumber = floatNumber;
            Console.WriteLine("double :" + doubleNumber);
            longNumber = intNumber;
            Console.WriteLine("long :" + longNumber);
            Console.WriteLine("явные преобразования(c указанием типа) : ");
            longNumber = (long)doubleNumber;
            Console.WriteLine("long :" + longNumber);
            intUnsingedNumber = (uint)floatNumber;
            Console.WriteLine("uint :" + intUnsingedNumber);
            byteNumber = (byte)shortUnsignedNumber;
            Console.WriteLine("byte :" + byteNumber);
            intNumber = (int)longNumber;
            Console.WriteLine("int :" + intNumber);
            shortUnsignedNumber = (ushort)longUnsignedNumber;
            Console.WriteLine("ushort :" + shortUnsignedNumber);
            Console.WriteLine("Преобразования с использованием класса Convert :");
            intNumber = Convert.ToInt32(longUnsignedNumber);
            Console.WriteLine("int :" + intNumber);
            flag = Convert.ToBoolean(intNumber);
            Console.WriteLine("bool :" + flag);
            Console.WriteLine("---------------------------");
            int k = 666;
            Object obj = k;
            Console.WriteLine(obj);
            int jo = (int)obj;
            Console.WriteLine(jo);
            Console.WriteLine("Неявно типизированные перменные : ");
            var num = 32;
            var str = "Hello";
            var arr = new[] { 0, 1, 2 };
            Console.WriteLine("Переменная в качестве числа : " + num);
            Console.WriteLine("В качестве строки :" + str);
            Console.WriteLine("В качестве массива : " + arr);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Nullable - Переменные : ");
            int? var2 = 777;
            if (var2.HasValue)
            {
                Console.WriteLine("Nullable var2 :" + var2.Value);
            }
            else
            {
                Console.WriteLine("Error : var2 has no value!");
            }
            int? var3 = null;
            if (var3.HasValue)
            {
                Console.WriteLine("Nullable var3:" + var3.Value);
            }
            else
            {
                Console.WriteLine("Error: var3 has no value!");
            }
            Console.WriteLine("--------------------------");
            var variable = 12;
            Console.WriteLine("variable : " + variable);
            //  variable = -564.456; //Ошибка происходит, т.к невозможно неявно преобразовать int в double.
            Console.WriteLine("variable : " + variable);


            //Работа со строками
            String line = "Hello, world!";
            String line2 = "hello";
            String line3 = "new line";
            Console.WriteLine("CompareTo: " + line.CompareTo(line2));
            Console.WriteLine("Equals: " + line.Equals(line2));
            line2 = line;
            Console.WriteLine("CompareTo: " + line.CompareTo(line2));
            Console.WriteLine("Equals: " + line.Equals(line2));
            line = String.Concat(line2, line3);
            Console.WriteLine("Конкатенация : " + line);
            line2 = line2.Substring(4);
            Console.WriteLine(line2);
            String[] strArray = line.Split(" ");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(strArray[i] + " | ");
            }
            //Интерполяция строк
            Console.WriteLine($"\n Строка 1:{line} \n Строка 2:{line2} \n Строка 3: {line3}");


            String strNull = null;

            for (int i = 0; i < 3; i++)
            {
                if (String.IsNullOrEmpty(strNull))
                {
                    Console.WriteLine("Строка <strNull> является Null-строкой или пустой строкой!");
                }
                else
                {
                    Console.WriteLine("Строка <strNull> не является ни Null-строкой, ни пустой строкой!");
                }
                if (i == 0)
                    strNull = "";
                if (i == 1)
                    strNull = "kek";
            }

            //Работа со StringBuilder

            StringBuilder sbLine = new StringBuilder("Hello world!!!");
            Console.WriteLine("Новый StringBuilder :" + sbLine);
            sbLine.Clear();
            Console.WriteLine($"Строка после полного очищения : {sbLine}");
            sbLine.Append("\n Hello!");
            Console.WriteLine($"Строка после добавления новой строки : {sbLine}");
            sbLine.Insert(0, "Это начало!");
            Console.WriteLine($"Строка после добавления новой строки в начало : {sbLine}");
            sbLine.AppendFormat(line);
            Console.WriteLine($"строка после добавления другой строки : {sbLine}");
            sbLine.Remove(0, 10);
            Console.WriteLine($"Строка посе удаления первых 10 символов : {sbLine}");


            //Работа с массивами!

            int[,] matrix = { { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 3, 4, 5, 6, 7 }, { 4, 5, 6, 7, 8 }, { 5, 6, 7, 8, 9 } };
            int rows = matrix.GetUpperBound(0);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            String[] stringArray = { "Hello", ",", " ", "world", "!" };
            foreach (String element in stringArray)
            {
                Console.WriteLine(element);
            }
            int indeX = 100;
            Console.WriteLine($"Длина массива : {stringArray.Length} элементов");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Выберите позицию элемента, который хотите поменять и введите новый!");
                //       indeX = Convert.ToInt32(Console.ReadLine());
                if (indeX <= stringArray.Length)
                {
                    break;
                }
            }
            //   String newLine = Console.ReadLine();
            Console.WriteLine(indeX);
            //    stringArray[indeX] = newLine;

            Console.WriteLine("Новый массив :");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write(stringArray[i] + " ");
            }

            //зубчатый массив
            double[][] nums = new double[3][];
            nums[0] = new double[2];
            nums[1] = new double[3];
            nums[2] = new double[4];
            Console.WriteLine("Введите значения для ступенчатого массива : ");
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    //      Console.WriteLine($"Введите значение {j+1} элемента {i+1} строки : ");
                    //         nums[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j] + " ");
                }
                Console.WriteLine();
            }

            // неявно типизированные переменные для хранения массива или строки : 
            var typedArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var typedString = "неявно типизированная строка!";
            Console.WriteLine($"Неявно типизированная строка : {typedString}");
            Console.WriteLine($"Неявно типизированный массив : {typedArray}");

            //работа с кортежами : 
            (int, String, char, String, ulong) tuple = (666, "Это кортеж", 'a', "Четвертый элемент", 666);
            Console.WriteLine($"Полученный кортеж :{tuple}");
            Console.WriteLine($"Первый элемент кортежа :{tuple.Item1} \nЧетвертый элемент кортежа : {tuple.Item4}");
            int firstItem = tuple.Item1;
            Console.WriteLine("Первый элемент кортежа : " + firstItem);
            String secondItem = tuple.Item2;
            char thirdItem = tuple.Item3;
            String fourthItem = tuple.Item4;
            ulong fifthItem = tuple.Item5;

            //Сравнение кортежей 
            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);
            Console.WriteLine(left != right);

            var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 10);
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
            int[] intArr = { 1, 2, 3, 4, 5 };
            line = "Hello, world!";
            var kek = newFunc(intArr, line);
            Console.WriteLine(kek);


            static Tuple<int, int, int, String> newFunc(int[] array, String line)
            {
                int min = array[0];
                int max = array[0];
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                    if (array[i] < min)
                        min = array[i];
                    sum += array[i];
                }
                line = line.Substring(0, line.Length - (line.Length - 1));
                return Tuple.Create<int, int, int, String>(max, min, sum, line);
            }

            int function1()
            {
                int maxVal = 2147483647;
                int z = 0;
                try
                {
                    z = checked(maxVal + 11);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine(e.ToString());
                }
                return z;
            }
            int function2()
            {
                int maxVal = 2147483647;
                int z = 0;
                try
                {
                    z = maxVal + 11;
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine(e.ToString());
                }
                return z;
            }

            Console.WriteLine("fisrt : {0}", function1());
            Console.WriteLine("second : {0}", function2());
        }









    }
}
