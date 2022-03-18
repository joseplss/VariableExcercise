using System;

namespace VariableExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code goes here
            string dogName = "Mocha";
            int dogAge = 2;
            bool dogTypeDash = true;
            char dogToy = '!';
            double X = 33.76767;
            double Y = 117.91;
            decimal dogAway = 12.42m;

            Console.WriteLine
                (
                $"Let me tell you a bit about my dog, {dogName} \nQuick true or false question though! is she a dachshund? {dogTypeDash} \nAnyway, she is {dogAge} and she loves her toys{dogToy}\nShe's acts a lot like a hunt dog, so be careful if you're coords are {X},{Y} because she will get you! \ninfact, she is {dogAway} meters from you! "
                );


        }
    }
}
