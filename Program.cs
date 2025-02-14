// See https://aka.ms/new-console-template for more information
BookManagerService manager = new BookManagerService{};
manager.AddBook("275235", "Le Petit Prince", "French Dude", "Adventure");
manager.AddBook("658626", "Call of Cthulu", "H.P. Lovecraft", "Horror");
manager.runService();

