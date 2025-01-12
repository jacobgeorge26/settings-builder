﻿namespace Source.Models;

public class Farm : ISettings
{
    public string? Name { get; init; } = null!;

    public string Location { get; init; } = null!;
}