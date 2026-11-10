namespace StreamWriter.Web
{
    public class DelayDailyChallengeTextGenerator : IDailyChallengeTextGenerator
    {
        private readonly TimeSpan _delay;
        private readonly IDailyChallengeTextGenerator _inner;

        public DelayDailyChallengeTextGenerator(
            TimeSpan delay,
            IDailyChallengeTextGenerator inner)
        {
            _delay = delay;
            _inner = inner;
        }

        public async Task<string> GetText()
        {
            await Task.Delay(_delay);
            return await _inner.GetText();
        }
    }
}
