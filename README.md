# Kye API
A public and free api made by me


### Minecraft API

##### Get Minecraft Profile from Username
(Returns UUID, Skin and Skin Type, Capes and name history)

```
GET https://kyeapi.herokuapp.com/minecraft/username/jeb_
```

Response

```json
{
  "timestamp": 1617308813070,
  "profileId": "853c80ef3c3749fdaa49938b674adae6",
  "profileName": "jeb_",
  "NameCount": 1,
  "textures": {
    "SKIN": {
      "url": "http://textures.minecraft.net/texture/7fd9ba42a7c81eeea22f1524271ae85a8e045ce0af5a6ae16c6406ae917e68b5"
    },
    "CAPE": {
      "url": "http://textures.minecraft.net/texture/5786fe99be377dfb6858859f926c4dbc995751e91cee373468c5fbf4865e7151"
    }
  },
  "names": [
    "jeb_"
  ]
}
```



##### Get Minecraft Profile from UUID
(Returns UUID, Skin and Skin Type, Capes and name history)


```
GET https://kyeapi.herokuapp.com/minecraft/id/853c80ef3c3749fdaa49938b674adae6
```

Response

```json
{
  "timestamp": 1617308813070,
  "profileId": "853c80ef3c3749fdaa49938b674adae6",
  "profileName": "jeb_",
  "NameCount": 1,
  "textures": {
    "SKIN": {
      "url": "http://textures.minecraft.net/texture/7fd9ba42a7c81eeea22f1524271ae85a8e045ce0af5a6ae16c6406ae917e68b5"
    },
    "CAPE": {
      "url": "http://textures.minecraft.net/texture/5786fe99be377dfb6858859f926c4dbc995751e91cee373468c5fbf4865e7151"
    }
  },
  "names": [
    "jeb_"
  ]
}
```
