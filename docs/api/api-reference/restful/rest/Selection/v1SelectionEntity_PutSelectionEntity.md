---
title: PUT Selection/{id}
id: v1SelectionEntity_PutSelectionEntity
---

# PUT Selection/{id}

```http
PUT /api/v1/Selection/{id}
```

Updates the existing SelectionEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SelectionEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Selection/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object




SelectionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SelectionEntity updated. |
| 412 | Update stopped because SelectionEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Description": "Compatible cohesive focus group",
  "Postit": "quia",
  "Associate": {
    "AssociateId": 896,
    "Name": "Mann, Hermann and Jacobi",
    "PersonId": 470,
    "Rank": 570,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 135,
    "FullName": "Johann Buckridge",
    "FormalName": "Durgan-Spinka",
    "Deleted": true,
    "EjUserId": 360,
    "UserName": "Blanda LLC"
  },
  "CreatedBy": {
    "AssociateId": 806,
    "Name": "Lehner-Wuckert",
    "PersonId": 918,
    "Rank": 483,
    "Tooltip": "possimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 163,
    "FullName": "Rebeka Hartmann",
    "FormalName": "Wyman-Kiehn",
    "Deleted": false,
    "EjUserId": 170,
    "UserName": "Luettgen, Graham and Gutmann"
  },
  "UpdatedBy": {
    "AssociateId": 878,
    "Name": "Berge-Jones",
    "PersonId": 328,
    "Rank": 497,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 745,
    "FullName": "Kayleigh Wolf Jr.",
    "FormalName": "Johnson, Lowe and Bogisich",
    "Deleted": true,
    "EjUserId": 742,
    "UserName": "Witting, Bode and Pollich"
  },
  "SelectionCategory": {
    "Id": 782,
    "Value": "modi",
    "Tooltip": "quaerat"
  },
  "GroupIdx": 191,
  "IncludePerson": 404,
  "MemberCount": 518,
  "Name": "Kunze Group",
  "PostitTextId": 935,
  "CreatedDate": "1996-07-15T15:05:42.7376673+02:00",
  "SelectionId": 492,
  "SoundEx": "consequatur",
  "Source": 503,
  "TextId": 782,
  "UpdatedDate": "2016-11-22T15:05:42.7376673+01:00",
  "UpdatedCount": 886,
  "Visibility": 690,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 964,
  "TargetTableName": "Lynch-Morissette",
  "Completed": false,
  "LeftSelectionId": 518,
  "RightSelectionId": 548,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Larkin, Hilpert and Nolan",
  "ShadowProviderName": "Glover Group",
  "ChartKey": "quibusdam",
  "LastLoaded": "2012-04-27T15:05:42.7376673+02:00",
  "LastLoadedBy": 616,
  "LastLoadedByAssociate": {
    "AssociateId": 505,
    "Name": "Herman-Torphy",
    "PersonId": 504,
    "Rank": 63,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 55,
    "FullName": "Clifton Abbott",
    "FormalName": "Pouros Inc and Sons",
    "Deleted": false,
    "EjUserId": 702,
    "UserName": "Morar-Zulauf"
  },
  "LastMembershipChange": "2007-10-20T15:05:42.7376673+02:00",
  "LastMembershipChangeBy": 31,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 766,
    "Name": "Littel-Sporer",
    "PersonId": 13,
    "Rank": 97,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 545,
    "FullName": "Mrs. Adrien Mohr",
    "FormalName": "Beer, Lueilwitz and Stehr",
    "Deleted": false,
    "EjUserId": 309,
    "UserName": "Braun-Hammes"
  },
  "MainHeading": "facilis",
  "MemberTabHeading": "aut",
  "MailingsProviderName": "Ziemann Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 728,
      "Visibility": "All",
      "DisplayValue": "ducimus"
    },
    {
      "VisibleId": 728,
      "Visibility": "All",
      "DisplayValue": "ducimus"
    }
  ]
}
```

```http_
HTTP/1.1 200 SelectionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Robust foreground model",
  "Postit": "et",
  "Associate": {
    "AssociateId": 311,
    "Name": "Thompson, Waters and Mertz",
    "PersonId": 41,
    "Rank": 585,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 886,
    "FullName": "Isadore Auer",
    "FormalName": "Haag LLC",
    "Deleted": true,
    "EjUserId": 966,
    "UserName": "Predovic Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 191
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 766,
    "Name": "Stoltenberg-Beahan",
    "PersonId": 500,
    "Rank": 700,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 838,
    "FullName": "Dr. Yadira West",
    "FormalName": "Wilkinson Inc and Sons",
    "Deleted": false,
    "EjUserId": 313,
    "UserName": "Carter-Kohler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 24
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 675,
    "Name": "Waters-Kemmer",
    "PersonId": 93,
    "Rank": 893,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 967,
    "FullName": "Shania Steuber",
    "FormalName": "Stark Inc and Sons",
    "Deleted": true,
    "EjUserId": 284,
    "UserName": "Stamm LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 556
      }
    }
  },
  "SelectionCategory": {
    "Id": 200,
    "Value": "placeat",
    "Tooltip": "ullam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 478
      }
    }
  },
  "GroupIdx": 26,
  "IncludePerson": 445,
  "MemberCount": 272,
  "Name": "Rodriguez Inc and Sons",
  "PostitTextId": 158,
  "CreatedDate": "2005-09-26T15:05:42.7416675+02:00",
  "SelectionId": 673,
  "SoundEx": "numquam",
  "Source": 441,
  "TextId": 696,
  "UpdatedDate": "2018-03-29T15:05:42.7416675+02:00",
  "UpdatedCount": 675,
  "Visibility": 874,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 490,
  "TargetTableName": "Murray LLC",
  "Completed": true,
  "LeftSelectionId": 190,
  "RightSelectionId": 882,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ullrich LLC",
  "ShadowProviderName": "Ward, Lowe and Wiegand",
  "ChartKey": "neque",
  "LastLoaded": "2010-06-27T15:05:42.7416675+02:00",
  "LastLoadedBy": 978,
  "LastLoadedByAssociate": {
    "AssociateId": 59,
    "Name": "Wilderman-Pollich",
    "PersonId": 810,
    "Rank": 350,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 505,
    "FullName": "Arden Donnelly",
    "FormalName": "Rice Group",
    "Deleted": false,
    "EjUserId": 846,
    "UserName": "Auer-Bode",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 251
      }
    }
  },
  "LastMembershipChange": "2014-12-08T15:05:42.7416675+01:00",
  "LastMembershipChangeBy": 696,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 217,
    "Name": "Kuhic-Haley",
    "PersonId": 965,
    "Rank": 266,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 536,
    "FullName": "Retha Haag",
    "FormalName": "Okuneva-Runolfsson",
    "Deleted": true,
    "EjUserId": 663,
    "UserName": "Conn, Shanahan and Dietrich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 793
      }
    }
  },
  "MainHeading": "saepe",
  "MemberTabHeading": "nobis",
  "MailingsProviderName": "Kertzmann, Macejkovic and O'Hara",
  "VisibleFor": [
    {
      "VisibleId": 585,
      "Visibility": "All",
      "DisplayValue": "amet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    },
    {
      "VisibleId": 585,
      "Visibility": "All",
      "DisplayValue": "amet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "optimize value-added paradigms"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 466
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```