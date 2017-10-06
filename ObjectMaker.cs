using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// set inter-cube distance and total cube side length. Keeps yielding compiling errors!
// public var dist = 1.1f;
// public var side = 10;

public class ObjectMaker : MonoBehaviour {

	public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 30; i++) {

			// iterate into x to make line segment
			Object.Instantiate (objectToCreate, new Vector3 (i * 1.2f, 0, 0), Quaternion.identity);

				// iterate into y to make vertical plane
				for (int j = 0; j < 30; j++) {
				Object.Instantiate (objectToCreate, new Vector3 (i * 1.2f, j * 1.2f, 0), Quaternion.identity);

				// iterate into z to make 2 far walls; just a shell
					for (int k = 0; k < 30; k+=29) {
					// if k == 0 OR 100
					Object.Instantiate (objectToCreate, new Vector3 (i * 1.2f, j * 1.2f, k * 1.2f), Quaternion.identity);
				}

				// iterate into z to make 2 floors; just a shell
					for (int l = 0; l < 30; l+=29) {
					// if l == 0 OR 100
					Object.Instantiate (objectToCreate, new Vector3 (i * 1.2f, l * 1.2f, j * 1.2f), Quaternion.identity);
				}

				// iterate into z to make 2 side walls; just a shell
				for (int m = 0; m < 30; m+=29) {
					// if l == 0 OR 100
					Object.Instantiate (objectToCreate, new Vector3 (m * 1.2f, i * 1.2f, j * 1.2f), Quaternion.identity);
				}


				// iterate into z to make solid cube
					// for (int k = 0; k < 50; k++) {
					// Object.Instantiate (objectToCreate, new Vector3 (i * 1.2f, j * 1.2f, k * 1.2f), Quaternion.identity);
					//	}
				}
		}

	}
	// Update is called once per frame
	void Update () {

	}
}
