using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Services;
using Services.Models;
using Microsoft.Extensions.Logging;

namespace Services.Pages
{
    public class FromDatabaseModel : PageModel
    {
        private readonly ILogger<FromFileModel> _logger;

        public DatabaseProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public FromDatabaseModel(ILogger<FromFileModel> logger,
            DatabaseProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}