namespace Lifetime.Sample.WebApi.Services
{
    public class SecondService : ISecondService
    {
        private readonly IRandomService randomService;
        public SecondService(IRandomService randomService) => this.randomService = randomService;
        public void Genearet() => randomService.GenerateRandom();
        public int Get() => randomService.GetRandom();
        public int GetRandomHashCode() => randomService.GetHashCode();

    }
}
