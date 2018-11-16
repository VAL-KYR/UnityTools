using UnityEngine;
using System;

// From http://va.lent.in/unity-make-your-lists-functional-with-reorderablelist/ //

[Serializable]
public struct MobWave {
	public enum WaveType {
		Mobs,
		Boss
	}

	public WaveType Type;
	public GameObject Prefab;
	public int Count;
}
