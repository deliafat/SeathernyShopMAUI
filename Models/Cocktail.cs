namespace SeathernyShopMAUI.Models

{
    public record Cocktail(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    Uri Image,
    List<string> Sweet,
    List<string> Savory);
}

    