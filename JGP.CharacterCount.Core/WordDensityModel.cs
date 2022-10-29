using System.Text.Json.Serialization;

namespace JGP.CharacterCount.Core;

/// <summary>
///     Class WordDensityModel.
/// </summary>
public class WordDensityModel
{
    /// <summary>
    ///     Gets or sets the word.
    /// </summary>
    /// <value>The word.</value>
    [JsonPropertyName("word")]
    public string? Word { get; set; }

    /// <summary>
    ///     Gets or sets the count.
    /// </summary>
    /// <value>The count.</value>
    [JsonPropertyName("count")]
    public int Count { get; set; } = 0;

    /// <summary>
    ///     Gets or sets the percentage.
    /// </summary>
    /// <value>The percentage.</value>
    [JsonPropertyName("percentage")]
    public int Percentage { get; set; } = 0;
}