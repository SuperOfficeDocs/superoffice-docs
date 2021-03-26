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
  "Description": "Horizontal client-driven matrix",
  "Postit": "accusantium",
  "Associate": {
    "AssociateId": 467,
    "Name": "Gottlieb Group",
    "PersonId": 292,
    "Rank": 133,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 198,
    "FullName": "Mylene Hermiston Sr.",
    "FormalName": "Toy Group",
    "Deleted": false,
    "EjUserId": 659,
    "UserName": "Schmitt Inc and Sons"
  },
  "CreatedBy": {
    "AssociateId": 436,
    "Name": "Hahn-Bosco",
    "PersonId": 424,
    "Rank": 235,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 971,
    "FullName": "Katheryn Hansen",
    "FormalName": "McGlynn-Sawayn",
    "Deleted": true,
    "EjUserId": 434,
    "UserName": "Goyette, Yundt and Collins"
  },
  "UpdatedBy": {
    "AssociateId": 171,
    "Name": "Torphy LLC",
    "PersonId": 634,
    "Rank": 977,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 273,
    "FullName": "Flavie Rowe DDS",
    "FormalName": "Dooley-Quitzon",
    "Deleted": true,
    "EjUserId": 58,
    "UserName": "Kreiger Inc and Sons"
  },
  "SelectionCategory": {
    "Id": 809,
    "Value": "at",
    "Tooltip": "corporis"
  },
  "GroupIdx": 95,
  "IncludePerson": 454,
  "MemberCount": 226,
  "Name": "Larson-Cartwright",
  "PostitTextId": 299,
  "CreatedDate": "2012-12-27T09:40:59.7179968+01:00",
  "SelectionId": 222,
  "SoundEx": "sunt",
  "Source": 603,
  "TextId": 876,
  "UpdatedDate": "2004-06-07T09:40:59.7179968+02:00",
  "UpdatedCount": 125,
  "Visibility": 23,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 974,
  "TargetTableName": "Sanford-Hyatt",
  "Completed": false,
  "LeftSelectionId": 724,
  "RightSelectionId": 226,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "O'Keefe, Trantow and Graham",
  "ShadowProviderName": "Kris Group",
  "ChartKey": "iure",
  "LastLoaded": "2017-05-30T09:40:59.7198565+02:00",
  "LastLoadedBy": 725,
  "LastLoadedByAssociate": {
    "AssociateId": 844,
    "Name": "Feeney, Koelpin and Labadie",
    "PersonId": 167,
    "Rank": 996,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 410,
    "FullName": "Derek Corwin",
    "FormalName": "Thiel-Bednar",
    "Deleted": false,
    "EjUserId": 697,
    "UserName": "Kuphal-DuBuque"
  },
  "LastMembershipChange": "2013-03-04T09:40:59.7198565+01:00",
  "LastMembershipChangeBy": 158,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 644,
    "Name": "Weber-Cartwright",
    "PersonId": 608,
    "Rank": 625,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 300,
    "FullName": "Lilyan Rippin",
    "FormalName": "Glover Inc and Sons",
    "Deleted": false,
    "EjUserId": 103,
    "UserName": "Bayer-Luettgen"
  },
  "MainHeading": "quidem",
  "MemberTabHeading": "animi",
  "MailingsProviderName": "Walker-Considine",
  "VisibleFor": [
    {
      "VisibleId": 695,
      "Visibility": "All",
      "DisplayValue": "quidem"
    },
    {
      "VisibleId": 695,
      "Visibility": "All",
      "DisplayValue": "quidem"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Decentralized actuating model",
  "Postit": "voluptatem",
  "Associate": {
    "AssociateId": 619,
    "Name": "Stanton LLC",
    "PersonId": 719,
    "Rank": 24,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 792,
    "FullName": "Bernard Hodkiewicz",
    "FormalName": "Rutherford Inc and Sons",
    "Deleted": false,
    "EjUserId": 408,
    "UserName": "Dach, Metz and Medhurst",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 178
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 575,
    "Name": "Treutel LLC",
    "PersonId": 28,
    "Rank": 847,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 932,
    "FullName": "Kara Lemke",
    "FormalName": "Hintz, Koelpin and Hegmann",
    "Deleted": false,
    "EjUserId": 919,
    "UserName": "Morissette Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 655
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 713,
    "Name": "Reichel-Bailey",
    "PersonId": 381,
    "Rank": 50,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 787,
    "FullName": "Mikayla Runolfsdottir",
    "FormalName": "Greenholt-Mann",
    "Deleted": false,
    "EjUserId": 844,
    "UserName": "Bradtke Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 247
      }
    }
  },
  "SelectionCategory": {
    "Id": 344,
    "Value": "at",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 374
      }
    }
  },
  "GroupIdx": 136,
  "IncludePerson": 435,
  "MemberCount": 94,
  "Name": "Lowe-Rodriguez",
  "PostitTextId": 121,
  "CreatedDate": "1994-01-06T09:40:59.7238901+01:00",
  "SelectionId": 234,
  "SoundEx": "autem",
  "Source": 632,
  "TextId": 805,
  "UpdatedDate": "2010-12-25T09:40:59.7238901+01:00",
  "UpdatedCount": 982,
  "Visibility": 52,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 704,
  "TargetTableName": "Sawayn-Kohler",
  "Completed": false,
  "LeftSelectionId": 587,
  "RightSelectionId": 779,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Mante Group",
  "ShadowProviderName": "McCullough, Parker and Rosenbaum",
  "ChartKey": "voluptate",
  "LastLoaded": "1997-09-08T09:40:59.7238901+02:00",
  "LastLoadedBy": 475,
  "LastLoadedByAssociate": {
    "AssociateId": 109,
    "Name": "Koelpin Group",
    "PersonId": 878,
    "Rank": 14,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 540,
    "FullName": "Scot Labadie",
    "FormalName": "Dicki, Grady and Leuschke",
    "Deleted": false,
    "EjUserId": 669,
    "UserName": "Labadie, Roob and Langosh",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 249
      }
    }
  },
  "LastMembershipChange": "2021-01-30T09:40:59.7248931+01:00",
  "LastMembershipChangeBy": 113,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 873,
    "Name": "Wintheiser-Carter",
    "PersonId": 579,
    "Rank": 363,
    "Tooltip": "labore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 908,
    "FullName": "Garrison Flatley",
    "FormalName": "Kunze LLC",
    "Deleted": false,
    "EjUserId": 476,
    "UserName": "Hudson, Hyatt and Erdman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "MainHeading": "omnis",
  "MemberTabHeading": "molestiae",
  "MailingsProviderName": "Runolfsdottir, Doyle and Farrell",
  "VisibleFor": [
    {
      "VisibleId": 746,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "VisibleId": 746,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 47
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
      "FieldLength": 595
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```