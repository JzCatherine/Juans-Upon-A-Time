using System;
using UnityEngine;

[Serializable]
public class Skills 
{

	[SerializeField]
	private string name;
	[SerializeField]
	private int damage;
	[SerializeField]
	private Sprite icon;
	[SerializeField]
	private float speed;
	[SerializeField]
	private float castTime;
	[SerializeField]
	private GameObject[] skillPrefab;


//	public string MyName {
//		get {
//			return name;
//		}
//	}
	public int MyDamage {
		get {
			return damage;
		}
	}
	public Sprite MyIcon {
		get {
			return icon;
		}
	}public float MySpeed {
		get {
			return speed;
		}
	}
	public float MyCastTime {
		get {
			return castTime;
		}
	}
	public GameObject[] MySkillPrefab
	{
		get {
			return skillPrefab;
		}
	}
}

