---
title: POST Selection
id: v1SelectionEntity_PostSelectionEntity
---

# POST Selection

```http
POST /api/v1/Selection
```

Creates a new SelectionEntity

Calls the Selection agent service SaveSelectionEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Selection?$select=name,department,category/id
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

## Request Body: newEntity  

The SelectionEntity to be saved. 

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


## Response: object




SelectionEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Selection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Description": "Front-line system-worthy middleware",
  "Postit": "voluptate",
  "Associate": {
    "AssociateId": 179,
    "Name": "Watsica, Jakubowski and Bosco",
    "PersonId": 824,
    "Rank": 408,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 208,
    "FullName": "Keagan Schuppe",
    "FormalName": "Boyle-Padberg",
    "Deleted": true,
    "EjUserId": 722,
    "UserName": "Waters LLC"
  },
  "CreatedBy": {
    "AssociateId": 843,
    "Name": "Hickle-Simonis",
    "PersonId": 166,
    "Rank": 467,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 451,
    "FullName": "Elena Funk",
    "FormalName": "Koss Group",
    "Deleted": true,
    "EjUserId": 39,
    "UserName": "Nicolas-Wolf"
  },
  "UpdatedBy": {
    "AssociateId": 786,
    "Name": "Boyer LLC",
    "PersonId": 632,
    "Rank": 607,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 900,
    "FullName": "Jaunita Murphy",
    "FormalName": "Jacobs Inc and Sons",
    "Deleted": true,
    "EjUserId": 659,
    "UserName": "Feest, Powlowski and Greenholt"
  },
  "SelectionCategory": {
    "Id": 758,
    "Value": "voluptatem",
    "Tooltip": "totam"
  },
  "GroupIdx": 628,
  "IncludePerson": 930,
  "MemberCount": 956,
  "Name": "Ritchie, Greenholt and Marks",
  "PostitTextId": 58,
  "CreatedDate": "2014-08-06T18:25:51.0759449+02:00",
  "SelectionId": 273,
  "SoundEx": "sed",
  "Source": 861,
  "TextId": 384,
  "UpdatedDate": "2008-09-05T18:25:51.0759449+02:00",
  "UpdatedCount": 190,
  "Visibility": 553,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 626,
  "TargetTableName": "Bernhard, Quigley and Stokes",
  "Completed": true,
  "LeftSelectionId": 536,
  "RightSelectionId": 402,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Lakin-Mann",
  "ShadowProviderName": "Bergstrom-Collins",
  "ChartKey": "optio",
  "LastLoaded": "1998-09-17T18:25:51.0759449+02:00",
  "LastLoadedBy": 217,
  "LastLoadedByAssociate": {
    "AssociateId": 29,
    "Name": "Beier Inc and Sons",
    "PersonId": 137,
    "Rank": 769,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 855,
    "FullName": "Bennie DuBuque II",
    "FormalName": "Weimann-Mills",
    "Deleted": false,
    "EjUserId": 222,
    "UserName": "Gutkowski Inc and Sons"
  },
  "LastMembershipChange": "1997-06-06T18:25:51.0759449+02:00",
  "LastMembershipChangeBy": 291,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 568,
    "Name": "Purdy, Treutel and Kohler",
    "PersonId": 726,
    "Rank": 435,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 147,
    "FullName": "Kendall Schaden",
    "FormalName": "Weissnat, Sipes and Gaylord",
    "Deleted": true,
    "EjUserId": 549,
    "UserName": "Homenick Inc and Sons"
  },
  "MainHeading": "necessitatibus",
  "MemberTabHeading": "sed",
  "MailingsProviderName": "Krajcik-Rolfson",
  "DashboardTileDefinitionId": 915,
  "VisibleFor": [
    {
      "VisibleId": 824,
      "Visibility": "All",
      "DisplayValue": "sint"
    },
    {
      "VisibleId": 824,
      "Visibility": "All",
      "DisplayValue": "sint"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Optional static frame",
  "Postit": "adipisci",
  "Associate": {
    "AssociateId": 443,
    "Name": "Torp-Walsh",
    "PersonId": 809,
    "Rank": 100,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 86,
    "FullName": "Sophia Nikolaus",
    "FormalName": "Parisian, Veum and Stamm",
    "Deleted": true,
    "EjUserId": 82,
    "UserName": "O'Kon-Paucek",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 204
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 634,
    "Name": "Mohr, Rowe and Runolfsdottir",
    "PersonId": 862,
    "Rank": 199,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 642,
    "FullName": "Mohammad Jenkins",
    "FormalName": "Daniel-Walter",
    "Deleted": false,
    "EjUserId": 768,
    "UserName": "Beatty-Cummerata",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 519
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 279,
    "Name": "Leuschke Group",
    "PersonId": 624,
    "Rank": 585,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 911,
    "FullName": "Ms. Emmalee Simonis",
    "FormalName": "Paucek, Abernathy and O'Kon",
    "Deleted": true,
    "EjUserId": 914,
    "UserName": "Orn-Schmitt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 536
      }
    }
  },
  "SelectionCategory": {
    "Id": 183,
    "Value": "totam",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 871
      }
    }
  },
  "GroupIdx": 420,
  "IncludePerson": 221,
  "MemberCount": 402,
  "Name": "Mueller Inc and Sons",
  "PostitTextId": 948,
  "CreatedDate": "2004-09-18T18:25:51.0819454+02:00",
  "SelectionId": 124,
  "SoundEx": "esse",
  "Source": 939,
  "TextId": 736,
  "UpdatedDate": "2011-11-20T18:25:51.0819454+01:00",
  "UpdatedCount": 164,
  "Visibility": 441,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 917,
  "TargetTableName": "Lebsack-Beer",
  "Completed": false,
  "LeftSelectionId": 626,
  "RightSelectionId": 50,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Abbott-Donnelly",
  "ShadowProviderName": "Hudson-Bins",
  "ChartKey": "eum",
  "LastLoaded": "2014-08-18T18:25:51.0819454+02:00",
  "LastLoadedBy": 786,
  "LastLoadedByAssociate": {
    "AssociateId": 259,
    "Name": "Green LLC",
    "PersonId": 723,
    "Rank": 177,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 599,
    "FullName": "Pansy Gutkowski",
    "FormalName": "Kirlin Inc and Sons",
    "Deleted": true,
    "EjUserId": 975,
    "UserName": "Hessel-Erdman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 670
      }
    }
  },
  "LastMembershipChange": "1995-12-28T18:25:51.0819454+01:00",
  "LastMembershipChangeBy": 431,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 467,
    "Name": "Heaney Group",
    "PersonId": 907,
    "Rank": 102,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 508,
    "FullName": "Shyann Heidenreich",
    "FormalName": "Reichert, Bauch and King",
    "Deleted": false,
    "EjUserId": 667,
    "UserName": "Walsh, Doyle and Collier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
      }
    }
  },
  "MainHeading": "deleniti",
  "MemberTabHeading": "quibusdam",
  "MailingsProviderName": "Ryan, Rodriguez and Trantow",
  "DashboardTileDefinitionId": 187,
  "VisibleFor": [
    {
      "VisibleId": 242,
      "Visibility": "All",
      "DisplayValue": "nobis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "innovate out-of-the-box e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    },
    {
      "VisibleId": 242,
      "Visibility": "All",
      "DisplayValue": "nobis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "innovate out-of-the-box e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 999
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
      "FieldLength": 5
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```