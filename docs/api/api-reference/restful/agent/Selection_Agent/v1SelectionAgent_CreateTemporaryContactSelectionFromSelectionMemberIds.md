---
title: CreateTemporaryContactSelectionFromSelectionMemberIds
id: v1SelectionAgent_CreateTemporaryContactSelectionFromSelectionMemberIds
---

# CreateTemporaryContactSelectionFromSelectionMemberIds

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds
```

Creates a temporary selection with members from a collection of selectionmember id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds?$select=name,department,category/id
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

SelectionId, SelectionMemberIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| SelectionMemberIds | array |  |


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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromSelectionMemberIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 344,
  "SelectionMemberIds": [
    16,
    599
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Object-based client-driven collaboration",
  "Postit": "quis",
  "Associate": {
    "AssociateId": 308,
    "Name": "Beatty, Ratke and Olson",
    "PersonId": 505,
    "Rank": 81,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 845,
    "FullName": "Erwin Turner",
    "FormalName": "Christiansen Group",
    "Deleted": true,
    "EjUserId": 804,
    "UserName": "Nitzsche Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 283
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 38,
    "Name": "Zemlak, Ward and Schiller",
    "PersonId": 264,
    "Rank": 983,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 107,
    "FullName": "Maude Bernier",
    "FormalName": "Fadel Group",
    "Deleted": true,
    "EjUserId": 354,
    "UserName": "Torp LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 100
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 387,
    "Name": "Rempel, Cassin and Schimmel",
    "PersonId": 302,
    "Rank": 802,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 137,
    "FullName": "Zion McClure",
    "FormalName": "Yost, Raynor and D'Amore",
    "Deleted": true,
    "EjUserId": 825,
    "UserName": "Reynolds-Wisoky",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 399
      }
    }
  },
  "SelectionCategory": {
    "Id": 847,
    "Value": "libero",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 168
      }
    }
  },
  "GroupIdx": 617,
  "IncludePerson": 61,
  "MemberCount": 147,
  "Name": "Block, Haley and Mitchell",
  "PostitTextId": 758,
  "CreatedDate": "2019-03-25T14:58:05.32063+01:00",
  "SelectionId": 356,
  "SoundEx": "est",
  "Source": 170,
  "TextId": 901,
  "UpdatedDate": "2003-11-09T14:58:05.32063+01:00",
  "UpdatedCount": 236,
  "Visibility": 166,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 655,
  "TargetTableName": "Hagenes, Pfeffer and Willms",
  "Completed": false,
  "LeftSelectionId": 956,
  "RightSelectionId": 985,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Hartmann Inc and Sons",
  "ShadowProviderName": "Prosacco Group",
  "ChartKey": "distinctio",
  "LastLoaded": "2020-12-15T14:58:05.3216288+01:00",
  "LastLoadedBy": 222,
  "LastLoadedByAssociate": {
    "AssociateId": 746,
    "Name": "Champlin Inc and Sons",
    "PersonId": 330,
    "Rank": 84,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 498,
    "FullName": "Mr. Louie Crist",
    "FormalName": "Ernser, Hamill and Gutmann",
    "Deleted": true,
    "EjUserId": 186,
    "UserName": "Casper, Harris and Schneider",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 1000
      }
    }
  },
  "LastMembershipChange": "2019-10-25T14:58:05.3216288+02:00",
  "LastMembershipChangeBy": 437,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 531,
    "Name": "Ebert, Welch and Fay",
    "PersonId": 645,
    "Rank": 527,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 430,
    "FullName": "Dulce Kub",
    "FormalName": "Welch, Predovic and Braun",
    "Deleted": true,
    "EjUserId": 482,
    "UserName": "Bergstrom-Green",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 740
      }
    }
  },
  "MainHeading": "corrupti",
  "MemberTabHeading": "maiores",
  "MailingsProviderName": "Luettgen-Fisher",
  "VisibleFor": [
    {
      "VisibleId": 968,
      "Visibility": "All",
      "DisplayValue": "eligendi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    },
    {
      "VisibleId": 968,
      "Visibility": "All",
      "DisplayValue": "eligendi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 688
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
      "FieldLength": 846
    }
  }
}
```