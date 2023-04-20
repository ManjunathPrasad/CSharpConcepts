namespace Static.Demo
{
    public interface IFish
    {
        string FishBreed { get; set; }
        string? FishColor { get; set; }
        string? FishSize { get; set; }

        int CountFish();
    }
}