/*
"In software engineering, the adapter pattern is a software design pattern (also known as wrapper) that allows the interface
of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code."
*/

JapaneseTeamMember teamMember = new JapaneseTeamMember();
IEnglishSpeaker translator = new Translator(teamMember);
CEO ceo = new CEO(translator);

ceo.Address("Good morning, team.");
ceo.Address("Please review the proposal.");


/*
When to Use it
Use Adapter when you want to use an existing class but its interface doesn't match what your code expects.

It's also helpful when you want to create a reusable class that cooperates with classes that don't have compatible interfaces.

And reach for it when you need to integrate a third-party library or legacy code without modifying it.
*/