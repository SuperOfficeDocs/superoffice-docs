---
title: POST Agents/Selection/CreateContactSelectionFromSelection
id: v1SelectionAgent_CreateContactSelectionFromSelection
---

# POST Agents/Selection/CreateContactSelectionFromSelection

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
  "SelectionId": 526,
  "Name": "Stamm Group",
  "TargetSelectionType": "Combined",
  "CopyMembers": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Programmable full-range portal",
  "Postit": "est",
  "Associate": {
    "AssociateId": 282,
    "Name": "Schumm, Champlin and Kessler",
    "PersonId": 859,
    "Rank": 568,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 331,
    "FullName": "Eva Daniel",
    "FormalName": "Osinski-Stokes",
    "Deleted": true,
    "EjUserId": 563,
    "UserName": "Krajcik-Schroeder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 22
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 407,
    "Name": "Morissette-Orn",
    "PersonId": 760,
    "Rank": 828,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 18,
    "FullName": "Dillan Kirlin",
    "FormalName": "Ward-Gerlach",
    "Deleted": true,
    "EjUserId": 300,
    "UserName": "Crist-Heaney",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 809
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 41,
    "Name": "Miller Inc and Sons",
    "PersonId": 469,
    "Rank": 637,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 453,
    "FullName": "Jaylen Douglas PhD",
    "FormalName": "Kunde-Block",
    "Deleted": true,
    "EjUserId": 481,
    "UserName": "Medhurst Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 321
      }
    }
  },
  "SelectionCategory": {
    "Id": 864,
    "Value": "architecto",
    "Tooltip": "libero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 720
      }
    }
  },
  "GroupIdx": 645,
  "IncludePerson": 223,
  "MemberCount": 52,
  "Name": "Hoeger-Reilly",
  "PostitTextId": 368,
  "CreatedDate": "2020-05-11T16:48:30.6709074+02:00",
  "SelectionId": 51,
  "SoundEx": "omnis",
  "Source": 293,
  "TextId": 450,
  "UpdatedDate": "1994-11-11T16:48:30.6709074+01:00",
  "UpdatedCount": 660,
  "Visibility": 266,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 476,
  "TargetTableName": "Breitenberg Inc and Sons",
  "Completed": true,
  "LeftSelectionId": 997,
  "RightSelectionId": 149,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Senger, Robel and Sauer",
  "ShadowProviderName": "Ortiz LLC",
  "ChartKey": "eos",
  "LastLoaded": "2013-09-12T16:48:30.6709074+02:00",
  "LastLoadedBy": 29,
  "LastLoadedByAssociate": {
    "AssociateId": 379,
    "Name": "Moen Inc and Sons",
    "PersonId": 902,
    "Rank": 12,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 416,
    "FullName": "Hattie Jerde",
    "FormalName": "Stroman, Hauck and Oberbrunner",
    "Deleted": false,
    "EjUserId": 523,
    "UserName": "Bednar LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 291
      }
    }
  },
  "LastMembershipChange": "2013-11-28T16:48:30.6709074+01:00",
  "LastMembershipChangeBy": 489,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 110,
    "Name": "Haley, Braun and Homenick",
    "PersonId": 238,
    "Rank": 317,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 208,
    "FullName": "Mrs. Keaton Carter",
    "FormalName": "Bruen-Jakubowski",
    "Deleted": true,
    "EjUserId": 807,
    "UserName": "Harris-Pouros",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 974
      }
    }
  },
  "MainHeading": "quos",
  "MemberTabHeading": "nobis",
  "MailingsProviderName": "Roberts-Hahn",
  "VisibleFor": [
    {
      "VisibleId": 330,
      "Visibility": "All",
      "DisplayValue": "libero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    },
    {
      "VisibleId": 330,
      "Visibility": "All",
      "DisplayValue": "libero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 944
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
      "FieldLength": 498
    }
  }
}
```