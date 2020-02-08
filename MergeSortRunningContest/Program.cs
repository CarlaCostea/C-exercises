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
            int numberOfSeries = contest.Series.Length;
            contest.GeneralRanking.Contestants = new Contestant[count1 * numberOfSeries];
            for (int k = 0; k < contest.Series[0].Contestants.Length; k++)
            {
                contest.GeneralRanking.Contestants[k] = contest.Series[0].Contestants[k];
            }

            int currentSerie = 1;
            while (numberOfSeries != 1)
            {
                Merge(ref contest, currentSerie);
                currentSerie++;
                numberOfSeries--;
            }
        }

        private static void Merge(ref Contest contest, int currentSerie)
        {
            int count2 = contest.Series[currentSerie].Contestants.Length;
            int count1 = count2 + (currentSerie - 1) * count2;
            int a = 0;
            int b = 0;
            int i = 0;
            Contest intermediate;
            intermediate.GeneralRanking.Contestants = new Contestant[count1 + count2];
            while (a < count1 && b < count2)
            {
                intermediate.GeneralRanking.Contestants[i++] = contest.GeneralRanking.Contestants[a].Time <= contest.Series[currentSerie].Contestants[b].Time
                    ? contest.GeneralRanking.Contestants[a++]
                    : contest.Series[currentSerie].Contestants[b++];
            }

            if (a < count1)
            {
                // fill tail from first array
                for (int j = a; j < count1; j++)
                {
                    intermediate.GeneralRanking.Contestants[i++] = contest.GeneralRanking.Contestants[j];
                }
            }
            else
            {
                // fill tail from second array
                for (int j = b; j < count2; j++)
                {
                    intermediate.GeneralRanking.Contestants[i++] = contest.Series[currentSerie].Contestants[j];
                }
            }

            contest.GeneralRanking = intermediate.GeneralRanking;
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