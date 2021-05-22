# Item system

This folder contains scripts for the inventory system.

## inventory class

save/load items, store items, inventory checks, add/remove item, equip armer/weapon, equipment checks.

main functions: 

backpack:

- save/load inventory, check/access item list, add/remove item
- equipment (armor, main/second hand, jewelries):
- save/load
- check/access equipment list
- equip/unequip

Items have the amount property, meaning a single item object can represent a stack of items. changing/splitting the amount field should be done by the inventory class.

## item class

Item is the item in backpack, shop, and inventory. Any other functions such as weapon or potion effects must be implemented somewhere else. Those class can be registered to some manager and refer to the item id, so that when item is used or equiped, the manager can instantiate related classes.

item properties: name, type, rarity, description, story, icon

compare methods:
- isItem: compare only item id
- equals: compare all properties

item types:

- weapon
- food
- material
- equipment
- special

item can be stacked.

all item data are stored in a separate file. the Item class only store the ID, count, and any custom tags. Default values will be searched from database when needed. Custom tags can be used to overwrite default values, like different name, durability, random properties, etc.

Item ID is the only item identifier. Item with same ID will be technically the same, but can have different value.

All items are instance of the Item class.

## Item related classes

some item may represent an weapon or potion, who have their own classes.

Those class should all inherite some base class, such as weapon base. Then when their manager systems are initialized, the system will use reflection to search all sub class of that base, and register them in a list. Then when an item is used or equipped, the item will be passed to that manager system and that system will search the list for the item ID and instantiate corresponding class.
