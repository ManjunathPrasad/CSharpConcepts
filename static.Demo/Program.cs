using Static.Demo;

Fish fish = new Fish();

Console.WriteLine(fish.CountFish());

/*FishRegion is a static member in class Fish. FishRegion can be accessed using classname without creating object of the class Fish */
Console.WriteLine(Fish.FishRegion);