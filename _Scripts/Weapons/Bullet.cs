using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
	[SerializeField]
	protected BulletDataSO bulletData;

	public virtual BulletDataSO BulletData
	{
		get { return bulletData; }
		set { bulletData = value; }
	}

	//[field: SerializeField]
	//public virtual BulletDataSO BulletData { get; set; }
}
