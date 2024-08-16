using MyFirstProgram;

var menu = new Menu();

var date = DateTime.UtcNow;

string name = Helpers.GetName();

await menu.ShowMenu(name, date);
