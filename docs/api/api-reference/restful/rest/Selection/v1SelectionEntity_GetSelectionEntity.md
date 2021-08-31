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
Accept-Language: en
```

```http_
HTTP/1.1 200 SelectionEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 11 Feb 1997 15:05:42 G2T

{
  "Description": "Centralized foreground interface",
  "Postit": "cum",
  "Associate": {
    "AssociateId": 604,
    "Name": "Funk LLC",
    "PersonId": 381,
    "Rank": 298,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 505,
    "FullName": "Andy Rutherford",
    "FormalName": "Cruickshank-Predovic",
    "Deleted": true,
    "EjUserId": 740,
    "UserName": "Corkery-Franecki",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 302
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 103,
    "Name": "Koelpin LLC",
    "PersonId": 345,
    "Rank": 607,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 15,
    "FullName": "Floyd Kuvalis",
    "FormalName": "Mitchell, Hammes and Hammes",
    "Deleted": false,
    "EjUserId": 679,
    "UserName": "Wisozk Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 642
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 666,
    "Name": "Dickens LLC",
    "PersonId": 923,
    "Rank": 805,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 126,
    "FullName": "Herminio Harvey",
    "FormalName": "Howell, Bartoletti and Upton",
    "Deleted": true,
    "EjUserId": 713,
    "UserName": "Watsica-Beer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 971
      }
    }
  },
  "SelectionCategory": {
    "Id": 539,
    "Value": "sit",
    "Tooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 942
      }
    }
  },
  "GroupIdx": 834,
  "IncludePerson": 840,
  "MemberCount": 438,
  "Name": "O'Connell Inc and Sons",
  "PostitTextId": 423,
  "CreatedDate": "2010-08-26T15:05:42.7346675+02:00",
  "SelectionId": 481,
  "SoundEx": "saepe",
  "Source": 375,
  "TextId": 781,
  "UpdatedDate": "1997-02-11T15:05:42.7346675+01:00",
  "UpdatedCount": 939,
  "Visibility": 215,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 325,
  "TargetTableName": "Moen, Gleichner and Hickle",
  "Completed": false,
  "LeftSelectionId": 953,
  "RightSelectionId": 268,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Gulgowski, Medhurst and Moen",
  "ShadowProviderName": "Nader-Will",
  "ChartKey": "adipisci",
  "LastLoaded": "2008-10-04T15:05:42.7346675+02:00",
  "LastLoadedBy": 266,
  "LastLoadedByAssociate": {
    "AssociateId": 64,
    "Name": "Lang LLC",
    "PersonId": 345,
    "Rank": 339,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 847,
    "FullName": "Novella Franecki",
    "FormalName": "Osinski, Ziemann and Hartmann",
    "Deleted": false,
    "EjUserId": 474,
    "UserName": "Connelly, Homenick and O'Connell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "e-enable visionary vortals"
        },
        "FieldType": "System.String",
        "FieldLength": 824
      }
    }
  },
  "LastMembershipChange": "2012-05-16T15:05:42.7356676+02:00",
  "LastMembershipChangeBy": 745,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 744,
    "Name": "Klocko Inc and Sons",
    "PersonId": 198,
    "Rank": 953,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 357,
    "FullName": "Lucas Herzog",
    "FormalName": "Heathcote-Tromp",
    "Deleted": false,
    "EjUserId": 642,
    "UserName": "Ziemann-Reichert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard efficient applications"
        },
        "FieldType": "System.String",
        "FieldLength": 459
      }
    }
  },
  "MainHeading": "similique",
  "MemberTabHeading": "itaque",
  "MailingsProviderName": "O'Connell-Bailey",
  "VisibleFor": [
    {
      "VisibleId": 231,
      "Visibility": "All",
      "DisplayValue": "quibusdam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    },
    {
      "VisibleId": 231,
      "Visibility": "All",
      "DisplayValue": "quibusdam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 464
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
      "FieldLength": 543
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```