using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvaders
{
	public class Game : MonoBehaviour
	{

		[SerializeField]
		private float gridSize;
		
		[SerializeField]
		private int invaderNumX;
		
		[SerializeField]
		private int invaderNumY;
		
		[SerializeField]
		private int sizeX;
		
		[SerializeField]
		private int sizeY;

		[SerializeField]
		private GameObject invaderPrefab;
		
		private List<Enemy> enemies = new List<Enemy>();

		public float GridSize
		{
			get { return gridSize; }
			set { gridSize = value; }
		}


		void Start()
		{
			var xNum = invaderNumX / 2 + invaderNumX % 2;
			var yNum = invaderNumY / 2 + invaderNumY % 2;;
			for (int i = -invaderNumX / 2; i < xNum; i++)
			{
				for (int j = - invaderNumY / 2; j < yNum; j++)
				{
					var enemyInstance = Instantiate(invaderPrefab, transform);
					enemyInstance.transform.position = new Vector3(sizeX * i, sizeY * j, 0);
					
					var enemy = enemyInstance.GetComponent<Enemy>();
					enemies.Add(enemy);
				}
			}
		}
	}
}