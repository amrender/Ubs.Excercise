using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ubs.Excercise
{
    /// <summary>
    /// class that add extention methods to string class for finding word stats in a sentence
    /// </summary>
    public static class StringExtentions
    {
        static readonly char[] WordSeparator = { ',', '.', ' ' };
        /// <summary>
        /// find word stats in a given string. Assumption is string contain only one sentence
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        static public string WordStats(this string sentence)
        {
            var stats = sentence.Split(WordSeparator, StringSplitOptions.RemoveEmptyEntries)
                        .GroupBy(x => x.ToLower())
                        .Select(x => string.Format("{0} - {1}", x.Key, x.Count()));
            return string.Join( "\n",stats);
        }
        
        /// <summary>
        /// Stats methos without using non linq methods
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        static public string WordStatsNonLinq(this string sentence)
        {
            var wordCount = SentenceStats(sentence);
            return JoinStringList(wordCount);
        }

        /// <summary>
        /// Join strings in the string collection
        /// </summary>
        /// <param name="stringCollection"></param>
        /// <param name="appender"></param>
        /// <returns></returns>
        private static string JoinStringList(IEnumerable<object> stringCollection, char appender = '\n')
        {
            
            var result = new StringBuilder();
            foreach (var statsCounter in stringCollection)
            {
                result.AppendFormat(statsCounter.ToString());
                result.AppendLine();
            }
            return result.Length > 0 ? result.ToString(0, result.Length - 2) : string.Empty;
        }

        /// <summary>
        /// This could be made public to provide stats counter collection, so easy to manage. Calculate word stats for a given sentence using non extention method. 
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        private static IEnumerable<StatsCounter> SentenceStats(string sentence)
        {
            var words = sentence.Split(WordSeparator, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new List<StatsCounter>();
            foreach (var word in words)
            {
                var wordTuple =
                    wordCount.FirstOrDefault(x => String.Compare(x.Word, word, StringComparison.OrdinalIgnoreCase) == 0);
                if (wordTuple == null)
                {
                    wordTuple = new StatsCounter(word.ToLower());
                    wordCount.Add(wordTuple);
                }
                else
                {
                    wordTuple.IncrementCount();
                }
            }
            return wordCount;
        }
    }
}
