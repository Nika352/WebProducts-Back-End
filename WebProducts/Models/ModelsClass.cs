﻿namespace WebProducts.Models;

public record ProductModel(int Code, string Name, decimal Price, int CategoryId, int CountryId);

public record CountryModel(string Name);

public record CategoryModel(string Name, int ParentId);