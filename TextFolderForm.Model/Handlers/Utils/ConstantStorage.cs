namespace TextFolderForm.Model.Handlers.Utils
{
    internal static class ConstantStorage
    {
        private static IReadOnlyList<char> _separators = new char[] { ' ', '\n', '\r', '\t' };

        internal static char[] Separators
        {
            get => _separators.ToArray();
        }
    }
}
