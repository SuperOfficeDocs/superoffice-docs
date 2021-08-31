---
title: CreateContactSelectionFromShadowSelection
id: v1SelectionAgent_CreateContactSelectionFromShadowSelection
---

# CreateContactSelectionFromShadowSelection

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
| SelectionId | int32 |  |
| Name | string |  |


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
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 309,
  "Name": "Armstrong LLC"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Re-engineered 6th generation database",
  "Postit": "eum",
  "Associate": {
    "AssociateId": 10,
    "Name": "Casper LLC",
    "PersonId": 810,
    "Rank": 132,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 188,
    "FullName": "Kaleb Rempel",
    "FormalName": "Murphy, O'Conner and Bernier",
    "Deleted": false,
    "EjUserId": 232,
    "UserName": "Kohler LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 370
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 510,
    "Name": "Gerhold, Brown and Goodwin",
    "PersonId": 930,
    "Rank": 93,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 407,
    "FullName": "Esteban Hilpert",
    "FormalName": "Kovacek Inc and Sons",
    "Deleted": false,
    "EjUserId": 867,
    "UserName": "Lesch, Kuvalis and Glover",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 27
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 920,
    "Name": "Lemke-Yost",
    "PersonId": 217,
    "Rank": 262,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 948,
    "FullName": "Tamia Adams",
    "FormalName": "Glover-Abshire",
    "Deleted": false,
    "EjUserId": 248,
    "UserName": "Graham Group",
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
  "SelectionCategory": {
    "Id": 44,
    "Value": "eum",
    "Tooltip": "id",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 904
      }
    }
  },
  "GroupIdx": 174,
  "IncludePerson": 98,
  "MemberCount": 304,
  "Name": "Dickens, Okuneva and Toy",
  "PostitTextId": 752,
  "CreatedDate": "1997-11-10T14:58:05.2086304+01:00",
  "SelectionId": 528,
  "SoundEx": "quibusdam",
  "Source": 860,
  "TextId": 399,
  "UpdatedDate": "2014-05-15T14:58:05.2086304+02:00",
  "UpdatedCount": 501,
  "Visibility": 312,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 151,
  "TargetTableName": "Schiller LLC",
  "Completed": true,
  "LeftSelectionId": 439,
  "RightSelectionId": 175,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Morissette-Lynch",
  "ShadowProviderName": "Schowalter-Bins",
  "ChartKey": "ad",
  "LastLoaded": "2016-11-19T14:58:05.2086304+01:00",
  "LastLoadedBy": 704,
  "LastLoadedByAssociate": {
    "AssociateId": 281,
    "Name": "Kuhlman LLC",
    "PersonId": 109,
    "Rank": 259,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 185,
    "FullName": "Kendall Kuvalis",
    "FormalName": "Mraz Group",
    "Deleted": false,
    "EjUserId": 736,
    "UserName": "Rempel-Ernser",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 285
      }
    }
  },
  "LastMembershipChange": "2018-01-03T14:58:05.2086304+01:00",
  "LastMembershipChangeBy": 311,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 899,
    "Name": "Reinger, Romaguera and Casper",
    "PersonId": 93,
    "Rank": 799,
    "Tooltip": "quidem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 757,
    "FullName": "Ms. Stefan Howell",
    "FormalName": "Zboncak, Buckridge and Bayer",
    "Deleted": true,
    "EjUserId": 267,
    "UserName": "Thompson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 481
      }
    }
  },
  "MainHeading": "ipsa",
  "MemberTabHeading": "aut",
  "MailingsProviderName": "White, Marks and Rice",
  "VisibleFor": [
    {
      "VisibleId": 27,
      "Visibility": "All",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    },
    {
      "VisibleId": 27,
      "Visibility": "All",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 905
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
      "FieldType": "System.String",
      "FieldLength": 560
    }
  }
}
```