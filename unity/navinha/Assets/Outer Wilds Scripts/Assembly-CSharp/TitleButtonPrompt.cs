using UnityEngine;
using UnityEngine.UI;

public class TitleButtonPrompt : MonoBehaviour
{
	[SerializeField]
	private Graphic[] _buttonPromptGraphics;
	[SerializeField]
	private Image _buttonImage;
	[SerializeField]
	private Sprite _xboxOneButtonA;
	[SerializeField]
	private Sprite _playstationButtonCross;
	[SerializeField]
	private Sprite _playstationButtonCircle;
	[SerializeField]
	private Sprite _ps5ButtonCross;
	[SerializeField]
	private Animator _animation;
	[SerializeField]
	private TitleCodeInputManager _titleCodeInputManager;
}
