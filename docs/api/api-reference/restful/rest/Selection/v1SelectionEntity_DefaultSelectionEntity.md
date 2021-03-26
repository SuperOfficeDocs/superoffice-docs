---
title: GET Selection/default
id: v1SelectionEntity_DefaultSelectionEntity
---

# GET Selection/default

```http
GET /api/v1/Selection/default
```

Set default values into a new SelectionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Selection agent service CreateDefaultSelectionEntity.






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
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Selection/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 19 Apr 2015 09:40:59 G4T

{
  "Description": "Visionary dedicated moratorium",
  "Postit": "architecto",
  "Associate": {
    "AssociateId": 332,
    "Name": "Hand Inc and Sons",
    "PersonId": 309,
    "Rank": 998,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 762,
    "FullName": "Danial Larkin",
    "FormalName": "Hansen Group",
    "Deleted": false,
    "EjUserId": 393,
    "UserName": "Jerde, Schimmel and Keebler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 495
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 38,
    "Name": "Dickens, Dickens and Eichmann",
    "PersonId": 628,
    "Rank": 523,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 36,
    "FullName": "Neva Kling",
    "FormalName": "Goodwin-Champlin",
    "Deleted": false,
    "EjUserId": 939,
    "UserName": "Bosco, Cassin and Smitham",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit integrated content"
        },
        "FieldType": "System.Int32",
        "FieldLength": 901
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 792,
    "Name": "Barrows, Schulist and Willms",
    "PersonId": 601,
    "Rank": 173,
    "Tooltip": "unde",
    "Type": "AnonymousAssociate",
    "GroupIdx": 706,
    "FullName": "Paul Berge",
    "FormalName": "Wolf, Nikolaus and Kautzer",
    "Deleted": true,
    "EjUserId": 521,
    "UserName": "Kreiger LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 931
      }
    }
  },
  "SelectionCategory": {
    "Id": 859,
    "Value": "ex",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 303
      }
    }
  },
  "GroupIdx": 831,
  "IncludePerson": 939,
  "MemberCount": 498,
  "Name": "Brakus, Towne and Flatley",
  "PostitTextId": 975,
  "CreatedDate": "2018-05-26T09:40:59.6766629+02:00",
  "SelectionId": 584,
  "SoundEx": "omnis",
  "Source": 576,
  "TextId": 174,
  "UpdatedDate": "2015-04-19T09:40:59.6766629+02:00",
  "UpdatedCount": 356,
  "Visibility": 397,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 313,
  "TargetTableName": "Mann LLC",
  "Completed": true,
  "LeftSelectionId": 672,
  "RightSelectionId": 315,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Cartwright LLC",
  "ShadowProviderName": "Kerluke, McGlynn and Klein",
  "ChartKey": "cumque",
  "LastLoaded": "1995-09-13T09:40:59.6766629+02:00",
  "LastLoadedBy": 302,
  "LastLoadedByAssociate": {
    "AssociateId": 418,
    "Name": "Feil-Parisian",
    "PersonId": 360,
    "Rank": 821,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 871,
    "FullName": "Jeffrey Osinski DVM",
    "FormalName": "Cruickshank, Erdman and Gibson",
    "Deleted": false,
    "EjUserId": 448,
    "UserName": "Schamberger Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 804
      }
    }
  },
  "LastMembershipChange": "1996-09-10T09:40:59.6866922+02:00",
  "LastMembershipChangeBy": 191,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 121,
    "Name": "Langosh LLC",
    "PersonId": 96,
    "Rank": 346,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 210,
    "FullName": "Jaqueline Larkin",
    "FormalName": "Hansen Inc and Sons",
    "Deleted": false,
    "EjUserId": 965,
    "UserName": "Parisian, Johnston and Feest",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 216
      }
    }
  },
  "MainHeading": "est",
  "MemberTabHeading": "dolorem",
  "MailingsProviderName": "Armstrong, Parisian and Windler",
  "VisibleFor": [
    {
      "VisibleId": 165,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 91
        }
      }
    },
    {
      "VisibleId": 165,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 91
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
      "FieldLength": 760
    }
  }
}
```