using System;

namespace SupportCases
{
    enum PriorityLevel
    {
        Critical,
        Important,
        Medium,
        Low
    }

    struct SupportTicket
    {
        public long Id;
        public string Description;
        public PriorityLevel Priority;

        public SupportTicket(long id, string description, PriorityLevel priority)
        {
            this.Id = id;
            this.Description = description;
            this.Priority = priority;
        }
    }

    class Program
    {
        static void Main()
        {
            SupportTicket[] tickets = ReadSupportTickets();
            Quick3Sort(tickets, 0, tickets.Length - 1);
            Print(tickets);
            Console.Read();
        }

        static void Quick3Sort(SupportTicket[] tickets, int start, int end)
        {
            int i;
            if (start >= end)
            {
                return;
            }

            i = Partition(tickets, start, end);

            Quick3Sort(tickets, start, i - 1);
            Quick3Sort(tickets, i + 1, end);
        }

        static int Partition(SupportTicket[] tickets, int start, int end)
        {
            SupportTicket temp;
            PriorityLevel p = tickets[end].Priority;
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (tickets[j].Priority < p)
                {
                    i++;
                    temp = tickets[i];
                    tickets[i] = tickets[j];
                    tickets[j] = temp;
                }
            }

            temp = tickets[i + 1];
            tickets[i + 1] = tickets[end];
            tickets[end] = temp;
            return i + 1;
        }

        static void Print(SupportTicket[] tickets)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                Console.WriteLine(tickets[i].Id + " - " + tickets[i].Description + " - " + tickets[i].Priority);
            }
        }

        static SupportTicket[] ReadSupportTickets()
        {
            const int ticketIdIndex = 0;
            const int descriptionIndex = 1;
            const int priorityLevelIndex = 2;

            int ticketsNumber = Convert.ToInt32(Console.ReadLine());
            SupportTicket[] result = new SupportTicket[ticketsNumber];

            for (int i = 0; i < ticketsNumber; i++)
            {
                string[] ticketData = Console.ReadLine().Split('-');
                long id = Convert.ToInt64(ticketData[ticketIdIndex]);
                result[i] = new SupportTicket(id, ticketData[descriptionIndex].Trim(), GetPriorityLevel(ticketData[priorityLevelIndex]));
            }

            return result;
        }

        static PriorityLevel GetPriorityLevel(string priority)
        {
            switch (priority.ToLower().Trim())
            {
                case "critical":
                    return PriorityLevel.Critical;
                case "important":
                    return PriorityLevel.Important;
                case "medium":
                    return PriorityLevel.Medium;
            }

            return PriorityLevel.Low;
        }
    }
}
