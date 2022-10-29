using System.Text.Json.Serialization;

namespace JGP.CharacterCount.Core;

/// <summary>
///     Class CountModel.
/// </summary>
public class CountModel
{
    /// <summary>
    ///     Gets or sets the text.
    /// </summary>
    /// <value>The text.</value>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    ///     Gets or sets the spaces count.
    /// </summary>
    /// <value>The spaces count.</value>
    [JsonPropertyName("spacesCount")]
    public int SpacesCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the character count.
    /// </summary>
    /// <value>The character count.</value>
    [JsonPropertyName("characterCount")]
    public int CharacterCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the unique character count.
    /// </summary>
    /// <value>The unique character count.</value>
    [JsonPropertyName("uniqueCharacterCount")]
    public int UniqueCharacterCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the word count.
    /// </summary>
    /// <value>The word count.</value>
    [JsonPropertyName("wordCount")]
    public int WordCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the unique word count.
    /// </summary>
    /// <value>The unique word count.</value>
    [JsonPropertyName("uniqueWordCount")]
    public int UniqueWordCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the sentence count.
    /// </summary>
    /// <value>The sentence count.</value>
    [JsonPropertyName("sentenceCount")]
    public int SentenceCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the paragraph count.
    /// </summary>
    /// <value>The paragraph count.</value>
    [JsonPropertyName("paragraphCount")]
    public int ParagraphCount { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the word density.
    /// </summary>
    /// <value>The word density.</value>
    [JsonPropertyName("wordDensities")]
    public List<WordDensityModel> WordDensities { get; set; } = new();
}