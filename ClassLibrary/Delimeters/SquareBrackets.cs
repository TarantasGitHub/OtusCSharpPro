namespace ClassLibrary.Delimeters
{
    /// <summary>
    /// Квадратные скобки
    /// </summary>
    public class SquareBrackets : Delimeter
    {
        protected override char closingCharacter { get { return ']';}}
    }
}