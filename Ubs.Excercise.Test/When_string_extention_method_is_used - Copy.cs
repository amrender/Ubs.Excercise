using System;
using NUnit.Framework;
namespace Ubs.Excercise.Test
{
    /// <summary>
    /// Test class for new stats string extention method.
    /// </summary>
    [TestFixture]
    public class When_string_extention_method_is_used
    {
        [Test]
        public void Should_pass_test_for_given_a_sentence()
        {
            const string expectedResult = "this - 2 is - 2 a - 1 statement - 1 and - 1 so - 1";
            const string sentance = "This is a statement, and so is this.";
            var result = sentance.WordStats().Replace('\n',' '); // Removing \n for clarity
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Should_pass_test_for_given_a_sentence_using_nonlinq()
        {
            const string expectedResult = "this - 2 is - 2 a - 1 statement - 1 and - 1 so - 1";
            const string sentance = "This is a statement, and so is this.";
            var result = sentance.WordStatsNonLinq().Replace(Environment.NewLine, " "); // Removing \n for clarity
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Emptystring_should_have_no_stat()
        {
            var expectedResult = string.Empty;
            var sentance = string.Empty;
            var result = sentance.WordStats();
            Assert.That(result, Is.SameAs(expectedResult));
        }

    }
}
