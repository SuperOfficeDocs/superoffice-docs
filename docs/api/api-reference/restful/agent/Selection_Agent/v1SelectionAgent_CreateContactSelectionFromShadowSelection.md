---
title: POST Agents/Selection/CreateContactSelectionFromShadowSelection
id: v1SelectionAgent_CreateContactSelectionFromShadowSelection
---

# POST Agents/Selection/CreateContactSelectionFromShadowSelection

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
```

Creates a new contact selection based on contact selection members from an existing shadow sale, appointment, project or document selection.

The new selection will always be static even if the original selection is dynamic.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection?$select=name,department,category/id
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

## Request Body: request  

SelectionId, Name 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Name | string |  |


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
POST /api/v1/Agents/Selection/CreateContactSelectionFromShadowSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 158,
  "Name": "Leffler, Deckow and Murray"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Centralized mission-critical forecast",
  "Postit": "consequatur",
  "Associate": {
    "AssociateId": 654,
    "Name": "Nienow Group",
    "PersonId": 474,
    "Rank": 531,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 122,
    "FullName": "Alberto Crooks",
    "FormalName": "Quitzon Inc and Sons",
    "Deleted": true,
    "EjUserId": 546,
    "UserName": "Cummerata-Ledner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 776
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 873,
    "Name": "O'Conner, Hammes and Durgan",
    "PersonId": 821,
    "Rank": 767,
    "Tooltip": "unde",
    "Type": "AnonymousAssociate",
    "GroupIdx": 828,
    "FullName": "Anderson Labadie V",
    "FormalName": "Lubowitz, Stehr and Hackett",
    "Deleted": false,
    "EjUserId": 163,
    "UserName": "Kirlin, O'Kon and Konopelski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 822
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 285,
    "Name": "Mosciski, Borer and DuBuque",
    "PersonId": 602,
    "Rank": 805,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 302,
    "FullName": "Destin Moore",
    "FormalName": "Tillman Group",
    "Deleted": true,
    "EjUserId": 39,
    "UserName": "Glover, Witting and Bogisich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 160
      }
    }
  },
  "SelectionCategory": {
    "Id": 276,
    "Value": "at",
    "Tooltip": "facere",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 280
      }
    }
  },
  "GroupIdx": 209,
  "IncludePerson": 128,
  "MemberCount": 855,
  "Name": "Roob, Hauck and Cormier",
  "PostitTextId": 13,
  "CreatedDate": "2020-12-20T16:48:30.7629361+01:00",
  "SelectionId": 990,
  "SoundEx": "aut",
  "Source": 260,
  "TextId": 775,
  "UpdatedDate": "2007-12-20T16:48:30.7629361+01:00",
  "UpdatedCount": 743,
  "Visibility": 31,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 313,
  "TargetTableName": "Farrell-Ernser",
  "Completed": false,
  "LeftSelectionId": 444,
  "RightSelectionId": 531,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Lakin-Little",
  "ShadowProviderName": "Hahn, Hegmann and Volkman",
  "ChartKey": "vero",
  "LastLoaded": "2013-06-28T16:48:30.763935+02:00",
  "LastLoadedBy": 132,
  "LastLoadedByAssociate": {
    "AssociateId": 40,
    "Name": "Schuster, Blick and Hoeger",
    "PersonId": 880,
    "Rank": 712,
    "Tooltip": "perferendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 370,
    "FullName": "Mitchel Marvin",
    "FormalName": "Wilkinson-O'Hara",
    "Deleted": false,
    "EjUserId": 905,
    "UserName": "Koepp Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 464
      }
    }
  },
  "LastMembershipChange": "2019-05-08T16:48:30.763935+02:00",
  "LastMembershipChangeBy": 592,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 756,
    "Name": "Boyle-Muller",
    "PersonId": 461,
    "Rank": 901,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 550,
    "FullName": "Evie Thompson",
    "FormalName": "Langosh-Heaney",
    "Deleted": true,
    "EjUserId": 923,
    "UserName": "Heathcote, Volkman and Huel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 22
      }
    }
  },
  "MainHeading": "consequatur",
  "MemberTabHeading": "modi",
  "MailingsProviderName": "VonRueden-Schowalter",
  "VisibleFor": [
    {
      "VisibleId": 121,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "revolutionize best-of-breed users"
          },
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    },
    {
      "VisibleId": 121,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "revolutionize best-of-breed users"
          },
          "FieldType": "System.Int32",
          "FieldLength": 107
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
      "FieldLength": 435
    }
  }
}
```