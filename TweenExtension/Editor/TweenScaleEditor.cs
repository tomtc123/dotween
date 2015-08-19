using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Next.Tween {
[CustomEditor(typeof(TweenScale))]
	public class TweenScaleEditor : TweenBaseEditor {

		public override void OnInspectorGUI () {
			var tp = target as TweenScale;
			tp.from = EditorGUILayout.Vector3Field("From", tp.from);
			tp.to = EditorGUILayout.Vector3Field("To", tp.from);
			base.OnInspectorGUI();
		}
	}
}
