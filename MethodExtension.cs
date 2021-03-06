﻿using UnityEngine;
using System.Collections;

public static class ExtensionForTransform {
	public static T GetOrAddComponent<T> (this Component child) where T: Component {
		T result = child.GetComponent<T>();
		if (result == null) {
			result = child.gameObject.AddComponent<T>();
		}
		return result;
	}
}
