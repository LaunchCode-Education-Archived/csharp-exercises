using System.Collections.Generic;
using System.Text;

namespace TechJobs
{
    class JobData
    {
        static List<Dictionary<string, string>> allJobs = new List<Dictionary<string, string>>();
        static bool isDataLoaded = false;

        /*
         * Fetch list of all employers from loaded data,
         * without duplicates.
         */
        public static List<string> getAllEmployers() {

            loadData();

            List<string> employers = new List<string>();

            foreach (Dictionary<string, string> job in allJobs) {

                string anEmployer = job["employer"];

                if (!employers.Contains(anEmployer))
                {
                    employers.Add(anEmployer);
                }
                
            }

            return employers;
        }

        /*
         * Returns results of search the jobs data by employer, using
         * inclusion of the search term.
         *
         * For example, searching for "Enterprise" will include results
         * with "Enterprise Holdings, Inc" as the employer.
         */
        public static List<Dictionary<string, string>> getJobsByEmployer(string employer)
        {
            loadData();

            List<Dictionary<string, string>> jobs = new List<Dictionary<string, string>>();

            foreach (Dictionary<string, string> job in allJobs)
            {
                string anEmployer = job["employer"];

                if (anEmployer.Contains(employer))
                {
                    jobs.Add(job);
                }
            }

            return jobs;
        }

        /*
         * Fetch list of all employers from loaded data,
         * without duplicates.
         */
        public static List<string> getAllSkills()
        {

            loadData();

            List<string> skills = new List<string>();

            foreach (Dictionary<string, string> job in allJobs)
            {
                string[] jobSkills = job["skills"].Split(',');
                foreach (string skill in jobSkills) {

                    // There might be a pace before or after the skill name
                    string trimmmedSkill = skill.Trim();

                    // Only add the skill if it's not already in the list
                    if (!skills.Contains(trimmmedSkill))
                    {
                        skills.Add(trimmmedSkill);
                    }
                }
                
            }

            return skills;
        }

        /*
         * Returns results of search the jobs data by skill, using
         * inclusion of the search term.
         *
         * For example, searching for "HTML" will include results
         * with "HTML, JS, CSS" in the skills field.
         */
        public static List<Dictionary<string, string>> getJobsBySkill(string skill)
        {
            loadData();

            List<Dictionary<string, string>> jobs = new List<Dictionary<string, string>>();

            foreach (Dictionary<string, string> job in allJobs)
            {
                string jobSkills = job["skills"];

                if (jobSkills.Contains(skill))
                {
                    jobs.Add(job);
                }
            }

            return jobs;
        }

        /*
         * Load and parse data from Resrouces/job_data.csv
         */
        private static void loadData()
        {

            if (isDataLoaded) {
                return;
            }

            string rawData = TechJobs.Properties.Resources.job_data;
            string[] lines = rawData.Split('\n');
            List<string[]> rows = new List<string[]>();

            // Parse each row into an array
            foreach (string line in lines) {
                string[] rowArrray = CSVRowToStringArray(line);
                if (rowArrray.Length > 0)
                {
                    rows.Add(rowArrray);
                }
            }

            string[] headers = rows[0];
            rows.Remove(headers);

            // Parse each row array into a more friendly Dictionary
            foreach (string[] row in rows)
            {
                Dictionary<string, string> rowDict = new Dictionary<string, string>();

                for (int i = 0; i < headers.Length; i++) {
                    rowDict.Add(headers[i], row[i]);
                }

                allJobs.Add(rowDict);
            }

            isDataLoaded = true;
        }

        /*
         * Parse a single line of a CSV file into a string array
         */
        private static string[] CSVRowToStringArray(string r, char fieldSep = ',', char stringSep = '\"')
        {
            bool bolQuote = false;
            StringBuilder bld = new StringBuilder();
            List<string> retAry = new List<string>();

            foreach (char c in r.ToCharArray())
            {
                if ((c == fieldSep && !bolQuote))
                {
                    retAry.Add(bld.ToString());
                    bld.Clear();
                }
                else
                {
                    if (c == stringSep)
                    {
                        bolQuote = !bolQuote;
                    }
                    else
                    {
                        bld.Append(c);
                    }
                }
            }

            return retAry.ToArray();
        }
    }
}
