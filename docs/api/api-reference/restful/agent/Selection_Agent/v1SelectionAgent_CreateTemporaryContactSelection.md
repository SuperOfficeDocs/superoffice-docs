---
title: CreateTemporaryContactSelection
id: v1SelectionAgent_CreateTemporaryContactSelection
---

# CreateTemporaryContactSelection

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection
```

Creates a temporary selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Synchronised intangible knowledge user",
  "Postit": "omnis",
  "Associate": {
    "AssociateId": 759,
    "Name": "Fay, Wolf and Johns",
    "PersonId": 603,
    "Rank": 108,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 42,
    "FullName": "Myrtie Wunsch",
    "FormalName": "Moen LLC",
    "Deleted": false,
    "EjUserId": 542,
    "UserName": "Marquardt, Runte and Armstrong",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 290
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 680,
    "Name": "Schowalter LLC",
    "PersonId": 281,
    "Rank": 997,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 718,
    "FullName": "Elna White",
    "FormalName": "Schaden, Sipes and Kreiger",
    "Deleted": true,
    "EjUserId": 593,
    "UserName": "Jast-Schiller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 13
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 619,
    "Name": "Yundt, Rath and Heidenreich",
    "PersonId": 472,
    "Rank": 581,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 239,
    "FullName": "Noemi Hartmann",
    "FormalName": "Becker Group",
    "Deleted": false,
    "EjUserId": 665,
    "UserName": "McLaughlin-Douglas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 700
      }
    }
  },
  "SelectionCategory": {
    "Id": 915,
    "Value": "debitis",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 379
      }
    }
  },
  "GroupIdx": 490,
  "IncludePerson": 939,
  "MemberCount": 905,
  "Name": "Koss-Reinger",
  "PostitTextId": 637,
  "CreatedDate": "2014-04-23T14:58:05.3166329+02:00",
  "SelectionId": 918,
  "SoundEx": "debitis",
  "Source": 423,
  "TextId": 259,
  "UpdatedDate": "2017-01-29T14:58:05.3166329+01:00",
  "UpdatedCount": 357,
  "Visibility": 92,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 90,
  "TargetTableName": "Jewess-Dicki",
  "Completed": true,
  "LeftSelectionId": 179,
  "RightSelectionId": 652,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Kemmer LLC",
  "ShadowProviderName": "Padberg-Shanahan",
  "ChartKey": "a",
  "LastLoaded": "2000-03-13T14:58:05.3166329+01:00",
  "LastLoadedBy": 118,
  "LastLoadedByAssociate": {
    "AssociateId": 800,
    "Name": "Dickinson-Smitham",
    "PersonId": 958,
    "Rank": 934,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 278,
    "FullName": "Darien Leannon",
    "FormalName": "Pagac, Wolf and Pfannerstill",
    "Deleted": false,
    "EjUserId": 962,
    "UserName": "Torp Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 202
      }
    }
  },
  "LastMembershipChange": "2001-10-04T14:58:05.3166329+02:00",
  "LastMembershipChangeBy": 455,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 920,
    "Name": "Ward Inc and Sons",
    "PersonId": 385,
    "Rank": 240,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 252,
    "FullName": "Jayme Hamill",
    "FormalName": "Leannon, Hintz and Tromp",
    "Deleted": false,
    "EjUserId": 913,
    "UserName": "Schaden, Prohaska and Connelly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 234
      }
    }
  },
  "MainHeading": "consequatur",
  "MemberTabHeading": "nostrum",
  "MailingsProviderName": "DuBuque, Jewess and Johnson",
  "VisibleFor": [
    {
      "VisibleId": 606,
      "Visibility": "All",
      "DisplayValue": "pariatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    },
    {
      "VisibleId": 606,
      "Visibility": "All",
      "DisplayValue": "pariatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 582
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
      "FieldLength": 207
    }
  }
}
```