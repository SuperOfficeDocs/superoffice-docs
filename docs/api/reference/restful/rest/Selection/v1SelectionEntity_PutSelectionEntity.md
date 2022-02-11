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
| DashboardTileDefinitionId | int32 | The associated tile definition |
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
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Description": "Persistent solution-oriented circuit",
  "Postit": "ipsum",
  "Associate": {
    "AssociateId": 899,
    "Name": "Friesen, Parker and Welch",
    "PersonId": 610,
    "Rank": 462,
    "Tooltip": "ratione",
    "Type": "AnonymousAssociate",
    "GroupIdx": 148,
    "FullName": "Joan Schaden",
    "FormalName": "Koss Group",
    "Deleted": true,
    "EjUserId": 929,
    "UserName": "Weissnat-Bayer"
  },
  "CreatedBy": {
    "AssociateId": 601,
    "Name": "Dibbert-O'Connell",
    "PersonId": 207,
    "Rank": 763,
    "Tooltip": "commodi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 247,
    "FullName": "Arvilla Bauch III",
    "FormalName": "Kub-VonRueden",
    "Deleted": true,
    "EjUserId": 669,
    "UserName": "Wiegand-Gutkowski"
  },
  "UpdatedBy": {
    "AssociateId": 846,
    "Name": "Nitzsche, Gerlach and Gulgowski",
    "PersonId": 274,
    "Rank": 627,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 231,
    "FullName": "Erika Mraz",
    "FormalName": "Greenholt-Jacobs",
    "Deleted": false,
    "EjUserId": 734,
    "UserName": "Zemlak, Turcotte and Cummings"
  },
  "SelectionCategory": {
    "Id": 419,
    "Value": "aut",
    "Tooltip": "atque"
  },
  "GroupIdx": 458,
  "IncludePerson": 455,
  "MemberCount": 863,
  "Name": "Boyer-Grimes",
  "PostitTextId": 787,
  "CreatedDate": "2010-06-21T18:25:51.0889452+02:00",
  "SelectionId": 8,
  "SoundEx": "laudantium",
  "Source": 510,
  "TextId": 740,
  "UpdatedDate": "2002-09-22T18:25:51.0889452+02:00",
  "UpdatedCount": 1001,
  "Visibility": 540,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 111,
  "TargetTableName": "Zboncak, Mueller and Bernier",
  "Completed": false,
  "LeftSelectionId": 698,
  "RightSelectionId": 171,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Miller, Fadel and Langworth",
  "ShadowProviderName": "Harvey-Conroy",
  "ChartKey": "autem",
  "LastLoaded": "1998-08-25T18:25:51.0889452+02:00",
  "LastLoadedBy": 718,
  "LastLoadedByAssociate": {
    "AssociateId": 757,
    "Name": "Smith Inc and Sons",
    "PersonId": 291,
    "Rank": 459,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 293,
    "FullName": "Loma Lynch",
    "FormalName": "Predovic-Bahringer",
    "Deleted": true,
    "EjUserId": 835,
    "UserName": "Trantow-Schumm"
  },
  "LastMembershipChange": "1996-07-12T18:25:51.0889452+02:00",
  "LastMembershipChangeBy": 987,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 844,
    "Name": "Sauer, Kautzer and Wisozk",
    "PersonId": 174,
    "Rank": 598,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 142,
    "FullName": "Arianna Blick",
    "FormalName": "Hartmann, Moore and Reynolds",
    "Deleted": true,
    "EjUserId": 130,
    "UserName": "Bauch Group"
  },
  "MainHeading": "sapiente",
  "MemberTabHeading": "ipsam",
  "MailingsProviderName": "Crona-Jast",
  "DashboardTileDefinitionId": 958,
  "VisibleFor": [
    {
      "VisibleId": 901,
      "Visibility": "All",
      "DisplayValue": "asperiores"
    },
    {
      "VisibleId": 901,
      "Visibility": "All",
      "DisplayValue": "asperiores"
    }
  ]
}
```

```http_
HTTP/1.1 200 SelectionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Pre-emptive leading edge Graphical User Interface",
  "Postit": "ducimus",
  "Associate": {
    "AssociateId": 730,
    "Name": "Gorczany LLC",
    "PersonId": 65,
    "Rank": 644,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 253,
    "FullName": "Aidan Bogan",
    "FormalName": "Kozey-Hirthe",
    "Deleted": false,
    "EjUserId": 830,
    "UserName": "Harvey-Casper",
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
  "CreatedBy": {
    "AssociateId": 735,
    "Name": "Harvey LLC",
    "PersonId": 50,
    "Rank": 422,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 719,
    "FullName": "Judah Brekke",
    "FormalName": "Ankunding, Ritchie and Schroeder",
    "Deleted": true,
    "EjUserId": 476,
    "UserName": "Hickle LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 949
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 732,
    "Name": "Schulist, Hane and Walker",
    "PersonId": 534,
    "Rank": 557,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 39,
    "FullName": "Keith Sipes",
    "FormalName": "Christiansen-Haag",
    "Deleted": false,
    "EjUserId": 152,
    "UserName": "Mann, Stiedemann and Nicolas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 246
      }
    }
  },
  "SelectionCategory": {
    "Id": 391,
    "Value": "iure",
    "Tooltip": "dicta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "visualize 24/7 markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 796
      }
    }
  },
  "GroupIdx": 794,
  "IncludePerson": 970,
  "MemberCount": 444,
  "Name": "Lubowitz-Prohaska",
  "PostitTextId": 870,
  "CreatedDate": "1996-04-13T18:25:51.0929468+02:00",
  "SelectionId": 645,
  "SoundEx": "ut",
  "Source": 41,
  "TextId": 682,
  "UpdatedDate": "2019-03-10T18:25:51.0939532+01:00",
  "UpdatedCount": 524,
  "Visibility": 382,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 219,
  "TargetTableName": "Morar Inc and Sons",
  "Completed": true,
  "LeftSelectionId": 121,
  "RightSelectionId": 945,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Welch, Klocko and Conroy",
  "ShadowProviderName": "Bednar Group",
  "ChartKey": "ea",
  "LastLoaded": "1997-09-06T18:25:51.0939532+02:00",
  "LastLoadedBy": 127,
  "LastLoadedByAssociate": {
    "AssociateId": 220,
    "Name": "Trantow LLC",
    "PersonId": 375,
    "Rank": 602,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 912,
    "FullName": "Jaron Reichel",
    "FormalName": "Boyle, Steuber and Kessler",
    "Deleted": true,
    "EjUserId": 506,
    "UserName": "Hammes, Predovic and Pfannerstill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 503
      }
    }
  },
  "LastMembershipChange": "2000-02-18T18:25:51.0939532+01:00",
  "LastMembershipChangeBy": 181,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 188,
    "Name": "Robel-Nienow",
    "PersonId": 257,
    "Rank": 656,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 242,
    "FullName": "Mireya Schowalter",
    "FormalName": "Will-Windler",
    "Deleted": true,
    "EjUserId": 741,
    "UserName": "Becker Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 83
      }
    }
  },
  "MainHeading": "occaecati",
  "MemberTabHeading": "qui",
  "MailingsProviderName": "Treutel-Boyle",
  "DashboardTileDefinitionId": 649,
  "VisibleFor": [
    {
      "VisibleId": 132,
      "Visibility": "All",
      "DisplayValue": "dolore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    },
    {
      "VisibleId": 132,
      "Visibility": "All",
      "DisplayValue": "dolore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 46
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
      "FieldLength": 514
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```