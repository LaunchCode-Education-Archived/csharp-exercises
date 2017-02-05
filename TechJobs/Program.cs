using System;
using System.Collections.Generic;

namespace TechJobs
{
    class Program
    {
        private static string[] actionChoices = { "Browse", "Search" };
        private static string[] browseChoices = { "Skill", "Employer" };
        private static string[] searchChoices = { "Skill", "Employer" };

       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LaunchCode's TechJobs App!");

            // Allow user to search/browse until they manually quit with ctrl+c
            while (true) {

                int actionChoice = displayChoiceMenu("View Jobs", actionChoices);

                if (actionChoices[actionChoice].Equals("Browse"))
                {
                    int browseChoice = displayChoiceMenu("Browse", browseChoices);

                    if (browseChoices[browseChoice].Equals("Employer"))
                    {
                        List<string> allEmployers = JobData.getAllEmployers();

                        Console.WriteLine("\n***All Employers***");
                        foreach (string employer in allEmployers)
                        {
                            Console.WriteLine(employer);
                        }
                    }
                    else
                    {
                        List<string> allSkills = JobData.getAllSkills();

                        Console.WriteLine("\n***All Skills***");
                        foreach (string skill in allSkills)
                        {
                            Console.WriteLine(skill);
                        }
                    }
                }
                else // choice is "search"
                {
                    // How does the user want to search (e.g. by skill or employer)
                    int searchChoice = displayChoiceMenu("Search", searchChoices);

                    // What is their search term?
                    Console.WriteLine("\nSearch term: ");
                    string searchTerm = Console.ReadLine();

                    List<Dictionary<string, string>> searchResults;

                    // Fetch results
                    if (searchChoices[searchChoice].Equals("Skill"))
                    {
                        searchResults = JobData.getJobsBySkill(searchTerm);
                    }
                    else
                    {
                        searchResults = JobData.getJobsByEmployer(searchTerm);
                    }

                    // Print results
                    if (searchResults.Count == 0)
                    {
                        Console.WriteLine("No results");
                    }
                    else
                    {
                        printJobs(searchResults);
                    }
                }
            }
        }

        private static int displayChoiceMenu(string choiceText, string[] choices)
        {
            int result;
            bool isValidChoice = false;

            do
            {
                Console.WriteLine("\n" + choiceText + " by:");

                for (int i = 0; i < choices.Length; i++)
                {
                    Console.WriteLine(i + " - " + choices[i]);
                }

                string input = Console.ReadLine();
                result = int.Parse(input);

                if (result < 0 || result >= choices.Length)
                {
                    Console.WriteLine("Invalid choices. Try again.");
                }
                else
                {
                    isValidChoice = true;
                }

            } while (!isValidChoice);

            return result;
        }

        private static void printJobs(List<Dictionary<string, string>> someJobs)
        {
            foreach (Dictionary<string, string> job in someJobs)
            {
                string jobString = "\n*****" +
                        "\nEmployer: " + job["employer"] +
                        "\nName: " + job["name"] +
                        "\nDescription: " + job["desc"] +
                        "\nSkills: " + job["skills"] +
                        "\n*****";

                Console.WriteLine(jobString);
            }
        }
    }
}
