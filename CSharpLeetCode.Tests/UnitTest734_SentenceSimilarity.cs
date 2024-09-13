using System.Collections;

namespace CSharpLeetCode.Tests
{
    public class UnitTest734TestCase
    {
        public string[] FirstSentence { get; }
        
        public string[] SecondSentence { get; }

        public IList<IList<string>> SimilarPairs { get; }
        
        public bool Expected { get; }

        public UnitTest734TestCase(string[] firstSentence, string[] secondSentence, IList<IList<string>> pairs, bool expected)
        {
            FirstSentence = firstSentence;
            SecondSentence = secondSentence;
            SimilarPairs = pairs;
            Expected = expected;
        }
    }
    
    public class UnitTest734SentenceSimilarity
    {
        private static UnitTest734TestCase FirstCase = new UnitTest734TestCase(
            new string[] {"great", "acting", "skills"},
            new string[] {"fine", "drama", "talent"},
            new List<IList<string>>()
            {
                new List<string>() {"great", "fine"},
                new List<string>() {"drama", "acting"},
                new List<string>() {"skills", "talent"}
            },
            true
        );
        
        public static IEnumerable<object[]> TestCases
        {
            get
            {
                yield return new object[] {FirstCase};
                yield return new object[] {SecondCase};
            }
        }

        private static UnitTest734TestCase SecondCase = new UnitTest734TestCase(
            new string[] {"an", "extraordinary", "meal"},
            new string[] {"one", "good", "dinner"},
            new List<IList<string>>()
            {
                new List<string>() {"great", "good"},
                new List<string>() {"extraordinary", "good"},
                new List<string>() {"well", "good"},
                new List<string>() {"wonderful", "good"},
                new List<string>() {"excellent", "good"},
                new List<string>() {"fine", "good"},
                new List<string>() {"nice", "good"},
                new List<string>() {"any", "one"},
                new List<string>() {"some", "one"},
                new List<string>() {"unique", "one"},
                new List<string>() {"the", "one"},
                new List<string>() {"an", "one"},
                new List<string>() {"single", "one"},
                new List<string>() {"a", "one"},
                new List<string>() {"truck", "car"},
                new List<string>() {"wagon", "car"},
                new List<string>() {"automobile", "car"},
                new List<string>() {"auto", "car"},
                new List<string>() {"vehicle", "car"},
                new List<string>() {"entertain", "have"},
                new List<string>() {"drink", "have"},
                new List<string>() {"eat", "have"},
                new List<string>() {"take", "have"},
                new List<string>() {"fruits", "meal"},
                new List<string>() {"brunch", "meal"},
                new List<string>() {"breakfast", "meal"},
                new List<string>() {"food", "meal"},
                new List<string>() {"dinner", "meal"},
                new List<string>() {"super", "meal"},
                new List<string>() {"lunch", "meal"},
                new List<string>() {"possess", "own"},
                new List<string>() {"keep", "own"},
                new List<string>() {"have", "own"},
                new List<string>() {"extremely", "very"},
                new List<string>() {"actually", "very"},
                new List<string>() {"really", "very"},
                new List<string>() {"super", "very"}
            },
            true
        );

        private readonly SentenceSimilaritySolution _solution = new SentenceSimilaritySolution();
        
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test_SentenceSimilarity(UnitTest734TestCase testCase)
        {
            var result = _solution.AreSentencesSimilar(testCase.FirstSentence, testCase.SecondSentence, testCase.SimilarPairs);
            
            Assert.That(result, Is.EqualTo(testCase.Expected));
        }
    }
}