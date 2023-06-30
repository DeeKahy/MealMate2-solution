using System.Text.Json;

namespace MealMate2.Models
{
    public class ActiveItemModel
    {
        // property for a food item, including name, experation date, and some other things        // property for a food item, including name, experation date, and some other things
        public string Name { get; set; }
        public string ExperationDate { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string weightORQuantity { get; set; }
        public string initWeightORQuantity { get; set; }

        // serialize the object to a string
        public override string ToString() => JsonSerializer.Serialize<ActiveItemModel>(this);
        public static List<ActiveItemModel> LoadItemsFromJson(string jsonFilePath)
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            var items = JsonSerializer.Deserialize<List<ActiveItemModel>>(jsonData);
            return items;
        }
    }
}
