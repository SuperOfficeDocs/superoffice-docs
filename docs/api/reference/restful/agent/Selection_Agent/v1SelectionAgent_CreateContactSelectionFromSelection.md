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
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateContactSelectionFromSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 187,
  "Name": "Kling, Zieme and Bayer",
  "TargetSelectionType": "Combined",
  "CopyMembers": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Extended dedicated algorithm",
  "Postit": "nesciunt",
  "Associate": {
    "AssociateId": 576,
    "Name": "Kris-O'Hara",
    "PersonId": 762,
    "Rank": 356,
    "Tooltip": "vero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 173,
    "FullName": "Janae Reichel",
    "FormalName": "Kilback-Kuhlman",
    "Deleted": true,
    "EjUserId": 220,
    "UserName": "Zemlak, Grimes and Hartmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 318
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 819,
    "Name": "Mills Group",
    "PersonId": 587,
    "Rank": 275,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 148,
    "FullName": "Daron Hahn",
    "FormalName": "King Group",
    "Deleted": false,
    "EjUserId": 84,
    "UserName": "Zieme-Rau",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 924
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 34,
    "Name": "Hauck Group",
    "PersonId": 242,
    "Rank": 532,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 538,
    "FullName": "Deondre Eichmann",
    "FormalName": "Kunze-Lockman",
    "Deleted": false,
    "EjUserId": 512,
    "UserName": "Sipes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 300
      }
    }
  },
  "SelectionCategory": {
    "Id": 416,
    "Value": "nobis",
    "Tooltip": "animi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 55
      }
    }
  },
  "GroupIdx": 554,
  "IncludePerson": 113,
  "MemberCount": 581,
  "Name": "Runte LLC",
  "PostitTextId": 448,
  "CreatedDate": "2014-10-13T18:28:50.2404117+02:00",
  "SelectionId": 871,
  "SoundEx": "in",
  "Source": 746,
  "TextId": 706,
  "UpdatedDate": "2008-04-26T18:28:50.2404117+02:00",
  "UpdatedCount": 87,
  "Visibility": 450,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 516,
  "TargetTableName": "Schmidt Inc and Sons",
  "Completed": false,
  "LeftSelectionId": 799,
  "RightSelectionId": 564,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ledner-Green",
  "ShadowProviderName": "Wolf, Kunze and Reynolds",
  "ChartKey": "aperiam",
  "LastLoaded": "2011-04-04T18:28:50.2404117+02:00",
  "LastLoadedBy": 971,
  "LastLoadedByAssociate": {
    "AssociateId": 376,
    "Name": "Paucek, Hoppe and Stoltenberg",
    "PersonId": 37,
    "Rank": 793,
    "Tooltip": "iste",
    "Type": "AnonymousAssociate",
    "GroupIdx": 416,
    "FullName": "Darrick Kunze",
    "FormalName": "Stokes, Glover and Fritsch",
    "Deleted": true,
    "EjUserId": 513,
    "UserName": "Pagac, Weissnat and Zieme",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 797
      }
    }
  },
  "LastMembershipChange": "2019-09-26T18:28:50.2404117+02:00",
  "LastMembershipChangeBy": 13,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 544,
    "Name": "Predovic-Krajcik",
    "PersonId": 727,
    "Rank": 5,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 94,
    "FullName": "Rigoberto Adams",
    "FormalName": "DuBuque Group",
    "Deleted": true,
    "EjUserId": 347,
    "UserName": "Nienow LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 189
      }
    }
  },
  "MainHeading": "et",
  "MemberTabHeading": "laudantium",
  "MailingsProviderName": "Altenwerth, Ziemann and Torp",
  "DashboardTileDefinitionId": 544,
  "VisibleFor": [
    {
      "VisibleId": 169,
      "Visibility": "All",
      "DisplayValue": "possimus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    },
    {
      "VisibleId": 169,
      "Visibility": "All",
      "DisplayValue": "possimus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 408
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
      "FieldLength": 828
    }
  }
}
```