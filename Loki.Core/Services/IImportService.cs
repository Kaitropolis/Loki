using Microsoft.AspNetCore.Http;

namespace Loki.Services
{
    public interface IImportService
    {
        Task ImportAnimals(IFormFile? importFile);
    }
}