namespace E_D;
public interface File
{
    public Task<bool> Have(string Name);
    public Task<string> Read(string Name);
}