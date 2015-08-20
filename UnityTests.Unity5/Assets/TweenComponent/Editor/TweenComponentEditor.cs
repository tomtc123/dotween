using UnityEngine;
using System.Collections;
using UnityEditor;

namespace TC.Tween {
[CustomEditor(typeof(TweenComponentBase))]
public class TweenComponentEditor : Editor {

	public TweenComponentBase mTarget;
	public SerializedProperty mOnComplete;

	void OnEnable() {
		mTarget = (TweenComponentBase)target;
		mOnComplete = serializedObject.FindProperty("onComplete");
	}

	public override void OnInspectorGUI ()
	{
		mTarget.target = EditorGUILayout.ObjectField("Target", mTarget.target, typeof(Transform), true) as Transform;
		mTarget.duration = EditorGUILayout.FloatField("Duration", mTarget.duration);
		mTarget.delay = EditorGUILayout.FloatField("Delay", mTarget.delay);
		mTarget.loopTimes = EditorGUILayout.IntField(new GUIContent("Loop Times","-1 infinite loop"), mTarget.loopTimes);
		mTarget.loopType = (DG.Tweening.LoopType)EditorGUILayout.EnumPopup("Loop Type", mTarget.loopType);
		mTarget.easeType = (DG.Tweening.Ease)EditorGUILayout.EnumPopup("Ease", mTarget.easeType);
		if (mTarget.easeType == DG.Tweening.Ease.INTERNAL_Custom) {
			mTarget.animaCurve = EditorGUILayout.CurveField("Ease curve", mTarget.animaCurve);
		}

		EditorGUILayout.PropertyField(mOnComplete, true);

	}

}
}
