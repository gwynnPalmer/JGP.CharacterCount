using JGP.CharacterCount.Core;
using JGP.CharacterCount.Services.Calculators;
using JGP.CharacterCount.Services.Counters;

namespace JGP.CharacterCount.Services;

/// <summary>
///     Interface ICharacterCountService
/// </summary>
public interface ICharacterCountService
{
    /// <summary>
    ///     Counts the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>CountModel.</returns>
    CountModel Count(string text);
}

/// <summary>
///     Class CharacterCountService.
/// </summary>
public class CharacterCountService : ICharacterCountService
{
    /// <summary>
    ///     The calculator
    /// </summary>
    private readonly WordDensityCalculator _calculator = new();

    /// <summary>
    ///     Counts the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>CountModel.</returns>
    public CountModel Count(string text)
    {
        return Count(new CountModel { Text = text });
    }

    /// <summary>
    ///     Counts the specified type.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="text">The text.</param>
    /// <returns>System.Int32.</returns>
    private static int Count(TextCounterType type, string text)
    {
        return TextCounterFactory.Get(type).Count(text);
    }

    /// <summary>
    ///     Counts the specified model.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <returns>CountModel.</returns>
    private CountModel Count(CountModel model)
    {
        if (string.IsNullOrWhiteSpace(model.Text)) return model;

        return new CountModel
        {
            SpacesCount = Count(TextCounterType.Space, model.Text),
            CharacterCount = Count(TextCounterType.Character, model.Text),
            UniqueCharacterCount = Count(TextCounterType.UniqueCharacter, model.Text),
            WordCount = Count(TextCounterType.Word, model.Text),
            UniqueWordCount = Count(TextCounterType.UniqueWord, model.Text),
            SentenceCount = Count(TextCounterType.Sentence, model.Text),
            ParagraphCount = Count(TextCounterType.Paragraph, model.Text),
            WordDensities = _calculator.Calculate(model.Text)
        };
    }
}