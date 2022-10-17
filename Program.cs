int s=1;
string ? name=Console.ReadLine();
int razmer= Convert.ToInt32(name);
           // int razmer = int.Parse(Console.ReadLine());
            int [,]massiv = new int[razmer, razmer];
            for(int i = 0; i < razmer; i++)
            {
                for(int j = 0; j < razmer; j++)
                {
                    massiv[i, j] = 0;
                }
            }
            for (int y = 0; y < razmer; y++)
            {
                massiv[0,y] = s;
                s++;
            }
            for (int x = 1; x < razmer; x++)
            {
                massiv[x,razmer - 1] = s;
                s++;
            }
            for (int y = razmer - 2; y >= 0; y--)
            {
                massiv[razmer - 1,y] = s;
                s++;
            }
            for (int x = razmer - 2; x > 0; x--)
            {
                massiv[x,0] = s;
                s++;
            }
            int d = 1;
            int c = 1;
            while (s < massiv.Length)
            {
                while (massiv[c, d + 1] == 0)
                {
                 massiv[c, d] = s;
                    s++;
                    d++;
                }
                
                while (massiv[c + 1, d] == 0)
                {
                    massiv[c, d] = s;
                    s++;
                    c++;
                }

              
                while (massiv[c, d - 1] == 0)
                {
                    massiv[c, d] = s;
                    s++;
                    d--;
                }

                
                while (massiv[c - 1, d] == 0)
                {
                    massiv[c, d] = s;
                    s++;
                    c--;
                }
            }

            for (int x = 0; x < razmer; x++)
            {
                for (int y = 0; y < razmer; y++)
                {
                    if (massiv[x,y] == 0)
                    {
                        massiv[x,y] = s;
                    }
                }
            }
            for (int i = 0; i < razmer; i++)
            {
                for(int j = 0; j < razmer; j++)
                {
                    Console.Write(massiv[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            /*int a, b;
            Console.WriteLine("Введите два числа");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b) {
                Console.WriteLine($"Число {a} наибольшее, а число {b} наименьшее");
                }
            else if (a < b){
                Console.WriteLine($"Число {b} наибольшее, а число {a} наименьшее");
            }
            else {
                Console.WriteLine($"Число {a} равно числу {b}"); ;
            }
            */
