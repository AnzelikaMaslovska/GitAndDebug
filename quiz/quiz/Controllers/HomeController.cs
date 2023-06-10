using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quiz.Models;
using System;
using System.Collections.Generic;

namespace quiz.Controllers
{
    public class HomeController : Controller
    {
        private void InitQuiz()
        {
            quiz = new Quiz
            {
                Name = "QUIZ ABOUT ANIMALS",
                Description = "This quiz contain 16 questions about animals that will test your knowledge about them",
                ActiveQuestionIndex = -1,
                IsQuizStarted = false,
                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "What is the largest animal in the world?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "African elephant",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Antarctic blue whale",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Colossal squid",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Giraffe",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "What is the tallest animal in the world?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                           new Answer
                            {
                                Text = "African elephant",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Antarctic blue whale",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Colossal squid",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Giraffe",
                                IsCorrect = true,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which direction do northern birds fly during winter?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "North",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "East",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "West",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "South",
                                IsCorrect = true,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "What do you call a baby goat?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Buck",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Kid",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Calf",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Cub",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "What do you call a female peacock?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Peafowl",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Peananny",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Peahens",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Peonies",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "What is the average lifespan of a dog?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "3-5 years",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "10-13 years",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "14-20 years",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "20-25 years",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which type of animal is Abu in Aladdin?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Elephant",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Monkey",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Parrot",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Siberian Tiger",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Where do lions normally live?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Britan",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Australia",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Africa",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Latvia",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which of the following animals can breathe under water?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Penguins",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Ducks",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Condors",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Manta rays",
                                IsCorrect = true,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which animal does not have a brain?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Jellyfish",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Starfish",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Goat",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Seal",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "How long can snails sleep at a time?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "30 hours",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "15 hours",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "8 hours",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "36 hours",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "How many ants are there for every human in the world",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "100",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "100 000",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "1000",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "1.6 million",
                                IsCorrect = true,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Where is the shrimp’s heart located?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "In their head",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "In their chest",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "In their tails",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "In their legs",
                                IsCorrect = false,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which animal is the only animal that couldn’t jump?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Pigs",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Whales",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Giraffes",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Elephants",
                                IsCorrect = true,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which animal is known for their pink milks?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Pigs",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Elephants",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Rabbits",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Hippos",
                                IsCorrect = true,
                            }
                        }
                    },
                    new Question
                    {
                        Text = "Which animal doesn’t need to drink water their whole life?",
                        WasUserAnswerCorrect = false,
                        DidUserAnswered = false,
                        Answers = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Camel",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Tiny kangaroo rat",
                                IsCorrect = true,
                            },
                            new Answer
                            {
                                Text = "Owl",
                                IsCorrect = false,
                            },
                            new Answer
                            {
                                Text = "Elephant",
                                IsCorrect = false,
                            }
                        }
                    }
                }
            };
        }
        // GET: HomeController
        private static Quiz quiz = new Quiz();
        
        public IActionResult Index()
        {
            InitQuiz();
            return View(quiz);
        }

        public IActionResult Results()
        {
            return View("Results",quiz);
        }

        [HttpPost]
        public IActionResult Start() 
        { 
            quiz.IsQuizStarted = true;
            quiz.ActiveQuestionIndex = 0;
            return View("Index", quiz);
        }

        public IActionResult SelectQuestion(string id)
        {
            if(quiz.IsQuizStarted)
                quiz.ActiveQuestionIndex = Convert.ToInt32(id);
            return View("Index", quiz);
        }
        
        [HttpPost]
        public IActionResult AnsweredAndLoadNextQuestion(Quiz SentAnswer)
        {
            if(SentAnswer.ReceivedAnswer != null)
            {
                quiz.Questions[quiz.ActiveQuestionIndex].WasUserAnswerCorrect = false;
                quiz.Questions[quiz.ActiveQuestionIndex].DidUserAnswered = true;
                foreach (Answer answer in quiz.Questions[quiz.ActiveQuestionIndex].Answers)
                {
                    if (answer.IsCorrect)
                    {
                        if (answer.Text == SentAnswer.ReceivedAnswer)
                        {
                            quiz.Questions[quiz.ActiveQuestionIndex].WasUserAnswerCorrect = true;
                            break;
                        }
                    }
                }
                if (quiz.ActiveQuestionIndex < quiz.Questions.Count-1)
                {
                    quiz.ActiveQuestionIndex++;
                } else
                {
                    if (quiz.Questions.Count == quiz.AnsweredQuestionCount())
                    {
                        return View("Results", quiz);
                    }
                }
            }

            return View("Index",quiz);
        }
    }
}
