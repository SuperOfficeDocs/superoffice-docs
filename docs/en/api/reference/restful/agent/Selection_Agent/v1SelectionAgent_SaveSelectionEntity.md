---
title: POST Agents/Selection/SaveSelectionEntity
uid: v1SelectionAgent_SaveSelectionEntity
generated: true
---

# POST Agents/Selection/SaveSelectionEntity

```http
POST /api/v1/Agents/Selection/SaveSelectionEntity
```

Updates the existing SelectionEntity or creates a new SelectionEntity if the id parameter is empty








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

## Request Body: entity 

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

### Response body: SelectionEntity

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
| MemberCount | int32 | How many selectionmembers (for progress bar calculations) - estimate, -1 (or 4294967295) means we don't know |
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

## Sample request

```http!
POST /api/v1/Agents/Selection/SaveSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Description": "Synergized dedicated flexibility",
  "Postit": "ducimus",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 386,
  "IncludePerson": 104,
  "MemberCount": 868,
  "Name": "Johns Inc and Sons",
  "PostitTextId": 211,
  "CreatedDate": "2019-02-05T12:19:46.2264184+01:00",
  "SelectionId": 544,
  "SoundEx": "libero",
  "Source": 516,
  "TextId": 466,
  "UpdatedDate": "2019-11-07T12:19:46.2420414+01:00",
  "UpdatedCount": 492,
  "Visibility": 304,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 457,
  "TargetTableName": "Kihn Inc and Sons",
  "Completed": false,
  "LeftSelectionId": 218,
  "RightSelectionId": 352,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Konopelski, Kuvalis and Windler",
  "ShadowProviderName": "Cruickshank-Oberbrunner",
  "ChartKey": "nam",
  "LastLoaded": "2001-09-22T12:19:46.2420414+02:00",
  "LastLoadedBy": 57,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2004-06-12T12:19:46.2420414+02:00",
  "LastMembershipChangeBy": 68,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "libero",
  "MemberTabHeading": "sapiente",
  "MailingsProviderName": "Mills-Padberg",
  "DashboardTileDefinitionId": 44,
  "VisibleFor": [
    {
      "VisibleId": 669,
      "Visibility": "All",
      "DisplayValue": "ut"
    },
    {
      "VisibleId": 669,
      "Visibility": "All",
      "DisplayValue": "ut"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Digitized user-facing time-frame",
  "Postit": "sed",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 58,
  "IncludePerson": 552,
  "MemberCount": 9,
  "Name": "Kertzmann-Bruen",
  "PostitTextId": 903,
  "CreatedDate": "2003-03-08T12:19:46.2420414+01:00",
  "SelectionId": 13,
  "SoundEx": "rem",
  "Source": 318,
  "TextId": 692,
  "UpdatedDate": "2015-11-06T12:19:46.2420414+01:00",
  "UpdatedCount": 179,
  "Visibility": 816,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 930,
  "TargetTableName": "Homenick-Haag",
  "Completed": false,
  "LeftSelectionId": 694,
  "RightSelectionId": 499,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Hauck-Boyle",
  "ShadowProviderName": "Crist, Hane and Pouros",
  "ChartKey": "temporibus",
  "LastLoaded": "2023-11-28T12:19:46.2420414+01:00",
  "LastLoadedBy": 439,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2004-04-30T12:19:46.2420414+02:00",
  "LastMembershipChangeBy": 512,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "qui",
  "MemberTabHeading": "atque",
  "MailingsProviderName": "Huel, Jenkins and Volkman",
  "DashboardTileDefinitionId": 61,
  "VisibleFor": [
    {
      "VisibleId": 883,
      "Visibility": "All",
      "DisplayValue": "officiis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    },
    {
      "VisibleId": 883,
      "Visibility": "All",
      "DisplayValue": "officiis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 390
    }
  }
}
```