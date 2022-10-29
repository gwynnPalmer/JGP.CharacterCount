# JGP.CharacterCount

It... Counts Characters?

Able to count:
    [] Spaces
	[] Characters
	[] Unique Characters
	[] Words
	[] Unique Words
	[] Sentences
	[] Paragraphs
	[] Word Densities with Counts and Percentages

Example usage:

        public SomeClass PerformSomeAction(SomeClass someClass)
        {
        	ICharacterCountService service = new CharacterCountService();
        	var model = service.Count(someClass.Text);
        	// Do stuff.
        }
	
I built this to use for a page on my website.
It works well so I made it public.. Crack on.

Easy to use in MVC or similar.
	
The algorithm used to calculate density percentages is not NASA-Engineer grade. But it's good enough for me.
Feel free to contribute to the project, or let me know if you've used this and it's been useful.