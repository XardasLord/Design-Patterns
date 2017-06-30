using System;
using System.Collections.Generic;

namespace Builder.Models
{
    public class Item
    {
        private Dictionary<String, String> _itemInfoDict;
        private List<Item> _children = new List<Item>();

        public string ItemName { get; set; }

        public Item(string itemName)
        {
            ItemName = itemName;
            _itemInfoDict = new Dictionary<string, string>(20);
        }

        public void Add(Item childNode)
        {
            _children.Add(childNode);
        }

        public void AddItemInformation(string infoName, string info)
        {
            _itemInfoDict.Add(infoName, info);
        }

        public string GetItemInformation(string infoName)
        {
            string info;
            _itemInfoDict.TryGetValue(infoName, out info);

            return info;
        }

        public new string ToString()
        {
            string itemInformation = $"\n{ItemName} ";

            if(!(_itemInfoDict.Count == 0))
            {
                itemInformation += DisplayProductInfo();
            }
            
            using (IEnumerator<Item> enumerator = _children.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Item node = enumerator.Current;
                    itemInformation += node.ToString();
                }
            }

            return itemInformation;
        }

        public string DisplayProductInfo()
        {
            string productInfo = "";

            foreach(var entry in _itemInfoDict)
            {
                productInfo += entry.Key + ": " + entry.Value + " ";
            }

            return productInfo;
        }
    }
}
