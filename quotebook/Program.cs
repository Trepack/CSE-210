﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Source source = new Source("None were with him", "http://www.churchofjesuschrist.org");

Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holland", "Because Jesus walked such a long, lonely path utterly alone, we do not have to do so",source);
Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();

_board.AddQuote(
    new Quote(
        "Paul";
        "God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard to acheive your dreams. Don't let discouragement or mistakes delay you.",
        new Source(
            "How to Dare Great Things"
            "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng"
        )
    )
)

Menu _menu = new Menu(_board);
_menu.Display();

quoteboard.AddQuote(holland);
quoteboard.ShowQuotes();

