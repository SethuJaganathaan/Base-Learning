namespace Base_Learning.Basic_Program
{
    public class Vowel
    {
        public bool VowelCheck(char letter)
        {
            letter = Char.ToLower(letter);
            return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
        }
    }
}
