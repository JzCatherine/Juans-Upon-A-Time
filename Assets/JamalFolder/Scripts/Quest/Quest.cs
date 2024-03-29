﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Quest
{
	[SerializeField]
	private string title;
	[SerializeField]
	private string description;

	[SerializeField]
	private CollectObjective[] collectObjective;



	public QuestScript MyQuestScript { get; set; }

	public string MyTitle 
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}
	public string MyDescription 
	{
		get
		{
			return description;
		}
		set
		{
			description = value;
		}
	}
	public  CollectObjective[] MyCollectObjective 
	{
		get
		{
			return collectObjective;
		}
	}
	public bool IsComplete 
	{
		get
		{
			foreach (Objective o in collectObjective)
			{
				if (!o.IsComplete)
				{
					return false;
				}
			}
			return true;
		}
	
	}
    // Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public abstract class Objective 
{	
	[SerializeField]
	private int amount;

	private int currentAmount;

	[SerializeField]
	private string type;

	public int MyAmount 
	{
		get
		{
			return amount;
		}
	}
	public int MyCurrentAmount 
	{
		get
		{
			return currentAmount;
		}
		set
		{
			currentAmount = value;
		}
	}
	public string MyType 
	{
		get
		{
			return type;
		}
	}
	public bool IsComplete 
	{
		get
		{
			return MyCurrentAmount >= MyAmount;
		}

	}
}
[System.Serializable]
public class CollectObjective : Objective
{	
	public void UpdateItemCount(Item item) 
	{
		if (MyType.ToLower() == item.MyItemName.ToLower())
		{
			MyCurrentAmount = InventoryScript.MyInstance.GetItemCount(item.MyItemName);
			Questlog.MyInstance.UpdateSelected();
			Questlog.MyInstance.CheckCompletion();
		}
	}
}
