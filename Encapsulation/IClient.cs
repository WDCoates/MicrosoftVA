namespace Encapsulation
{
    public interface IClient
    {
        string Name { get; set; }

        void AddApplication(string application);

        void DelApplication(string application);
    }
}