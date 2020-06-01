using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Skeleton
{
    class TrainsSkeleton
    {
        private static Deque<Train> trains = new Deque<Train>();
        private static Stack<Train> history = new Stack<Train>();

        private static void Add(int number, string name, string type, int cars)
        {
            if (type == "F")
            {
                //Add freight trains to back
                trains.AddBack(new Train(number, name, type, cars));
            }
            else
            {
                trains.AddFront(new Train(number, name, type, cars));
            }
        }
        private static void Travel()
        {
            if (trains.Count > 0)
            {

                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {                   
                    Console.WriteLine(trains.RemoveBack());
                    history.Push(backTrain);
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    Console.WriteLine(trains.RemoveFront());
                    history.Push(frontTrain);
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    Console.WriteLine(trains.RemoveBack());
                    history.Push(backTrain);
                }
            }
        }
        private static void Next()
        {
            if (trains.Count > 0)
            {

                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    Console.WriteLine(backTrain);
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    Console.WriteLine(frontTrain);
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    Console.WriteLine(backTrain);
                }
            }
        }

        private static void History()
        {
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {

            string[] command;
            do
            {
                command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Add":
                        Add(int.Parse(command[1]), command[2], command[3], int.Parse(command[4]));
                        break;
                    case "Travel":
                        Travel();
                        break;
                    case "Next":
                        Next();
                        break;
                    case "History":
                        History();
                        break;
                }
            } while (command[0] != "End");

        }


    }
}
/*Add 85611 Karlovo P 2
Add 82223 Sofia P 3
Add 12123 Varna P 4
Next
Travel
Next
Add 12125 Plovdiv P 4
Add 12126 Karnobat P 4
Travel
Next
Travel
Add 12127 Karnobat P 2
End

Add 85611 Karlovo P 2
Add 82223 Sofia P 3
Add 12123 Varna P 4
Next
Travel
Next
Add 12125 Plovdiv P 4
Add 12126 Karnobat P 4
Travel
History
Next
Travel
History
End

Add 31233 BobovDol F 30
Add 85611 Karlovo P 3
Add 22222 Tulovo F 10
Travel
Travel
Travel
Add 31234 BobovDol F 30
Add 85612 Karlovo P 3
Travel
History
End
*/