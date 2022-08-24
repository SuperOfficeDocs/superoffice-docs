---
title: POST Agents/Selection/CreateTemporaryContactSelectionFromProjectMembers
id: v1SelectionAgent_CreateTemporaryContactSelectionFromProjectMembers
---

# POST Agents/Selection/CreateTemporaryContactSelectionFromProjectMembers

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromProjectMembers
```

Creates a temporary selection with members from an existing project.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromProjectMembers?$select=name,department,category/id
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

ProjectId

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 |  |

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
| SelectionCategory |  | Selection category type (list item)  <br />Use MDO List name "searchCat" to get list items. |
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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 753
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Cross-group object-oriented alliance",
  "Postit": "est",
  "Associate": {
    "AssociateId": 180,
    "Name": "Kilback, Spencer and Balistreri",
    "PersonId": 798,
    "Rank": 573,
    "Tooltip": "ipsa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 682,
    "FullName": "Stephan Connelly",
    "FormalName": "Kilback-McLaughlin",
    "Deleted": false,
    "EjUserId": 4,
    "UserName": "Bogan-Schultz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 129
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 293,
    "Name": "Bosco-Marks",
    "PersonId": 864,
    "Rank": 642,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 212,
    "FullName": "Jeffery Johns",
    "FormalName": "Morissette-Casper",
    "Deleted": false,
    "EjUserId": 957,
    "UserName": "Barton, Cole and DuBuque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize scalable web-readiness"
        },
        "FieldType": "System.String",
        "FieldLength": 603
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 365,
    "Name": "Carter, Armstrong and Tromp",
    "PersonId": 506,
    "Rank": 103,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 42,
    "FullName": "Gerhard Runolfsson",
    "FormalName": "Bode Inc and Sons",
    "Deleted": true,
    "EjUserId": 448,
    "UserName": "Windler, Haag and Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 87
      }
    }
  },
  "SelectionCategory": {
    "Id": 294,
    "Value": "ab",
    "Tooltip": "animi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 452
      }
    }
  },
  "GroupIdx": 248,
  "IncludePerson": 474,
  "MemberCount": 521,
  "Name": "Langworth Inc and Sons",
  "PostitTextId": 36,
  "CreatedDate": "1997-11-03T18:28:50.2504443+01:00",
  "SelectionId": 823,
  "SoundEx": "maxime",
  "Source": 441,
  "TextId": 940,
  "UpdatedDate": "2020-10-09T18:28:50.2504443+02:00",
  "UpdatedCount": 421,
  "Visibility": 893,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 639,
  "TargetTableName": "Powlowski LLC",
  "Completed": true,
  "LeftSelectionId": 904,
  "RightSelectionId": 421,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Johnston, Hahn and Kertzmann",
  "ShadowProviderName": "Koss-Rosenbaum",
  "ChartKey": "fugiat",
  "LastLoaded": "2004-08-19T18:28:50.2504443+02:00",
  "LastLoadedBy": 689,
  "LastLoadedByAssociate": {
    "AssociateId": 398,
    "Name": "O'Conner-Goldner",
    "PersonId": 188,
    "Rank": 649,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 356,
    "FullName": "Logan Swaniawski",
    "FormalName": "Thompson Inc and Sons",
    "Deleted": false,
    "EjUserId": 758,
    "UserName": "Franecki-Morissette",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 612
      }
    }
  },
  "LastMembershipChange": "2006-05-31T18:28:50.2504443+02:00",
  "LastMembershipChangeBy": 382,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 705,
    "Name": "Parker Inc and Sons",
    "PersonId": 208,
    "Rank": 790,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 989,
    "FullName": "Joelle Abernathy",
    "FormalName": "O'Hara-Rutherford",
    "Deleted": true,
    "EjUserId": 916,
    "UserName": "Kertzmann, Keeling and Langosh",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 239
      }
    }
  },
  "MainHeading": "quasi",
  "MemberTabHeading": "et",
  "MailingsProviderName": "Olson LLC",
  "DashboardTileDefinitionId": 268,
  "VisibleFor": [
    {
      "VisibleId": 990,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    },
    {
      "VisibleId": 990,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 810
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
      "FieldLength": 715
    }
  }
}
```
