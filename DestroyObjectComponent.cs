using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PirateCrew.Components
{
	public class DestroyObjectComponent : MonoBehaviour
	{
		[SerializeField] private GameObject _objectToDestroy;
		
		private int valueAmount;

		public void DestroyObject()
		{
			Destroy(_objectToDestroy);
		}
	}
}


