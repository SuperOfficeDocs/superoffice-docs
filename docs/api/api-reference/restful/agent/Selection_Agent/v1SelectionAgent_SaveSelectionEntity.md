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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Description": "Reactive contextually-based Graphic Interface",
  "Postit": "alias",
  "Associate": {
    "AssociateId": 474,
    "Name": "Rath-Kuhlman",
    "PersonId": 833,
    "Rank": 520,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 898,
    "FullName": "Rudolph Sipes",
    "FormalName": "Kuhic, Willms and Jacobs",
    "Deleted": false,
    "EjUserId": 812,
    "UserName": "Bogan, Vandervort and Cassin"
  },
  "CreatedBy": {
    "AssociateId": 906,
    "Name": "Schumm Inc and Sons",
    "PersonId": 131,
    "Rank": 150,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 296,
    "FullName": "Ms. Mariano Hayes",
    "FormalName": "Bogisich, Bashirian and Green",
    "Deleted": false,
    "EjUserId": 476,
    "UserName": "Borer Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 87,
    "Name": "McClure, Hudson and Gulgowski",
    "PersonId": 516,
    "Rank": 590,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 406,
    "FullName": "Chase Ankunding",
    "FormalName": "Bins-Gorczany",
    "Deleted": true,
    "EjUserId": 397,
    "UserName": "Lynch Group"
  },
  "SelectionCategory": {
    "Id": 480,
    "Value": "dolorum",
    "Tooltip": "et"
  },
  "GroupIdx": 775,
  "IncludePerson": 422,
  "MemberCount": 578,
  "Name": "Blick-Schulist",
  "PostitTextId": 268,
  "CreatedDate": "2001-03-08T16:48:30.6559351+01:00",
  "SelectionId": 277,
  "SoundEx": "possimus",
  "Source": 701,
  "TextId": 987,
  "UpdatedDate": "2002-01-19T16:48:30.6559351+01:00",
  "UpdatedCount": 548,
  "Visibility": 117,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 534,
  "TargetTableName": "Bins, Powlowski and Emard",
  "Completed": true,
  "LeftSelectionId": 239,
  "RightSelectionId": 654,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Grady-Johnston",
  "ShadowProviderName": "Russel, Roob and Torp",
  "ChartKey": "voluptas",
  "LastLoaded": "2011-12-13T16:48:30.6569348+01:00",
  "LastLoadedBy": 126,
  "LastLoadedByAssociate": {
    "AssociateId": 330,
    "Name": "Veum, Goyette and Bergstrom",
    "PersonId": 526,
    "Rank": 522,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 16,
    "FullName": "Julien Lesch",
    "FormalName": "Stiedemann LLC",
    "Deleted": true,
    "EjUserId": 205,
    "UserName": "Dooley-Johnston"
  },
  "LastMembershipChange": "1997-02-20T16:48:30.6569348+01:00",
  "LastMembershipChangeBy": 781,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 450,
    "Name": "Ryan, Yundt and Weissnat",
    "PersonId": 102,
    "Rank": 887,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 946,
    "FullName": "Olen Schiller",
    "FormalName": "Pouros-Rath",
    "Deleted": false,
    "EjUserId": 243,
    "UserName": "Koss-Metz"
  },
  "MainHeading": "ut",
  "MemberTabHeading": "eveniet",
  "MailingsProviderName": "Rippin Inc and Sons",
  "VisibleFor": [
    {
      "VisibleId": 996,
      "Visibility": "All",
      "DisplayValue": "fugit"
    },
    {
      "VisibleId": 996,
      "Visibility": "All",
      "DisplayValue": "fugit"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Digitized holistic open architecture",
  "Postit": "et",
  "Associate": {
    "AssociateId": 187,
    "Name": "Schimmel, McLaughlin and Schuster",
    "PersonId": 131,
    "Rank": 639,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 342,
    "FullName": "Favian Reinger",
    "FormalName": "Bogisich-Nicolas",
    "Deleted": true,
    "EjUserId": 629,
    "UserName": "Roberts, Nicolas and Kub",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 110
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 930,
    "Name": "Cassin LLC",
    "PersonId": 866,
    "Rank": 423,
    "Tooltip": "ipsa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 315,
    "FullName": "Hailie Crist",
    "FormalName": "Koepp-Romaguera",
    "Deleted": true,
    "EjUserId": 658,
    "UserName": "Smith-Frami",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 321
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 65,
    "Name": "Kuphal, Little and Hamill",
    "PersonId": 185,
    "Rank": 779,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 380,
    "FullName": "Augusta Kozey",
    "FormalName": "Bergnaum, Pfannerstill and Conroy",
    "Deleted": false,
    "EjUserId": 981,
    "UserName": "Koss, Kub and Gottlieb",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "productize virtual deliverables"
        },
        "FieldType": "System.String",
        "FieldLength": 518
      }
    }
  },
  "SelectionCategory": {
    "Id": 523,
    "Value": "voluptatem",
    "Tooltip": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 132
      }
    }
  },
  "GroupIdx": 880,
  "IncludePerson": 195,
  "MemberCount": 137,
  "Name": "Bogan, Blanda and Gibson",
  "PostitTextId": 182,
  "CreatedDate": "2005-03-12T16:48:30.6609357+01:00",
  "SelectionId": 773,
  "SoundEx": "enim",
  "Source": 799,
  "TextId": 568,
  "UpdatedDate": "2005-07-19T16:48:30.6609357+02:00",
  "UpdatedCount": 593,
  "Visibility": 299,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 190,
  "TargetTableName": "Kerluke LLC",
  "Completed": true,
  "LeftSelectionId": 193,
  "RightSelectionId": 858,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Pacocha, Fritsch and Goyette",
  "ShadowProviderName": "Bayer LLC",
  "ChartKey": "omnis",
  "LastLoaded": "2012-01-02T16:48:30.6609357+01:00",
  "LastLoadedBy": 752,
  "LastLoadedByAssociate": {
    "AssociateId": 195,
    "Name": "Stroman, Rutherford and Romaguera",
    "PersonId": 1000,
    "Rank": 304,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 579,
    "FullName": "Eunice Macejkovic PhD",
    "FormalName": "Turcotte, Kessler and Rogahn",
    "Deleted": false,
    "EjUserId": 546,
    "UserName": "Wiza Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 368
      }
    }
  },
  "LastMembershipChange": "2015-01-24T16:48:30.6609357+01:00",
  "LastMembershipChangeBy": 156,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 467,
    "Name": "Funk LLC",
    "PersonId": 30,
    "Rank": 859,
    "Tooltip": "blanditiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 448,
    "FullName": "Tyrell Cole",
    "FormalName": "Hickle LLC",
    "Deleted": false,
    "EjUserId": 722,
    "UserName": "Collins-Ritchie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 207
      }
    }
  },
  "MainHeading": "fugiat",
  "MemberTabHeading": "ut",
  "MailingsProviderName": "Lakin-Weber",
  "VisibleFor": [
    {
      "VisibleId": 23,
      "Visibility": "All",
      "DisplayValue": "iste",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    },
    {
      "VisibleId": 23,
      "Visibility": "All",
      "DisplayValue": "iste",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 971
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
      "FieldLength": 601
    }
  }
}
```