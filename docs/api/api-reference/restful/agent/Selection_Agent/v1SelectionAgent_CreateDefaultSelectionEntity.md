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
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/CreateDefaultSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Multi-lateral heuristic encryption",
  "Postit": "minima",
  "Associate": {
    "AssociateId": 778,
    "Name": "Little-Dibbert",
    "PersonId": 188,
    "Rank": 437,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 967,
    "FullName": "Dejuan Bauch",
    "FormalName": "Wyman, Gerlach and Crist",
    "Deleted": true,
    "EjUserId": 421,
    "UserName": "Rempel, Botsford and D'Amore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 896
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 225,
    "Name": "Maggio-Ratke",
    "PersonId": 589,
    "Rank": 398,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 675,
    "FullName": "Ayden Kirlin",
    "FormalName": "Parker LLC",
    "Deleted": false,
    "EjUserId": 298,
    "UserName": "McGlynn-Ferry",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 186
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 888,
    "Name": "Lockman-Parker",
    "PersonId": 303,
    "Rank": 687,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 983,
    "FullName": "Frederic Fritsch",
    "FormalName": "Stanton Inc and Sons",
    "Deleted": true,
    "EjUserId": 419,
    "UserName": "Reichert-Cummerata",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 467
      }
    }
  },
  "SelectionCategory": {
    "Id": 490,
    "Value": "expedita",
    "Tooltip": "expedita",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 530
      }
    }
  },
  "GroupIdx": 702,
  "IncludePerson": 919,
  "MemberCount": 267,
  "Name": "Gleason-Yundt",
  "PostitTextId": 271,
  "CreatedDate": "2000-08-14T16:48:30.6539361+02:00",
  "SelectionId": 912,
  "SoundEx": "labore",
  "Source": 263,
  "TextId": 432,
  "UpdatedDate": "2019-01-10T16:48:30.6539361+01:00",
  "UpdatedCount": 519,
  "Visibility": 363,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 229,
  "TargetTableName": "Aufderhar-Waelchi",
  "Completed": true,
  "LeftSelectionId": 503,
  "RightSelectionId": 219,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Kuvalis Inc and Sons",
  "ShadowProviderName": "Gerhold, Nitzsche and Brown",
  "ChartKey": "sint",
  "LastLoaded": "1995-09-12T16:48:30.6539361+02:00",
  "LastLoadedBy": 963,
  "LastLoadedByAssociate": {
    "AssociateId": 866,
    "Name": "Miller LLC",
    "PersonId": 414,
    "Rank": 58,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 60,
    "FullName": "Brook Toy",
    "FormalName": "Nikolaus, Marquardt and Ortiz",
    "Deleted": false,
    "EjUserId": 782,
    "UserName": "Runolfsdottir, Hettinger and Klein",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 26
      }
    }
  },
  "LastMembershipChange": "2018-09-18T16:48:30.6549359+02:00",
  "LastMembershipChangeBy": 601,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 154,
    "Name": "Mann, McDermott and Jacobi",
    "PersonId": 928,
    "Rank": 933,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 865,
    "FullName": "Maudie Ankunding",
    "FormalName": "Nicolas, Hickle and Douglas",
    "Deleted": true,
    "EjUserId": 621,
    "UserName": "Kertzmann Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 502
      }
    }
  },
  "MainHeading": "minus",
  "MemberTabHeading": "facere",
  "MailingsProviderName": "Wyman Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 54,
      "Visibility": "All",
      "DisplayValue": "iste",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 946
        }
      }
    },
    {
      "VisibleId": 54,
      "Visibility": "All",
      "DisplayValue": "iste",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 946
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
      "FieldLength": 353
    }
  }
}
```