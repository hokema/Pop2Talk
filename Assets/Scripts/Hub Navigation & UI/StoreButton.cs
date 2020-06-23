﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour {

	UIButton button;
	LootBoxSettings myBox;

	IntCallback Clicked;
	int index;

	[SerializeField] Text priceText;
	[SerializeField] GameObject priceHolder;

	void Awake () {
		button = GetComponentInChildren<UIButton>();
	}

	void Start() {
		button.SubscribePress(Click);
	}

	public void SetUp(LootBoxSettings lootBox, int index, IntCallback OnClick) {
		myBox = lootBox;
		button.SetSprite(lootBox.picture);
		priceText.text = myBox.price.ToString();
		this.index = index;
		Clicked = OnClick;
	}
	

	void Click() {
		Clicked(index);
	}

	public void TogglePrice(bool on) {
		priceHolder.SetActive(on);
	}
}
