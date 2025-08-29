using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ProductApi.Controllers;
using ProductApi.Models;
using ProductApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ProductApi.Tests.Controllers;

public class ProductsControllerTests
{
    private readonly IProductRepository _mockRepository;
    private readonly ProductsController _controller;

    public ProductsControllerTests()
    {
        _mockRepository = Substitute.For<IProductRepository>();
        _controller = new ProductsController(_mockRepository);
    }

    [Fact]
    public async Task GetAll_WhenProductsExist_ReturnsOkWithProducts()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
            new Product { Id = 2, Name = "Book", Price = 19.99m, Category = "Books" }
        };
        _mockRepository.GetAllAsync().Returns(products);

        // Act
        var result = await _controller.GetAll();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);
        Assert.Equal(2, returnValue.Count());
        await _mockRepository.Received().GetAllAsync();
    }

    [Fact]
    public async Task GetById_ExistingId_ReturnsOkWithProduct()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" };
        _mockRepository.GetByIdAsync(1).Returns(product);

        // Act
        var result = await _controller.GetById(1);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<Product>(okResult.Value);
        Assert.Equal("Laptop", returnValue.Name);
        await _mockRepository.Received().GetByIdAsync(1);
    }

    [Fact]
    public async Task Create_ValidProduct_ReturnsCreatedAtAction()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" };
        _mockRepository.AddAsync(Arg.Any<Product>()).Returns(product);

        // Act
        var result = await _controller.Create(product);

        // Assert
        var createdResult = Assert.IsType<CreatedAtActionResult>(result);
        Assert.Equal("GetById", createdResult.ActionName);
        Assert.Equal(1, createdResult.RouteValues["id"]);
        var returnValue = Assert.IsType<Product>(createdResult.Value);
        Assert.Equal("Laptop", returnValue.Name);
        await _mockRepository.Received().AddAsync(Arg.Is<Product>(p => p.Name == "Laptop"));
    }

    [Fact]
    public async Task Delete_ExistingId_ReturnsNoContent()
    {
        // Arrange
        _mockRepository.DeleteAsync(1).Returns(true);

        // Act
        var result = await _controller.Delete(1);

        // Assert
        Assert.IsType<NoContentResult>(result);
        await _mockRepository.Received().DeleteAsync(1);
    }
}