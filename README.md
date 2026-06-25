# Further Programming Skills
## Pi approximation (multi-threading & concurrent programming)
This program uses a Monte Carlo simulation to approximate the value of pi, with both a single and multi-threaded solution. Both solutions run the same number of trials, and each can calculate the value of pi to an accuracy of roughly 0.005%, given more than 1,000,000 trials. When running 1,000,000,000 trials, the single threaded solution takes 30 seconds to execute, and the multi-threaded solution takes 5 (8 cores, ~4GHz).
## Text generator (web APIs)
This is a basic text generator, that continually uses the previous word to suggest the next. The input is taken in from the console, then the program continually writes out the next suggested word from the API, with a chance to stop every time the API returns a full stop as the suggested word. There is a random weighting in the function that decides the next word, to avoid infinite loops of words from forming. Using this program is similar to typing a word on a phone's keyboard, and then continually accepting the suggested words in the box above the keyboard.
## Flashcard app (introduction to Windows Forms)
This program is a flashcard app, where each flashcard has a title, subject, creator, and a front and backside. Each card is stored in the current working directory, as a text file. Flashcards are loaded dynamically every time the study menu is opened, and stored as a list, which is indexed to go through each unique flashcard.

<img width="1898" height="1114" alt="image" src="https://github.com/user-attachments/assets/c8a49f82-65d8-4913-9cb7-22d968f36e77" />
