using System;

namespace RunningContest
{
    struct Contestant
    {
        public string Name;
        public string Country;
        public double Time;

        public Contestant(string name, string country, double time)
        {
            this.Name = name;
            this.Country = country;
            this.Time = time;
        }
    }

    struct ContestRanking
    {
        public Contestant[] Contestants;
    }

    struct Contest
    {
        public ContestRanking[] Series;
        public ContestRanking GeneralRanking;
    }

    class Program
    {
        static void Main()
        {
            Contest contest = ReadContestSeries();
            GenerateGeneralRanking(ref contest);
            Print(contest.GeneralRanking);
            Console.Read();
        }

        private static void Print(ContestRanking contestRanking)
        {
            for (int i = 0; i < contestRanking.Contestants.Length; i++)
            {
                Contestant contestant = contestRanking.Contestants[i];
                const string line = "{0} - {1} - {2:F3}";
                Console.WriteLine(string.Format(line, contestant.Name, contestant.Country, contestant.Time));
            }
        }

        static void GenerateGeneralRanking(ref Contest contest)
        {
            int count1 = contest.Series[0].Contestants.Length;
            int count2 = contest.Series[1].Contestants.Length;

            int a = 0, b = 0;   // indexes in origin arrays
            int i = 0;          // index in result array
            contest.GeneralRanking.Contestants = new Contestant[count1 + count2];
            // join
            while (a < count1 && b < count2)
            {
                if (contest.Series[0].Contestants[a].Time <= contest.Series[1].Contestants[b].Time)
                {
                    // element in first array at current index 'a'
                    // is less or equals to element in second array at index 'b'
                    contest.GeneralRanking.Contestants[i++] = contest.Series[0].Contestants[a++];
                }
                else
                {
                    contest.GeneralRanking.Contestants[i++] = contest.Series[1].Contestants[b++];
                }
            }

            // tail
            if (a < count1)
            {
                // fill tail from first array
                for (int j = a; j < count1; j++)
                {
                    contest.GeneralRanking.Contestants[i++] = contest.Series[0].Contestants[j]; ;
                }
            }
            else
            {
                // fill tail from second array
                for (int j = b; j < count2; j++)
                {
                    contest.GeneralRanking.Contestants[i++] = contest.Series[1].Contestants[j];
                }
            }

        }

        

        static Contest ReadContestSeries()
        {
            Contest contest = new Contest();

            int seriesNumber = Convert.ToInt32(Console.ReadLine());
            int contestantsPerSeries = Convert.ToInt32(Console.ReadLine());

            contest.Series = new ContestRanking[seriesNumber];

            for (int i = 0; i < seriesNumber; i++)
            {
                contest.Series[i].Contestants = new Contestant[contestantsPerSeries];
                for (int j = 0; j < contestantsPerSeries; j++)
                {
                    string contestantLine = "";

                    while (contestantLine == "")
                    {
                        contestantLine = Console.ReadLine();
                    }

                    contest.Series[i].Contestants[j] = CreateContestant(contestantLine.Split('-'));
                }
            }

            return contest;
        }

        private static Contestant CreateContestant(string[] contestantData)
        {
            const int nameIndex = 0;
            const int countryIndex = 1;
            const int timeIndex = 2;

            return new Contestant(
                contestantData[nameIndex].Trim(),
                contestantData[countryIndex].Trim(),
                Convert.ToDouble(contestantData[timeIndex]));
        }
    }
}

