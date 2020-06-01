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
            string input;
            List<string> disease = new List<string>();
            List<string> KnownDiseases = new List<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                disease.Add(input);
            }
            int[] DiseasePower = new int[disease.Count];
            int[] TimeForWinning = new int[disease.Count];
            for (int i = 0; i < disease.Count; i++)
            {
                if (ImmuneSystemPower <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    string word = disease[i];
                    int br = 0;
                    for (int j = 0; j < word.Length; j++)
                    {
                        char temp = word[j];
                        DiseasePower[i] = (DiseasePower[i] + (int)temp);
                        br++;
                    }
                    DiseasePower[i] = DiseasePower[i] / 3;
                    if (disease[i] == disease[disease.Count - 1])
                    {
                        if (KnownDiseases.Contains(disease[i]) == false)
                        {
                            KnownDiseases.Add(disease[i]);
                            TimeForWinning[i] = DiseasePower[i] * br;
                        }
                        else
                        {
                            TimeForWinning[i] = (DiseasePower[i] * br) / 3;
                        }
                    }
                    else
                    {
                        if (KnownDiseases.Contains(disease[i]) == false && disease[i] != disease[i + 1])
                        {
                            KnownDiseases.Add(disease[i]);
                            TimeForWinning[i] = DiseasePower[i] * br;
                        }
                        else
                        {
                            TimeForWinning[i] = (DiseasePower[i] * br) / 3;
                        }
                    }
                    Console.WriteLine($"Virus {disease[i]}: {DiseasePower[i]} => {TimeForWinning[i]} seconds");
                    ImmuneSystemPower = ImmuneSystemPower - TimeForWinning[i];
                    if (ImmuneSystemPower > 0)
                    {
                        Console.WriteLine($"{disease[i]} defeated in {TimeForWinning[i] / 60}m {TimeForWinning[i] % 60}s.");
                        Console.WriteLine($"Remaining health: {ImmuneSystemPower}");
                    }
                    ImmuneSystemPower = ImmuneSystemPower + ImmuneSystemPower / 5;
                    if (ImmuneSystemPower > OriginPower) ImmuneSystemPower = OriginPower;
                }
            }
            if (ImmuneSystemPower > 0) Console.WriteLine($"Final Health: {ImmuneSystemPower}");
            //else Console.WriteLine("Immune System Defeated.");
        }
    }
}