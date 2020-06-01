using System;
using System.Collections.Generic;
using System.Text;

namespace Generator_for_Dump_Passwords.Model
{
    class Generator
    {
        public int N { get; set; }
        public int L { get; set; }
        public List<string> passwords;
        public Generator()
        {
            passwords = new List<string>();
        }

        public void GeneratePasswords()
        {
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    for (char k = 'a'; k < 'a' + L; k++)
                    {
                        for (char l = 'a'; l < 'a' + L; l++)
                        {
                            for (int n = Math.Max(i, j) + 1; n <= N; n++)
                            {
                                passwords.Add($"{i}{j}{k}{l}{n}");
                            }
                        }
                    }
                }
            }
        }
    }
}
