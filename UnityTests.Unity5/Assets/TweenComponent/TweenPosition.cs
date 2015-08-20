using UnityEngine;
using System.Collections;
using DG.Tweening;

namespace TC.Tween {
	public class TweenPosition : TweenComponentBase {
		public Vector3 from = Vector3.zero;
		public Vector3 to = Vector3.one;
		
		public override void OnStart ()
		{
			base.OnStart ();
			DoMove();
		}
		
		void DoMove() {
			var type = target.GetType();
			if (type.IsSubclassOf(typeof(RectTransform)) || (type == typeof(RectTransform))) {
				Debug.Log("target is RectTransform");
				var rect = target.GetComponent<RectTransform>();
				rect.anchoredPosition3D = from;
				DOTween.To(()=>{return rect.anchoredPosition3D;}, (x)=>{rect.anchoredPosition3D = x;}, to, duration)
					.SetDelay(delay)
					.SetLoops(loopTimes, loopType)
					.OnComplete(onComplete.Invoke);
			}
			else {
				target.localPosition = from;
				DOTween.To(()=>{return target.localPosition;}, (x)=>{target.localPosition = x;}, to, duration)
					.SetDelay(delay)
					.SetLoops(loopTimes, loopType)
					.OnComplete(onComplete.Invoke);
			}
		}
	}
}
