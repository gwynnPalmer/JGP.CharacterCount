namespace JGP.CharacterCount.Services.Splitters;

/// <summary>
///     Interface ITextSplitter
/// </summary>
internal interface ITextSplitter
{
    /// <summary>
    ///     Splits the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>IEnumerable&lt;System.String&gt;.</returns>
    IEnumerable<string> Split(string text);
}