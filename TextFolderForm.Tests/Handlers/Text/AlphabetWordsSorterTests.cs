using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFolderForm.Model.Handlers.Implementations.Text;

namespace TextFolderForm.Tests.Handlers.Text
{
    public class AlphabetWordsSorterTests
    {
        [Test]
        public void TestEmptyText()
        {
            AlphabetWordsSorter sorter = new AlphabetWordsSorter();
            var result = sorter.HandleText(string.Empty);
            Assert.That(result, Is.EqualTo(""));
        }

        [TestCase("test", "test")]
        [TestCase("test_text", "test_text")]
        [TestCase("testtext", "testtext")]
        //[TestCase("$^%$^%$$@#$@#$#@$", "")]
        [TestCase("blablalbla", "blablalbla")]
        public void TestTextWithOneWord(string text, string expected)
        {
            AlphabetWordsSorter sorter = new AlphabetWordsSorter();

            var result = sorter.HandleText(text);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("             ")]
        [TestCase("\r\r\r\r\r\r\r\r\r\r\r")]
        [TestCase("\n\n\n\n\n\n\n\n\n")]
        [TestCase("         \n\n\n  ")]
        [TestCase(@"



        ")]
        [TestCase(@"


                                 
              
        ")]
        public void TestTextContainingOnlyWhitespaces(string text)
        {
            AlphabetWordsSorter sorter = new AlphabetWordsSorter();
            var result = sorter.HandleText(text);
            Assert.That(result, Is.EqualTo(String.Empty));
        }

        [TestCase("test", "test")]
        [TestCase("test", "test")]
        [TestCase("test", "test")]
        [TestCase("test", "test")]
        [TestCase("te\nst", "st te")]
        [TestCase("baby abc city long day guy", "abc baby city day guy long")]
        public void TestTextWithLettersAndWhitespaces(string text, string expected)
        {
            AlphabetWordsSorter sorter = new AlphabetWordsSorter();
            var result = sorter.HandleText(text);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
