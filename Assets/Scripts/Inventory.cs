using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

		public Text inventoryName;
		public Text inventoryDescription;


		void start() {


		}

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
			inventoryDescription.text += item.description;
			inventoryDescription.text += "\n";

			// // GameObject newText = new GameObject("Text1");
			// // var newTextComp = newText.AddComponent<Text>();
			// // newTextComp.text = "text" + item.name;
			// // newTextComp.fontSize = 14;
			// // newText.transform.SetParent(transform);
			//
	    // GameObject UItextGO = new GameObject("Text2");
	    // UItextGO.transform.SetParent(canvas_transform);
			//
	    // RectTransform trans = UItextGO.AddComponent<RectTransform>();
	    // trans.anchoredPosition = new Vector2(x, y);
			//
	    // Text text = UItextGO.AddComponent<Text>();
	    // text.text = "text" + item.name;
	    // text.fontSize = 20;
	    // // text.color = text_color;
		}

		void Update () {
				// foreach (Items element in items)
				// {
				// 		// inventoryName.text = element.name;
				// 		// inventoryDescription.text = element.description;
				//
				//
				// }
		}


}
