using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using DG.Tweening;

namespace TC.Tween {
	public class ButtonScale : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler {

		public Transform target;
		public Vector3 hover = new Vector3(1.05f, 1.05f, 1.05f);
		public Vector3 pressed = new Vector3(1.1f, 1.1f, 1.1f);
		public float duration = .2f;

		Vector3 mScale;

		void Start() {
			if (target == null) {
				target = transform;
			}
			mScale = target.localScale;
		}

		#region IPointerDownHandler implementation

		public void OnPointerDown (PointerEventData eventData)
		{
			DoScale(pressed);
		}

		#endregion

		#region IPointerUpHandler implementation

		public void OnPointerUp (PointerEventData eventData)
		{
			DoScale(mScale);
		}

		#endregion

		#region IPointerEnterHandler implementation

		public void OnPointerEnter (PointerEventData eventData)
		{
			DoScale(hover);
		}

		#endregion

		#region IPointerExitHandler implementation

		public void OnPointerExit (PointerEventData eventData)
		{
			DoScale(mScale);
		}

		#endregion

		public void DoScale(Vector3 to) {
			DOTween.To(()=>{return target.localScale;}, (x)=>{target.localScale = x;}, to, duration);
		}

	}
}
