using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Main
    {
        const int percentSplit = 66;
        public static string classifyTest(string file, string classifier)
        {
            string data = "No data";
            try
            {
                //weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader("C:\\Users\\kinli\\source\\repos\\WebApplication2\\WebApplication2\\iris.arff"));
                weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(file));
                insts.setClassIndex(insts.numAttributes() - 1);
                weka.classifiers.Classifier cl = new weka.classifiers.trees.J48();

                if (classifier == "J48")
                {
                    cl = new weka.classifiers.trees.J48();
                }
                else if (classifier == "MLP")
                {
                    cl = new weka.classifiers.functions.MultilayerPerceptron();
                }
                else if(classifier == "NaiveBayes")
                {
                    cl = new weka.classifiers.bayes.NaiveBayes();
                }

                //data = ("Performing " + percentSplit + "% split evaluation.\n");
                data = ("Performing use training set evaluation.\n");
                //randomize the order of the instances in the dataset.
                
                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);
                /*
                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl.buildClassifier(train);
                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }*/
                cl.buildClassifier(insts);
                
                int numCorrect = 0;
                for (int i = 0; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                data = data + (numCorrect + " out of " + insts.numInstances() + " correct (" +
                           (double)((double)numCorrect / (double)insts.numInstances() * 100.0) + "%)");

            }
            catch (java.lang.Exception ex)
            {
                data = "Error";
                ex.printStackTrace();
            }
            return data;
        }

    }
}