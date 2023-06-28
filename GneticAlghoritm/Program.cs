using ProblemSolvers.Experiments;
using ProblemSolvers.Logger;
using ProblemSolvers.ProblemSolvers;
using ProblemSolvers.ProblemSolvers.Crossing;
using ProblemSolvers.ProblemSolvers.GA;
using ProblemSolvers.ProblemSolvers.GA.Selection;
using ProblemSolvers.ProblemSolvers.Mutation;

//desktoplocation is the place that the file results will be saved in based on the user's computer.(applicable to windows)
// for the outputFolderName, is is basically based on the user's preferences to choose any name to be used as the folder name for saved results.
//inputFileName is the name of the 9 different provided datasets. (the datasets are already included in the submission file in order to make it easier to compile and run.)

string desktopLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // example for our own system output location is : string outputLocation = "C:\\Users\\Free\\OneDrive\\Desktop"
string outputFolderName = "a280_n279_bounded-strongly-corr.ttp"; //This is the name of the output folder in which the data will be saved (it is exactly same name as the provided dataset.)
string inputFileName = "a280_n279_bounded-strongly-corr.ttp"; // This is the first dataset (as an example) that it has been provided to us.

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
    desktopLocation
);




