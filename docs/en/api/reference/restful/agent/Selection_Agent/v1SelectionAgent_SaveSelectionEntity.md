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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Description": "Diverse value-added productivity",
  "Postit": "ipsam",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 955,
  "IncludePerson": 154,
  "MemberCount": 489,
  "Name": "Stokes Inc and Sons",
  "PostitTextId": 707,
  "CreatedDate": "2008-02-23T11:16:09.6947013+01:00",
  "SelectionId": 972,
  "SoundEx": "ut",
  "Source": 534,
  "TextId": 252,
  "UpdatedDate": "2021-01-18T11:16:09.6947013+01:00",
  "UpdatedCount": 401,
  "Visibility": 497,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 233,
  "TargetTableName": "Goyette, Padberg and Schaden",
  "Completed": true,
  "LeftSelectionId": 410,
  "RightSelectionId": 926,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Satterfield LLC",
  "ShadowProviderName": "Kuhn Group",
  "ChartKey": "quo",
  "LastLoaded": "2011-07-13T11:16:09.6947013+02:00",
  "LastLoadedBy": 849,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2017-01-31T11:16:09.6947013+01:00",
  "LastMembershipChangeBy": 856,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "consequatur",
  "MemberTabHeading": "in",
  "MailingsProviderName": "Greenfelder, Watsica and Ritchie",
  "DashboardTileDefinitionId": 889,
  "VisibleFor": [
    {
      "VisibleId": 68,
      "Visibility": "All",
      "DisplayValue": "dolor"
    },
    {
      "VisibleId": 68,
      "Visibility": "All",
      "DisplayValue": "dolor"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Organized non-volatile methodology",
  "Postit": "alias",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 550,
  "IncludePerson": 709,
  "MemberCount": 735,
  "Name": "Wilderman LLC",
  "PostitTextId": 945,
  "CreatedDate": "2012-12-03T11:16:09.7103639+01:00",
  "SelectionId": 693,
  "SoundEx": "quis",
  "Source": 59,
  "TextId": 153,
  "UpdatedDate": "2017-01-16T11:16:09.7103639+01:00",
  "UpdatedCount": 403,
  "Visibility": 893,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 63,
  "TargetTableName": "Dickens-Luettgen",
  "Completed": false,
  "LeftSelectionId": 502,
  "RightSelectionId": 281,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Nader-Runolfsdottir",
  "ShadowProviderName": "Hegmann, Beahan and Morissette",
  "ChartKey": "autem",
  "LastLoaded": "2024-04-18T11:16:09.7103639+02:00",
  "LastLoadedBy": 358,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2001-03-04T11:16:09.7103639+01:00",
  "LastMembershipChangeBy": 138,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "aut",
  "MemberTabHeading": "quidem",
  "MailingsProviderName": "Turner, Hirthe and Beahan",
  "DashboardTileDefinitionId": 34,
  "VisibleFor": [
    {
      "VisibleId": 722,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    },
    {
      "VisibleId": 722,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 169
    }
  }
}
```