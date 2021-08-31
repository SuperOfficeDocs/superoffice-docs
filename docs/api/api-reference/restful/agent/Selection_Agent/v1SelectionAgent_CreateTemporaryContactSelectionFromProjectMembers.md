---
title: CreateTemporaryContactSelectionFromProjectMembers
id: v1SelectionAgent_CreateTemporaryContactSelectionFromProjectMembers
---

# CreateTemporaryContactSelectionFromProjectMembers

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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 454
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Balanced zero defect orchestration",
  "Postit": "facilis",
  "Associate": {
    "AssociateId": 402,
    "Name": "VonRueden-Runte",
    "PersonId": 951,
    "Rank": 539,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 509,
    "FullName": "Vicente Muller",
    "FormalName": "Kshlerin LLC",
    "Deleted": false,
    "EjUserId": 937,
    "UserName": "Hilll, Stokes and Gerhold",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 990
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 515,
    "Name": "Schoen-Hintz",
    "PersonId": 532,
    "Rank": 464,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 815,
    "FullName": "Valentine Jakubowski IV",
    "FormalName": "Streich-Renner",
    "Deleted": false,
    "EjUserId": 120,
    "UserName": "Lubowitz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 54
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 919,
    "Name": "Sawayn-Conroy",
    "PersonId": 963,
    "Rank": 630,
    "Tooltip": "sapiente",
    "Type": "AnonymousAssociate",
    "GroupIdx": 131,
    "FullName": "Elsa Wolf",
    "FormalName": "Feest, Pouros and Rath",
    "Deleted": false,
    "EjUserId": 460,
    "UserName": "Legros, Gulgowski and Skiles",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 173
      }
    }
  },
  "SelectionCategory": {
    "Id": 976,
    "Value": "ab",
    "Tooltip": "facere",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 147
      }
    }
  },
  "GroupIdx": 149,
  "IncludePerson": 389,
  "MemberCount": 854,
  "Name": "Fahey-Kiehn",
  "PostitTextId": 466,
  "CreatedDate": "2010-08-11T14:58:05.3096282+02:00",
  "SelectionId": 498,
  "SoundEx": "voluptatem",
  "Source": 208,
  "TextId": 838,
  "UpdatedDate": "1998-02-17T14:58:05.3096282+01:00",
  "UpdatedCount": 754,
  "Visibility": 802,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 524,
  "TargetTableName": "Roberts-Schamberger",
  "Completed": false,
  "LeftSelectionId": 405,
  "RightSelectionId": 458,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Wiza-Breitenberg",
  "ShadowProviderName": "Breitenberg-Kunde",
  "ChartKey": "sunt",
  "LastLoaded": "2006-09-16T14:58:05.3096282+02:00",
  "LastLoadedBy": 326,
  "LastLoadedByAssociate": {
    "AssociateId": 820,
    "Name": "Quitzon, Bogan and Sipes",
    "PersonId": 432,
    "Rank": 500,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 139,
    "FullName": "Elenora Ernser",
    "FormalName": "Wisoky Group",
    "Deleted": false,
    "EjUserId": 404,
    "UserName": "Rutherford-Kilback",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 492
      }
    }
  },
  "LastMembershipChange": "2013-07-01T14:58:05.3096282+02:00",
  "LastMembershipChangeBy": 879,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 316,
    "Name": "Smitham-Rodriguez",
    "PersonId": 315,
    "Rank": 429,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 438,
    "FullName": "Elyssa Greenfelder",
    "FormalName": "Stroman-Kuhlman",
    "Deleted": false,
    "EjUserId": 952,
    "UserName": "Tillman, Koepp and Connelly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 190
      }
    }
  },
  "MainHeading": "quis",
  "MemberTabHeading": "incidunt",
  "MailingsProviderName": "Heaney Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 622,
      "Visibility": "All",
      "DisplayValue": "consequuntur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    },
    {
      "VisibleId": 622,
      "Visibility": "All",
      "DisplayValue": "consequuntur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 243
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
        "Reason": "evolve robust ROI"
      },
      "FieldType": "System.String",
      "FieldLength": 625
    }
  }
}
```