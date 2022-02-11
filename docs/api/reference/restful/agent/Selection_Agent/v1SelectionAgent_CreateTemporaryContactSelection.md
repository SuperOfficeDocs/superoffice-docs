---
title: POST Agents/Selection/CreateTemporaryContactSelection
id: v1SelectionAgent_CreateTemporaryContactSelection
---

# POST Agents/Selection/CreateTemporaryContactSelection

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
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Universal hybrid flexibility",
  "Postit": "maxime",
  "Associate": {
    "AssociateId": 491,
    "Name": "Reichel-Ruecker",
    "PersonId": 147,
    "Rank": 654,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 797,
    "FullName": "Miss Aletha Thiel",
    "FormalName": "Klein Group",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Hammes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 216
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 689,
    "Name": "McLaughlin Group",
    "PersonId": 596,
    "Rank": 172,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 150,
    "FullName": "Paige Hessel",
    "FormalName": "Bechtelar Group",
    "Deleted": false,
    "EjUserId": 94,
    "UserName": "Kilback Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 64
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 285,
    "Name": "Reichel, Johnston and Hermiston",
    "PersonId": 513,
    "Rank": 309,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 704,
    "FullName": "Herbert Douglas",
    "FormalName": "West, Thiel and Ward",
    "Deleted": false,
    "EjUserId": 995,
    "UserName": "Stanton LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 845
      }
    }
  },
  "SelectionCategory": {
    "Id": 108,
    "Value": "rerum",
    "Tooltip": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 497
      }
    }
  },
  "GroupIdx": 59,
  "IncludePerson": 729,
  "MemberCount": 593,
  "Name": "Cremin-Trantow",
  "PostitTextId": 433,
  "CreatedDate": "2020-08-11T18:28:50.2564418+02:00",
  "SelectionId": 350,
  "SoundEx": "dolores",
  "Source": 894,
  "TextId": 377,
  "UpdatedDate": "2008-02-09T18:28:50.2564418+01:00",
  "UpdatedCount": 389,
  "Visibility": 638,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 998,
  "TargetTableName": "Barrows-Pfannerstill",
  "Completed": false,
  "LeftSelectionId": 148,
  "RightSelectionId": 670,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Wyman-Sporer",
  "ShadowProviderName": "D'Amore LLC",
  "ChartKey": "iusto",
  "LastLoaded": "1997-08-03T18:28:50.2564418+02:00",
  "LastLoadedBy": 154,
  "LastLoadedByAssociate": {
    "AssociateId": 340,
    "Name": "Spencer Inc and Sons",
    "PersonId": 419,
    "Rank": 600,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 953,
    "FullName": "Terrance Luettgen",
    "FormalName": "Stracke-Quigley",
    "Deleted": false,
    "EjUserId": 878,
    "UserName": "Hilpert-Walter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 423
      }
    }
  },
  "LastMembershipChange": "2009-08-21T18:28:50.2584414+02:00",
  "LastMembershipChangeBy": 203,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 282,
    "Name": "Skiles Inc and Sons",
    "PersonId": 942,
    "Rank": 617,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 607,
    "FullName": "Agustina Keebler",
    "FormalName": "Lockman, Keebler and Rau",
    "Deleted": true,
    "EjUserId": 556,
    "UserName": "Hessel-Doyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 971
      }
    }
  },
  "MainHeading": "tempora",
  "MemberTabHeading": "veniam",
  "MailingsProviderName": "Rolfson, Wisozk and Hyatt",
  "DashboardTileDefinitionId": 407,
  "VisibleFor": [
    {
      "VisibleId": 50,
      "Visibility": "All",
      "DisplayValue": "temporibus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    },
    {
      "VisibleId": 50,
      "Visibility": "All",
      "DisplayValue": "temporibus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 345
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
      "FieldLength": 378
    }
  }
}
```