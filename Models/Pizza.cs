using System.ComponentModel.DataAnnotations;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Models;

public class Pizza
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public PizzaSize Size { get; set; }
    public bool IsGlutenFree { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

public enum PizzaSize { Small, Medium, Large }

[BindProperty]
public Pizza NewPizza { get; set; }

public string GlutenFreeText(Pizza pizza)
{
    if (pizza.IsGlutenFree)
        return "Gluten Free";
    return "Not Gluten Free";
}