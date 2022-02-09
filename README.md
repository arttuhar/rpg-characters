# rpg-characters

## Table of Contents

- [General Information](#general-information)
  - [Equipment](#equipment)
  - [Heroes](#heroes)
  - [Weapons](#weapons)
  - [Armour](#armour)
- [Technologies](#technologies)
- [Maintainers](#maintainers)

## General Information

#### Heroes

User can select character class at the beginning. Character always begins from level 1 and every time character levels up, they gain additional points to their abilities. Each class has different strengths and weaknesses and more detailed breakdown of character abilities can be found from tables below.

__Mage__

Mages will deal increased damage for every point of *Intelligence*. Each point of *Intelligence* increases Mages damage by 1%.

At level 1:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
1 | 1 | 8

At level up:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
1 | 1 | 5

__Ranger__

Rangers will deal increased damage for every point of *Dexterity*. Each point of *Dexterity* increases Rangers damage by 1%.

At level 1:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
1 | 7 | 1

At level up:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
1 | 5 | 1

__Rogue__

Rogues will deal increased damage for every point of *Dexterity*. Each point of *Dexterity* increases Rogues damage by 1%.

At level 1:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
2 | 6 | 1

At level up:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
1 | 4 | 1

__Warrior__

Warriors will deal increased damage for every point of *Strength*. Each point of *Strength* increases Warriors damage by 1%.

At level 1:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
5 | 2 | 1

At level up:

Strength | Dexterity | Intelligence
:---: | :---: | :---:
3 | 2 | 1


### Equipment

There are several different items which exists. Character can equip items to increase stats. Full list of available slots is found below:

* __Head__ - Armour

* __Body__ - Armour

* __Legs__ - Armour

* __Hand__ - Weapon


### Weapons

Character can equip weaponry to increase damage and attack speed. Weapons are possible to equip on the Hand slot. The weapons DPS can be calculated by multiplying damage and attack speed together:

__Damage * Attack speed = DPS__


Certain character classes can equip only certain weapons. If character tries to equip weapon which is meant for different class, invalid weapon message will be shown:

* __Mage__ - Staff, Wand

* __Ranger__ - Bow

* __Rogue__ - Dagger, Sword

* __Warrior__ - Axe, Hammer, Sword


### Armour

Like weapons, certain classes can equip only certain armour. If character tries to equip armour which is meant for different class, invalid armour message will be shown:

* __Mage__ - Cloth

* __Ranger__ - Leather, Mail

* __Rogue__ - Leather, Mail,

* __Warrior__ - Mail, Plate


## Technologies

The project is implemented with using following technologies:

- C#

## Maintainers

[Arttu Hartikainen (@arttuhar)](https://github.com/arttuhar)
