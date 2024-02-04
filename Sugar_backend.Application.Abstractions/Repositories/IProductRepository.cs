using Sugar_backend.Application.Models.Products;

namespace Sugar_backend.Application.Abstraction.Repositories;

public interface IProductRepository
{
    Product? GetProductByName(string name);

    int GetCarbsAmount(string name);

    void AddProduct(string name, int carbs);
}