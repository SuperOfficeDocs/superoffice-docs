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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Description": "Expanded interactive migration",
  "Postit": "deserunt",
  "Associate": {
    "AssociateId": 650,
    "Name": "Schmidt-Schultz",
    "PersonId": 846,
    "Rank": 382,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 811,
    "FullName": "Florine Boyle",
    "FormalName": "Jaskolski, Ernser and Koss",
    "Deleted": true,
    "EjUserId": 681,
    "UserName": "Lehner Group"
  },
  "CreatedBy": {
    "AssociateId": 762,
    "Name": "Schmidt Inc and Sons",
    "PersonId": 856,
    "Rank": 607,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 294,
    "FullName": "Erick O'Conner",
    "FormalName": "Nolan-Koepp",
    "Deleted": false,
    "EjUserId": 597,
    "UserName": "Medhurst, Carroll and Wunsch"
  },
  "UpdatedBy": {
    "AssociateId": 228,
    "Name": "Olson, Borer and Rohan",
    "PersonId": 719,
    "Rank": 799,
    "Tooltip": "hic",
    "Type": "AnonymousAssociate",
    "GroupIdx": 62,
    "FullName": "Rae Satterfield",
    "FormalName": "Pacocha LLC",
    "Deleted": true,
    "EjUserId": 583,
    "UserName": "Ankunding Inc and Sons"
  },
  "SelectionCategory": {
    "Id": 432,
    "Value": "dolor",
    "Tooltip": "culpa"
  },
  "GroupIdx": 7,
  "IncludePerson": 270,
  "MemberCount": 85,
  "Name": "Weimann-Mitchell",
  "PostitTextId": 779,
  "CreatedDate": "1999-11-26T15:05:42.7256686+01:00",
  "SelectionId": 964,
  "SoundEx": "voluptas",
  "Source": 857,
  "TextId": 699,
  "UpdatedDate": "2008-09-13T15:05:42.7256686+02:00",
  "UpdatedCount": 408,
  "Visibility": 344,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 726,
  "TargetTableName": "Stracke, King and Ebert",
  "Completed": true,
  "LeftSelectionId": 745,
  "RightSelectionId": 14,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Dicki, Jaskolski and Toy",
  "ShadowProviderName": "Walter, Conn and Schiller",
  "ChartKey": "et",
  "LastLoaded": "2016-01-14T15:05:42.7256686+01:00",
  "LastLoadedBy": 122,
  "LastLoadedByAssociate": {
    "AssociateId": 323,
    "Name": "Wyman Inc and Sons",
    "PersonId": 165,
    "Rank": 761,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 609,
    "FullName": "Alvah Kutch",
    "FormalName": "Bayer-Ratke",
    "Deleted": false,
    "EjUserId": 61,
    "UserName": "Medhurst Group"
  },
  "LastMembershipChange": "2005-01-14T15:05:42.7266681+01:00",
  "LastMembershipChangeBy": 810,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 605,
    "Name": "Mosciski-Stehr",
    "PersonId": 930,
    "Rank": 560,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 182,
    "FullName": "Griffin Rogahn PhD",
    "FormalName": "Bayer-Hagenes",
    "Deleted": true,
    "EjUserId": 130,
    "UserName": "Hessel-Kunze"
  },
  "MainHeading": "iure",
  "MemberTabHeading": "aut",
  "MailingsProviderName": "Feil-Berge",
  "VisibleFor": [
    {
      "VisibleId": 855,
      "Visibility": "All",
      "DisplayValue": "quo"
    },
    {
      "VisibleId": 855,
      "Visibility": "All",
      "DisplayValue": "quo"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Centralized global challenge",
  "Postit": "excepturi",
  "Associate": {
    "AssociateId": 981,
    "Name": "Hoeger-Mohr",
    "PersonId": 275,
    "Rank": 457,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 561,
    "FullName": "Creola Goldner",
    "FormalName": "Harvey, Mills and Luettgen",
    "Deleted": true,
    "EjUserId": 146,
    "UserName": "Schmitt, Osinski and Gaylord",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 704
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 522,
    "Name": "Rice LLC",
    "PersonId": 685,
    "Rank": 347,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 713,
    "FullName": "Peter Bartell",
    "FormalName": "Friesen, Steuber and Ernser",
    "Deleted": false,
    "EjUserId": 398,
    "UserName": "Towne, Rau and Pagac",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 902
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 711,
    "Name": "Cremin Inc and Sons",
    "PersonId": 806,
    "Rank": 51,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 975,
    "FullName": "Lue Stroman",
    "FormalName": "Jakubowski-Marvin",
    "Deleted": false,
    "EjUserId": 33,
    "UserName": "Bruen-Dooley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 658
      }
    }
  },
  "SelectionCategory": {
    "Id": 408,
    "Value": "vel",
    "Tooltip": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 446
      }
    }
  },
  "GroupIdx": 134,
  "IncludePerson": 142,
  "MemberCount": 610,
  "Name": "Reichert-Rodriguez",
  "PostitTextId": 280,
  "CreatedDate": "2008-09-17T15:05:42.7306748+02:00",
  "SelectionId": 872,
  "SoundEx": "quaerat",
  "Source": 896,
  "TextId": 530,
  "UpdatedDate": "2011-05-16T15:05:42.7306748+02:00",
  "UpdatedCount": 485,
  "Visibility": 145,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 394,
  "TargetTableName": "Prohaska, Crona and Kuhic",
  "Completed": true,
  "LeftSelectionId": 532,
  "RightSelectionId": 400,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Johnston, Shanahan and Roob",
  "ShadowProviderName": "Wunsch-Johnston",
  "ChartKey": "ut",
  "LastLoaded": "1995-03-29T15:05:42.7306748+02:00",
  "LastLoadedBy": 369,
  "LastLoadedByAssociate": {
    "AssociateId": 310,
    "Name": "Skiles, Reilly and Parker",
    "PersonId": 938,
    "Rank": 775,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 331,
    "FullName": "Oda Rempel",
    "FormalName": "Rolfson Group",
    "Deleted": false,
    "EjUserId": 653,
    "UserName": "Zemlak-Hand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 45
      }
    }
  },
  "LastMembershipChange": "2018-04-07T15:05:42.7306748+02:00",
  "LastMembershipChangeBy": 882,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 914,
    "Name": "Block Inc and Sons",
    "PersonId": 179,
    "Rank": 420,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 978,
    "FullName": "Kattie Hegmann",
    "FormalName": "Larson, McLaughlin and Monahan",
    "Deleted": false,
    "EjUserId": 60,
    "UserName": "Dibbert Inc and Sons",
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
  "MainHeading": "maiores",
  "MemberTabHeading": "dolores",
  "MailingsProviderName": "Nienow, Schroeder and Trantow",
  "VisibleFor": [
    {
      "VisibleId": 851,
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
          "FieldLength": 675
        }
      }
    },
    {
      "VisibleId": 851,
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
          "FieldLength": 675
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
        "Reason": "enable one-to-one schemas"
      },
      "FieldType": "System.String",
      "FieldLength": 730
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```