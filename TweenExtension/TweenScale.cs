using UnityEngine;
using System.Collections;
using DG.Tweening;

namespace Next.Tween {
	public class TweenScale : TweenBase {
		public Vector3 from = Vector3.zero;
		public Vector3 to = Vector3.one;

		public override void OnStart ()
		{
			base.OnStart ();
			DoScale();
		}

		void DoScale() {
			target.localScale = from;
			DOTween.To(()=>{return target.localScale;}, (x)=>{target.localScale = x;}, to, duration)
				.SetDelay(delay)
				.SetLoops(loopTimes, loopType)
				.OnComplete(onComplete.Invoke);
		}

	}
}
