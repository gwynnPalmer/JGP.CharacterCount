namespace JGP.CharacterCount.Services.Splitters;

/// <summary>
///     Class SplitterFactory.
/// </summary>
internal static class SplitterFactory
{
    /// <summary>
    ///     Gets the specified splitter type.
    /// </summary>
    /// <param name="splitterType">Type of the splitter.</param>
    /// <returns>ITextSplitter.</returns>
    public static ITextSplitter Get(SplitterType splitterType)
    {
        return splitterType switch
        {
            SplitterType.Word => new WordSplitter(),
            SplitterType.Sentence => new SentenceSplitter(),
            SplitterType.Paragraph => new ParagraphSplitter(),
            _ => throw new ArgumentOutOfRangeException(nameof(splitterType), splitterType, null)
        };
    }
}