// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
            string[] M;
            Console.WriteLine("Введите массив строк (через пробел)");
            string stroke = Console.ReadLine();
            M = stroke.Split(' ');
            var result = new string[M .Length];
            var theSize = 0;
            foreach (var value in M )
            {
                if (value.Length <= 3)
                {
                    result[theSize] = value;
                    theSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, theSize));
            Console.ReadKey(true);