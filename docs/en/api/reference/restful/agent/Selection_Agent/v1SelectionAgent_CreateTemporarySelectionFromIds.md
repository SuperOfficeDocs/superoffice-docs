---
title: POST Agents/Selection/CreateTemporarySelectionFromIds
uid: v1SelectionAgent_CreateTemporarySelectionFromIds
generated: true
---

# POST Agents/Selection/CreateTemporarySelectionFromIds

```http
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds
```

Creates a temporary selection with members from a collection of entity id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds?$select=name,department,category/id
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

## Request Body: request 

Ids, TargetTableNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Ids | Array |  |
| TargetTableNumber | Integer |  |

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

## Sample request

```http!
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Ids": [
    679,
    573
  ],
  "TargetTableNumber": 734
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Multi-channelled dedicated pricing structure",
  "Postit": "esse",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 813,
  "IncludePerson": 740,
  "MemberCount": 99.99,
  "Name": "Kuhn Inc and Sons",
  "PostitTextId": 136,
  "CreatedDate": "2002-10-31T10:17:56.0509411+01:00",
  "SelectionId": 255,
  "SoundEx": "et",
  "Source": 549,
  "TextId": 839,
  "UpdatedDate": "2007-08-30T10:17:56.0509411+02:00",
  "UpdatedCount": 558,
  "Visibility": 791,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 734,
  "TargetTableName": "Sawayn LLC",
  "Completed": false,
  "LeftSelectionId": 556,
  "RightSelectionId": 398,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Sipes, Glover and Morar",
  "ShadowProviderName": "Beer-Paucek",
  "ChartKey": "aspernatur",
  "LastLoaded": "2022-04-25T10:17:56.0509411+02:00",
  "LastLoadedBy": 654,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2010-04-16T10:17:56.0509411+02:00",
  "LastMembershipChangeBy": 348,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "doloribus",
  "MemberTabHeading": "omnis",
  "MailingsProviderName": "Rogahn, Ledner and Fay",
  "DashboardTileDefinitionId": 355,
  "VisibleFor": [
    {
      "VisibleId": 855,
      "Visibility": "All",
      "DisplayValue": "fuga",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    },
    {
      "VisibleId": 855,
      "Visibility": "All",
      "DisplayValue": "fuga",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 853
    }
  }
}
```