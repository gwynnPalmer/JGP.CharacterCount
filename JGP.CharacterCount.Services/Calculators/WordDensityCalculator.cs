using JGP.CharacterCount.Core;
using JGP.CharacterCount.Services.Splitters;

namespace JGP.CharacterCount.Services.Calculators;

/// <summary>
///     Class WordDensityCalculator.
/// </summary>
internal class WordDensityCalculator
{
    /// <summary>
    ///     The word splitter
    /// </summary>
    private readonly ITextSplitter _wordSplitter = new WordSplitter();

    /// <summary>
    ///     Calculates the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>List&lt;WordDensityModel&gt;.</returns>
    public List<WordDensityModel> Calculate(string text)
    {
        var words = ParseWords(text);
        var distinctWords = words.Distinct().ToList();
        var models = BuildInitialModels(distinctWords, words);

        var difference = 100 - models.Sum(model => model.Percentage);
        return CalculateFinalModels(models, difference);
    }

    /// <summary>
    ///     Builds the initial models.
    /// </summary>
    /// <param name="distinctWords">The distinct words.</param>
    /// <param name="words">The words.</param>
    /// <returns>List&lt;WordDensityModel&gt;.</returns>
    private static List<WordDensityModel> BuildInitialModels(List<string> distinctWords, IReadOnlyCollection<string> words)
    {
        var models = new List<WordDensityModel>();
        for (var i = 0; i < distinctWords.Count; i++)
        {
            var word = distinctWords[i];
            var wordCount = words.Count(w => w == word);
            models.Add(new WordDensityModel
            {
                Word = word,
                Count = wordCount,
                Percentage = (int)Math.Round((double)wordCount / words.Count * 100, 0)
            });
        }

        return models;
    }

    /// <summary>
    ///     Calculates the final models.
    /// </summary>
    /// <param name="models">The models.</param>
    /// <param name="difference">The difference.</param>
    /// <returns>List&lt;WordDensityModel&gt;.</returns>
    private static List<WordDensityModel> CalculateFinalModels(List<WordDensityModel> models, int difference)
    {
        models = models
            .OrderByDescending(model => model.Percentage)
            .ToList();

        for (var i = 0; i < models.Count; i++)
        {
            if (i >= difference) break;
            var model = models[i];
            model.Percentage++;
        }

        return models;
    }

    /// <summary>
    ///     Parses the words.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>List&lt;System.String&gt;.</returns>
    private List<string> ParseWords(string text)
    {
        var words = _wordSplitter
            .Split(text)
            .Select(word => new string(word.Where(char.IsLetterOrDigit).ToArray()))
            .ToList();
        return words;
    }
}