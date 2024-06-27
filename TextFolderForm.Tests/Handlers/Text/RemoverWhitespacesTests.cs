using TextFolderForm.Model.Handlers.Implementations.Text;

namespace TextFolderForm.Tests.Handlers.Text
{
    [TestFixture]
    public class RemoverWhitespacesTests
    {
        [Test]
        public void TestEmptyText() 
        {
            RemoverWhitespaces removerWhitespaces = new RemoverWhitespaces();
            var result = removerWhitespaces.HandleText(string.Empty);
            Assert.That(result, Is.EqualTo(""));
        }

        [TestCase("             ", "")]
        [TestCase("\r\r\r\r\r\r\r\r\r\r\r", "")]
        [TestCase("\t\t\t\t", "")]
        [TestCase("\n\n\n\n\n\n\n\n\n", "")]
        [TestCase("         \n\n\n  ", "")]
        [TestCase(@"



        ", "")]
        [TestCase(@"


                                 
              
        ", "")]
        public void TestTextContainingOnlyWhitespaces(string text, string expected) 
        {
            RemoverWhitespaces removerWhitespaces = new RemoverWhitespaces();

            var result = removerWhitespaces.HandleText(text);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("test")]
        [TestCase("test_text")]
        [TestCase("testText")]
        [TestCase("$^%$^%$$@#$@#$#@$")]
        [TestCase("blablalbla")]
        public void TestTextWithoutWhitespaces(string text) 
        {
            RemoverWhitespaces removerWhitespaces = new RemoverWhitespaces();

            var result = removerWhitespaces.HandleText(text);

            Assert.That(result, Is.EqualTo(text));
        }

        [TestCase("test ", "test")]
        [TestCase(" test", "test")]
        [TestCase(" test ", "test")]
        [TestCase("te st", "test")]
        [TestCase("te\nst", "test")]
        [TestCase("this is long text, with special characters like \'\n I need to test how parser works with sentences like this...",
            "thisislongtext,withspecialcharacterslike'Ineedtotesthowparserworkswithsentenceslikethis...")]
        public void TestTextWithLettersAndWhitespaces(string text, string expected) 
        {
            RemoverWhitespaces removerWhitespaces = new RemoverWhitespaces();

            var result = removerWhitespaces.HandleText(text);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
