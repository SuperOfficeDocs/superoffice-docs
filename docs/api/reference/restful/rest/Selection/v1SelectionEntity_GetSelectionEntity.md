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
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 SelectionEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 30 Aug 1996 18:25:51 G8T

{
  "Description": "Implemented real-time superstructure",
  "Postit": "ullam",
  "Associate": {
    "AssociateId": 601,
    "Name": "Kub, Pollich and Blick",
    "PersonId": 406,
    "Rank": 204,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 558,
    "FullName": "Dr. Blanca Mohr",
    "FormalName": "Dickinson Inc and Sons",
    "Deleted": false,
    "EjUserId": 506,
    "UserName": "Toy, Bernhard and Lemke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 457
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 983,
    "Name": "Parisian, O'Conner and Walker",
    "PersonId": 569,
    "Rank": 64,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 146,
    "FullName": "Roxane Lubowitz V",
    "FormalName": "Murphy, Kuhn and Graham",
    "Deleted": false,
    "EjUserId": 924,
    "UserName": "Denesik-Rosenbaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize cross-media metrics"
        },
        "FieldType": "System.String",
        "FieldLength": 360
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 114,
    "Name": "Rodriguez-Adams",
    "PersonId": 572,
    "Rank": 69,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 59,
    "FullName": "Lily Boyer",
    "FormalName": "Satterfield, O'Hara and Jenkins",
    "Deleted": true,
    "EjUserId": 302,
    "UserName": "Spencer, Pagac and Kulas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 925
      }
    }
  },
  "SelectionCategory": {
    "Id": 739,
    "Value": "ut",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 828
      }
    }
  },
  "GroupIdx": 106,
  "IncludePerson": 547,
  "MemberCount": 993,
  "Name": "Reilly, Hodkiewicz and Wolff",
  "PostitTextId": 475,
  "CreatedDate": "2019-08-09T18:25:51.0859494+02:00",
  "SelectionId": 918,
  "SoundEx": "saepe",
  "Source": 137,
  "TextId": 445,
  "UpdatedDate": "1996-08-30T18:25:51.0869453+02:00",
  "UpdatedCount": 379,
  "Visibility": 570,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 436,
  "TargetTableName": "Eichmann, Maggio and Schiller",
  "Completed": true,
  "LeftSelectionId": 169,
  "RightSelectionId": 289,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Wehner, Volkman and Hermiston",
  "ShadowProviderName": "Wilderman, Little and Streich",
  "ChartKey": "animi",
  "LastLoaded": "2017-01-09T18:25:51.0869453+01:00",
  "LastLoadedBy": 464,
  "LastLoadedByAssociate": {
    "AssociateId": 700,
    "Name": "King LLC",
    "PersonId": 691,
    "Rank": 32,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 979,
    "FullName": "Madyson Ernser",
    "FormalName": "Weissnat-Toy",
    "Deleted": false,
    "EjUserId": 200,
    "UserName": "Luettgen-Borer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 3
      }
    }
  },
  "LastMembershipChange": "2001-11-26T18:25:51.0869453+01:00",
  "LastMembershipChangeBy": 60,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 184,
    "Name": "Bednar, Batz and Wisozk",
    "PersonId": 873,
    "Rank": 56,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 40,
    "FullName": "Mr. Kenneth Turner",
    "FormalName": "Reilly, Mitchell and Gerhold",
    "Deleted": true,
    "EjUserId": 237,
    "UserName": "O'Kon Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 374
      }
    }
  },
  "MainHeading": "magnam",
  "MemberTabHeading": "cupiditate",
  "MailingsProviderName": "Witting, Johns and Kuhic",
  "DashboardTileDefinitionId": 258,
  "VisibleFor": [
    {
      "VisibleId": 941,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    },
    {
      "VisibleId": 941,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
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
      "FieldType": "System.Int32",
      "FieldLength": 47
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```