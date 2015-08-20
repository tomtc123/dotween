using UnityEngine;
using System.Collections;
using UnityEditor;

namespace TC.Tween {
[CustomEditor(typeof(TweenPosition))]
	public class TweenPositionEditor : TweenComponentEditor {

		public override void OnInspectorGUI () {
			var tp = target as TweenPosition;
			tp.from = EditorGUILayout.Vector3Field("From", tp.from);
			tp.to = EditorGUILayout.Vector3Field("To", tp.to);
			base.OnInspectorGUI();
		}
	}
}
