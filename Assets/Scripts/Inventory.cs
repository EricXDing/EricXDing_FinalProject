using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

		public Text inventoryName;
		public Text inventoryDescription;

		// singletance
		public static Inventory instance;
		void Awake()
		{
			if (instance != null)
			{
				Debug.LogWarning("more than one instance of Invetory found!");
				return;
			}
			instance = this;
		}
		// singletance

		public List<Items> items = new List<Items>();
		public void Add(Items item)
		{
			items.Add(item);

			inventoryName.text += item.name;
			inventoryName.text += "\n";
			inventoryName.text += "\n";
			inventoryDescription.text += item.description;
			inventoryDescription.text += "\n";

		}


}
