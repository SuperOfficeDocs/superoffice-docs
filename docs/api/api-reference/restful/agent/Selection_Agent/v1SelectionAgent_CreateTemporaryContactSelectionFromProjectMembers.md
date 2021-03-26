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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 856
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Quality-focused scalable superstructure",
  "Postit": "nemo",
  "Associate": {
    "AssociateId": 987,
    "Name": "Kozey-Sauer",
    "PersonId": 410,
    "Rank": 543,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 817,
    "FullName": "Eliseo Auer",
    "FormalName": "Anderson-Dibbert",
    "Deleted": true,
    "EjUserId": 161,
    "UserName": "Flatley LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 526
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 867,
    "Name": "Bartell, Heaney and Koelpin",
    "PersonId": 294,
    "Rank": 261,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 920,
    "FullName": "Lurline Stanton",
    "FormalName": "Hamill, Huel and Klocko",
    "Deleted": true,
    "EjUserId": 72,
    "UserName": "Dare-Hamill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 647
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 768,
    "Name": "Rice Inc and Sons",
    "PersonId": 884,
    "Rank": 966,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 424,
    "FullName": "Kennith Leannon",
    "FormalName": "Lemke-Bayer",
    "Deleted": false,
    "EjUserId": 95,
    "UserName": "Schaefer Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 478
      }
    }
  },
  "SelectionCategory": {
    "Id": 254,
    "Value": "odit",
    "Tooltip": "laborum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 649
      }
    }
  },
  "GroupIdx": 494,
  "IncludePerson": 732,
  "MemberCount": 239,
  "Name": "Barton, Armstrong and Hudson",
  "PostitTextId": 309,
  "CreatedDate": "2018-11-29T16:48:30.6809359+01:00",
  "SelectionId": 899,
  "SoundEx": "saepe",
  "Source": 727,
  "TextId": 623,
  "UpdatedDate": "1997-01-06T16:48:30.6809359+01:00",
  "UpdatedCount": 132,
  "Visibility": 761,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 476,
  "TargetTableName": "Harber-Brown",
  "Completed": false,
  "LeftSelectionId": 575,
  "RightSelectionId": 632,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Stehr Group",
  "ShadowProviderName": "Pfeffer, Hilll and Swift",
  "ChartKey": "aut",
  "LastLoaded": "1999-02-04T16:48:30.6809359+01:00",
  "LastLoadedBy": 615,
  "LastLoadedByAssociate": {
    "AssociateId": 60,
    "Name": "Hyatt Inc and Sons",
    "PersonId": 353,
    "Rank": 28,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 822,
    "FullName": "Keaton Stark Jr.",
    "FormalName": "Reilly, Hagenes and Crooks",
    "Deleted": false,
    "EjUserId": 684,
    "UserName": "Jacobson-Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 972
      }
    }
  },
  "LastMembershipChange": "2019-08-27T16:48:30.6809359+02:00",
  "LastMembershipChangeBy": 526,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 852,
    "Name": "Block-Hammes",
    "PersonId": 147,
    "Rank": 384,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 981,
    "FullName": "Mr. Yadira Brakus",
    "FormalName": "Waters, Grimes and Corkery",
    "Deleted": false,
    "EjUserId": 908,
    "UserName": "Maggio-Schimmel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enhance world-class infomediaries"
        },
        "FieldType": "System.Int32",
        "FieldLength": 551
      }
    }
  },
  "MainHeading": "illo",
  "MemberTabHeading": "veritatis",
  "MailingsProviderName": "Crist, Connelly and Feil",
  "VisibleFor": [
    {
      "VisibleId": 707,
      "Visibility": "All",
      "DisplayValue": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 562
        }
      }
    },
    {
      "VisibleId": 707,
      "Visibility": "All",
      "DisplayValue": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 562
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
      "FieldLength": 941
    }
  }
}
```