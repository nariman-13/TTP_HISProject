namespace ProblemSolvers.ProblemSolvers.GA.Selection;

public interface ISelector
{
    public PermutationIndividual SelectParent(PermutationIndividual[] population);
}

