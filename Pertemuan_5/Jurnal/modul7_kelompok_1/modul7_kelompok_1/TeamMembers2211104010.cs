using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Jurnal7
{
    public class TeamMembers2211104010
    {
        // Model Anggota
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        // Model Tim
        public class Team
        {
            public List<Member> members { get; set; }
        }

        public static void ReadJSON()
        {
            // Sesuaikan dengan nama file JSON kamu
            string filePath =( "jurnal7_2_2211104010.json");

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                Team team = JsonConvert.DeserializeObject<Team>(jsonContent);

                Console.WriteLine("Team member list:");
                foreach (var member in team.members)
                {
                    Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON file:");
                Console.WriteLine($"Message: {ex.Message}");
            }
        }
    }
}
