namespace DrizzlyWebsite.Models
{
    public class Activity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public ActivityImage Image { get; set; }
        
        public ActivityConditions Conditions { get; set; }
        
        // User foreign key
        public string UserId { get; set; }
        
        public ApplicationUser User { get; set; }
    }
}