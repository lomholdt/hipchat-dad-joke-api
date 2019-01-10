using System;
using System.Collections.Generic;
using System.Linq;

namespace DadJokes
{
  public class JokeService : IJokeService
  {
    public Joke getRandomJoke()
    {
      return _jokes.ToArray()[(int)DateTime.Now.Ticks % _jokes.Count()];
    }

    private readonly IEnumerable<Joke> _jokes = new[]
    {
      new Joke
      {
        Question = "What diet did the ghost developer go on?",
        Answer =  "Boolean"
      },
      new Joke
      {
        Question = "Why was the developer unhappy at his job?",
        Answer =  "He wanted arrays."
      },
      new Joke
      {
        Question = "Why did 10 get paid less than \"10\"?",
        Answer =  "There was workplace inequality."
      },
      new Joke
      {
        Question = "Why was the function sad after a successful first call?",
        Answer =  "He didn’t get a callback."
      },
      new Joke
      {
        Question = "Why did the angry function exceed the callstack size?",
        Answer =  "He got into an Argument with himself"
      },
      new Joke
      {
        Question = "Whats the object-oriented way to become wealthy?",
        Answer =  "Inheritance"
      },
      new Joke
      {
        Question = "Why did the developer ground his daughter?",
        Answer =  "She wasn't telling the truthy"
      },
      new Joke
      {
        Question = "What did the array say after it was extended?",
        Answer =  "Stop objectifying me."
      },
      new Joke
      {
        Question = "!false",
        Answer = "It's funny 'cause it's true."
      },
      new Joke
      {
        Question = "Where did the parallel function wash its hands?",
        Answer =  "Async"
      },
      new Joke
      {
        Question = "I'm starting a band called HTML Encoder",
        Answer =  "Looking to buy a guitar &amp;"
      },
      new Joke
      {
        Question = "Why did the functions stop calling each other?",
        Answer =  "Because they had constant arguments."
      },
      new Joke
      {
        Question = "What's the second movie about a database engineer called?",
        Answer =  "The SQL."
      },
      new Joke
      {
        Question = "A programmer's wife tells them, \"Run to the store and pick up a loaf of bread. If they have eggs, get a dozen.\"",
        Answer = "The programmer comes home with 12 loaves of bread."
      },
      new Joke
      {
        Question = "What did the spider do on the computer?",
        Answer =  "Made a website!"
      },
      new Joke
      {
        Question = "What did the computer do at lunchtime?",
        Answer =  "Had a byte!"
      },
      new Joke
      {
        Question = "What does a baby computer call his father?",
        Answer =  "Data!"
      },
      new Joke
      {
        Question = "Why did the computer keep sneezing?",
        Answer =  "It had a virus!"
      },
      new Joke
      {
        Question = "What is a computer virus?",
        Answer =  "A terminal illness!"
      },
      new Joke
      {
        Question = "Why was the computer cold?",
        Answer =  "It left its Windows open!"
      },
      new Joke
      {
        Question = "Why was there a bug in the computer?",
        Answer =  "Because it was looking for a byte to eat"
      },
      new Joke
      {
        Question = "Why did the computer squeak?",
        Answer =  "Because someone stepped on it's mouse!"
      },
      new Joke
      {
        Question = "What do you get when you cross a computer and a life guard?",
        Answer =  "A screensaver!"
      },
      new Joke
      {
        Question = "Where do all the cool mice live?",
        Answer =  "In their mousepads!"
      },
      new Joke
      {
        Question = "What do you get when you cross a computer with an elephant?",
        Answer =  "Lots of memory!"
      },
      new Joke
      {
        Question = "Java truly is an OOP language...",
        Answer = "As in: OOPs I used Java!"
      },
      new Joke
      {
        Question = "How do programming pirates pass method parameters?",
        Answer =  "Varrrrarrrgs."
      },
      new Joke
      {
        Question = "How do programming shepherds count their flock?",
        Answer =  "With lambda functions"
      },
      new Joke
      {
        Question = "How did pirates collaborate before computers ?",
        Answer =  "Pier to pier networking."
      },
      new Joke
      {
        Question = "Why don't bachelors like Git?",
        Answer =  "Because they are afraid to commit."
      },
      new Joke
      {
        Question = "A SQL query goes into a bar, walks up to two tables and asks:",
        Answer =  "Can I JOIN you?"
      },
      new Joke
      {
        Question = "[\"hip\",\"hip\"]",
        Answer =  "(hip hip array!)"
      },
      new Joke
      {
        Question = "Why was the developer's family upset with them at dinner?",
        Answer =  "They forgot to git squash before going home"
      },
      new Joke
      {
        Question = "What did JavaScript call his son?",
        Answer =  "JSON!"
      },
      new Joke
      {
        Question = "What did the proud React component say to its child?",
        Answer =  "I've got to give you props"
      },
      new Joke
      {
        Question = "What did the server say to his client who was having a bad day?",
        Answer =  "Everything's going to be 200"
      },
      new Joke
      {
        Question = "Why did the developer go broke?",
        Answer =  "Because he used up all his cache"
      }
    };
  }
}
