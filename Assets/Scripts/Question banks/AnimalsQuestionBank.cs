using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalsQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question animals001 = new Question();
    public static Question animals002 = new Question();
    public static Question animals003 = new Question();
    public static Question animals004 = new Question();
    public static Question animals005 = new Question();
    public static Question animals006 = new Question();
    public static Question animals007 = new Question();
    public static Question animals008 = new Question();
    public static Question animals009 = new Question();
    public static Question animals010 = new Question();
    public static Question animals011 = new Question();
    public static Question animals012 = new Question();
    public static Question animals013 = new Question();
    public static Question animals014 = new Question();
    public static Question animals015 = new Question();
    public static Question animals016 = new Question();
    public static Question animals017 = new Question();
    public static Question animals018 = new Question();
    public static Question animals019 = new Question();
    public static Question animals020 = new Question();
    public static Question animals021 = new Question();
    public static Question animals022 = new Question();
    public static Question animals023 = new Question();
    public static Question animals024 = new Question();
    public static Question animals025 = new Question();
    public static Question animals026 = new Question();


    void Start()
    {
        animals001 = new Question()
        {
            number = 1,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bear"
        };

        animals002 = new Question()
        {
            number = 2,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("Questions/Animals/Wolf"),
            answerOptions = new List<string>()
        {
            "cat",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Wolf"
        };

        animals003 = new Question()
        {
            number = 3,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("Questions/Animals/Zebra"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Zebra"
        };

        animals004 = new Question()
        {
            number = 4,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("Questions/Animals/Owl"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Owl"
        };

        animals005 = new Question()
        {
            number = 5,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Monkey"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Monkey"
        };

        animals006 = new Question()
        {
            number = 6,
            questionName = "parrot",
            sprite = Resources.Load<Sprite>("Questions/Animals/Parrot"),
            answerOptions = new List<string>()
        {
            "monkey",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Parrot"
        };

        animals007 = new Question()
        {
            number = 7,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("Questions/Animals/Giraffe"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Giraffe"
        };

        animals008 = new Question()
        {
            number = 8,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("Questions/Animals/Lion"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lion"
        };

        animals009 = new Question()
        {
            number = 9,
            questionName = "crocodile",
            sprite = Resources.Load<Sprite>("Questions/Animals/Crocodile"),
            answerOptions = new List<string>()
        {
            "crocodile",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Crocodile"
        };



        animals010 = new Question()
        {
            number = 10,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("Questions/Animals/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Rabbit"
        };

        animals011 = new Question()
        {
            number = 11,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Frog"
        };

        animals012 = new Question()
        {
            number = 12,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("Questions/Animals/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tiger"
        };


        animals013 = new Question()
        {
            number = 13,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("Questions/Animals/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Elephant"
        };

        animals014 = new Question()
        {
            number = 14,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("Questions/Animals/Lizard"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "lizard"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lizard"
        };

        animals015 = new Question()
        {
            number = 15,
            questionName = "bat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "lizard"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bat"
        };

        animals016 = new Question()
        {
            number = 16,
            questionName = "eagle",
            sprite = Resources.Load<Sprite>("Questions/Animals/Eagle"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Eagle"
        };

        animals017 = new Question()
        {
            number = 17,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("Questions/Animals/Kangaroo"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Kangaroo"
        };

        animals018 = new Question()
        {
            number = 18,
            questionName = "panda",
            sprite = Resources.Load<Sprite>("Questions/Animals/Panda"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Panda"
        };

        animals019 = new Question()
        {
            number = 19,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("Questions/Animals/Penguin"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "penguin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Penguin"
        };



        animals020 = new Question()
        {
            number = 20,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("Questions/Animals/Snake"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "snake",
            "penguin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Snake"
        };

        animals021 = new Question()
        {
            number = 21,
            questionName = "swan",
            sprite = Resources.Load<Sprite>("Questions/Animals/Swan"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Swan"
        };

        animals022 = new Question()
        {
            number = 22,
            questionName = "tortoise",
            sprite = Resources.Load<Sprite>("Questions/Animals/Tortoise"),
            answerOptions = new List<string>()
        {
            "tortoise",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tortoise"
        };

        animals023 = new Question()
        {
            number = 23,
            questionName = "shark",
            sprite = Resources.Load<Sprite>("Questions/Animals/Shark"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Shark"
        };

        animals024 = new Question()
        {
            number = 24,
            questionName = "dolphin",
            sprite = Resources.Load<Sprite>("Questions/Animals/Dolphin"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dolphin"
        };

        animals025 = new Question()
        {
            number = 25,
            questionName = "bee",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bee"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bee"
        };

        animals026 = new Question()
        {
            number = 26,
            questionName = "bird",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bird"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bird"
        };

        LoadQuestionList();
    }

    public static void LoadQuestionList()
    {
        // if (!GameControl.animalName004known)
        questions.Add(animals001);

        //  if (!GameControl.animalName005known)
        questions.Add(animals002);

        //  if (!GameControl.animalName006known)
        questions.Add(animals003);

        //    if (!GameControl.animalName007known)
        questions.Add(animals004);

        //  if (!GameControl.animalName008known)
        questions.Add(animals005);

        //   if (!GameControl.animalName009known)
        questions.Add(animals006);

        //   if (!GameControl.animalName010known)
        questions.Add(animals007);

        //   if (!GameControl.animalName011known)
        questions.Add(animals008);

        //   if (!GameControl.animalName012known)
        questions.Add(animals009);

        //     if (!GameControl.animalName017known)
        questions.Add(animals010);

        //    if (!GameControl.animalName018known)
        questions.Add(animals011);

        //    if (!GameControl.animalName019known)
        questions.Add(animals012);

        //     if (!GameControl.animalName022known)
        questions.Add(animals013);

        //   if (!GameControl.animalName023known)
        questions.Add(animals014);

        //    if (!GameControl.animalName024known)
        questions.Add(animals015);

        //     if (!GameControl.animalName025known)
        questions.Add(animals016);

        //    if (!GameControl.animalName026known)
        questions.Add(animals017);

        //   if (!GameControl.animalName027known)
        questions.Add(animals018);

        //    if (!GameControl.animalName028known)
        questions.Add(animals019);

        //    if (!GameControl.animalName030known)
        questions.Add(animals020);

        //   if (!GameControl.animalName031known)
        questions.Add(animals021);

        //   if (!GameControl.animalName032known)
        questions.Add(animals022);

        //    if (!GameControl.animalName033known)
        questions.Add(animals023);

        //    if (!GameControl.animalName034known)
        questions.Add(animals024);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        //Debug.Log(questions.Count);
    }
}
