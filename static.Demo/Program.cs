using Static.Demo;

Fish fish = new Fish("Rohu", "White", "xxl");

Console.WriteLine($"Fish Breed is {fish.FishBreed} \n Fish color is {fish.FishColor} \n Fish size is  {fish.FishSize} ");

Console.WriteLine(fish.CountFish());

/*FishRegion is a static member in class Fish. FishRegion can be accessed using classname without creating object of the class Fish */
Console.WriteLine(Fish.FishRegion);

