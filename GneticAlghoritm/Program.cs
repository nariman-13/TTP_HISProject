using ProblemSolvers.Experiments;
using ProblemSolvers.Logger;
using ProblemSolvers.ProblemSolvers;
using ProblemSolvers.ProblemSolvers.Crossing;
using ProblemSolvers.ProblemSolvers.GA;
using ProblemSolvers.ProblemSolvers.GA.Selection;
using ProblemSolvers.ProblemSolvers.Mutation;

string outputLocation = "C:\\Users\\Free\\OneDrive\\Desktop";
string outputFolderName = "AliGa2";
string inputFileName = "280Cities-Easy.ttp";

GeneticAlgorithm geneticAlgorithmParams = new
(
    mutationFreqThreshhold: 0.65,
    crossoverFrequency: 0.8,
    mutationStrategy: new SwapCountMutation(1),
    crossoverStrategy: new OrderedCrossover(),
    parentSelector: new Tournament(0.05),
    new ProblemSolverParams(50)
);

ExperimentRunner<GeneticAlgorithm, GeneticAlghoritm, MinMaxAvg>.RunExperiments(
    new List<Experiment<GeneticAlgorithm>> { new Experiment<GeneticAlgorithm>(outputFolderName, 10, 2000, geneticAlgorithmParams) },
    new GaSolverFactory(),
    inputFileName,
    outputLocation
);




