﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//, IPointerClickHandler
public class BagButton : MonoBehaviour
{
	private Bag bag;

	[SerializeField]
	private Sprite full, empty;

	public Bag MyBag 
	{
		get
		{
			return bag;
		}
		set 
		{
			if (value != null)
			{
				GetComponent<Image>().sprite = full;
			}
			else 
			{
				GetComponent<Image>().sprite = empty;
			}
			bag = value;
		}
	}
//	public void OnPointerClick(PointerEventData eventData)
//	{
//		if (bag != null)
//		{
//			bag.MyBagScript.OpenCloseBags();
//		}
//	}
}
