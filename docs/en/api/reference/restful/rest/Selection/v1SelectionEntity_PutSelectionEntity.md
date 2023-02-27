---
title: PUT Selection/{id}
uid: v1SelectionEntity_PutSelectionEntity
---

# PUT Selection/{id}

```http
PUT /api/v1/Selection/{id}
```

Updates the existing SelectionEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SelectionEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Selection/{id}?$select=name,department,category/id
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

SelectionEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | SelectionEntity updated. |
| 412 | Update stopped because SelectionEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: SelectionEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Associate | Associate | Owner of the selection |
| CreatedBy | Associate | Who created the selection |
| UpdatedBy | Associate | Who last modified the selection |
| SelectionCategory | SelectionCategory | Selection category type (list item)  <para>Use MDO List name "searchCat" to get list items.</para> |
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Description": "Diverse contextually-based utilisation",
  "Postit": "sit",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 156,
  "IncludePerson": 247,
  "MemberCount": 408,
  "Name": "Lindgren-Kautzer",
  "PostitTextId": 890,
  "CreatedDate": "2021-01-04T14:19:10.7717284+01:00",
  "SelectionId": 908,
  "SoundEx": "perspiciatis",
  "Source": 674,
  "TextId": 743,
  "UpdatedDate": "2015-03-20T14:19:10.7717284+01:00",
  "UpdatedCount": 948,
  "Visibility": 560,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 582,
  "TargetTableName": "Douglas Group",
  "Completed": false,
  "LeftSelectionId": 305,
  "RightSelectionId": 389,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Heller-Pfeffer",
  "ShadowProviderName": "Schinner LLC",
  "ChartKey": "qui",
  "LastLoaded": "2013-12-21T14:19:10.7717284+01:00",
  "LastLoadedBy": 376,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2004-09-09T14:19:10.7717284+02:00",
  "LastMembershipChangeBy": 919,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "iure",
  "MemberTabHeading": "odit",
  "MailingsProviderName": "Koss, Lakin and Goldner",
  "DashboardTileDefinitionId": 52,
  "VisibleFor": [
    {
      "VisibleId": 384,
      "Visibility": "All",
      "DisplayValue": "quo"
    },
    {
      "VisibleId": 384,
      "Visibility": "All",
      "DisplayValue": "quo"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 SelectionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Advanced contextually-based website",
  "Postit": "culpa",
  "Associate": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "SelectionCategory": null,
  "GroupIdx": 957,
  "IncludePerson": 723,
  "MemberCount": 349,
  "Name": "Wolf Inc and Sons",
  "PostitTextId": 408,
  "CreatedDate": "2014-01-10T14:19:10.7717284+01:00",
  "SelectionId": 816,
  "SoundEx": "modi",
  "Source": 75,
  "TextId": 481,
  "UpdatedDate": "1995-10-30T14:19:10.7717284+01:00",
  "UpdatedCount": 481,
  "Visibility": 449,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 172,
  "TargetTableName": "O'Kon, Lubowitz and Daugherty",
  "Completed": true,
  "LeftSelectionId": 227,
  "RightSelectionId": 780,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Stark-Lockman",
  "ShadowProviderName": "McKenzie, Heathcote and Hammes",
  "ChartKey": "ut",
  "LastLoaded": "1996-07-08T14:19:10.7717284+02:00",
  "LastLoadedBy": 866,
  "LastLoadedByAssociate": null,
  "LastMembershipChange": "2001-06-28T14:19:10.7717284+02:00",
  "LastMembershipChangeBy": 803,
  "LastMembershipChangeByAssociate": null,
  "MainHeading": "dolorum",
  "MemberTabHeading": "modi",
  "MailingsProviderName": "Stamm LLC",
  "DashboardTileDefinitionId": 352,
  "VisibleFor": [
    {
      "VisibleId": 127,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    },
    {
      "VisibleId": 127,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 1000
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```