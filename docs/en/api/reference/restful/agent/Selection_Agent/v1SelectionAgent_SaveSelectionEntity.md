---
title: POST Agents/Selection/SaveSelectionEntity
uid: v1SelectionAgent_SaveSelectionEntity
generated: true
content_type: reference
---

# POST Agents/Selection/SaveSelectionEntity

```http
POST /api/v1/Agents/Selection/SaveSelectionEntity
```

Updates the existing SelectionEntity or creates a new SelectionEntity if the id parameter is 0.








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

## Request Body: selectionEntity 

The SelectionEntity that is saved 

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
POST /api/v1/Agents/Selection/SaveSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Description": "Reactive multimedia alliance",
  "Postit": "ut",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 909,
  "IncludePerson": 884,
  "MemberCount": 99.99,
  "Name": "Beier LLC",
  "PostitTextId": 50,
  "CreatedDate": "2012-08-09T11:24:48.6095199+02:00",
  "SelectionId": 439,
  "SoundEx": "autem",
  "Source": 654,
  "TextId": 84,
  "UpdatedDate": "2002-09-06T11:24:48.6095199+02:00",
  "UpdatedCount": 523,
  "Visibility": 657,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 921,
  "TargetTableName": "Grady Group",
  "Completed": false,
  "LeftSelectionId": 323,
  "RightSelectionId": 940,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ondricka, Predovic and Marvin",
  "ShadowProviderName": "Prohaska, O'Connell and Sanford",
  "ChartKey": "ad",
  "LastLoaded": "2001-08-28T11:24:48.6095199+02:00",
  "LastLoadedBy": 651,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2012-10-06T11:24:48.6095199+02:00",
  "LastMembershipChangeBy": 341,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "omnis",
  "MemberTabHeading": "accusantium",
  "MailingsProviderName": "O'Connell-Tromp",
  "DashboardTileDefinitionId": 249,
  "VisibleFor": [
    {
      "VisibleId": 238,
      "Visibility": "All",
      "DisplayValue": "id"
    },
    {
      "VisibleId": 238,
      "Visibility": "All",
      "DisplayValue": "id"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Vision-oriented hybrid access",
  "Postit": "dignissimos",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 154,
  "IncludePerson": 649,
  "MemberCount": 99.99,
  "Name": "Harber-Dickens",
  "PostitTextId": 352,
  "CreatedDate": "2010-06-07T11:24:48.6095199+02:00",
  "SelectionId": 871,
  "SoundEx": "voluptas",
  "Source": 377,
  "TextId": 506,
  "UpdatedDate": "2023-02-16T11:24:48.6095199+01:00",
  "UpdatedCount": 887,
  "Visibility": 13,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 395,
  "TargetTableName": "Yost, Smitham and Reynolds",
  "Completed": false,
  "LeftSelectionId": 353,
  "RightSelectionId": 121,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Cartwright-Romaguera",
  "ShadowProviderName": "Rogahn, Weissnat and Douglas",
  "ChartKey": "vitae",
  "LastLoaded": "2021-12-08T11:24:48.6095199+01:00",
  "LastLoadedBy": 883,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2010-10-25T11:24:48.6095199+02:00",
  "LastMembershipChangeBy": 653,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "occaecati",
  "MemberTabHeading": "doloremque",
  "MailingsProviderName": "Tromp-Cremin",
  "DashboardTileDefinitionId": 788,
  "VisibleFor": [
    {
      "VisibleId": 455,
      "Visibility": "All",
      "DisplayValue": "debitis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    },
    {
      "VisibleId": 455,
      "Visibility": "All",
      "DisplayValue": "debitis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 600
    }
  }
}
```