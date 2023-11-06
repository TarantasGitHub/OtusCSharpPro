namespace ClassLibrary.Delimeters
{
    /// <summary>
    /// Круглые скобки
    /// </summary>
    public class RoundBrackets : Delimeter
    {
        protected override char closingCharacter { get { return ')';}}
    }
}
