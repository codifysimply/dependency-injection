namespace Lifetime.Sample.WebApi.Services
{
    public class RandomService : IRandomService
    {
        private int random;
        public void GenerateRandom() => random = new Random().Next(1,10);
        public int GetRandom() => random;
    }
}
