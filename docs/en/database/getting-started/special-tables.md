---
title: Special tables
uid: special_tables
description: Special tables
author: {github-id}
keywords: database
topic: reference
# envir:
# client:
---

# Special tables in SuperOffice

Some of the tables in a SuperOffice database are very special.

## Dictionary tables

> [!NOTE]
> Dictionary tables are legacy tables that only exist in version 8.0 and earlier.

Firstly, in a SuperOffice database, there are **dictionary information tables** which contain a description of the database itself.

> [!CAUTION]
> These tables are not shown in the table listing. Nothing must be inserted into or deleted from this table! Any changes will cause SuperOffice to crash or corrupt the database.

### Dictionary information tables

Changes to these tables may make it impossible to log in or to repair the database.

Use the **SODictionarySDK** in the client Data API to add new tables to the dictionary information tables safely.

* ConceptualDatabase
* ConceptualTable
* ConceptualField
* PhysicalSchema
* PhysicalDatabase
* PhysicalTable
* PhysicalField
* Relationship
* DicIndex
* IndexField

### SuperOffice Reporter "dictionary"

> [!WARNING]
> **Do not change layout!** Modifying these tables may break the print-out function in SuperOffice.

Report definitions and layouts are stored in these tables.

* OLEField
* OLEFIeldText
* OLESubject
* OLESubjectText
* OLEView
* OLEViewText
* SORCriteria
* SORFCT
* SORField
* SOROperators
* SORPublish
* SORSection
* SORTemplate

## User-defined fields

The following tables contain user-defined fields

> [!CAUTION]
> **Do not change the layout!** Doing so will result in a corrupt database. Updates to the tables may cause loss of data.

* UDContactLarge
* UDContactSmall
* UDPersonLarge
* UDPersonSmall
* UDProjectLarge
* UDProjectSmall
* UDAppntLarge
* UDAppntSmall
* UDDocLarge
* UDDocSmall
* UDSaleLarge
* UDSaleSmall
* UDTempLarge
* UDTempSmall
* UdefField
* UdefFieldGL

## Licensing information

* [Company][11] contains the owner of the database. Tampering with this table will **cause SuperOffice login to be disabled**.
* [Associate][12] contains all users or employees in the owner Company. Any change to this table may result in **users being locked out of the database**.
* `Sequence` contains rows for generating unique IDs for each SuperOffice table. Nothing must be inserted into or deleted from this table.
* [ActiveUser][14] Any changes made to this table may result in **users being logged out automatically**.

## Travel tables

Containing information on users with the Travel option in SuperOffice.

> [!CAUTION]
> You should never change any of these tables!

* [Traveltransactionlog][15]
* [TravelCurrent][17]
* [TravelGeneratedDatabase][18]
* [TravelGeneratedTransaction][19]
* [TravelIDMapping][20]
* [Traveller][21]
* [Area][22]
* [AreaUserAssigment][23]
* [AreaUserInclusion][24]
* [Satellite][25]
* [OwnerContactLink][26]

## Country-specific information

* [Country][27] Defines address layout, phone prefixes, and other country-specific information.

## Calendar information

* [RedLetterDay][28] Contains calendar information regarding which days are to be red.

<!-- Referenced links -->
[11]: ../tables/company.md
[12]: ../tables/associate.md
[14]: ../tables/activeuser.md
[15]: ../tables/traveltransactionlog.md
[17]: ../tables/travelcurrent.md
[18]: ../tables/travelgenerateddatabase.md
[19]: ../tables/travelgeneratedtransaction.md
[20]: ../tables/travelidmapping.md
[21]: ../tables/traveller.md
[22]: ../tables/area.md
[23]: ../tables/areauserassignment.md
[24]: ../tables/areauserinclusion.md
[25]: ../tables/satellite.md
[26]: ../tables/ownercontactlink.md
[27]: ../tables/country.md
[28]: ../tables/redletterday.md
