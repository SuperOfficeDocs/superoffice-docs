---
title: SaveSelectionEntity
id: v1SelectionAgent_SaveSelectionEntity
---

# SaveSelectionEntity

```http
POST /api/v1/Agents/Selection/SaveSelectionEntity
```

Updates the existing SelectionEntity or creates a new SelectionEntity if the id parameter is empty








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
POST /api/v1/Agents/Selection/SaveSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Description": "Monitored contextually-based Graphical User Interface",
  "Postit": "voluptas",
  "Associate": {
    "AssociateId": 661,
    "Name": "Gutmann-Wunsch",
    "PersonId": 848,
    "Rank": 700,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 186,
    "FullName": "Abigail Swaniawski",
    "FormalName": "Rau LLC",
    "Deleted": false,
    "EjUserId": 725,
    "UserName": "Bode, Ullrich and Kub"
  },
  "CreatedBy": {
    "AssociateId": 4,
    "Name": "Abbott-Ryan",
    "PersonId": 527,
    "Rank": 419,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 415,
    "FullName": "Mckayla Morissette DDS",
    "FormalName": "Tillman Group",
    "Deleted": true,
    "EjUserId": 108,
    "UserName": "Murray Group"
  },
  "UpdatedBy": {
    "AssociateId": 14,
    "Name": "Streich, Johnson and O'Keefe",
    "PersonId": 193,
    "Rank": 831,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 939,
    "FullName": "Graciela Schmidt DVM",
    "FormalName": "D'Amore Inc and Sons",
    "Deleted": true,
    "EjUserId": 464,
    "UserName": "Wolff Group"
  },
  "SelectionCategory": {
    "Id": 169,
    "Value": "a",
    "Tooltip": "minus"
  },
  "GroupIdx": 834,
  "IncludePerson": 681,
  "MemberCount": 977,
  "Name": "Steuber-Effertz",
  "PostitTextId": 492,
  "CreatedDate": "2015-02-12T14:58:05.2256283+01:00",
  "SelectionId": 910,
  "SoundEx": "omnis",
  "Source": 310,
  "TextId": 653,
  "UpdatedDate": "2007-06-10T14:58:05.2256283+02:00",
  "UpdatedCount": 863,
  "Visibility": 550,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 363,
  "TargetTableName": "Turcotte-Schuppe",
  "Completed": true,
  "LeftSelectionId": 9,
  "RightSelectionId": 248,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Barton-Yost",
  "ShadowProviderName": "Schuster, Price and Weimann",
  "ChartKey": "tempore",
  "LastLoaded": "1997-10-05T14:58:05.2256283+02:00",
  "LastLoadedBy": 705,
  "LastLoadedByAssociate": {
    "AssociateId": 325,
    "Name": "Denesik Inc and Sons",
    "PersonId": 743,
    "Rank": 164,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 813,
    "FullName": "Bettie Fahey",
    "FormalName": "Crona-Mertz",
    "Deleted": false,
    "EjUserId": 832,
    "UserName": "Orn Group"
  },
  "LastMembershipChange": "2011-08-11T14:58:05.2266284+02:00",
  "LastMembershipChangeBy": 688,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 583,
    "Name": "Funk-Ebert",
    "PersonId": 285,
    "Rank": 64,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 990,
    "FullName": "Ima Cassin",
    "FormalName": "Bayer Inc and Sons",
    "Deleted": false,
    "EjUserId": 945,
    "UserName": "Lang, Hermiston and Zemlak"
  },
  "MainHeading": "possimus",
  "MemberTabHeading": "nam",
  "MailingsProviderName": "Bayer Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 663,
      "Visibility": "All",
      "DisplayValue": "a"
    },
    {
      "VisibleId": 663,
      "Visibility": "All",
      "DisplayValue": "a"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Object-based cohesive definition",
  "Postit": "officiis",
  "Associate": {
    "AssociateId": 586,
    "Name": "Hermiston, Rath and Tillman",
    "PersonId": 386,
    "Rank": 339,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 481,
    "FullName": "Tyrell Morissette",
    "FormalName": "Swaniawski Inc and Sons",
    "Deleted": true,
    "EjUserId": 457,
    "UserName": "Heidenreich-Fay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 586
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 147,
    "Name": "Flatley-Nitzsche",
    "PersonId": 686,
    "Rank": 571,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 529,
    "FullName": "Hobart Feeney",
    "FormalName": "Monahan-Mosciski",
    "Deleted": true,
    "EjUserId": 734,
    "UserName": "Gleichner-Jast",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 416
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 976,
    "Name": "Dicki, Ledner and Hermann",
    "PersonId": 564,
    "Rank": 808,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 859,
    "FullName": "Jeremie Bailey",
    "FormalName": "Hansen, Gerlach and Crooks",
    "Deleted": true,
    "EjUserId": 13,
    "UserName": "Zieme-Schulist",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 618
      }
    }
  },
  "SelectionCategory": {
    "Id": 163,
    "Value": "quia",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 755
      }
    }
  },
  "GroupIdx": 862,
  "IncludePerson": 160,
  "MemberCount": 103,
  "Name": "Becker, Harber and Weber",
  "PostitTextId": 405,
  "CreatedDate": "2001-01-30T14:58:05.2316281+01:00",
  "SelectionId": 42,
  "SoundEx": "impedit",
  "Source": 481,
  "TextId": 942,
  "UpdatedDate": "2017-07-17T14:58:05.2316281+02:00",
  "UpdatedCount": 969,
  "Visibility": 524,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 980,
  "TargetTableName": "Feeney Group",
  "Completed": false,
  "LeftSelectionId": 948,
  "RightSelectionId": 646,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Ernser LLC",
  "ShadowProviderName": "Gleason Inc and Sons",
  "ChartKey": "totam",
  "LastLoaded": "2018-11-24T14:58:05.2316281+01:00",
  "LastLoadedBy": 62,
  "LastLoadedByAssociate": {
    "AssociateId": 531,
    "Name": "Harber, Beier and Jast",
    "PersonId": 209,
    "Rank": 690,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 403,
    "FullName": "Mr. Troy Mueller",
    "FormalName": "Renner-Rolfson",
    "Deleted": false,
    "EjUserId": 363,
    "UserName": "Aufderhar-Jaskolski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 359
      }
    }
  },
  "LastMembershipChange": "1997-04-17T14:58:05.2316281+02:00",
  "LastMembershipChangeBy": 635,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 396,
    "Name": "Koss Inc and Sons",
    "PersonId": 909,
    "Rank": 994,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 593,
    "FullName": "Mr. Koby Batz",
    "FormalName": "Hermiston, Brakus and D'Amore",
    "Deleted": true,
    "EjUserId": 528,
    "UserName": "McCullough, Jacobson and Spencer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 551
      }
    }
  },
  "MainHeading": "magnam",
  "MemberTabHeading": "pariatur",
  "MailingsProviderName": "Gutmann, Langosh and Herzog",
  "VisibleFor": [
    {
      "VisibleId": 931,
      "Visibility": "All",
      "DisplayValue": "hic",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    },
    {
      "VisibleId": 931,
      "Visibility": "All",
      "DisplayValue": "hic",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 162
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
      "FieldLength": 215
    }
  }
}
```