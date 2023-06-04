namespace ProblemSolvers.ProblemSolvers.Crossing;

public interface ICrossingStrategy
{
    public PermutationIndividual[] Cross(PermutationIndividual parent1, PermutationIndividual parent2);
}

