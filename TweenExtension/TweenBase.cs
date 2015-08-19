using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;

namespace Next.Tween {
	public class TweenBase : MonoBehaviour {

		public Transform target;
		public float duration = 1f;
		public float delay = 0f;
		public Ease easeType = Ease.Linear;
		public AnimationCurve animaCurve = new AnimationCurve(new Keyframe(0,0,0,0), new Keyframe(1,1,1,1));
		public int loopTimes = 1;
		public LoopType loopType = LoopType.Restart;
		public UnityEvent onComplete;

		public virtual void OnStart() {
			if (target == null) {
				target = transform;
			}
		}

		// Use this for initialization
		public void Start () {
			OnStart();
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
