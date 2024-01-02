using System;
using System.Security.Cryptography.X509Certificates;

namespace AdventCode
{
    internal class Program
    {
        //public record struct Location(int x, int y);

        public record struct Location
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        static void Main()
        {
            string input = File.ReadAllText("Day3.txt");
            //int uniqueHousesVisited = 1;
            Location currentLocation = new Location()
            {
                x = 0,
                y = 0,
            };
            HashSet<Location> visitedLocations = new HashSet<Location>()
            {
                currentLocation
            };

            foreach (char move in input)
            {
                switch (move)
                {
                    case 'v':
                        currentLocation.y--;
                        break;
                    case '>':
                        currentLocation.x++;
                        break;
                    case '<':
                        currentLocation.x--;
                        break;
                    case '^':
                        currentLocation.y++;
                        break;

                    default:
                        break;
                }

                //var isAdded =
                visitedLocations.Add(currentLocation);
                //if (isAdded == true)
                //{
                //    uniqueHousesVisited++;
                //}
            }

            Console.WriteLine(visitedLocations.Count);
            Console.ReadKey();
        }

    }

}

//private static void Day2()
//        {
//            //directions
//            //Day1();
//            string[] input = File.ReadAllLines("Day2.txt");
//            //string[] input = new []{"1x1x10"};
//            var counter = 0;
//            var ribbonCounter = 0;
//            for (int i = 0; i < input.Length; i++)
//            {
//                var dimensions = input[i].Split('x');
//                var length = int.Parse(dimensions[0]);
//                var width = int.Parse(dimensions[1]);
//                var height = int.Parse(dimensions[2]);

//                Console.WriteLine($"{length}, {width}, {height}");

//                var calculation1 = (length * width);
//                var calculation2 = (width * height);
//                var calculation3 = (height * length);

//                var perimeter = new int[]
//                {
//                    length,
//                    width,
//                    height,
//                }.OrderBy(x => x).ToArray();

//                ribbonCounter += perimeter[0] + perimeter[0] + perimeter[1] + perimeter[1] + (length * width * height);

//                var smallest = new int[]
//                {
//                    calculation1,
//                    calculation2,
//                    calculation3,
//                }.Min();

//                Console.WriteLine(smallest);
//                counter += (2 * calculation1) + 2 * calculation2 + 2 * calculation3 + smallest;
//            }

//            Console.WriteLine(counter);
//            Console.WriteLine(ribbonCounter);
//        }

//        private static void Day1()
//        {
//            int counter = 0;
//            string input = File.ReadAllText("day1.txt");
//            for (int i = 0; i < input.Length; i++)
//            {
//                var character = input[i];
//                if (character == '(')
//                {
//                    counter++;
//                }
//                else
//                {
//                    counter--;
//                }

//                if (counter == -1)
//                {
//                    Console.WriteLine(i);
//                    return;
//                }

//                Console.WriteLine(counter);
//            }
//        }
//    }
//}
