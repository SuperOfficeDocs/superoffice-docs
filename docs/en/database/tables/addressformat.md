---
uid: table-AddressFormat
title: AddressFormat table
description: Address formats for GUI and labels. See more information; Addressformat on http;//techdoc.superoffice.com
so.generated: true
keywords: database table AddressFormat
so.topic: reference
so.envir: onsite, online
---

# AddressFormat Table (57)

Address formats for GUI and labels. See more information; Addressformat on http;//techdoc.superoffice.com

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|addressformat\_id|Primary key|PK| |
|name|Name of address format (descriptive, multi-language)|String(239)| |
|layout\_id|Corresponds to Country.layout_id|ShortId| |
|atype\_idx|Corresponds to Address.atype_idx|UShort| |
|address1\_line|Line no. for address1 field, 0 if not shown|UShort| |
|address1\_subpos|Position within line for address1 field|UShort| |
|address1\_leadtext|Lead text resource ID for address1 field, 0 = no leadtext|Id| |
|address1\_zip|Zip lookup functionality for address1 field: 0 = none, 1 = source, 2 = target|UShort| |
|address1\_length|Field length in characters for address1 field|UShort| |
|address1\_flags|Field flags for address1 field: See EAddrFormatFlags enum|UShort| |
|address1\_mask|Formatting mask for address1 field|String(9)| |
|address2\_line|Line no. for address2 field, 0 if not shown|UShort| |
|address2\_subpos|Position within line for address2 field|UShort| |
|address2\_leadtext|Lead text resource ID for address2 field, 0 = no leadtext|Id| |
|address2\_zip|Zip lookup functionality for address2 field: 0 = none, 1 = source, 2 = target|UShort| |
|address2\_length|Field length in characters for address2 field|UShort| |
|address2\_flags|Field flags for address2 field: See EAddrFormatFlags enum|UShort| |
|address2\_mask|Formatting mask for address2 field|String(9)| |
|address3\_line|Line no. for address3 field, 0 if not shown|UShort| |
|address3\_subpos|Position within line for address3 field|UShort| |
|address3\_leadtext|Lead text resource ID for address3 field, 0 = no leadtext|Id| |
|address3\_zip|Zip lookup functionality for address3 field: 0 = none, 1 = source, 2 = target|UShort| |
|address3\_length|Field length in characters for address3 field|UShort| |
|address3\_flags|Field flags for address3 field: See EAddrFormatFlags enum|UShort| |
|address3\_mask|Formatting mask for address3 field|String(9)| |
|city\_line|Line no. for city field, 0 if not shown|UShort| |
|city\_subpos|Position within line for city field|UShort| |
|city\_leadtext|Lead text resource ID for city field, 0 = no leadtext|Id| |
|city\_zip|Zip lookup functionality for city field: 0 = none, 1 = source, 2 = target|UShort| |
|city\_length|Field length in characters for city field|UShort| |
|city\_flags|Field flags for city field: See EAddrFormatFlags enum|UShort| |
|city\_mask|Formatting mask for city field|String(9)| |
|county\_line|Line no. for county field, 0 if not shown|UShort| |
|county\_subpos|Position within line for county field|UShort| |
|county\_leadtext|Lead text resource ID for county field, 0 = no leadtext|Id| |
|county\_zip|Zip lookup functionality for county field: 0 = none, 1 = source, 2 = target|UShort| |
|county\_length|Field length in characters for county field|UShort| |
|county\_flags|Field flags for county field: See EAddrFormatFlags enum|UShort| |
|county\_mask|Formatting mask for county field|String(9)| |
|state\_line|Line no. for state field, 0 if not shown|UShort| |
|state\_subpos|Position within line for state field|UShort| |
|state\_leadtext|Lead text resource ID for state field, 0 = no leadtext|Id| |
|state\_zip|Zip lookup functionality for state field: 0 = none, 1 = source, 2 = target|UShort| |
|state\_length|Field length in characters for state field|UShort| |
|state\_flags|Field flags for state field: See EAddrFormatFlags enum|UShort| |
|state\_mask|Formatting mask for state field|String(9)| |
|zip\_line|Line no. for zip field, 0 if not shown|UShort| |
|zip\_subpos|Position within line for zip field|UShort| |
|zip\_leadtext|Lead text resource ID for zip field, 0 = no leadtext|Id| |
|zip\_zip|Zip lookup functionality for zip field: 0 = none, 1 = source, 2 = target|UShort| |
|zip\_length|Field length in characters for zip field|UShort| |
|zip\_flags|Field flags for zip field: See EAddrFormatFlags enum|UShort| |
|zip\_mask|Formatting mask for zip field|String(9)| |
|extraFlags|OBSOLETE: Extra flags for tag substitution mechanism, see idb.h. This function has been taken over by the tag-based formatting, controlled by the labelLayout and labelLayout2 fields|UInt| |
|labelLayout|Format specification for labels, uses standard tags|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|labelLayout2|Part two of format specification, concatenated with part one above|String(254)|&#x25CF;|
|isBuiltIn|Is this row populated by SuperOffice?|Bool|&#x25CF;|


![AddressFormat table relationship diagram](./media/AddressFormat.png)

[!include[details](./includes/addressformat.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|addressformat\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

