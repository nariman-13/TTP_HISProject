using ProblemSolvers.ProblemSolvers.Crossing;
using ProblemSolvers.ProblemSolvers.GA.Selection;
using ProblemSolvers.ProblemSolvers.Mutation;

namespace ProblemSolvers.ProblemSolvers.GA;

public record GeneticAlgorithm : ProblemSolverParams
{
    private Tournament parentSelector;
    private ProblemSolverParams problemSolverParams;

    public GeneticAlgorithm(
                    double mutationFrequencyTreshold,
                    double crossingFrequency,
                    IMutationStrategy mutationStrategy,
                    ICrossingStrategy crossingStrategy,
                    ISelector parentSelector,
                    int populationSize) : base(populationSize)
    {
        this.MutationFrequencyTreshold = mutationFrequencyTreshold;
        this.CrossingFrequency = crossingFrequency;
        this.MutationStrategy = mutationStrategy;
        this.CrossingStrategy = crossingStrategy;
        this.ParentSelector = parentSelector;
    }

    public GeneticAlgorithm(
                double mutationFreqThreshhold,
                double crossoverFrequency,
                IMutationStrategy mutationStrategy,
                ICrossingStrategy crossoverStrategy,
                ISelector parentSelector,
                ProblemSolverParams problemSolver) : base(problemSolver)
    {
        MutationFrequencyTreshold = mutationFreqThreshhold;
        CrossingFrequency = crossoverFrequency;
        MutationStrategy = mutationStrategy;
        CrossingStrategy = crossoverStrategy;
        ParentSelector = parentSelector;
    }

    public double MutationFrequencyTreshold { get; init; }
    public double CrossingFrequency { get; init; }
    public IMutationStrategy MutationStrategy { get; init; }
    public ICrossingStrategy CrossingStrategy { get; init; }
    public ISelector ParentSelector { get; init; }
}

