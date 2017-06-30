using System;
using System.Collections.Generic;

namespace Builder.Models
{
    public class ItemBuilder
    {
        private List<Item> _items = new List<Item>();
        private Item _root;
        private Item _current;
        private Item _parent;

        public ItemBuilder(string rootName)
        {
            _root = new Item(rootName);

            AddItemToList(_root);

            _current = _root;
            _parent = _root;

            _root.AddItemInformation("Parent", _parent.ItemName);
        }

        public void AddItemInformation(string name, string value)
        {
            _current.AddItemInformation(name, value);
        }

        public void AddChild(string child)
        {
            Item childNode = new Item(child);

            AddItemToList(childNode);

            _current.Add(childNode);
            _parent = _current;
            _current = childNode;

            childNode.AddItemInformation("Parent", _parent.ItemName);
        }

        public void AddSibling(string sibling)
        {
            Item siblingNode = new Item(sibling);

            AddItemToList(siblingNode);

            _parent.Add(siblingNode);
            _current = siblingNode;

            siblingNode.AddItemInformation("Parent", _parent.ItemName);
        }

        public void AddItemToList(Item newItem)
        {
            _items.Add(newItem);
        }

        public new string ToString()
        {
            return _root.ToString();
        }

        public void DisplayAllItems()
        {
            foreach(var item in _items)
            {
                Console.WriteLine($"{item.ItemName}: {item.DisplayProductInfo()}");
            }
        }

        public void EditThisItem(string itemName)
        {
            foreach (var item in _items)
            {
                if(item.ItemName.Equals(itemName))
                {
                    _current = item;

                    SetItemsParent(_current.GetItemInformation("Parent"));
                }
            }
        }

        public void SetItemsParent(string parentItem)
        {
            foreach (var item in _items)
            {
                if (item.ItemName.Equals(parentItem))
                {
                    _parent = item;
                }
            }
        }

        public string GetItemByName(string itemToGet)
        {
            Item itemToReturn = null;

            foreach(var item in _items)
            {
                if(item.ItemName.Equals(itemToGet))
                {
                    itemToReturn = item;
                }
            }

            return itemToReturn.ToString();
        }
    }
}
