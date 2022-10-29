using JGP.CharacterCount.Services.Splitters;

namespace JGP.CharacterCount.Services.Counters;

/// <summary>
///     Class ParagraphCounter.
///     Implements the <see cref="JGP.CharacterCount.Services.Counters.ITextCounter" />
/// </summary>
/// <seealso cref="JGP.CharacterCount.Services.Counters.ITextCounter" />
internal class ParagraphCounter : ITextCounter
{
    private readonly ITextSplitter _textSplitter = new ParagraphSplitter();
    /// <summary>
    ///     Counts the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>System.Int32.</returns>
    public int Count(string text)
    {
        return _textSplitter.Split(text).Count();
    }
}