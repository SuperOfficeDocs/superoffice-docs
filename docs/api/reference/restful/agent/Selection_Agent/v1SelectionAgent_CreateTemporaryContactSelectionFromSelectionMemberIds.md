---
title: POST Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds
id: v1SelectionAgent_CreateTemporaryContactSelectionFromSelectionMemberIds
---

# POST Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds
```

Creates a temporary selection with members from a collection of selectionmember id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds?$select=name,department,category/id
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

SelectionId, SelectionMemberIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| SelectionMemberIds | array |  |


## Response: object

Carrier object for SelectionEntity.
Services for the SelectionEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISelectionAgent">Selection Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Associate |  | Owner of the selection |
| CreatedBy |  | Who created the selection |
| UpdatedBy |  | Who last modified the selection |
| SelectionCategory |  | Selection category type (list item)  <para>Use MDO List name "searchCat" to get list items.</para> |
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
| LastLoadedByAssociate |  | Associate that last looked at the selection members; only date (not time) is valid |
| LastMembershipChange | date-time | The date/time the membership the selection last changed. Dynamic: change of criteria; Static: add/remove members; Combined: change of algorithm |
| LastMembershipChangeBy | int32 | Who last changed the membership |
| LastMembershipChangeByAssociate |  | Associate that last changed the selection membership (static members, dynamic criteria, combined parameters); only date (not time) is valid |
| MainHeading | string | 'Static selection of Companies', or whatever else is appropriate, made by combining text resources for the type and the entity (plural form); this string will contain resource references |
| MemberTabHeading | string | 'Companies', or whatever else is appropriate - the plural form of the entity name; this string will contain resource references |
| MailingsProviderName | string | The name of the provider for the Mailings tab, if relevant; this string will contain resource references |
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 14,
  "SelectionMemberIds": [
    252,
    485
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Organized heuristic ability",
  "Postit": "facere",
  "Associate": {
    "AssociateId": 607,
    "Name": "Klocko, Morissette and Shanahan",
    "PersonId": 148,
    "Rank": 21,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 244,
    "FullName": "Andreane Dare PhD",
    "FormalName": "Fritsch Group",
    "Deleted": true,
    "EjUserId": 470,
    "UserName": "Berge-Greenfelder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 365
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 122,
    "Name": "Barton LLC",
    "PersonId": 456,
    "Rank": 635,
    "Tooltip": "possimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 335,
    "FullName": "Kenya Hermiston",
    "FormalName": "Cummerata LLC",
    "Deleted": false,
    "EjUserId": 735,
    "UserName": "Abernathy, Kessler and McKenzie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 562
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 392,
    "Name": "Lindgren LLC",
    "PersonId": 30,
    "Rank": 403,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 642,
    "FullName": "Ena Schaefer",
    "FormalName": "Wisoky-Johnson",
    "Deleted": false,
    "EjUserId": 939,
    "UserName": "Fadel, Boehm and Klein",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 698
      }
    }
  },
  "SelectionCategory": {
    "Id": 530,
    "Value": "et",
    "Tooltip": "aliquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 245
      }
    }
  },
  "GroupIdx": 954,
  "IncludePerson": 214,
  "MemberCount": 322,
  "Name": "Waters LLC",
  "PostitTextId": 577,
  "CreatedDate": "2018-10-11T18:28:50.262442+02:00",
  "SelectionId": 527,
  "SoundEx": "in",
  "Source": 948,
  "TextId": 82,
  "UpdatedDate": "2020-11-29T18:28:50.262442+01:00",
  "UpdatedCount": 23,
  "Visibility": 665,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 436,
  "TargetTableName": "Weber-Pollich",
  "Completed": true,
  "LeftSelectionId": 246,
  "RightSelectionId": 334,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Stokes-Hills",
  "ShadowProviderName": "Cruickshank-Keeling",
  "ChartKey": "commodi",
  "LastLoaded": "2021-07-05T18:28:50.262442+02:00",
  "LastLoadedBy": 210,
  "LastLoadedByAssociate": {
    "AssociateId": 608,
    "Name": "Yost-Swaniawski",
    "PersonId": 510,
    "Rank": 343,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 752,
    "FullName": "Khalil Tromp",
    "FormalName": "Dach, Gutkowski and Kirlin",
    "Deleted": true,
    "EjUserId": 310,
    "UserName": "Brakus Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 717
      }
    }
  },
  "LastMembershipChange": "2001-07-07T18:28:50.2644119+02:00",
  "LastMembershipChangeBy": 140,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 597,
    "Name": "Becker Group",
    "PersonId": 23,
    "Rank": 815,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 564,
    "FullName": "Laurel Runte",
    "FormalName": "Jones-McClure",
    "Deleted": true,
    "EjUserId": 37,
    "UserName": "Kutch, Emard and Stoltenberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 754
      }
    }
  },
  "MainHeading": "provident",
  "MemberTabHeading": "molestiae",
  "MailingsProviderName": "Schiller LLC",
  "DashboardTileDefinitionId": 785,
  "VisibleFor": [
    {
      "VisibleId": 81,
      "Visibility": "All",
      "DisplayValue": "minus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer synergistic metrics"
          },
          "FieldType": "System.String",
          "FieldLength": 451
        }
      }
    },
    {
      "VisibleId": 81,
      "Visibility": "All",
      "DisplayValue": "minus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer synergistic metrics"
          },
          "FieldType": "System.String",
          "FieldLength": 451
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 638
    }
  }
}
```