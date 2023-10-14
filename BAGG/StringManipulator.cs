namespace BAGG
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            char[] charsArray = input.ToCharArray();
            Array.Reverse(charsArray);
            return new string(charsArray);
        }

        public string RemoveSpaces(string input)
        {
            return new string(input.ToCharArray().Where(x => !Char.IsWhiteSpace(x)).ToArray());
        }
    }
}
