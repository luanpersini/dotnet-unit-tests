using TestingBasics.Functionalities;

namespace TestingBasics.Test.FunctionalitiesTests;

//Manual mock for DbService
public class DbServiceMock : IDbService
{
    public bool ProcessResult { get; set; }
    public Product ProductBeingProcessed { get; set; }
    public int ProductIdBeingProcessed { get; set; }

    public bool RemoveShoppingCartItem(int? id)
    {
        if (id != null)
            ProductIdBeingProcessed = Convert.ToInt32(id);
        return ProcessResult;
    }

    public bool SaveShoppingCartItem(Product prod)
    {
        ProductBeingProcessed = prod;
        return ProcessResult;
    }
}