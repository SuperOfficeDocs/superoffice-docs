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
  "Description": "Persevering regional open architecture",
  "Postit": "exercitationem",
  "Associate": {
    "AssociateId": 91,
    "Name": "Prosacco Inc and Sons",
    "PersonId": 812,
    "Rank": 14,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 345,
    "FullName": "Kristian Hackett DVM",
    "FormalName": "Armstrong, Schuppe and Yundt",
    "Deleted": false,
    "EjUserId": 928,
    "UserName": "Rodriguez-Johns"
  },
  "CreatedBy": {
    "AssociateId": 220,
    "Name": "Schneider, Gislason and Hessel",
    "PersonId": 546,
    "Rank": 562,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 614,
    "FullName": "Milan Pfeffer",
    "FormalName": "Willms, Nienow and Schulist",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Kunde Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 301,
    "Name": "Gibson LLC",
    "PersonId": 769,
    "Rank": 803,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 345,
    "FullName": "Jeanne Koch",
    "FormalName": "Rogahn Group",
    "Deleted": true,
    "EjUserId": 503,
    "UserName": "Lakin, Feil and Predovic"
  },
  "SelectionCategory": {
    "Id": 419,
    "Value": "voluptas",
    "Tooltip": "accusantium"
  },
  "GroupIdx": 148,
  "IncludePerson": 115,
  "MemberCount": 438,
  "Name": "Gutkowski Group",
  "PostitTextId": 740,
  "CreatedDate": "2007-05-23T09:40:59.7328904+02:00",
  "SelectionId": 236,
  "SoundEx": "eaque",
  "Source": 795,
  "TextId": 545,
  "UpdatedDate": "1999-03-07T09:40:59.7328904+01:00",
  "UpdatedCount": 690,
  "Visibility": 970,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 203,
  "TargetTableName": "Wilkinson-Towne",
  "Completed": false,
  "LeftSelectionId": 120,
  "RightSelectionId": 158,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Schmidt, Mills and Moore",
  "ShadowProviderName": "Daugherty Group",
  "ChartKey": "possimus",
  "LastLoaded": "2006-05-21T09:40:59.7328904+02:00",
  "LastLoadedBy": 209,
  "LastLoadedByAssociate": {
    "AssociateId": 256,
    "Name": "Runolfsdottir-Reichert",
    "PersonId": 501,
    "Rank": 515,
    "Tooltip": "inventore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 457,
    "FullName": "Katherine Rempel",
    "FormalName": "Deckow Inc and Sons",
    "Deleted": false,
    "EjUserId": 75,
    "UserName": "Cremin Inc and Sons"
  },
  "LastMembershipChange": "1995-09-24T09:40:59.7328904+02:00",
  "LastMembershipChangeBy": 186,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 738,
    "Name": "Turcotte, Mraz and Batz",
    "PersonId": 861,
    "Rank": 18,
    "Tooltip": "ab",
    "Type": "AnonymousAssociate",
    "GroupIdx": 762,
    "FullName": "Lizzie Kemmer",
    "FormalName": "Klein-Hirthe",
    "Deleted": true,
    "EjUserId": 60,
    "UserName": "Olson-Goyette"
  },
  "MainHeading": "officiis",
  "MemberTabHeading": "debitis",
  "MailingsProviderName": "Crona Group",
  "VisibleFor": [
    {
      "VisibleId": 500,
      "Visibility": "All",
      "DisplayValue": "quia"
    },
    {
      "VisibleId": 500,
      "Visibility": "All",
      "DisplayValue": "quia"
    }
  ]
}
```

```http_
HTTP/1.1 200 SelectionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Reverse-engineered tertiary structure",
  "Postit": "exercitationem",
  "Associate": {
    "AssociateId": 968,
    "Name": "Stroman Inc and Sons",
    "PersonId": 385,
    "Rank": 124,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 482,
    "FullName": "Pearlie Olson",
    "FormalName": "Streich Group",
    "Deleted": true,
    "EjUserId": 401,
    "UserName": "Brekke Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 951
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 798,
    "Name": "Lang Group",
    "PersonId": 703,
    "Rank": 65,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 898,
    "FullName": "Adonis Mohr",
    "FormalName": "Russel, Terry and Beier",
    "Deleted": true,
    "EjUserId": 175,
    "UserName": "Treutel Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 610
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 495,
    "Name": "Adams, Huels and Sauer",
    "PersonId": 580,
    "Rank": 891,
    "Tooltip": "officia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 343,
    "FullName": "Pearl Jewess",
    "FormalName": "Luettgen, Schamberger and Hahn",
    "Deleted": true,
    "EjUserId": 662,
    "UserName": "Reichert-Hand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 529
      }
    }
  },
  "SelectionCategory": {
    "Id": 966,
    "Value": "maiores",
    "Tooltip": "praesentium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incubate scalable communities"
        },
        "FieldType": "System.Int32",
        "FieldLength": 116
      }
    }
  },
  "GroupIdx": 869,
  "IncludePerson": 125,
  "MemberCount": 352,
  "Name": "Smitham LLC",
  "PostitTextId": 601,
  "CreatedDate": "2011-10-03T09:40:59.7378876+02:00",
  "SelectionId": 758,
  "SoundEx": "laboriosam",
  "Source": 23,
  "TextId": 611,
  "UpdatedDate": "2003-11-20T09:40:59.7378876+01:00",
  "UpdatedCount": 880,
  "Visibility": 69,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 775,
  "TargetTableName": "Rippin-Bechtelar",
  "Completed": false,
  "LeftSelectionId": 209,
  "RightSelectionId": 604,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Daugherty, Price and Stamm",
  "ShadowProviderName": "Harber, Haley and Dooley",
  "ChartKey": "sed",
  "LastLoaded": "2015-12-29T09:40:59.7378876+01:00",
  "LastLoadedBy": 636,
  "LastLoadedByAssociate": {
    "AssociateId": 489,
    "Name": "Feil, Price and Russel",
    "PersonId": 927,
    "Rank": 714,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 406,
    "FullName": "Miss Loyce Klein",
    "FormalName": "Hodkiewicz, Schultz and Donnelly",
    "Deleted": true,
    "EjUserId": 488,
    "UserName": "O'Hara LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 10
      }
    }
  },
  "LastMembershipChange": "2001-11-21T09:40:59.7388903+01:00",
  "LastMembershipChangeBy": 412,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 83,
    "Name": "Terry-Collins",
    "PersonId": 974,
    "Rank": 77,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 2,
    "FullName": "Loyal Ankunding",
    "FormalName": "Rutherford Group",
    "Deleted": true,
    "EjUserId": 238,
    "UserName": "Jacobi, Schuster and Rippin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 320
      }
    }
  },
  "MainHeading": "illum",
  "MemberTabHeading": "eos",
  "MailingsProviderName": "Purdy, Gaylord and Frami",
  "VisibleFor": [
    {
      "VisibleId": 746,
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
          "FieldLength": 343
        }
      }
    },
    {
      "VisibleId": 746,
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
          "FieldLength": 343
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
      "FieldLength": 597
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```