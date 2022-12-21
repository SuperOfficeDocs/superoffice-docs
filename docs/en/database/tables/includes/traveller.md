<!-- markdownlint-disable-file MD041 -->
### Database type

| Databasetype | ID | Comment |
|---|---|---|
| Sybase Anywhere | 1 | requires owned license from Sybase Anywhere. |
| C-tree | 2 | OBSOLETE! |
| MSDE | 3 | Microsoft MSDE (Microsoft Desktop Engine) |
| BuildIn | 4 | Replaced c-tree (v.6), actually Sybase which is locked to the SuperOffice application. |
| SQL Express | 5 | Microsoft SQL Express 2005- |

| encryptedComm | ID | Comment |
|---|---|---|
| None | 0 | Transmitted travel data are not encrypted (only ZIPed) |
| Serial |  1 | Transmitted travel data are encrypted using licence serial number as key |
| BF128 | 2 | Transmitted travel data are encrypted using a 128-bit key |
