---
title: POST Agents/Selection/SaveSelectionEntity
id: v1SelectionAgent_SaveSelectionEntity
---

# POST Agents/Selection/SaveSelectionEntity

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
| DashboardTileDefinitionId | int32 | The associated tile definition |
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
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/SaveSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Description": "Digitized well-modulated array",
  "Postit": "est",
  "Associate": {
    "AssociateId": 240,
    "Name": "Walker LLC",
    "PersonId": 475,
    "Rank": 847,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 706,
    "FullName": "Ward Kuhlman",
    "FormalName": "Jacobson, Blick and Schultz",
    "Deleted": false,
    "EjUserId": 928,
    "UserName": "Weimann-Carter"
  },
  "CreatedBy": {
    "AssociateId": 135,
    "Name": "Hauck Group",
    "PersonId": 124,
    "Rank": 765,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 316,
    "FullName": "Kaya Little",
    "FormalName": "Hilpert, White and Carroll",
    "Deleted": false,
    "EjUserId": 535,
    "UserName": "Larson, Gaylord and Lindgren"
  },
  "UpdatedBy": {
    "AssociateId": 3,
    "Name": "Waelchi, Legros and Gerhold",
    "PersonId": 374,
    "Rank": 433,
    "Tooltip": "culpa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 121,
    "FullName": "Marilyne Hand DDS",
    "FormalName": "Nienow, Farrell and Welch",
    "Deleted": false,
    "EjUserId": 150,
    "UserName": "Wehner-Goyette"
  },
  "SelectionCategory": {
    "Id": 543,
    "Value": "et",
    "Tooltip": "odit"
  },
  "GroupIdx": 979,
  "IncludePerson": 986,
  "MemberCount": 600,
  "Name": "Price, Hauck and Stracke",
  "PostitTextId": 203,
  "CreatedDate": "2015-07-11T18:28:50.2194516+02:00",
  "SelectionId": 924,
  "SoundEx": "omnis",
  "Source": 133,
  "TextId": 963,
  "UpdatedDate": "1998-10-08T18:28:50.2194516+02:00",
  "UpdatedCount": 429,
  "Visibility": 725,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 346,
  "TargetTableName": "Trantow Group",
  "Completed": false,
  "LeftSelectionId": 748,
  "RightSelectionId": 397,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Nienow, Zboncak and Lubowitz",
  "ShadowProviderName": "Anderson-Blanda",
  "ChartKey": "est",
  "LastLoaded": "2007-08-17T18:28:50.2194516+02:00",
  "LastLoadedBy": 266,
  "LastLoadedByAssociate": {
    "AssociateId": 983,
    "Name": "Upton, Leannon and Jakubowski",
    "PersonId": 307,
    "Rank": 112,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 94,
    "FullName": "Rebeca Ankunding",
    "FormalName": "Blanda Inc and Sons",
    "Deleted": true,
    "EjUserId": 259,
    "UserName": "Christiansen Inc and Sons"
  },
  "LastMembershipChange": "2000-11-24T18:28:50.2194516+01:00",
  "LastMembershipChangeBy": 966,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 563,
    "Name": "Hilll Inc and Sons",
    "PersonId": 752,
    "Rank": 57,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 460,
    "FullName": "Lucie Kerluke",
    "FormalName": "Kuhic-Johnson",
    "Deleted": true,
    "EjUserId": 1000,
    "UserName": "Brakus-Schowalter"
  },
  "MainHeading": "ipsum",
  "MemberTabHeading": "voluptatem",
  "MailingsProviderName": "Berge, Larkin and Kohler",
  "DashboardTileDefinitionId": 500,
  "VisibleFor": [
    {
      "VisibleId": 136,
      "Visibility": "All",
      "DisplayValue": "rerum"
    },
    {
      "VisibleId": 136,
      "Visibility": "All",
      "DisplayValue": "rerum"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Self-enabling zero tolerance solution",
  "Postit": "non",
  "Associate": {
    "AssociateId": 974,
    "Name": "Upton LLC",
    "PersonId": 982,
    "Rank": 346,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 196,
    "FullName": "Luna Swaniawski",
    "FormalName": "Brakus-Kassulke",
    "Deleted": true,
    "EjUserId": 126,
    "UserName": "Nienow LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "redefine granular niches"
        },
        "FieldType": "System.Int32",
        "FieldLength": 904
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 890,
    "Name": "Parker-Vandervort",
    "PersonId": 154,
    "Rank": 951,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 514,
    "FullName": "Mina Kreiger",
    "FormalName": "Brekke-Schmitt",
    "Deleted": false,
    "EjUserId": 203,
    "UserName": "Stracke, Marquardt and Carter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 868
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 622,
    "Name": "Bogan-Wehner",
    "PersonId": 68,
    "Rank": 592,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 339,
    "FullName": "Mervin Kulas",
    "FormalName": "Ritchie, Stark and Borer",
    "Deleted": false,
    "EjUserId": 264,
    "UserName": "Cronin-Collier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 120
      }
    }
  },
  "SelectionCategory": {
    "Id": 447,
    "Value": "voluptas",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 330
      }
    }
  },
  "GroupIdx": 304,
  "IncludePerson": 166,
  "MemberCount": 402,
  "Name": "Glover-Ortiz",
  "PostitTextId": 294,
  "CreatedDate": "2016-08-27T18:28:50.2234466+02:00",
  "SelectionId": 773,
  "SoundEx": "earum",
  "Source": 709,
  "TextId": 24,
  "UpdatedDate": "2018-07-11T18:28:50.2234466+02:00",
  "UpdatedCount": 723,
  "Visibility": 32,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 60,
  "TargetTableName": "Kub, Tromp and Satterfield",
  "Completed": false,
  "LeftSelectionId": 949,
  "RightSelectionId": 146,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Kulas, Dibbert and Price",
  "ShadowProviderName": "Durgan-Medhurst",
  "ChartKey": "est",
  "LastLoaded": "2003-01-23T18:28:50.2244467+01:00",
  "LastLoadedBy": 401,
  "LastLoadedByAssociate": {
    "AssociateId": 993,
    "Name": "Streich, Welch and Quitzon",
    "PersonId": 17,
    "Rank": 377,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 609,
    "FullName": "Karley DuBuque",
    "FormalName": "Mayer Group",
    "Deleted": true,
    "EjUserId": 388,
    "UserName": "Kunze, Cassin and Bechtelar",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 593
      }
    }
  },
  "LastMembershipChange": "2006-12-17T18:28:50.2244467+01:00",
  "LastMembershipChangeBy": 501,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 429,
    "Name": "Barton, Heaney and DuBuque",
    "PersonId": 617,
    "Rank": 195,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 765,
    "FullName": "Kailey Reichert II",
    "FormalName": "Roob LLC",
    "Deleted": true,
    "EjUserId": 138,
    "UserName": "Rohan-Barton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  },
  "MainHeading": "et",
  "MemberTabHeading": "consequuntur",
  "MailingsProviderName": "Simonis-Veum",
  "DashboardTileDefinitionId": 997,
  "VisibleFor": [
    {
      "VisibleId": 623,
      "Visibility": "All",
      "DisplayValue": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    },
    {
      "VisibleId": 623,
      "Visibility": "All",
      "DisplayValue": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 302
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
      "FieldLength": 740
    }
  }
}
```