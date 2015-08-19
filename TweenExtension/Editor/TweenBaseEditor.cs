using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Next.Tween {
[CustomEditor(typeof(TweenBase))]
public class TweenBaseEditor : Editor {

	public TweenBase mTarget;

	void OnEnable() {
		mTarget = (TweenBase)target;
	}

	public override void OnInspectorGUI ()
	{
		mTarget.target = EditorGUILayout.ObjectField("Target", mTarget.target, typeof(Transform), true) as Transform;
		mTarget.duration = EditorGUILayout.FloatField("Duration", mTarget.duration);
		mTarget.delay = EditorGUILayout.FloatField("Delay", mTarget.delay);
		mTarget.loopTimes = EditorGUILayout.IntField(new GUIContent("Loop Times","-1表示一直循环"), mTarget.loopTimes);
		mTarget.loopType = (DG.Tweening.LoopType)EditorGUILayout.EnumPopup("Loop Type", mTarget.loopType);
		mTarget.easeType = (DG.Tweening.Ease)EditorGUILayout.EnumPopup("Ease", mTarget.easeType);
		if (mTarget.easeType == DG.Tweening.Ease.INTERNAL_Custom) {
			mTarget.animaCurve = EditorGUILayout.CurveField("Ease curve", mTarget.animaCurve);
		}

	}

}
}
