namespace Lifetime.Sample.WebApi.Services
{
    public class FirstService : IFirstService
    {
        private readonly IRandomService randomService;
        public FirstService(IRandomService randomService) => this.randomService = randomService;
        public void Genearet() => randomService.GenerateRandom();
        public int Get() => randomService.GetRandom();
        public int GetRandomHashCode() => randomService.GetHashCode();
    }
}
