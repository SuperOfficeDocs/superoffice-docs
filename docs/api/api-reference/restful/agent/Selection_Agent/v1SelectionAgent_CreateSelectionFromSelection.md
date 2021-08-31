---
title: CreateSelectionFromSelection
id: v1SelectionAgent_CreateSelectionFromSelection
---

# CreateSelectionFromSelection

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
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateSelectionFromSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 920,
  "Name": "Zemlak Inc and Sons",
  "TargetSelectionType": "Combined",
  "CopyMembers": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Innovative value-added project",
  "Postit": "qui",
  "Associate": {
    "AssociateId": 922,
    "Name": "Koch LLC",
    "PersonId": 558,
    "Rank": 852,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 744,
    "FullName": "Chad Luettgen Jr.",
    "FormalName": "Effertz-Graham",
    "Deleted": true,
    "EjUserId": 937,
    "UserName": "Rolfson, Zemlak and Towne",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 824
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 67,
    "Name": "Keeling Group",
    "PersonId": 279,
    "Rank": 760,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 234,
    "FullName": "Darlene Homenick",
    "FormalName": "Quitzon, Franecki and Nitzsche",
    "Deleted": true,
    "EjUserId": 302,
    "UserName": "Koss, Mohr and Kris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 81
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 644,
    "Name": "Kassulke, Gerlach and Deckow",
    "PersonId": 596,
    "Rank": 29,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 997,
    "FullName": "Harry King",
    "FormalName": "Graham Group",
    "Deleted": true,
    "EjUserId": 798,
    "UserName": "DuBuque-Baumbach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 20
      }
    }
  },
  "SelectionCategory": {
    "Id": 1001,
    "Value": "blanditiis",
    "Tooltip": "laboriosam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 466
      }
    }
  },
  "GroupIdx": 949,
  "IncludePerson": 878,
  "MemberCount": 975,
  "Name": "Nienow, Hermann and Metz",
  "PostitTextId": 387,
  "CreatedDate": "1999-04-30T14:58:05.2036285+02:00",
  "SelectionId": 648,
  "SoundEx": "rerum",
  "Source": 513,
  "TextId": 279,
  "UpdatedDate": "2012-10-26T14:58:05.2036285+02:00",
  "UpdatedCount": 504,
  "Visibility": 673,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 876,
  "TargetTableName": "Denesik-Davis",
  "Completed": true,
  "LeftSelectionId": 166,
  "RightSelectionId": 596,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Nader-Bosco",
  "ShadowProviderName": "Keeling Group",
  "ChartKey": "dolore",
  "LastLoaded": "2010-06-24T14:58:05.2036285+02:00",
  "LastLoadedBy": 7,
  "LastLoadedByAssociate": {
    "AssociateId": 744,
    "Name": "Donnelly LLC",
    "PersonId": 658,
    "Rank": 929,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 489,
    "FullName": "Mr. Cindy Ortiz",
    "FormalName": "Carroll, Schneider and Stracke",
    "Deleted": false,
    "EjUserId": 699,
    "UserName": "Langworth, Baumbach and Pagac",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 480
      }
    }
  },
  "LastMembershipChange": "1995-06-05T14:58:05.2046286+02:00",
  "LastMembershipChangeBy": 151,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 527,
    "Name": "Volkman LLC",
    "PersonId": 930,
    "Rank": 967,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 259,
    "FullName": "Mylene Bartell",
    "FormalName": "Mitchell LLC",
    "Deleted": true,
    "EjUserId": 425,
    "UserName": "Haley-Waters",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 336
      }
    }
  },
  "MainHeading": "fugit",
  "MemberTabHeading": "distinctio",
  "MailingsProviderName": "Doyle, Cartwright and Moen",
  "VisibleFor": [
    {
      "VisibleId": 985,
      "Visibility": "All",
      "DisplayValue": "eius",
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
    {
      "VisibleId": 985,
      "Visibility": "All",
      "DisplayValue": "eius",
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
        "Reason": "matrix interactive experiences"
      },
      "FieldType": "System.Int32",
      "FieldLength": 429
    }
  }
}
```