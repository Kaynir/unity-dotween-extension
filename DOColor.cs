using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace CozyDragon.Tweening
{
    public class DOColor : DOAnimation
    {
        [Header("Color Settings:")]
        [SerializeField] private Graphic _target = null;
        [SerializeField] private Color _startColor = Color.clear;
        [SerializeField] private Color _endColor = Color.white;

        protected override Tween CreateAnimation()
        {
            _target.color = _startColor;
            return _target.DOColor(_endColor, Duration);
        }
    }
}