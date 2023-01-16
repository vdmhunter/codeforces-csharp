namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20220817.ProblemH01;

public static class Program
{
    public static void Main(string[] args)
    {
        var nm = Console.ReadLine()!.Split(' ');
        var m = Convert.ToInt32(nm[1]);

        var currentTime = 0;
        var totalEnergy = 0L;

        var processors = Console.ReadLine()!
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(a => new Processor(currentTime, Convert.ToInt32(a)))
            .ToArray();

        var freeProcessors = new PriorityQueue<Processor, long>();

        foreach (var processor in processors)
            freeProcessors.Enqueue(processor, processor.EnergyConsumption);

        var busyProcessors = new PriorityQueue<Processor, long>();

        for (var i = 0; i < m; i++)
        {
            var tl = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var t = Convert.ToInt32(tl[0]);
            var l = Convert.ToInt32(tl[1]);

            var diffTime = t - currentTime;
            currentTime += diffTime;
            
            while (true)
                if (busyProcessors.Count > 0)
                {
                    var firstBusyProcessor = busyProcessors.Peek();

                    if (firstBusyProcessor.ReleaseTime - currentTime <= 0)
                    {
                        busyProcessors.Dequeue();
                        freeProcessors.Enqueue(firstBusyProcessor, firstBusyProcessor.EnergyConsumption);
                    }
                    else
                        break;
                }
                else
                    break;

            if (freeProcessors.Count == 0)
                continue;

            var currentProcessor = freeProcessors.Dequeue();

            totalEnergy += currentProcessor.EnergyConsumption * l;
            currentProcessor.ReleaseTime = currentTime + l;

            busyProcessors.Enqueue(currentProcessor, currentTime + l);
        }

        Console.WriteLine(totalEnergy);
    }

    private struct Processor
    {
        public long ReleaseTime;

        public readonly long EnergyConsumption;

        public Processor(long releaseTime, long energyConsumption)
        {
            ReleaseTime = releaseTime;
            EnergyConsumption = energyConsumption;
        }
    }
}
