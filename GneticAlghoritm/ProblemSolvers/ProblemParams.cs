namespace ProblemSolvers.ProblemSolvers;

public record ProblemSolverParams
{
    public int PopulationSize { get; init; }

    public ProblemSolverParams(int populationSize)
    {
        PopulationSize = populationSize;
    }
}
