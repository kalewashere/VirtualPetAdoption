namespace VirtualPetAdoption.Models
{
    public class Pet //attributes that descibe a pet, mapped to columns in databse - with each attribute having accessor methods getters and setters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
        // Simplified traits (1-5 scale)
        public int Playfulness { get; set; }
        public int Affection { get; set; }
    }
}