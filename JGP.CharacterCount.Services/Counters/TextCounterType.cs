namespace JGP.CharacterCount.Services.Counters;

/// <summary>
///     Enum TextCounterType
/// </summary>
internal enum TextCounterType
{
    /// <summary>
    ///     The character
    /// </summary>
    Character = 0,

    /// <summary>
    ///     The unique character
    /// </summary>
    UniqueCharacter = 1,

    /// <summary>
    ///     The word
    /// </summary>
    Word = 2,

    /// <summary>
    ///     The unique word
    /// </summary>
    UniqueWord = 3,

    /// <summary>
    ///     The sentence
    /// </summary>
    Sentence = 4,

    /// <summary>
    ///     The paragraph
    /// </summary>
    Paragraph = 5,

    /// <summary>
    ///     The spaces
    /// </summary>
    Space = 6
}