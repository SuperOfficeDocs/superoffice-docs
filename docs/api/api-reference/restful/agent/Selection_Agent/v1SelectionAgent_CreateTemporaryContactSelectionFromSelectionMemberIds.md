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
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 538,
  "SelectionMemberIds": [
    943,
    985
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Quality-focused holistic project",
  "Postit": "voluptatum",
  "Associate": {
    "AssociateId": 916,
    "Name": "Corwin, Towne and Jast",
    "PersonId": 158,
    "Rank": 699,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 126,
    "FullName": "Hellen Buckridge",
    "FormalName": "Kihn Inc and Sons",
    "Deleted": false,
    "EjUserId": 414,
    "UserName": "Lockman, Okuneva and Carter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 902
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 404,
    "Name": "Steuber, Predovic and Bernhard",
    "PersonId": 322,
    "Rank": 116,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 632,
    "FullName": "Mrs. Emerald McLaughlin",
    "FormalName": "McGlynn Group",
    "Deleted": false,
    "EjUserId": 510,
    "UserName": "Schulist-Terry",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 289
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 930,
    "Name": "Ryan LLC",
    "PersonId": 523,
    "Rank": 477,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 306,
    "FullName": "Anastacio Herzog",
    "FormalName": "Bosco LLC",
    "Deleted": true,
    "EjUserId": 484,
    "UserName": "Donnelly-Klein",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 54
      }
    }
  },
  "SelectionCategory": {
    "Id": 406,
    "Value": "nemo",
    "Tooltip": "voluptatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 34
      }
    }
  },
  "GroupIdx": 187,
  "IncludePerson": 770,
  "MemberCount": 625,
  "Name": "Brekke, Murray and Will",
  "PostitTextId": 22,
  "CreatedDate": "2004-11-27T16:48:30.6919381+01:00",
  "SelectionId": 782,
  "SoundEx": "quidem",
  "Source": 606,
  "TextId": 202,
  "UpdatedDate": "2007-07-07T16:48:30.6919381+02:00",
  "UpdatedCount": 210,
  "Visibility": 550,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 188,
  "TargetTableName": "Witting, Pagac and Flatley",
  "Completed": true,
  "LeftSelectionId": 118,
  "RightSelectionId": 50,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ankunding, Balistreri and Swaniawski",
  "ShadowProviderName": "Hane-Cartwright",
  "ChartKey": "voluptatibus",
  "LastLoaded": "2004-06-26T16:48:30.6919381+02:00",
  "LastLoadedBy": 375,
  "LastLoadedByAssociate": {
    "AssociateId": 764,
    "Name": "Keeling LLC",
    "PersonId": 797,
    "Rank": 552,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 807,
    "FullName": "Hortense Davis",
    "FormalName": "Kunde Inc and Sons",
    "Deleted": true,
    "EjUserId": 93,
    "UserName": "Hickle-Zemlak",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 585
      }
    }
  },
  "LastMembershipChange": "2000-08-13T16:48:30.6929344+02:00",
  "LastMembershipChangeBy": 110,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 263,
    "Name": "Block Inc and Sons",
    "PersonId": 230,
    "Rank": 938,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 403,
    "FullName": "Shannon Pouros",
    "FormalName": "Halvorson, Schuster and Considine",
    "Deleted": true,
    "EjUserId": 580,
    "UserName": "Quigley, Thiel and Champlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 248
      }
    }
  },
  "MainHeading": "dolor",
  "MemberTabHeading": "fugit",
  "MailingsProviderName": "Baumbach, Kessler and Crist",
  "VisibleFor": [
    {
      "VisibleId": 523,
      "Visibility": "All",
      "DisplayValue": "sequi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    },
    {
      "VisibleId": 523,
      "Visibility": "All",
      "DisplayValue": "sequi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 551
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
      "FieldLength": 677
    }
  }
}
```