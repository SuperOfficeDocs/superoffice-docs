---
title: CreateTemporarySelectionFromIds
id: v1SelectionAgent_CreateTemporarySelectionFromIds
---

# CreateTemporarySelectionFromIds

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Ids": [
    708,
    306
  ],
  "TargetTableNumber": 671
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Ameliorated executive focus group",
  "Postit": "et",
  "Associate": {
    "AssociateId": 642,
    "Name": "Stracke, Ryan and Kertzmann",
    "PersonId": 81,
    "Rank": 323,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 234,
    "FullName": "Nakia Romaguera PhD",
    "FormalName": "Harvey LLC",
    "Deleted": false,
    "EjUserId": 167,
    "UserName": "Prohaska-Upton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 28
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 462,
    "Name": "Fay-Hartmann",
    "PersonId": 577,
    "Rank": 742,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 318,
    "FullName": "Dorris Koss",
    "FormalName": "Kemmer Group",
    "Deleted": true,
    "EjUserId": 212,
    "UserName": "Hagenes-Marquardt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 792
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 698,
    "Name": "Pfeffer Group",
    "PersonId": 950,
    "Rank": 303,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 862,
    "FullName": "Mallory Wehner",
    "FormalName": "Kertzmann-Marquardt",
    "Deleted": false,
    "EjUserId": 436,
    "UserName": "Stracke, Grimes and Dare",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 470
      }
    }
  },
  "SelectionCategory": {
    "Id": 354,
    "Value": "aut",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 880
      }
    }
  },
  "GroupIdx": 726,
  "IncludePerson": 481,
  "MemberCount": 884,
  "Name": "Armstrong-Nolan",
  "PostitTextId": 122,
  "CreatedDate": "2010-03-15T14:58:05.1986282+01:00",
  "SelectionId": 322,
  "SoundEx": "voluptas",
  "Source": 504,
  "TextId": 555,
  "UpdatedDate": "2019-01-28T14:58:05.1986282+01:00",
  "UpdatedCount": 741,
  "Visibility": 644,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 828,
  "TargetTableName": "Larson-Bartoletti",
  "Completed": false,
  "LeftSelectionId": 235,
  "RightSelectionId": 482,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Davis-Miller",
  "ShadowProviderName": "Kling, Casper and Huel",
  "ChartKey": "porro",
  "LastLoaded": "2019-02-08T14:58:05.1996357+01:00",
  "LastLoadedBy": 50,
  "LastLoadedByAssociate": {
    "AssociateId": 972,
    "Name": "Emmerich, Dare and Rosenbaum",
    "PersonId": 666,
    "Rank": 950,
    "Tooltip": "delectus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 320,
    "FullName": "Ramona Ankunding III",
    "FormalName": "Beatty, Hermiston and Pouros",
    "Deleted": false,
    "EjUserId": 651,
    "UserName": "Bergstrom, Fay and Weimann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 206
      }
    }
  },
  "LastMembershipChange": "2018-08-26T14:58:05.1996357+02:00",
  "LastMembershipChangeBy": 776,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 381,
    "Name": "Medhurst-Barton",
    "PersonId": 622,
    "Rank": 609,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 798,
    "FullName": "Jordan Cormier",
    "FormalName": "West Group",
    "Deleted": false,
    "EjUserId": 68,
    "UserName": "Heaney-Johnson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 988
      }
    }
  },
  "MainHeading": "maiores",
  "MemberTabHeading": "itaque",
  "MailingsProviderName": "Jast Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 857,
      "Visibility": "All",
      "DisplayValue": "officia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 109
        }
      }
    },
    {
      "VisibleId": 857,
      "Visibility": "All",
      "DisplayValue": "officia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 109
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
      "FieldLength": 471
    }
  }
}
```