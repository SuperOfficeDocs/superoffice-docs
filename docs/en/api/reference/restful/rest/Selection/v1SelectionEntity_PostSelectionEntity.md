---
title: POST Selection
uid: v1SelectionEntity_PostSelectionEntity
generated: true
---

# POST Selection

```http
POST /api/v1/Selection
```

Creates a new SelectionEntity


Calls the Selection agent service SaveSelectionEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Selection?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: newEntity 

The SelectionEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Associate | Associate | Owner of the selection |
| CreatedBy | Associate | Who created the selection |
| UpdatedBy | Associate | Who last modified the selection |
| SelectionCategory | SelectionCategory | Selection category type (list item)  <para>Use MDO List name "searchCat" to get list items.</para> |
| GroupIdx | Integer | Original primary user group of associate |
| IncludePerson | Integer | 0 = Include first person, 1 = Include all persons, 2 = Include no persons |
| MemberCount | Integer | How many selectionmembers (for progress bar calculations) - estimate, -1 (or 4294967295) means we don't know |
| Name | String | Name of selection, freetext indexed |
| PostitTextId | Integer | Postit text record id. |
| CreatedDate | String | Registered when  in UTC. |
| SelectionId | Integer | Primary key |
| SoundEx | String | What the name sounds like, for duplicate detection |
| Source | Integer | How did we get this selection? For future integration needs |
| TextId | Integer | Description text record id |
| UpdatedDate | String | Last updated when  in UTC. |
| UpdatedCount | Integer | Number of updates made to this record |
| Visibility | Integer | Obsolete, but still maintained denormalization of visiblefor |
| SelectionType | String | Static/Dynamic/Combined? |
| CompanyUnique | Boolean | Filter out duplicate members based on company? |
| TargetTableNumber | Integer | TargetTableNumber defines the type of selection members this selection contains. e.g. the table number for 'contact', or 'project' or 'sale' |
| TargetTableName | String | TargetTableName contains the name of the table in lowercase. defines the type of selection members this selection contains. e.g. 'contact', or 'project' or 'sale' |
| Completed | Boolean | The Completed state. |
| LeftSelectionId | Integer | LeftSelectionId is used in combination with RightSelectionId and CombinationType to define an union of two selections when SelectionType=Combined. |
| RightSelectionId | Integer | RightSelectionId  is used in combination with LeftSelectionId and CombinationType to define an union of two selections when SelectionType=Combined. |
| SelectionUnionType | String | How to combine the two selections when SelectionType = Combined. |
| MainProviderName | String | The name of the Archive Provider that will deliver the content of the archive - the actual entity rows |
| ShadowProviderName | String | The name, if relevant, of the Archive Provider that will deliver the Shadow rows: contact/person rows related to the actual entity. Can be blank, indicating that there is no shadow archive |
| ChartKey | String | ID/key of the last-used chart tile on this selection |
| LastLoaded | String | The date/time this selection was last loaded (selectionentity fetched) |
| LastLoadedBy | Integer | Who last loaded this selection |
| LastLoadedByAssociate | Associate | Associate that last looked at the selection members; only date (not time) is valid |
| LastMembershipChange | String | The date/time the membership the selection last changed. Dynamic: change of criteria; Static: add/remove members; Combined: change of algorithm |
| LastMembershipChangeBy | Integer | Who last changed the membership |
| LastMembershipChangeByAssociate | Associate | Associate that last changed the selection membership (static members, dynamic criteria, combined parameters); only date (not time) is valid |
| MainHeading | String | 'Static selection of Companies', or whatever else is appropriate, made by combining text resources for the type and the entity (plural form); this string will contain resource references |
| MemberTabHeading | String | 'Companies', or whatever else is appropriate - the plural form of the entity name; this string will contain resource references |
| MailingsProviderName | String | The name of the provider for the Mailings tab, if relevant; this string will contain resource references |
| DashboardTileDefinitionId | Integer | The associated tile definition |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SelectionEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Associate | Associate | Owner of the selection |
| CreatedBy | Associate | Who created the selection |
| UpdatedBy | Associate | Who last modified the selection |
| SelectionCategory | SelectionCategory | Selection category type (list item)  Use MDO List name "searchCat" to get list items. |
| GroupIdx | int32 | Original primary user group of associate |
| IncludePerson | int32 | 0 = Include first person, 1 = Include all persons, 2 = Include no persons |
| MemberCount | int64 | How many selectionmembers (for progress bar calculations) - estimate, -1 (or 4294967295) means we don't know |
| Name | string | Name of selection, freetext indexed |
| PostitTextId | int32 | Postit text record id. |
| CreatedDate | date-time | Registered when  in UTC. |
| SelectionId | int32 | Primary key |
| SoundEx | string | What the name sounds like, for duplicate detection |
| Source | int32 | How did we get this selection? For future integration needs |
| TextId | int32 | Description text record id |
| UpdatedDate | date-time | Last updated when  in UTC. |
| UpdatedCount | int32 | Number of updates made to this record |
| Visibility | int32 | Obsolete, but still maintained denormalization of visiblefor |
| SelectionType | string | Static/Dynamic/Combined? |
| CompanyUnique | bool | Filter out duplicate members based on company? |
| TargetTableNumber | int32 | TargetTableNumber defines the type of selection members this selection contains. e.g. the table number for 'contact', or 'project' or 'sale' |
| TargetTableName | string | TargetTableName contains the name of the table in lowercase. defines the type of selection members this selection contains. e.g. 'contact', or 'project' or 'sale' |
| Completed | bool | The Completed state. |
| LeftSelectionId | int32 | LeftSelectionId is used in combination with RightSelectionId and CombinationType to define an union of two selections when SelectionType=Combined. |
| RightSelectionId | int32 | RightSelectionId  is used in combination with LeftSelectionId and CombinationType to define an union of two selections when SelectionType=Combined. |
| SelectionUnionType | string | How to combine the two selections when SelectionType = Combined. |
| MainProviderName | string | The name of the Archive Provider that will deliver the content of the archive - the actual entity rows |
| ShadowProviderName | string | The name, if relevant, of the Archive Provider that will deliver the Shadow rows: contact/person rows related to the actual entity. Can be blank, indicating that there is no shadow archive |
| ChartKey | string | ID/key of the last-used chart tile on this selection |
| LastLoaded | date-time | The date/time this selection was last loaded (selectionentity fetched) |
| LastLoadedBy | int32 | Who last loaded this selection |
| LastLoadedByAssociate | Associate | Associate that last looked at the selection members; only date (not time) is valid |
| LastMembershipChange | date-time | The date/time the membership the selection last changed. Dynamic: change of criteria; Static: add/remove members; Combined: change of algorithm |
| LastMembershipChangeBy | int32 | Who last changed the membership |
| LastMembershipChangeByAssociate | Associate | Associate that last changed the selection membership (static members, dynamic criteria, combined parameters); only date (not time) is valid |
| MainHeading | string | 'Static selection of Companies', or whatever else is appropriate, made by combining text resources for the type and the entity (plural form); this string will contain resource references |
| MemberTabHeading | string | 'Companies', or whatever else is appropriate - the plural form of the entity name; this string will contain resource references |
| MailingsProviderName | string | The name of the provider for the Mailings tab, if relevant; this string will contain resource references |
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Selection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Description": "Extended dynamic moratorium",
  "Postit": "itaque",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 763,
  "IncludePerson": 727,
  "MemberCount": 99.99,
  "Name": "Considine LLC",
  "PostitTextId": 38,
  "CreatedDate": "2005-01-21T13:14:09.1653933+01:00",
  "SelectionId": 127,
  "SoundEx": "ea",
  "Source": 798,
  "TextId": 105,
  "UpdatedDate": "2008-11-17T13:14:09.1653933+01:00",
  "UpdatedCount": 763,
  "Visibility": 12,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 186,
  "TargetTableName": "Kessler-Gulgowski",
  "Completed": true,
  "LeftSelectionId": 532,
  "RightSelectionId": 65,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Hackett, Dibbert and Ryan",
  "ShadowProviderName": "Mayert Inc and Sons",
  "ChartKey": "placeat",
  "LastLoaded": "2012-06-13T13:14:09.1653933+02:00",
  "LastLoadedBy": 439,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2010-02-10T13:14:09.1653933+01:00",
  "LastMembershipChangeBy": 895,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "necessitatibus",
  "MemberTabHeading": "aut",
  "MailingsProviderName": "Feest, Stanton and Wintheiser",
  "DashboardTileDefinitionId": 669,
  "VisibleFor": [
    {
      "VisibleId": 458,
      "Visibility": "All",
      "DisplayValue": "facilis"
    },
    {
      "VisibleId": 458,
      "Visibility": "All",
      "DisplayValue": "facilis"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Multi-tiered even-keeled open architecture",
  "Postit": "nostrum",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 605,
  "IncludePerson": 733,
  "MemberCount": 99.99,
  "Name": "Cartwright-Klocko",
  "PostitTextId": 980,
  "CreatedDate": "2014-11-02T13:14:09.1653933+01:00",
  "SelectionId": 513,
  "SoundEx": "porro",
  "Source": 778,
  "TextId": 998,
  "UpdatedDate": "2017-04-09T13:14:09.1653933+02:00",
  "UpdatedCount": 96,
  "Visibility": 195,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 998,
  "TargetTableName": "Braun-Denesik",
  "Completed": true,
  "LeftSelectionId": 822,
  "RightSelectionId": 784,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Wuckert-Thompson",
  "ShadowProviderName": "Bahringer Group",
  "ChartKey": "praesentium",
  "LastLoaded": "2022-07-14T13:14:09.1653933+02:00",
  "LastLoadedBy": 713,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2018-01-09T13:14:09.1653933+01:00",
  "LastMembershipChangeBy": 104,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "voluptates",
  "MemberTabHeading": "autem",
  "MailingsProviderName": "Cruickshank, Dicki and Purdy",
  "DashboardTileDefinitionId": 376,
  "VisibleFor": [
    {
      "VisibleId": 413,
      "Visibility": "All",
      "DisplayValue": "ut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    },
    {
      "VisibleId": 413,
      "Visibility": "All",
      "DisplayValue": "ut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 731
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```