namespace JGP.CharacterCount.Services.Counters;

/// <summary>
///     Interface ITextCounter
/// </summary>
internal interface ITextCounter
{
    /// <summary>
    ///     Counts the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>System.Int32.</returns>
    int Count(string text);
}