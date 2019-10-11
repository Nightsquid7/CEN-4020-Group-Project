## Tier 1: Minimal Basic Construct
* **Map -** 6 rooms, doors {}
* **Character Class**
  - **Class Attributes:** (necessary & general) 
    * health
    * defense
    * weapon
    * movements
    
  - **Player - 1** 
    * Player Class Attributes: (specific to)
      1. health  
         - variables: health
         - functions: setHealth(),getHealth()
      2. defenses? if we doing objects could be armor or shield, if not could be a stat that decides how much your health goes down for hit point
      3. weapon - gun
      4. movements specific to player
    
  - **Enemy - 1** 
    * Enemy Class Attributes: (specific to) 
      - same as player? think depends if we code it or do on unity or other framework
        * same base class?
        * What should this class be named? ..npc? enemy seems ok
        
* **Weapon -** gun (functions) 
   - Weapon Attributes:   
     * damage  
      - variables: damage, modifier/random?
      - functions: getDamage()
      - ammo?
        
* **Menu -** start game, score,  exit, etc {}
* **Storyline -** intro, goals  {}
* **Collection -** treasure {}
* **Music -** background, gun sound {} hit/health going down sound?
* **maybe we need to add a general object class to derive other objects from (assume we coding it and not using gui) like potions to restore health? armor? weapons ? we could put objects in tier 2 or 3 though
