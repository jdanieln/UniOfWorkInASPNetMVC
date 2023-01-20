namespace PatronesDeDiseno.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }

        //RelationShip
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
