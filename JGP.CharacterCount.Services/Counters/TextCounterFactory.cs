namespace JGP.CharacterCount.Services.Counters;

/// <summary>
///     Class TextCounterFactory.
/// </summary>
internal static class TextCounterFactory
{
    /// <summary>
    ///     Gets the specified text counter type.
    /// </summary>
    /// <param name="textCounterType">Type of the text counter.</param>
    /// <returns>ITextCounter.</returns>
    public static ITextCounter Get(TextCounterType textCounterType)
    {
        return textCounterType switch
        {
            TextCounterType.Character => new CharacterCounter(),
            TextCounterType.UniqueCharacter => new UniqueCharacterCounter(),
            TextCounterType.Word => new WordCounter(),
            TextCounterType.UniqueWord => new UniqueWordCounter(),
            TextCounterType.Sentence => new SentenceCounter(),
            TextCounterType.Paragraph => new ParagraphCounter(),
            TextCounterType.Space => new SpacesCounter(),
            _ => throw new ArgumentOutOfRangeException(nameof(textCounterType), textCounterType, null)
        };
    }
}