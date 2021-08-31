---
title: CreateSelectionEntity
id: v1SelectionAgent_CreateSelectionEntity
---

# CreateSelectionEntity

```http
POST /api/v1/Agents/Selection/CreateSelectionEntity
```

Create (but do not save) a new selection entity, for the current user and the given target table; other fields populated as by CreateDefaultSelectionEntity()







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateSelectionEntity?$select=name,department,category/id
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

TargetTableName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetTableName | string |  |


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
POST /api/v1/Agents/Selection/CreateSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TargetTableName": "Zboncak, Kuhn and Rempel"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Optimized interactive task-force",
  "Postit": "ipsam",
  "Associate": {
    "AssociateId": 625,
    "Name": "Ortiz, Wiza and Reichert",
    "PersonId": 644,
    "Rank": 114,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 756,
    "FullName": "Nola McGlynn IV",
    "FormalName": "Mayert, Kuhic and Runolfsson",
    "Deleted": false,
    "EjUserId": 953,
    "UserName": "Lynch LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 172
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 353,
    "Name": "Langworth Inc and Sons",
    "PersonId": 220,
    "Rank": 570,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 326,
    "FullName": "Krystel Larson",
    "FormalName": "Pouros Inc and Sons",
    "Deleted": false,
    "EjUserId": 170,
    "UserName": "Jenkins, Nitzsche and Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 242
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 366,
    "Name": "Gerhold-Gusikowski",
    "PersonId": 273,
    "Rank": 216,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 670,
    "FullName": "Newton Bailey",
    "FormalName": "Heidenreich LLC",
    "Deleted": true,
    "EjUserId": 257,
    "UserName": "Deckow, Adams and Smith",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 535
      }
    }
  },
  "SelectionCategory": {
    "Id": 754,
    "Value": "non",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 205
      }
    }
  },
  "GroupIdx": 686,
  "IncludePerson": 627,
  "MemberCount": 541,
  "Name": "Lesch LLC",
  "PostitTextId": 579,
  "CreatedDate": "2000-11-06T14:58:05.2416291+01:00",
  "SelectionId": 26,
  "SoundEx": "vero",
  "Source": 145,
  "TextId": 563,
  "UpdatedDate": "2019-12-15T14:58:05.2416291+01:00",
  "UpdatedCount": 4,
  "Visibility": 53,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 988,
  "TargetTableName": "Ledner Inc and Sons",
  "Completed": false,
  "LeftSelectionId": 542,
  "RightSelectionId": 740,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Jerde Inc and Sons",
  "ShadowProviderName": "Becker Group",
  "ChartKey": "doloribus",
  "LastLoaded": "2003-06-21T14:58:05.2416291+02:00",
  "LastLoadedBy": 16,
  "LastLoadedByAssociate": {
    "AssociateId": 477,
    "Name": "Dooley Group",
    "PersonId": 431,
    "Rank": 78,
    "Tooltip": "iste",
    "Type": "AnonymousAssociate",
    "GroupIdx": 392,
    "FullName": "Ally Lebsack I",
    "FormalName": "Cormier-Stamm",
    "Deleted": false,
    "EjUserId": 678,
    "UserName": "Orn-Zulauf",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 165
      }
    }
  },
  "LastMembershipChange": "2002-09-26T14:58:05.2426286+02:00",
  "LastMembershipChangeBy": 706,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 690,
    "Name": "Boyle, Marks and Hyatt",
    "PersonId": 989,
    "Rank": 578,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 806,
    "FullName": "Reta Jacobs",
    "FormalName": "Hegmann-Glover",
    "Deleted": false,
    "EjUserId": 891,
    "UserName": "Pfannerstill, Turner and Bernier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 349
      }
    }
  },
  "MainHeading": "necessitatibus",
  "MemberTabHeading": "quis",
  "MailingsProviderName": "Hoppe LLC",
  "VisibleFor": [
    {
      "VisibleId": 870,
      "Visibility": "All",
      "DisplayValue": "dolorum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 125
        }
      }
    },
    {
      "VisibleId": 870,
      "Visibility": "All",
      "DisplayValue": "dolorum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 125
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
      "FieldLength": 266
    }
  }
}
```