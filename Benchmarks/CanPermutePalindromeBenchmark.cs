using BenchmarkDotNet.Attributes;
using CSharpLeetCode;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class CanPermutePalindromeBenchmark
    {
        [Params("code", "aab", "carerac", "aa", "aabb")]
        public string s;

        [Benchmark(Baseline = true)]
        public bool CanPermutePalindromeClassic()
        {
            return new PalindromePermutationSolution().CanPermutePalindrome(s);
        }

        [Benchmark]
        public bool CanPermutePalindromeModified()
        {
            return new PalindromePermutationSolution().CanPermutePalindromeModified(s);
        }
    }
}