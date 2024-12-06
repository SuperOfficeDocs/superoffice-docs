---
title: POST Agents/Selection/CreateContactSelectionFromShadowSelection
uid: v1SelectionAgent_CreateContactSelectionFromShadowSelection
generated: true
---

# POST Agents/Selection/CreateContactSelectionFromShadowSelection

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
```

Creates a new contact selection based on contact selection members from an existing shadow sale, appointment, project or document selection.


The new selection will always be static even if the original selection is dynamic.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection?$select=name,department,category/id
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

SelectionId, Name 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | Integer |  |
| Name | String |  |

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
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 831,
  "Name": "Bernhard Inc and Sons"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Decentralized zero tolerance contingency",
  "Postit": "distinctio",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 850,
  "IncludePerson": 847,
  "MemberCount": 99.99,
  "Name": "Konopelski, Herzog and Mosciski",
  "PostitTextId": 826,
  "CreatedDate": "2019-03-08T10:17:56.0509411+01:00",
  "SelectionId": 605,
  "SoundEx": "ratione",
  "Source": 382,
  "TextId": 72,
  "UpdatedDate": "2023-08-29T10:17:56.0509411+02:00",
  "UpdatedCount": 703,
  "Visibility": 853,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 824,
  "TargetTableName": "Skiles LLC",
  "Completed": true,
  "LeftSelectionId": 618,
  "RightSelectionId": 557,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Watsica-Veum",
  "ShadowProviderName": "Kilback, Kassulke and Batz",
  "ChartKey": "cumque",
  "LastLoaded": "2020-05-07T10:17:56.0509411+02:00",
  "LastLoadedBy": 949,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2004-07-05T10:17:56.0509411+02:00",
  "LastMembershipChangeBy": 819,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "qui",
  "MemberTabHeading": "iste",
  "MailingsProviderName": "Klein, O'Conner and Hansen",
  "DashboardTileDefinitionId": 887,
  "VisibleFor": [
    {
      "VisibleId": 233,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    },
    {
      "VisibleId": 233,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 967
    }
  }
}
```