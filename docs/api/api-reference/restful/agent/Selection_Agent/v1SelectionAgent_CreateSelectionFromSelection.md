---
title: POST Agents/Selection/CreateSelectionFromSelection
id: v1SelectionAgent_CreateSelectionFromSelection
---

# POST Agents/Selection/CreateSelectionFromSelection

```http
POST /api/v1/Agents/Selection/CreateSelectionFromSelection
```

Creates a new selection based on selection members from an existing selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateSelectionFromSelection?$select=name,department,category/id
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
POST /api/v1/Agents/Selection/CreateSelectionFromSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 83,
  "Name": "Altenwerth Inc and Sons",
  "TargetSelectionType": "Combined",
  "CopyMembers": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Ergonomic well-modulated adapter",
  "Postit": "perferendis",
  "Associate": {
    "AssociateId": 96,
    "Name": "Goyette-Prohaska",
    "PersonId": 738,
    "Rank": 579,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 919,
    "FullName": "Mrs. Jaylen Zieme",
    "FormalName": "Wiegand LLC",
    "Deleted": true,
    "EjUserId": 642,
    "UserName": "Haley-Lesch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 469
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 858,
    "Name": "Reynolds-Kerluke",
    "PersonId": 31,
    "Rank": 12,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 966,
    "FullName": "Santina Wolf",
    "FormalName": "Smith Inc and Sons",
    "Deleted": true,
    "EjUserId": 271,
    "UserName": "Bednar, Leffler and Bashirian",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 848
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 382,
    "Name": "Predovic LLC",
    "PersonId": 52,
    "Rank": 535,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 806,
    "FullName": "Mrs. Shyanne Bartoletti",
    "FormalName": "Gutmann-Daugherty",
    "Deleted": true,
    "EjUserId": 97,
    "UserName": "Considine, Kuphal and Langworth",
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
  "SelectionCategory": {
    "Id": 882,
    "Value": "illum",
    "Tooltip": "eos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 564
      }
    }
  },
  "GroupIdx": 482,
  "IncludePerson": 261,
  "MemberCount": 916,
  "Name": "Braun Group",
  "PostitTextId": 421,
  "CreatedDate": "2021-01-14T18:28:50.1944476+01:00",
  "SelectionId": 137,
  "SoundEx": "vel",
  "Source": 745,
  "TextId": 602,
  "UpdatedDate": "2015-10-09T18:28:50.1944476+02:00",
  "UpdatedCount": 860,
  "Visibility": 301,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 705,
  "TargetTableName": "Rice, McCullough and Boyle",
  "Completed": false,
  "LeftSelectionId": 563,
  "RightSelectionId": 885,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Schmitt, DuBuque and McDermott",
  "ShadowProviderName": "Jacobson, Toy and Senger",
  "ChartKey": "neque",
  "LastLoaded": "2000-09-03T18:28:50.1944476+02:00",
  "LastLoadedBy": 592,
  "LastLoadedByAssociate": {
    "AssociateId": 439,
    "Name": "Kshlerin Group",
    "PersonId": 722,
    "Rank": 790,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 962,
    "FullName": "Arnoldo Runte",
    "FormalName": "Rohan-Shields",
    "Deleted": false,
    "EjUserId": 162,
    "UserName": "Rosenbaum Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 932
      }
    }
  },
  "LastMembershipChange": "2017-09-09T18:28:50.1944476+02:00",
  "LastMembershipChangeBy": 677,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 341,
    "Name": "Jacobi, Wehner and Collins",
    "PersonId": 4,
    "Rank": 397,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 604,
    "FullName": "Aubrey Harris",
    "FormalName": "Morar-Weimann",
    "Deleted": true,
    "EjUserId": 123,
    "UserName": "Fahey, O'Hara and Bergnaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 18
      }
    }
  },
  "MainHeading": "veritatis",
  "MemberTabHeading": "aliquam",
  "MailingsProviderName": "Mann Inc and Sons",
  "DashboardTileDefinitionId": 891,
  "VisibleFor": [
    {
      "VisibleId": 572,
      "Visibility": "All",
      "DisplayValue": "error",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    },
    {
      "VisibleId": 572,
      "Visibility": "All",
      "DisplayValue": "error",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 953
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
      "FieldLength": 620
    }
  }
}
```