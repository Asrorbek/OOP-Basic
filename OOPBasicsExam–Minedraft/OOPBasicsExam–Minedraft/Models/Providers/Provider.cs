﻿using System;
using System.Text;

public abstract class Provider
{
    private double energyOutput;
    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
    
    public string Id { get; private set; }

    public double EnergyOutput
    {
        get => this.energyOutput;
        protected set
        {
            if (value<0||value>=10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }

            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        sb.AppendLine($"{this.GetType().Name.Replace("Provider", "")} Provider - {this.Id}")
            .Append($"Energy Output: {this.EnergyOutput}");
        return sb.ToString();
    }
}
