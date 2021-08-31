---
title: CreateContactSelectionFromSelection
id: v1SelectionAgent_CreateContactSelectionFromSelection
---

# CreateContactSelectionFromSelection

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromSelection
```

Creates a new selection based on selection members from an existing selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromSelection?$select=name,department,category/id
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

SelectionId, Name, TargetSelectionType, CopyMembers 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Name | string |  |
| TargetSelectionType | string |  |
| CopyMembers | bool |  |


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
POST /api/v1/Agents/Selection/CreateContactSelectionFromSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 364,
  "Name": "Schmitt, Koch and Goldner",
  "TargetSelectionType": "Combined",
  "CopyMembers": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Automated hybrid alliance",
  "Postit": "fugiat",
  "Associate": {
    "AssociateId": 636,
    "Name": "Morar, Kautzer and Hodkiewicz",
    "PersonId": 970,
    "Rank": 4,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 568,
    "FullName": "Antwon Ernser",
    "FormalName": "O'Hara LLC",
    "Deleted": false,
    "EjUserId": 109,
    "UserName": "Paucek, Kris and Padberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 293
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 47,
    "Name": "Hodkiewicz, Farrell and Hand",
    "PersonId": 412,
    "Rank": 232,
    "Tooltip": "nulla",
    "Type": "AnonymousAssociate",
    "GroupIdx": 172,
    "FullName": "Raymundo Nicolas",
    "FormalName": "Kuvalis-Medhurst",
    "Deleted": true,
    "EjUserId": 620,
    "UserName": "Ledner, Stroman and Altenwerth",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 44
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 149,
    "Name": "Gottlieb LLC",
    "PersonId": 978,
    "Rank": 405,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 267,
    "FullName": "Deborah Yundt",
    "FormalName": "Schuster, Hirthe and Reichert",
    "Deleted": true,
    "EjUserId": 759,
    "UserName": "Hamill Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 836
      }
    }
  },
  "SelectionCategory": {
    "Id": 48,
    "Value": "dolor",
    "Tooltip": "nobis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 84
      }
    }
  },
  "GroupIdx": 250,
  "IncludePerson": 569,
  "MemberCount": 451,
  "Name": "Koepp Inc and Sons",
  "PostitTextId": 680,
  "CreatedDate": "2009-07-29T14:58:05.2986325+02:00",
  "SelectionId": 242,
  "SoundEx": "quia",
  "Source": 630,
  "TextId": 86,
  "UpdatedDate": "2002-05-19T14:58:05.2986325+02:00",
  "UpdatedCount": 492,
  "Visibility": 289,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 648,
  "TargetTableName": "Will, Daugherty and Dooley",
  "Completed": false,
  "LeftSelectionId": 143,
  "RightSelectionId": 359,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Buckridge, McClure and Beatty",
  "ShadowProviderName": "Mraz, Rowe and Marquardt",
  "ChartKey": "ad",
  "LastLoaded": "1994-08-11T14:58:05.2986325+02:00",
  "LastLoadedBy": 294,
  "LastLoadedByAssociate": {
    "AssociateId": 152,
    "Name": "Rogahn-Rice",
    "PersonId": 891,
    "Rank": 480,
    "Tooltip": "sapiente",
    "Type": "AnonymousAssociate",
    "GroupIdx": 690,
    "FullName": "Chadd Feest",
    "FormalName": "Nolan, Cassin and Bernier",
    "Deleted": true,
    "EjUserId": 654,
    "UserName": "Brekke Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 143
      }
    }
  },
  "LastMembershipChange": "2012-01-29T14:58:05.2986325+01:00",
  "LastMembershipChangeBy": 9,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 326,
    "Name": "Parisian Inc and Sons",
    "PersonId": 525,
    "Rank": 827,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 446,
    "FullName": "Emily Weber",
    "FormalName": "Stanton-Borer",
    "Deleted": true,
    "EjUserId": 408,
    "UserName": "Carroll, Wolf and Nicolas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 937
      }
    }
  },
  "MainHeading": "et",
  "MemberTabHeading": "nihil",
  "MailingsProviderName": "Rogahn Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 201,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    },
    {
      "VisibleId": 201,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 245
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
      "FieldLength": 119
    }
  }
}
```