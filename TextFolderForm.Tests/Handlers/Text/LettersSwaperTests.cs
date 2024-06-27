using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFolderForm.Model.Handlers.Implementations.Text;

namespace TextFolderForm.Tests.Handlers.Text
{
    [TestFixture]
    public class LettersSwaperTests
    {
        [Test]
        public void TestEmptyText()
        {
            LettersSwaper lettersSwaper = new LettersSwaper();
            var result = lettersSwaper.HandleText(string.Empty);
            Assert.That(result, Is.EqualTo(""));
        }

        [TestCase("test", "test")]
        [TestCase("test_text", "test_text")]
        [TestCase("testtext", "testtext")]
        [TestCase("$^%$^%$$@#$@#$#@$", "$^%$^%$$@#$@#$#@$")]
        [TestCase("blablalbla", "alablalblb")]
        public void TestTextWithoutWhitespaces(string text, string expected)
        {
            LettersSwaper letterSwaper = new LettersSwaper();

            var result = letterSwaper.HandleText(text);

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
            LettersSwaper letterSwaper = new LettersSwaper();

            var result = letterSwaper.HandleText(text);

            Assert.That(result, Is.EqualTo(text));
        }


        [TestCase("12213123", "12213123")]
        [TestCase("12213123 2121211", "12213123 2121211")]
        [TestCase("12213123QWQQW", "12213123QWQQW")]
        [TestCase("QWQQW1", "QWQQW1")]
        [TestCase("QWQQW#", "QWQQW#")]
        [TestCase("@QWQQW", "@QWQQW")]
        public void TestTextContainingNotOnlyLetters(string text, string expected)
        {
            LettersSwaper letterSwaper = new LettersSwaper();

            var result = letterSwaper.HandleText(text);

            Assert.That(result, Is.EqualTo(text));
        }


        [TestCase("test", "test")]
        [TestCase(" test", " test")]
        [TestCase(" test ", " test ")]
        [TestCase("te st", "et ts")]
        [TestCase("te\nst", "et\nts")]
        [TestCase("this is long text, with special characters like \'\n I need to test how parser works with sentences like this...",
           "shit si gonl text, hitw lpecias sharacterc eikl '\n I deen ot test woh rarsep sorkw hitw sentences eikl shit...")]
        public void TestTextWithLettersAndWhitespaces(string text, string expected)
        {
            LettersSwaper letterSwaper = new LettersSwaper();

            var result = letterSwaper.HandleText(text);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
