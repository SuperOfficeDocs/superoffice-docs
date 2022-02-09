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
| DashboardTileDefinitionId | int32 | The associated tile definition |
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
Last-Modified: Wed, 14 Mar 2007 18:25:51 G3T

{
  "Description": "Optional well-modulated extranet",
  "Postit": "atque",
  "Associate": {
    "AssociateId": 314,
    "Name": "Lang-Dietrich",
    "PersonId": 923,
    "Rank": 746,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 72,
    "FullName": "Noemie Davis",
    "FormalName": "Buckridge-Lakin",
    "Deleted": true,
    "EjUserId": 843,
    "UserName": "Schinner-Muller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 512
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 462,
    "Name": "Metz, Littel and Bahringer",
    "PersonId": 155,
    "Rank": 214,
    "Tooltip": "illum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 304,
    "FullName": "Luis Purdy",
    "FormalName": "Greenholt-Lind",
    "Deleted": false,
    "EjUserId": 737,
    "UserName": "Mertz-Turcotte",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform proactive infrastructures"
        },
        "FieldType": "System.String",
        "FieldLength": 498
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 860,
    "Name": "Streich-Roob",
    "PersonId": 687,
    "Rank": 462,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 15,
    "FullName": "Niko Lang",
    "FormalName": "Dibbert-Schroeder",
    "Deleted": true,
    "EjUserId": 853,
    "UserName": "Vandervort LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 295
      }
    }
  },
  "SelectionCategory": {
    "Id": 917,
    "Value": "id",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 755
      }
    }
  },
  "GroupIdx": 960,
  "IncludePerson": 896,
  "MemberCount": 439,
  "Name": "Williamson-Frami",
  "PostitTextId": 887,
  "CreatedDate": "2020-07-06T18:25:51.0729454+02:00",
  "SelectionId": 344,
  "SoundEx": "illum",
  "Source": 708,
  "TextId": 85,
  "UpdatedDate": "2007-03-14T18:25:51.0729454+01:00",
  "UpdatedCount": 47,
  "Visibility": 275,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 987,
  "TargetTableName": "Ziemann, Ryan and Heidenreich",
  "Completed": true,
  "LeftSelectionId": 464,
  "RightSelectionId": 771,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Renner Group",
  "ShadowProviderName": "Torp Inc and Sons",
  "ChartKey": "ea",
  "LastLoaded": "2013-11-16T18:25:51.0729454+01:00",
  "LastLoadedBy": 376,
  "LastLoadedByAssociate": {
    "AssociateId": 556,
    "Name": "Toy, Balistreri and King",
    "PersonId": 743,
    "Rank": 81,
    "Tooltip": "officia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 24,
    "FullName": "Davon Krajcik",
    "FormalName": "Beahan, Nader and Rosenbaum",
    "Deleted": true,
    "EjUserId": 547,
    "UserName": "Conn-Dickens",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 578
      }
    }
  },
  "LastMembershipChange": "1997-11-03T18:25:51.0729454+01:00",
  "LastMembershipChangeBy": 936,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 418,
    "Name": "Cole Group",
    "PersonId": 901,
    "Rank": 403,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Mrs. Adell Swift",
    "FormalName": "Thiel, Heathcote and Kuhn",
    "Deleted": true,
    "EjUserId": 299,
    "UserName": "O'Keefe, Zulauf and Erdman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 703
      }
    }
  },
  "MainHeading": "dolor",
  "MemberTabHeading": "dolorem",
  "MailingsProviderName": "Boehm Inc and Sons",
  "DashboardTileDefinitionId": 507,
  "VisibleFor": [
    {
      "VisibleId": 892,
      "Visibility": "All",
      "DisplayValue": "architecto",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    },
    {
      "VisibleId": 892,
      "Visibility": "All",
      "DisplayValue": "architecto",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 218
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
      "FieldLength": 466
    }
  }
}
```