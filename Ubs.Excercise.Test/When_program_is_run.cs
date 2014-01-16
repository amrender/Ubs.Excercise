using NUnit.Framework;
namespace Ubs.Excercise.Test
{
    /// <summary>
    /// class to tests application to calculate sentence stats.
    /// </summary>
    [TestFixture]
    public class When_program_is_run
    {
        [Test]
        public void Should_pass_test_for_given_a_sentence()
        {
            const string expectedResult = "this - 2 is - 2 a - 1 statement - 1 and - 1 so - 1";
            const string sentance = "This is a statement, and so is this.";
            var result = Given_a_process_runner.Give_a_sentence_stats_calculator(sentance).Replace('\n', ' '); // Removing \n for clarity
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Emptystring_should_have_no_stats()
        {
            var expectedResult = string.Empty;
            var sentance = string.Empty;
            var result = Given_a_process_runner.Give_a_sentence_stats_calculator(sentance);
            Assert.That(result, Is.SameAs(expectedResult));
        }

    }
}
