---
title: GET Selection/{id}
id: v1SelectionEntity_GetSelectionEntity
---

# GET Selection/{id}

```http
GET /api/v1/Selection/{id}
```

Gets a SelectionEntity object.

Calls the Selection agent service GetSelectionEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SelectionEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/Selection/{id}?$select=name,department,category/id
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




SelectionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SelectionEntity found. |
| 304 | SelectionEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 SelectionEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 11 Feb 1995 09:40:59 G2T

{
  "Description": "Reverse-engineered leading edge ability",
  "Postit": "est",
  "Associate": {
    "AssociateId": 640,
    "Name": "Kuphal, Hermiston and Cormier",
    "PersonId": 584,
    "Rank": 916,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 59,
    "FullName": "Isaac Cronin",
    "FormalName": "Keeling Inc and Sons",
    "Deleted": true,
    "EjUserId": 750,
    "UserName": "DuBuque LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 253
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 365,
    "Name": "Nitzsche-VonRueden",
    "PersonId": 189,
    "Rank": 286,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 588,
    "FullName": "Elaina Ernser",
    "FormalName": "Renner, Larkin and Lang",
    "Deleted": false,
    "EjUserId": 52,
    "UserName": "Buckridge Group",
    "TableRight": {},
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
  },
  "UpdatedBy": {
    "AssociateId": 254,
    "Name": "Leannon Inc and Sons",
    "PersonId": 125,
    "Rank": 712,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 366,
    "FullName": "Cornelius Harber",
    "FormalName": "Heaney, Crooks and Volkman",
    "Deleted": false,
    "EjUserId": 625,
    "UserName": "Collier, Adams and Herzog",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 742
      }
    }
  },
  "SelectionCategory": {
    "Id": 601,
    "Value": "quidem",
    "Tooltip": "eos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 268
      }
    }
  },
  "GroupIdx": 765,
  "IncludePerson": 100,
  "MemberCount": 464,
  "Name": "Rowe Inc and Sons",
  "PostitTextId": 523,
  "CreatedDate": "2011-03-23T09:40:59.7308893+01:00",
  "SelectionId": 67,
  "SoundEx": "rem",
  "Source": 279,
  "TextId": 885,
  "UpdatedDate": "1995-02-11T09:40:59.7308893+01:00",
  "UpdatedCount": 812,
  "Visibility": 900,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 72,
  "TargetTableName": "Prohaska Group",
  "Completed": true,
  "LeftSelectionId": 135,
  "RightSelectionId": 972,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "McClure, Kerluke and McKenzie",
  "ShadowProviderName": "Hegmann, Robel and Blick",
  "ChartKey": "illum",
  "LastLoaded": "2014-01-29T09:40:59.7308893+01:00",
  "LastLoadedBy": 526,
  "LastLoadedByAssociate": {
    "AssociateId": 241,
    "Name": "Kub, Ziemann and Mueller",
    "PersonId": 684,
    "Rank": 521,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 828,
    "FullName": "Miss Zander Veum",
    "FormalName": "Mann, Waters and Wehner",
    "Deleted": true,
    "EjUserId": 129,
    "UserName": "Macejkovic, Weimann and Ward",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 538
      }
    }
  },
  "LastMembershipChange": "1999-02-19T09:40:59.7308893+01:00",
  "LastMembershipChangeBy": 558,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 995,
    "Name": "Nader-Fadel",
    "PersonId": 262,
    "Rank": 761,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 616,
    "FullName": "Cynthia Mayert",
    "FormalName": "Jaskolski, Torphy and Rosenbaum",
    "Deleted": true,
    "EjUserId": 955,
    "UserName": "Kohler-Thiel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 249
      }
    }
  },
  "MainHeading": "et",
  "MemberTabHeading": "dolores",
  "MailingsProviderName": "Walter-Upton",
  "VisibleFor": [
    {
      "VisibleId": 627,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "VisibleId": 627,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 860
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
      "FieldLength": 985
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```