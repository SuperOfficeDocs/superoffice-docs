---
title: POST Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
id: v1SelectionAgent_CreateTemporaryContactSelectionFromContactPersonIds
---

# POST Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
```

Creates a temporary selection with members from a collection of ContactPerson id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds?$select=name,department,category/id
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

ContactPersonIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactPersonIds | array |  |


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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactPersonIds": [
    {
      "PersonId": 792,
      "ContactId": 994
    },
    {
      "PersonId": 792,
      "ContactId": 994
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Networked high-level portal",
  "Postit": "porro",
  "Associate": {
    "AssociateId": 379,
    "Name": "D'Amore-Feeney",
    "PersonId": 828,
    "Rank": 406,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 662,
    "FullName": "Miss Charles West",
    "FormalName": "Rippin-Wolf",
    "Deleted": false,
    "EjUserId": 413,
    "UserName": "Wunsch-Terry",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 366
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 937,
    "Name": "Treutel, Heathcote and Blick",
    "PersonId": 367,
    "Rank": 454,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 619,
    "FullName": "Joanne Pfannerstill",
    "FormalName": "Terry Group",
    "Deleted": true,
    "EjUserId": 213,
    "UserName": "Howell, Gaylord and Koch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 334
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 206,
    "Name": "Kuphal, Lehner and Metz",
    "PersonId": 317,
    "Rank": 463,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 165,
    "FullName": "Monica Glover",
    "FormalName": "Pfeffer-Greenfelder",
    "Deleted": true,
    "EjUserId": 96,
    "UserName": "Reilly LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "unleash viral initiatives"
        },
        "FieldType": "System.String",
        "FieldLength": 681
      }
    }
  },
  "SelectionCategory": {
    "Id": 286,
    "Value": "dolorem",
    "Tooltip": "aperiam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 649
      }
    }
  },
  "GroupIdx": 21,
  "IncludePerson": 568,
  "MemberCount": 45,
  "Name": "Strosin Group",
  "PostitTextId": 569,
  "CreatedDate": "2008-02-12T18:28:50.2444426+01:00",
  "SelectionId": 486,
  "SoundEx": "quibusdam",
  "Source": 569,
  "TextId": 171,
  "UpdatedDate": "2003-03-22T18:28:50.2444426+01:00",
  "UpdatedCount": 427,
  "Visibility": 425,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 631,
  "TargetTableName": "Ryan-Feest",
  "Completed": true,
  "LeftSelectionId": 486,
  "RightSelectionId": 790,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Hauck Inc and Sons",
  "ShadowProviderName": "Bailey, Rippin and Waters",
  "ChartKey": "aut",
  "LastLoaded": "2007-06-15T18:28:50.2454415+02:00",
  "LastLoadedBy": 222,
  "LastLoadedByAssociate": {
    "AssociateId": 509,
    "Name": "Jewess-Mayert",
    "PersonId": 256,
    "Rank": 879,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 116,
    "FullName": "Gregg Wisoky",
    "FormalName": "Langosh-Ernser",
    "Deleted": true,
    "EjUserId": 874,
    "UserName": "Johnston, Luettgen and Kautzer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 313
      }
    }
  },
  "LastMembershipChange": "2000-04-03T18:28:50.2454415+02:00",
  "LastMembershipChangeBy": 451,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 62,
    "Name": "Ledner-McClure",
    "PersonId": 899,
    "Rank": 204,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 776,
    "FullName": "Florence Kessler",
    "FormalName": "Padberg Group",
    "Deleted": false,
    "EjUserId": 939,
    "UserName": "Gleason LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 318
      }
    }
  },
  "MainHeading": "distinctio",
  "MemberTabHeading": "omnis",
  "MailingsProviderName": "Heidenreich, Welch and Bogisich",
  "DashboardTileDefinitionId": 253,
  "VisibleFor": [
    {
      "VisibleId": 119,
      "Visibility": "All",
      "DisplayValue": "eum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    },
    {
      "VisibleId": 119,
      "Visibility": "All",
      "DisplayValue": "eum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 385
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
      "FieldLength": 253
    }
  }
}
```