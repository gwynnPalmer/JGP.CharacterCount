using FluentAssertions;
using FluentAssertions.Execution;
using JGP.CharacterCount.Services;
using NUnit.Framework;

namespace JGP.CharacterCount.Tests;

/// <summary>
///     Class CountTests.
/// </summary>
public class CountTests
{
    /// <summary>
    ///     Defines the test method Count_Spaces.
    /// </summary>
    [Test]
    public void Count_Spaces()
    {
        const string text = "This is a test";
        var model = new CharacterCountService().Count(text);
        model.SpacesCount.Should().Be(3);
    }

    /// <summary>
    ///     Defines the test method Count_Characters.
    /// </summary>
    [Test]
    public void Count_Characters()
    {
        var count = new Random().Next(1, 30);
        var text = new string('a', count);
        var model = new CharacterCountService().Count(text);
        model.CharacterCount.Should().Be(count);
    }

    /// <summary>
    ///     Defines the test method Count_UniqueCharacters.
    /// </summary>
    [Test]
    public void Count_UniqueCharacters()
    {
        var count = new Random().Next(1, 30);
        var text = new string('a', count);
        var extra = count % 2 == 0;

        if (extra)
        {
            text += "b";
        }

        var model = new CharacterCountService().Count(text);

        model.UniqueCharacterCount.Should().Be(extra ? 2 : 1);
    }

    /// <summary>
    ///     Defines the test method Count_Words.
    /// </summary>
    [Test]
    public void Count_Words()
    {
        const string text = "This is a test";
        var model = new CharacterCountService().Count(text);
        model.WordCount.Should().Be(4);
    }

    /// <summary>
    ///     Defines the test method Count_UniqueWords.
    /// </summary>
    [Test]
    public void Count_UniqueWords()
    {
        const string text = "This is a test";
        var model = new CharacterCountService().Count(text);
        model.UniqueWordCount.Should().Be(4);
    }

    /// <summary>
    ///     Defines the test method Count_Sentences.
    /// </summary>
    [Test]
    public void Count_Sentences()
    {
        const string text = "This is a test. This is another test.";
        var model = new CharacterCountService().Count(text);
        model.SentenceCount.Should().Be(2);
    }

    /// <summary>
    ///     Defines the test method Count_Paragraphs.
    /// </summary>
    [Test]
    public void Count_Paragraphs()
    {
        var extra = new Random().Next(1, 10) % 2 == 0;
        var text = "This is a test. This is another test.";
        if (extra)
        {
            text += Environment.NewLine + text;
        }

        var model = new CharacterCountService().Count(text);
        model.ParagraphCount.Should().Be(extra ? 2 : 1);
    }

    /// <summary>
    ///     Defines the test method Count_WordDensities.
    /// </summary>
    [Test]
    public void Count_WordDensities()
    {
        const string text = "This is a test.";
        var model = new CharacterCountService().Count(text);
        using (new AssertionScope())
        {
            model.WordDensities.Should().NotBeNull();
            model.WordDensities.Should().NotBeEmpty();
            model.WordDensities.Should().HaveCount(4);

            model.WordDensities.Select(mod => mod.Word).Should().Contain("This");
            model.WordDensities.Select(mod => mod.Word).Should().Contain("is");
            model.WordDensities.Select(mod => mod.Word).Should().Contain("a");
            model.WordDensities.Select(mod => mod.Word).Should().Contain("test");

            model.WordDensities.Sum(mod => mod.Count).Should().Be(4);

            model.WordDensities.Sum(mod => mod.Percentage).Should().Be(100);
        }
    }
}