using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immune_System
{
    class Immune_System
    {
        static void Main(string[] args)
        {
            int ImmuneSystemPower = int.Parse(Console.ReadLine());
            int OriginPower = ImmuneSystemPower;
            string disease;
            List<string> KnownDiseases = new List<string>();
            while ((disease = Console.ReadLine()) != "end")
            {
                int TimeForWinning = 1;
                int DiseasePower = 0;
                if (ImmuneSystemPower <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    string word = disease;
                    int br = 0;
                    for (int j = 0; j < word.Length; j++)
                    {
                        DiseasePower = DiseasePower + word[j];
                        br++;
                    }
                    DiseasePower = DiseasePower / 3;
                    if (KnownDiseases.Contains(disease) == false)
                    {
                        KnownDiseases.Add(disease);
                        TimeForWinning = DiseasePower * br;
                    }
                    else
                    {
                        if(disease == KnownDiseases[KnownDiseases.Count - 1]) TimeForWinning = DiseasePower * br/3;
                        else TimeForWinning = (DiseasePower * br) / 3;
                    }
                    Console.WriteLine($"Virus {disease}: {DiseasePower} => {TimeForWinning} seconds");
                    ImmuneSystemPower = ImmuneSystemPower - TimeForWinning;
                    if (ImmuneSystemPower > 0)
                    {
                        Console.WriteLine($"{disease} defeated in {TimeForWinning / 60}m {TimeForWinning % 60}s.");
                        Console.WriteLine($"Remaining health: {ImmuneSystemPower}");
                    }
                    ImmuneSystemPower = ImmuneSystemPower + ImmuneSystemPower / 5;
                    if (ImmuneSystemPower > OriginPower) ImmuneSystemPower = OriginPower;
                }
            }
            if (ImmuneSystemPower > 0) Console.WriteLine($"Final Health: {ImmuneSystemPower}");
        }
    }
}
