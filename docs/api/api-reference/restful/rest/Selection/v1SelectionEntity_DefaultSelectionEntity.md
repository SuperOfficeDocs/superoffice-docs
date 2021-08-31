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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 10 Nov 2020 15:05:42 G11T

{
  "Description": "Self-enabling dynamic support",
  "Postit": "corrupti",
  "Associate": {
    "AssociateId": 350,
    "Name": "Harris, Schulist and Williamson",
    "PersonId": 312,
    "Rank": 205,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 721,
    "FullName": "Mrs. Owen Dach",
    "FormalName": "Boyle-Bode",
    "Deleted": true,
    "EjUserId": 52,
    "UserName": "Lesch-Armstrong",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 286
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 578,
    "Name": "Corwin Group",
    "PersonId": 534,
    "Rank": 581,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 776,
    "FullName": "Braulio Tromp",
    "FormalName": "Kertzmann, Mitchell and Muller",
    "Deleted": false,
    "EjUserId": 621,
    "UserName": "Green-DuBuque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 780
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 516,
    "Name": "Schulist, Windler and Schowalter",
    "PersonId": 588,
    "Rank": 246,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 282,
    "FullName": "Cicero Kuhlman",
    "FormalName": "Gerlach-Corwin",
    "Deleted": false,
    "EjUserId": 156,
    "UserName": "Feeney, Bradtke and Crona",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 609
      }
    }
  },
  "SelectionCategory": {
    "Id": 146,
    "Value": "quis",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 44
      }
    }
  },
  "GroupIdx": 713,
  "IncludePerson": 59,
  "MemberCount": 967,
  "Name": "Torp-Swift",
  "PostitTextId": 323,
  "CreatedDate": "2005-02-28T15:05:42.7226684+01:00",
  "SelectionId": 325,
  "SoundEx": "et",
  "Source": 131,
  "TextId": 174,
  "UpdatedDate": "2020-11-10T15:05:42.7226684+01:00",
  "UpdatedCount": 57,
  "Visibility": 420,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 546,
  "TargetTableName": "Rice-Thompson",
  "Completed": false,
  "LeftSelectionId": 125,
  "RightSelectionId": 980,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Gaylord Group",
  "ShadowProviderName": "Gerhold, Keeling and Jones",
  "ChartKey": "unde",
  "LastLoaded": "2019-02-19T15:05:42.7226684+01:00",
  "LastLoadedBy": 862,
  "LastLoadedByAssociate": {
    "AssociateId": 798,
    "Name": "Herzog Group",
    "PersonId": 555,
    "Rank": 610,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 973,
    "FullName": "Emerald Kuhic",
    "FormalName": "Kling, Ebert and O'Conner",
    "Deleted": true,
    "EjUserId": 833,
    "UserName": "Spinka-Hodkiewicz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 674
      }
    }
  },
  "LastMembershipChange": "2008-04-08T15:05:42.7236685+02:00",
  "LastMembershipChangeBy": 379,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 221,
    "Name": "Schumm, Kreiger and Windler",
    "PersonId": 559,
    "Rank": 754,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 182,
    "FullName": "Reece Bosco",
    "FormalName": "Christiansen-Bergstrom",
    "Deleted": false,
    "EjUserId": 442,
    "UserName": "Schmitt, Ernser and Ryan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 20
      }
    }
  },
  "MainHeading": "veniam",
  "MemberTabHeading": "porro",
  "MailingsProviderName": "Carter, Hintz and Schroeder",
  "VisibleFor": [
    {
      "VisibleId": 775,
      "Visibility": "All",
      "DisplayValue": "aliquid",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enhance value-added synergies"
          },
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    },
    {
      "VisibleId": 775,
      "Visibility": "All",
      "DisplayValue": "aliquid",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enhance value-added synergies"
          },
          "FieldType": "System.Int32",
          "FieldLength": 561
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
      "FieldLength": 124
    }
  }
}
```