using Xunit;
using FindAndReplace.Objects;
using System;
using System.Collections.Generic;

namespace FindAndReplace
{
  public class UserInputTest
  {
    [Fact]
    public void FindAndReplace_NoMatch_original()
    {
      string original = "Hello World";
      string word = "phone";
      string replacement = "bananas";

      UserInput testUserInput = new UserInput(original, word, replacement);
      string output = testUserInput.FindAndReplace();
      string expectedOutput = original;
      Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void FindAndReplace_ExactStringMatch_replace_string()
    {
      string original = "hello";
      string word = "hello";
      string replacement = "goodbye";

      UserInput testUserInput = new UserInput(original, word, replacement);
      string output = testUserInput.FindAndReplace();
      string expectedOutput = replacement;
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void FindAndReplace_ExactWordMatch_replace_word()
    {
      string original = "Hello world";
      string word = "world";
      string replacement = "universe";

      UserInput testUserInput = new UserInput(original, word, replacement);
      string output = testUserInput.FindAndReplace();
      string expectedOutput = "Hello universe";
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void FindAndReplace_UppercaseMatch_replace_word()
    {
      string original = "Hello world";
      string word = "HELLO";
      string replacement = "GOODBYE";

      UserInput testUserInput = new UserInput(original, word, replacement);
      string output = testUserInput.FindAndReplace();
      string expectedOutput = "GOODBYE world";
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void FindAndReplace_UppercaseCapitalizeMatch_replace_word()
    {
      string original = "Hello world";
      string word = "World";
      string replacement = "universe";

      UserInput testUserInput = new UserInput(original, word, replacement);
      string output = testUserInput.FindAndReplace();
      string expectedOutput = "Hello universe";
      Assert.Equal(expectedOutput, output);
    }
  }
}
