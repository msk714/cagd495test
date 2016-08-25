using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Character
{
	public class MikesEnemyBehavior : MonoBehaviour {

		public float speed, rayDistance;
		public GameObject posObj1, posObj2;
		public bool toPos1, toPos2;

		private RaycastHit enemyRayHit;
		private Ray enemyRay;

		// Use this for initialization
		void Start () {
			toPos1 = true;
			toPos2 = false;
		}
		
		// Update is called once per frame
		void Update () 
		{
			if (toPos1) 
			{	
				transform.position = Vector3.Lerp (transform.position, posObj1.transform.position, speed * Time.deltaTime);
				enemyRay = new Ray (transform.position, posObj1.transform.position.normalized);
				if (Physics.Raycast (enemyRay, out enemyRayHit, rayDistance)) 
				{
					if (enemyRayHit.collider.gameObject.name == posObj1.name) 
					{
						Debug.DrawRay (transform.position, posObj1.transform.position.normalized);
						toPos1 = false;
						toPos2 = true;
					}
				}
			}
			else if(toPos2)
			{
				transform.position = Vector3.Lerp (transform.position, posObj2.transform.position, speed * Time.deltaTime);
				enemyRay = new Ray (transform.position, posObj2.transform.position.normalized);

				if (Physics.Raycast (enemyRay, out enemyRayHit, rayDistance)) 
				{
					if (enemyRayHit.collider.gameObject.name == posObj2.name) 
					{
						Debug.DrawRay (transform.position, posObj2.transform.position.normalized);
						toPos1 = true;
						toPos2 = false;
					}
				}
			}
		}
	}
}