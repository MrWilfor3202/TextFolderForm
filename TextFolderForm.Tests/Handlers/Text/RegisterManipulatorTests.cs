using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFolderForm.Model.Handlers.Implementations.Text;

namespace TextFolderForm.Tests.Handlers.Text
{
    [TestFixture]
    public class RegisterManipulatorTests 
    {
        [Test]
        public void TestEmptyText()
        {
            RegisterManipulator registerManipulator = new RegisterManipulator();
            var result = registerManipulator.HandleText(string.Empty);
            Assert.That(result, Is.EqualTo(""));
        }

        [TestCase("test", "Test")]
        [TestCase("test_text", "Test_text")]
        [TestCase("testText", "TestText")]
        [TestCase("$^%$^%$$@#$@#$#@$", "$^%$^%$$@#$@#$#@$")]
        [TestCase("blablalbla", "Blablalbla")]
        public void TestTextWithoutWhitespaces(string text, string expected)
        {
            RegisterManipulator registerManipulator = new RegisterManipulator();

            var result = registerManipulator.HandleText(text);

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
            RegisterManipulator removerWhitespaces = new RegisterManipulator();

            var result = removerWhitespaces.HandleText(text);

            Assert.That(result, Is.EqualTo(text));
        }

        [TestCase("test ", "Test ")]
        [TestCase(" test", " Test")]
        [TestCase(" test ", " Test ")]
        [TestCase("te st", "Te St")]
        [TestCase("te\nst", "Te\nSt")]
        [TestCase("this is long text, with special characters like \'\n I need to test how parser works with sentences like this...",
           "This Is Long Text, With Special Characters Like '\n I Need To Test How Parser Works With Sentences Like This...")]
        public void TestTextWithLettersAndWhitespaces(string text, string expected)
        {
            RegisterManipulator registerManipulator = new RegisterManipulator();

            var result = registerManipulator.HandleText(text);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
