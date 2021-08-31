---
title: CreateDefaultSelectionEntity
id: v1SelectionAgent_CreateDefaultSelectionEntity
---

# CreateDefaultSelectionEntity

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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Implemented actuating forecast",
  "Postit": "quisquam",
  "Associate": {
    "AssociateId": 565,
    "Name": "Crona-Schumm",
    "PersonId": 965,
    "Rank": 473,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 188,
    "FullName": "Harold McDermott",
    "FormalName": "Welch LLC",
    "Deleted": true,
    "EjUserId": 39,
    "UserName": "Torphy-Collier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 108
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 261,
    "Name": "Volkman-Legros",
    "PersonId": 17,
    "Rank": 289,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 693,
    "FullName": "Cleta Hayes II",
    "FormalName": "Armstrong, Weber and Berge",
    "Deleted": false,
    "EjUserId": 731,
    "UserName": "Willms, Breitenberg and Auer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "utilize wireless interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 858
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 1001,
    "Name": "Rath-Prosacco",
    "PersonId": 955,
    "Rank": 996,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 924,
    "FullName": "Cleo Hickle",
    "FormalName": "Hirthe, Waters and Parker",
    "Deleted": false,
    "EjUserId": 872,
    "UserName": "Nolan LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 413
      }
    }
  },
  "SelectionCategory": {
    "Id": 899,
    "Value": "repudiandae",
    "Tooltip": "cumque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 209
      }
    }
  },
  "GroupIdx": 708,
  "IncludePerson": 630,
  "MemberCount": 652,
  "Name": "Bahringer Inc and Sons",
  "PostitTextId": 656,
  "CreatedDate": "2018-12-28T14:58:05.2236284+01:00",
  "SelectionId": 809,
  "SoundEx": "voluptas",
  "Source": 742,
  "TextId": 282,
  "UpdatedDate": "2020-11-14T14:58:05.2236284+01:00",
  "UpdatedCount": 169,
  "Visibility": 340,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 390,
  "TargetTableName": "Kilback LLC",
  "Completed": true,
  "LeftSelectionId": 407,
  "RightSelectionId": 543,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Kuhn-Murray",
  "ShadowProviderName": "Kutch LLC",
  "ChartKey": "non",
  "LastLoaded": "2003-05-03T14:58:05.2236284+02:00",
  "LastLoadedBy": 304,
  "LastLoadedByAssociate": {
    "AssociateId": 35,
    "Name": "Stanton-White",
    "PersonId": 992,
    "Rank": 456,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 673,
    "FullName": "Avis Rogahn",
    "FormalName": "Kris, Kessler and Jerde",
    "Deleted": false,
    "EjUserId": 762,
    "UserName": "Collins Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 163
      }
    }
  },
  "LastMembershipChange": "2008-12-03T14:58:05.2236284+01:00",
  "LastMembershipChangeBy": 586,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 721,
    "Name": "Ebert-Rolfson",
    "PersonId": 361,
    "Rank": 866,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 442,
    "FullName": "Zackary Johns IV",
    "FormalName": "Strosin, Kreiger and Koch",
    "Deleted": false,
    "EjUserId": 706,
    "UserName": "Beier, Wolf and Ullrich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 790
      }
    }
  },
  "MainHeading": "molestiae",
  "MemberTabHeading": "eum",
  "MailingsProviderName": "Little, Gorczany and Crona",
  "VisibleFor": [
    {
      "VisibleId": 463,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 975
        }
      }
    },
    {
      "VisibleId": 463,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 975
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
      "FieldLength": 602
    }
  }
}
```