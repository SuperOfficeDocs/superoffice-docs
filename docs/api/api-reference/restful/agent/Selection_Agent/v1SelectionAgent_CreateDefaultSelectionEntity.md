---
title: POST Agents/Selection/CreateDefaultSelectionEntity
id: v1SelectionAgent_CreateDefaultSelectionEntity
---

# POST Agents/Selection/CreateDefaultSelectionEntity

```http
POST /api/v1/Agents/Selection/CreateDefaultSelectionEntity
```

Set default values into a new SelectionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Selection/CreateDefaultSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Automated solution-oriented support",
  "Postit": "animi",
  "Associate": {
    "AssociateId": 987,
    "Name": "Waelchi, Schoen and Rodriguez",
    "PersonId": 40,
    "Rank": 994,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Nona Marvin",
    "FormalName": "Braun Inc and Sons",
    "Deleted": false,
    "EjUserId": 726,
    "UserName": "Schamberger, Ankunding and Gibson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 573
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 122,
    "Name": "Greenfelder-Heller",
    "PersonId": 952,
    "Rank": 668,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 69,
    "FullName": "Camryn Bosco",
    "FormalName": "Zemlak Group",
    "Deleted": false,
    "EjUserId": 804,
    "UserName": "Herzog Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 915
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 185,
    "Name": "Schowalter, Witting and Leuschke",
    "PersonId": 275,
    "Rank": 844,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 321,
    "FullName": "Alena Russel",
    "FormalName": "Beahan, Franecki and Von",
    "Deleted": true,
    "EjUserId": 702,
    "UserName": "Murray, McClure and Schmeler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 797
      }
    }
  },
  "SelectionCategory": {
    "Id": 777,
    "Value": "est",
    "Tooltip": "ipsam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 907
      }
    }
  },
  "GroupIdx": 358,
  "IncludePerson": 868,
  "MemberCount": 796,
  "Name": "Lind-Muller",
  "PostitTextId": 322,
  "CreatedDate": "2003-06-16T18:28:50.2164295+02:00",
  "SelectionId": 24,
  "SoundEx": "doloremque",
  "Source": 292,
  "TextId": 313,
  "UpdatedDate": "1998-02-15T18:28:50.2164295+01:00",
  "UpdatedCount": 556,
  "Visibility": 963,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 553,
  "TargetTableName": "Anderson Group",
  "Completed": false,
  "LeftSelectionId": 430,
  "RightSelectionId": 49,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ernser Group",
  "ShadowProviderName": "McLaughlin-Abshire",
  "ChartKey": "qui",
  "LastLoaded": "1997-06-19T18:28:50.2174131+02:00",
  "LastLoadedBy": 52,
  "LastLoadedByAssociate": {
    "AssociateId": 243,
    "Name": "Ernser Inc and Sons",
    "PersonId": 262,
    "Rank": 126,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 507,
    "FullName": "Kyleigh Botsford",
    "FormalName": "Bashirian-Grant",
    "Deleted": true,
    "EjUserId": 830,
    "UserName": "Mayert, Bahringer and Hickle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 99
      }
    }
  },
  "LastMembershipChange": "2002-09-29T18:28:50.2174131+02:00",
  "LastMembershipChangeBy": 540,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 952,
    "Name": "Hilll Inc and Sons",
    "PersonId": 977,
    "Rank": 505,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 546,
    "FullName": "Sherwood Mitchell",
    "FormalName": "Morar, Lind and Hills",
    "Deleted": true,
    "EjUserId": 130,
    "UserName": "Kihn-Gutkowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enhance granular web-readiness"
        },
        "FieldType": "System.String",
        "FieldLength": 700
      }
    }
  },
  "MainHeading": "qui",
  "MemberTabHeading": "nihil",
  "MailingsProviderName": "Douglas-Schaden",
  "DashboardTileDefinitionId": 139,
  "VisibleFor": [
    {
      "VisibleId": 295,
      "Visibility": "All",
      "DisplayValue": "nam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 962
        }
      }
    },
    {
      "VisibleId": 295,
      "Visibility": "All",
      "DisplayValue": "nam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 962
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
      "FieldLength": 337
    }
  }
}
```