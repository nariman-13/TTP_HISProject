using ProblemSolvers.ProblemSolvers;

namespace ProblemSolvers.Experiments;

public record Experiment<T> where T : ProblemSolverParams
{
    public string OutputFolder { get; private set; }
    public int Repeats { get; private set; }
    public int MaxIterations { get; private set; }
    public T ProblemSolverParams { get; private set; }

    public Experiment(string dstPathName, int repeats, int maxIterations, T problemSolverParams)
    {
        OutputFolder = dstPathName;
        Repeats = repeats;
        MaxIterations = maxIterations;
        ProblemSolverParams = problemSolverParams;
    }
}

