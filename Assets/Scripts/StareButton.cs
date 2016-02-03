using System;
using System.Reflection;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class StareButton : MonoBehaviour, IEventSystemHandler, IPointerExitHandler, IPointerEnterHandler, ISelectHandler {

	//[RenamedSerializedData("onPress")]
	[SerializeField]
	private ButtonClickedEvent _OnClick = new ButtonClickedEvent();

	public float fillSpeed = 2f;

	Text _buttonLabel;

	public Image radialFill;
	bool _selected;
	bool _staring;

	void Awake() {
		_buttonLabel = this.gameObject.GetComponentInChildren<Text>();
	}

	// Use this for initialization
	void Start () {
		Reset ();
	}

	// Update is called once per frame
	void Update () {

		if (_staring)
			radialFill.fillAmount += (Time.deltaTime * fillSpeed);
		else
			radialFill.fillAmount -= (Time.deltaTime * fillSpeed);

		if (radialFill.fillAmount >= 1f) {
			radialFill.fillAmount = 1f;

			if (!_selected) { //prevent multiple triggers
				_selected = true;
				_OnClick.Invoke();
				Debug.Log("CLICK!");
			}
		}
		else if (radialFill.fillAmount <= 0f) {
			_selected = false;
			radialFill.fillAmount = 0f;
		}
	}

	public void StaringAt(bool on) {

		_staring = on;
	}

	public void Reset() {
		_staring = false;
		_selected = false;
		radialFill.fillAmount = 0;
	}

	public void OnPointerEnter(PointerEventData eventData) {

		//do your stuff when highlighted
		StaringAt(true);
	}

	public void OnPointerExit(PointerEventData eventData) {

		//do your stuff when not highlighted
		StaringAt(false);
	}

	public void OnSelect(BaseEventData eventData) {
		//do your stuff when selected
		_OnClick.Invoke();
		radialFill.fillAmount = 1f;
		_selected = true;

		Debug.Log("SELECT?!?!?!!");
	}

	[Serializable]
	public class ButtonClickedEvent : UnityEvent {}
}