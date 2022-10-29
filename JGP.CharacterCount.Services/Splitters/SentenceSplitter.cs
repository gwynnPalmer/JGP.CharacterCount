namespace JGP.CharacterCount.Services.Splitters;

/// <summary>
///     Class SentenceSplitter.
///     Implements the <see cref="JGP.CharacterCount.Services.Splitters.ITextSplitter" />
/// </summary>
/// <seealso cref="JGP.CharacterCount.Services.Splitters.ITextSplitter" />
internal class SentenceSplitter : ITextSplitter
{
    /// <summary>
    ///     Splits the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>IEnumerable&lt;System.String&gt;.</returns>
    public IEnumerable<string> Split(string text)
    {
        var chars = new[] { ".", "!", "?", ":" };
        return text.Split(chars, StringSplitOptions.RemoveEmptyEntries)
            .Select(sentence => sentence.Replace(chars[0], string.Empty)
                .Replace(chars[1], string.Empty)
                .Replace(chars[2], string.Empty)
                .Replace(chars[3], string.Empty))
            .Where(sentence => !string.IsNullOrWhiteSpace(sentence));
    }
}