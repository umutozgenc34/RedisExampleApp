using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace RedisExampleApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductService productService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(Product product)=> Ok(await productService.CreateAsync(product));

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await productService.GetAllAsync());
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) => Ok(await productService.GetAsync(id));
    
}
