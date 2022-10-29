namespace JGP.CharacterCount.Services.Splitters;

/// <summary>
///     Class WordSplitter.
///     Implements the <see cref="JGP.CharacterCount.Services.Splitters.ITextSplitter" />
/// </summary>
/// <seealso cref="JGP.CharacterCount.Services.Splitters.ITextSplitter" />
internal class WordSplitter : ITextSplitter
{
    /// <summary>
    ///     Splits the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>IEnumerable&lt;System.String&gt;.</returns>
    public IEnumerable<string> Split(string text)
    {
        return text
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(word => !string.IsNullOrWhiteSpace(word));
    }
}