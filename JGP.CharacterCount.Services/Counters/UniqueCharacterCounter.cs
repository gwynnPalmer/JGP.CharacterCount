namespace JGP.CharacterCount.Services.Counters;

/// <summary>
///     Class UniqueCharacterCounter.
///     Implements the <see cref="JGP.CharacterCount.Services.Counters.ITextCounter" />
/// </summary>
/// <seealso cref="JGP.CharacterCount.Services.Counters.ITextCounter" />
internal class UniqueCharacterCounter : ITextCounter
{
    /// <summary>
    ///     Counts the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>System.Int32.</returns>
    public int Count(string text)
    {
        return text.ToCharArray()
            .Distinct()
            .Count(char.IsLetterOrDigit);
    }
}