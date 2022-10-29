namespace JGP.CharacterCount.Services.Counters;

/// <summary>
///     Class SpacesCounter.
/// </summary>
internal class SpacesCounter : ITextCounter
{
    /// <summary>
    ///     Counts the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>System.Int32.</returns>
    public int Count(string text)
    {
        return text.Count(c => c == ' ');
    }
}