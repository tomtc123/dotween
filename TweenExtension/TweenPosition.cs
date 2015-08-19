using UnityEngine;
using System.Collections;
using DG.Tweening;

namespace Next.Tween {
	public class TweenPosition : TweenBase {
		public Vector3 from = Vector3.zero;
		public Vector3 to = Vector3.one;
		
		public override void OnStart ()
		{
			base.OnStart ();
			DoMove();
		}
		
		void DoMove() {
			target.localPosition = from;
			DOTween.To(()=>{return target.localPosition;}, (x)=>{target.localPosition = x;}, to, duration)
				.SetDelay(delay)
				.SetLoops(loopTimes, loopType)
				.OnComplete(onComplete.Invoke);
		}
	}
}
