namespace WearManager.Models
{
    public abstract class AbstractComponent 
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Distance { get; set; }
    }
}