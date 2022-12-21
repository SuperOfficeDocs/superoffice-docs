<!-- markdownlint-disable-file MD041 -->
### Version

The UDefField table contains many versions of the same field. When you publish a new udef field layout, a new version is created.

The version that is currently used by the SOCRM client is stored in a user preference.

### OwnerTable

UDefField contains an ownerTable ID, which table is this user defined field for.

This field is an enum, unlike all other owner Table IDs in the database. It does not use the table ID listed in the dictionary.

* UDefContact = 7
* UDefPerson = 8
* UDefProject = 9
* UDefSale = 10
* UDefTemp = 11
* UDefAppointment = 12
* UDefDocument = 13

### FieldType

* 1 = Number
* 2 = Short text (up to 39 chars long)
* 3 = Long text  ( 40 to 200 chars long)
* 4 = Date (for dates 1970 - 2036, stored as Long value)
* 5 = Unlimited date (for dates 0001 - 9999, stored as string)
* 6 = Check box (stored as 0/1 in long field)
* 7 = Drop-down (listtableid determines which list. If listTableId = 136 then this is a user-defined list and all items are stored in the `UDList` table with `UDList.UDListDefinition_ID = udeffield.UDListDefinition_id`)
* 8 = Decimal  - actually double - that is 80 bits IEEE floating point.

### ProgId

The Prog-id can be used to tag fields that are used by your application with a known value, so that you can easily find the udef fields you need. This may also be set from the Admin client. Must be unique per version+ownertable
