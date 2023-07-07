using RawDeal;
using RawDealView;

// string folder = "08-Reversals";
string folder = "09-SimpleEffects";
int idTest = 21;
string pathToTest = Path.Combine("data", $"{folder}-Tests", $"{idTest}.txt");

// Esta vista permite verificar el comportamiento de un test particular.
View view = View.BuildManualTestingView(pathToTest); 

// También puedes usar la vista antigua si quieres.
// View view = View.BuildConsoleView();  

string deckFolder = Path.Combine("data", folder);
Game game = new Game(view, deckFolder);
game.Play();
