namespace StreamWriter.Web
{
    public class RotatingDailyChallengeTextGenerator : IDailyChallengeTextGenerator
    {
        private readonly string[] _texts;
        private int _textIndex;

        public RotatingDailyChallengeTextGenerator(string[] texts)
        {
            _texts = texts;
            _textIndex = 0;
        }

        public Task<string> GetText()
        {
            string result = _texts[_textIndex];
            _textIndex = (_textIndex + 1) % _texts.Length;
            return Task.FromResult(result);
        }
    }
}
