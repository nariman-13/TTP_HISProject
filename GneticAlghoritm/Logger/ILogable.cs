namespace ProblemSolvers.Logger;

public interface ILogable
{
    public string ToString(char separator);
    public string GetHeader(char separator);
}

