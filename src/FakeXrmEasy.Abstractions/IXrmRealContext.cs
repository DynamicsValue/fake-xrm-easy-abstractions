namespace FakeXrmEasy.Abstractions 
{
    public interface IXrmRealContext: IXrmBaseContext 
    {
        string ConnectionStringName { get; set; }
    }
}