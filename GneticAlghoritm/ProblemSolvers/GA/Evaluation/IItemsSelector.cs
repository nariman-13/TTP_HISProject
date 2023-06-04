using ProblemSolvers.ProblemLoader;

namespace ProblemSolvers.ProblemSolvers;

internal interface IItemsSelector
{
    public Dictionary<City, List<Item>> SelectItems(PermutationIndividual individual, TravelingThiefProblem ttp);
}

