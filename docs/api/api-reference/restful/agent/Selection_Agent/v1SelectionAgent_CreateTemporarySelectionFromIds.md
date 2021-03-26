---
title: POST Agents/Selection/CreateTemporarySelectionFromIds
id: v1SelectionAgent_CreateTemporarySelectionFromIds
---

# POST Agents/Selection/CreateTemporarySelectionFromIds

```http
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds
```

Creates a temporary selection with members from a collection of entity id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds?$select=name,department,category/id
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

Ids, TargetTableNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Ids | array |  |
| TargetTableNumber | int32 |  |


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
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Ids": [
    725,
    572
  ],
  "TargetTableNumber": 400
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Virtual methodical system engine",
  "Postit": "laborum",
  "Associate": {
    "AssociateId": 317,
    "Name": "Jacobi-Hayes",
    "PersonId": 678,
    "Rank": 383,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 485,
    "FullName": "Deja Farrell",
    "FormalName": "Wolff, Paucek and Cummings",
    "Deleted": true,
    "EjUserId": 521,
    "UserName": "Murray Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 851
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 966,
    "Name": "Bashirian-Ritchie",
    "PersonId": 867,
    "Rank": 147,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 204,
    "FullName": "Viva Howell",
    "FormalName": "Stracke-Kessler",
    "Deleted": false,
    "EjUserId": 813,
    "UserName": "Reynolds Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 815
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 301,
    "Name": "Feil-Wuckert",
    "PersonId": 162,
    "Rank": 316,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 418,
    "FullName": "Althea Rath V",
    "FormalName": "Mueller-Kuhlman",
    "Deleted": true,
    "EjUserId": 777,
    "UserName": "Dooley-Von",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 491
      }
    }
  },
  "SelectionCategory": {
    "Id": 498,
    "Value": "qui",
    "Tooltip": "libero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 568
      }
    }
  },
  "GroupIdx": 735,
  "IncludePerson": 384,
  "MemberCount": 761,
  "Name": "Torphy-Effertz",
  "PostitTextId": 811,
  "CreatedDate": "2005-11-12T16:48:30.7029418+01:00",
  "SelectionId": 248,
  "SoundEx": "in",
  "Source": 957,
  "TextId": 195,
  "UpdatedDate": "2007-11-21T16:48:30.7029418+01:00",
  "UpdatedCount": 110,
  "Visibility": 665,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 327,
  "TargetTableName": "Homenick-Lubowitz",
  "Completed": false,
  "LeftSelectionId": 792,
  "RightSelectionId": 672,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Quigley, Cole and Rodriguez",
  "ShadowProviderName": "Ruecker-Schaden",
  "ChartKey": "vero",
  "LastLoaded": "2014-08-19T16:48:30.7029418+02:00",
  "LastLoadedBy": 731,
  "LastLoadedByAssociate": {
    "AssociateId": 673,
    "Name": "Emmerich, Hudson and Hermann",
    "PersonId": 612,
    "Rank": 663,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 793,
    "FullName": "Alexandrine Langworth",
    "FormalName": "Wilkinson, Hagenes and Deckow",
    "Deleted": true,
    "EjUserId": 431,
    "UserName": "Schmeler, Bernhard and Kilback",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 72
      }
    }
  },
  "LastMembershipChange": "2003-11-06T16:48:30.7029418+01:00",
  "LastMembershipChangeBy": 171,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 144,
    "Name": "Stroman-Watsica",
    "PersonId": 484,
    "Rank": 16,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 946,
    "FullName": "Zora Collins",
    "FormalName": "Witting-Hickle",
    "Deleted": true,
    "EjUserId": 232,
    "UserName": "Schowalter, Kovacek and Stroman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 874
      }
    }
  },
  "MainHeading": "assumenda",
  "MemberTabHeading": "molestiae",
  "MailingsProviderName": "McLaughlin Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 367,
      "Visibility": "All",
      "DisplayValue": "voluptatum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    },
    {
      "VisibleId": 367,
      "Visibility": "All",
      "DisplayValue": "voluptatum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "enhance innovative web services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 738
    }
  }
}
```