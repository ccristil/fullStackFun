namespace FirstAPI.Data
{
    public interface IFoodRepository
    {
        IEnumerable<MarriottFood> Foods { get; }

    }
}
