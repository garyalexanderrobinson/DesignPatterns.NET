namespace DesignPatterns.Builder
{
    public interface IBuilder<T>
    {
        T Build();
    }
}