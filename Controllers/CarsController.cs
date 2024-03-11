// Controllers/CarsController.cs
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    private static List<Car> _cars = new List<Car>
    {
        new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2022, Price = 25000 },
        new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2021, Price = 22000 }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
        return Ok(_cars);
    }

    [HttpPost]
    public ActionResult<Car> Post([FromBody] Car car)
    {
        car.Id = _cars.Count + 1;
        _cars.Add(car);
        return CreatedAtAction(nameof(Get), new { id = car.Id }, car);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Car car)
    {
        var existingCar = _cars.Find(c => c.Id == id);
        if (existingCar == null)
            return NotFound();

        existingCar.Make = car.Make;
        existingCar.Model = car.Model;
        existingCar.Year = car.Year;
        existingCar.Price = car.Price;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var car = _cars.Find(c => c.Id == id);
        if (car == null)
            return NotFound();

        _cars.Remove(car);
        return NoContent();
    }
}
