using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    public class Animal
    {
        public string Noise { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isMammal { get; set; }

        public Animal(string noise, string name, string description, bool isMammal)
        {
            this.Noise = noise;
            this.Name = name;
            this.Description = description;
            this.isMammal = isMammal;
        }

        public Animal()
        {

        }
    }

    public class Bird : Animal
    {
        public string typeOfBird { get; set; }
        public bool hasColoredFeathers { get; set; }
        public int coloredFeathersCount { get; set; }
        public double coloredFeathersRate { get; set; }

        public Bird(string type, bool hasFeather, int featherCount, double featherRate,
            string noise, string name, string description, bool isMammal)
        {
            this.typeOfBird = type;
            this.hasColoredFeathers = hasFeather;
            this.coloredFeathersCount = featherCount;
            this.coloredFeathersRate = featherRate;

            this.Noise = noise;
            this.Name = name;
            this.Description = description;
            this.isMammal = isMammal;

        }

        public void CreativeDisplay()
        {
            Console.WriteLine($"{Name} makes a {Noise} sound, can be described as looking " +
                $"like {Description}, and is it a mammal? {isMammal}. " +
                $"It is a bird, of type {typeOfBird}, and does it have colored feather? {hasColoredFeathers}. " +
                $"It has {coloredFeathersCount} colored feathers, at a rate of {coloredFeathersRate} per inch");
        }

    }

    public class Reptile : Animal
    {
        public string typeOfReptile { get; set; }
        public bool hasScales { get; set; }
        public int scalesCount { get; set; }
        public double scalesRate { get; set; }


        public Reptile(string typeOfReptile, bool hasScales, int scalesCount, double scalesRate,
            string noise, string name, string description, bool isMammal)
        {
            this.typeOfReptile = typeOfReptile;
            this.hasScales = hasScales;
            this.scalesCount = scalesCount;
            this.scalesRate = scalesRate;

            Noise = noise;
            Name = name;
            Description = description;
            this.isMammal = isMammal;
        }

        public void CreativeDisplay()
        {
            Console.WriteLine($"{Name} makes a {Noise} sound, can be described as looking " +
                $"like {Description}, and is it a mammal? {isMammal}. " +
                $"It is a reptile, of type {typeOfReptile}, and does it have scales? {hasScales}. " +
                $"It has {scalesCount} scales, at a rate of {scalesRate} per inch");
        }
    }
}
