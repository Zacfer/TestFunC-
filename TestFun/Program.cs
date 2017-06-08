using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFun
{
    class Program
    {
        static void Main(string[] args)
        {
            var participant1 = new Participant("Zac", 1);
            var participant2 = new Participant("Denis", 2);
            var participant3 = new Participant("Eoin", 3);

            var participants = new List<Participant>
            {
                participant1,
                participant2,
                participant3
            };

            var prizes = new Dictionary<int, decimal>
            {
                { 1, 3.45m },
                { 2, 2.34m },
                { 3, 1.23m }
            };

            AwardPrizes(participants, prizes);
            Console.ReadKey();
        }

        static void AwardPrizes(IList<Participant> participants, IDictionary<int, decimal> prizes)
        {
            var sortedParticipants = participants.OrderByDescending(x => x.Score).ToList();

            int i = 0;
            sortedParticipants.ForEach(Participant => Participant.Prize = prizes[++i]);

            sortedParticipants.ForEach(Console.WriteLine);
        }
    }
}
