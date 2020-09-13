using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Damage
{
	float value;
}

enum Attribute
{
	Fire,
	Water,
	Thunder,
}
public struct AttributeDamage
{
	float value;
	Attribute attribute;
}
