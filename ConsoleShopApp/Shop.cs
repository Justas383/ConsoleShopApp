using System;

namespace ConsoleShopApp
{
    
    internal class Shop
    {
        private readonly string _name;
        private readonly DateTime _createdDate;
        public Shop(string name, DateTime createdDate )
        {
           _name = name;
            _createdDate = createdDate;
        }
        public Shop() : this("Default", DateTime.Now)
        {
       
        }
        public string GetInformation()
        {
            return "This is a cool shop";
        }
        public void ListItems()
        {
            throw new NotImplementedException();
        }

        public void Buy(string v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void LoadItems(string itemName, int quantity)
        {
            // To load all items
        }
    }
}