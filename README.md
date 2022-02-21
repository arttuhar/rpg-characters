# rpg-characters

![GitHub repo size](https://img.shields.io/github/repo-size/arttuhar/rpg-characters)

## Table of Contents

- [General Information](#general-information)
- [Technologies](#technologies)
- [Installation and Usage](#installation-and-usage)
- [Maintainers](#maintainers)

## General Information

Idea of project is to imitate creation of RPG character. Currently project has four different hero classes where to choose:

- Mage
- Ranger
- Rogue
- Warrior

Heroes in the game have three different primary attributes: strength, dexterity and intelligence. Primary attribute points are set differently between each class. As hero levels up their primary attributes increases as well. Primary attributes at level 1 and gained attributes after level up can be found tables below:

__Mage__

At level 1:

Strength = 1, Dexterity = 1, Intelligence = 8

Level up:

Strenght = 1, Dexterity = 1, Intelligence = 5

Each point of Intelligence increases Mage class damage by 1%.

__Ranger__

At level 1:

Strength = 1, Dexterity = 7, Intelligence = 1

Level up:

Strenght = 1, Dexterity = 5, Intelligence = 1

Each point of Dexterity increases Ranger class damage by 1%.

__Rogue__

At level 1:

Strength = 2, Dexterity = 6, Intelligence = 1

Level up:

Strenght = 1, Dexterity = 4, Intelligence = 1

Each point of Dexterity increases Rogue class damage by 1%.

__Warrior__

At level 1:

Strength = 5, Dexterity = 2, Intelligence = 1

Level up:

Strenght = 3, Dexterity = 2, Intelligence = 1

Each point of Strength increases Warrior class damage by 1%.

Game also contains several different items which can boost heroes attributes and therefore possible damage hero can deal. First of all hero can equip weapon which has two different attributes Damage and Attack speed. With these attributes Damage per second can be calculated (Damage * Attackspeed = Damage per second). By equipping an armor, previously introduced primary attributes will increase. Also certain items can be equipped to certain item slots.

Weapon types (possible to equip on SLOT_WEAPON):

- Axe
- Bow
- Dagger
- Hammer
- Staff
- Sword
- Wand

Armor types (possible to equip on SLOT_HEAD, SLOT_BODY, SLOT_LEGS):

- Cloth
- Leather
- Mail
- Plate

Only certain hero class can equip certain weapon types and armor types. If hero trying to equip weapon which is meant for different class, Invalid weapon exception will be thrown. Also if hero trying to equip armor whis is meant for different class, Invalid armor exception will be thrown. 

__Mage__

Weapon types = Staff, Wand

Armor types = Cloth

__Ranger__

Weapon types = Bow

Armor types = Leather, Mail

__Rogue__

Weapon types = Dagger, Sword

Armor types = Leather, Mail

__Warrior__

Weapon types = Axe, Hammer, Sword

Armor types = Mail, Plate

Every hero has base primary attributes at beginning. After equipping armor, total primary attributs can be calculated by adding base primary attributes and armor attributes together. Total primary attributes will be used to calculate possible damage hero can deal:

Total primary attributes:

total primary attributes = base primary attributes + armor attributes

Damage:

damage = damage per second * (1 + total primary attribute / 100)


## Technologies

The project is implemented with using following technologies:

- C#
- .NET 5.0
- xUNit

## Installation and Usage

__NOTE:__ You will need *Visual Studio* to run application or tests.

1. Clone down this repository
```sh
git clone https://github.com/arttuhar/rpg-characters.git
```

2. Open project with Visual studio

To run application:

1. Click *Play* button from top bar

To run tests:

1. Navigate to *rpg-charactersTests* folder

2. Open *HeroTests.cs* or *ItemTests.cs* file

3. Right click method name and select option *Run Test(s)*


## Maintainers

[Arttu Hartikainen (@arttuhar)](https://github.com/arttuhar)
