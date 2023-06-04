using ProblemSolvers.ProblemSolvers;
using ProblemSolvers.ProblemSolvers.Evaluation;
using ProblemSolvers.Logger;
using ProblemSolvers.ProblemSolvers;
using ProblemSolvers.Logger;
using ProblemSolvers.ProblemSolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolvers.ProblemSolvers.GA;

namespace ProblemSolvers.Experiments;

public abstract class ProblemSolverFactory<T, P, L> where T : ProblemSlover<L> where P : ProblemSolverParams where L : ILogable
{
    public abstract T GetProblemSolver(P solverParams, int[] avalibleGens, IEvaluator evaluator, ILogger<L>? logger = null);
}

public class GaSolverFactory : ProblemSolverFactory<GeneticAlghoritm, GeneticAlgorithm, MinMaxAvg>
{
    public override GeneticAlghoritm GetProblemSolver(GeneticAlgorithm solverParams, int[] avalibleGens, IEvaluator evaluator, ILogger<MinMaxAvg> logger)
    {
        return new GeneticAlghoritm(solverParams, avalibleGens, evaluator)
        {
            logger = logger
        };
    }
}