using System.Threading.Tasks;
using DotnetTutorial.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotnetTutorial.Areas.MyArea.ViewComponents
{
    public class TotalLengthViewComponent: ViewComponent
    {
        private readonly YoDBContext _db;

        public TotalLengthViewComponent(YoDBContext db)
        {
            _db = db;
        }

       public async Task<IViewComponentResult> InvokeAsync(
        )
        {
            var items = await _db.user.CountAsync();
            return View(items);
        }
    }
    
}