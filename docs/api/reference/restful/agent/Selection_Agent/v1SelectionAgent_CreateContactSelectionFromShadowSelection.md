---
title: POST Agents/Selection/CreateContactSelectionFromShadowSelection
id: v1SelectionAgent_CreateContactSelectionFromShadowSelection
---

# POST Agents/Selection/CreateContactSelectionFromShadowSelection

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
```

Creates a new contact selection based on contact selection members from an existing shadow sale, appointment, project or document selection.

The new selection will always be static even if the original selection is dynamic.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection?$select=name,department,category/id
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

SelectionId, Name 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Name | string |  |


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
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 762,
  "Name": "Christiansen-Schowalter"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Integrated grid-enabled emulation",
  "Postit": "nemo",
  "Associate": {
    "AssociateId": 114,
    "Name": "Fritsch Inc and Sons",
    "PersonId": 694,
    "Rank": 695,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 105,
    "FullName": "Miss Savanah VonRueden",
    "FormalName": "Torphy-Bruen",
    "Deleted": false,
    "EjUserId": 34,
    "UserName": "Hintz Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 536
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 21,
    "Name": "Torphy-Krajcik",
    "PersonId": 32,
    "Rank": 711,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 425,
    "FullName": "Roman Bogisich",
    "FormalName": "Gleason-Fadel",
    "Deleted": false,
    "EjUserId": 768,
    "UserName": "Effertz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 285
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 524,
    "Name": "Swift Group",
    "PersonId": 231,
    "Rank": 51,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 676,
    "FullName": "Evelyn Considine",
    "FormalName": "Hauck LLC",
    "Deleted": false,
    "EjUserId": 729,
    "UserName": "Metz Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 152
      }
    }
  },
  "SelectionCategory": {
    "Id": 965,
    "Value": "repellat",
    "Tooltip": "accusamus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 196
      }
    }
  },
  "GroupIdx": 510,
  "IncludePerson": 459,
  "MemberCount": 350,
  "Name": "Willms LLC",
  "PostitTextId": 72,
  "CreatedDate": "1995-11-08T18:28:50.1984475+01:00",
  "SelectionId": 931,
  "SoundEx": "esse",
  "Source": 883,
  "TextId": 776,
  "UpdatedDate": "2002-11-23T18:28:50.1984475+01:00",
  "UpdatedCount": 700,
  "Visibility": 659,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 586,
  "TargetTableName": "Anderson-Pfeffer",
  "Completed": false,
  "LeftSelectionId": 94,
  "RightSelectionId": 784,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ernser, Romaguera and Green",
  "ShadowProviderName": "Witting-Lakin",
  "ChartKey": "error",
  "LastLoaded": "1997-10-08T18:28:50.2024153+02:00",
  "LastLoadedBy": 208,
  "LastLoadedByAssociate": {
    "AssociateId": 321,
    "Name": "Schmeler, Ledner and Hamill",
    "PersonId": 906,
    "Rank": 585,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 656,
    "FullName": "Jason Skiles",
    "FormalName": "Greenholt, Hirthe and Deckow",
    "Deleted": false,
    "EjUserId": 678,
    "UserName": "Ledner Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 641
      }
    }
  },
  "LastMembershipChange": "2013-01-07T18:28:50.2024153+01:00",
  "LastMembershipChangeBy": 445,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 374,
    "Name": "Christiansen, Schumm and King",
    "PersonId": 717,
    "Rank": 417,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 786,
    "FullName": "Molly Langosh Jr.",
    "FormalName": "Walker Inc and Sons",
    "Deleted": true,
    "EjUserId": 634,
    "UserName": "Cole, Runolfsson and Roberts",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 73
      }
    }
  },
  "MainHeading": "cum",
  "MemberTabHeading": "voluptatem",
  "MailingsProviderName": "Walker Group",
  "DashboardTileDefinitionId": 364,
  "VisibleFor": [
    {
      "VisibleId": 526,
      "Visibility": "All",
      "DisplayValue": "sed",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    },
    {
      "VisibleId": 526,
      "Visibility": "All",
      "DisplayValue": "sed",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 493
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
      "FieldLength": 628
    }
  }
}
```