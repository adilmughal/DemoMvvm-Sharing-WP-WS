namespace DemoMvvm.Shared.Contract
{
    using System.Collections.Generic;
    using DemoMvvm.Shared.Model;
    using System.Threading.Tasks;

    internal interface IContactRepository
    {
        IEnumerable<Category> PopulateDummyDataInCategories();
        
        Task Submit(string userName, string email, int selectedCategoryId, string inquiry);
    }
}