---
title: POST Agents/Selection/CreateSelectionFromSelection
id: v1SelectionAgent_CreateSelectionFromSelection
---

# POST Agents/Selection/CreateSelectionFromSelection

```http
POST /api/v1/Agents/Selection/CreateSelectionFromSelection
```

Creates a new selection based on selection members from an existing selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateSelectionFromSelection?$select=name,department,category/id
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

SelectionId, Name, TargetSelectionType, CopyMembers 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Name | string |  |
| TargetSelectionType | string |  |
| CopyMembers | bool |  |


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
POST /api/v1/Agents/Selection/CreateSelectionFromSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 333,
  "Name": "Gutmann Group",
  "TargetSelectionType": "Combined",
  "CopyMembers": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Ergonomic leading edge leverage",
  "Postit": "non",
  "Associate": {
    "AssociateId": 407,
    "Name": "Roberts Inc and Sons",
    "PersonId": 484,
    "Rank": 254,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 177,
    "FullName": "Miss Jewell Wilkinson",
    "FormalName": "Sporer, Hills and Howell",
    "Deleted": false,
    "EjUserId": 74,
    "UserName": "Lynch LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 620
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 775,
    "Name": "Hudson Group",
    "PersonId": 897,
    "Rank": 881,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 173,
    "FullName": "Brenna Jaskolski",
    "FormalName": "Beahan, Paucek and Wyman",
    "Deleted": true,
    "EjUserId": 470,
    "UserName": "Schiller-Bradtke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 787
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 798,
    "Name": "Sporer LLC",
    "PersonId": 322,
    "Rank": 377,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 334,
    "FullName": "Deja Daugherty",
    "FormalName": "O'Kon, Wisozk and Parisian",
    "Deleted": false,
    "EjUserId": 515,
    "UserName": "Hudson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 112
      }
    }
  },
  "SelectionCategory": {
    "Id": 277,
    "Value": "dolorem",
    "Tooltip": "praesentium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 84
      }
    }
  },
  "GroupIdx": 555,
  "IncludePerson": 142,
  "MemberCount": 804,
  "Name": "Kreiger, Keeling and Rutherford",
  "PostitTextId": 520,
  "CreatedDate": "2001-08-21T16:48:30.7079375+02:00",
  "SelectionId": 785,
  "SoundEx": "dolores",
  "Source": 567,
  "TextId": 8,
  "UpdatedDate": "1998-09-06T16:48:30.7079375+02:00",
  "UpdatedCount": 421,
  "Visibility": 904,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 394,
  "TargetTableName": "Breitenberg-Wisozk",
  "Completed": false,
  "LeftSelectionId": 211,
  "RightSelectionId": 102,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Kutch, Swaniawski and Hoeger",
  "ShadowProviderName": "Bernhard-Schuppe",
  "ChartKey": "eum",
  "LastLoaded": "1997-02-28T16:48:30.7079375+01:00",
  "LastLoadedBy": 824,
  "LastLoadedByAssociate": {
    "AssociateId": 34,
    "Name": "Morissette, Stiedemann and Koss",
    "PersonId": 94,
    "Rank": 821,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 3,
    "FullName": "Keanu Crooks",
    "FormalName": "Rau, Ondricka and Kihn",
    "Deleted": true,
    "EjUserId": 894,
    "UserName": "Hoeger-Stiedemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 404
      }
    }
  },
  "LastMembershipChange": "2014-02-10T16:48:30.7079375+01:00",
  "LastMembershipChangeBy": 67,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 747,
    "Name": "Ziemann, Lind and Bode",
    "PersonId": 327,
    "Rank": 88,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 878,
    "FullName": "Mrs. Giovani Koch",
    "FormalName": "Friesen, Haley and Erdman",
    "Deleted": false,
    "EjUserId": 353,
    "UserName": "O'Keefe LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 969
      }
    }
  },
  "MainHeading": "nulla",
  "MemberTabHeading": "est",
  "MailingsProviderName": "Vandervort-Wintheiser",
  "VisibleFor": [
    {
      "VisibleId": 213,
      "Visibility": "All",
      "DisplayValue": "voluptatum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    },
    {
      "VisibleId": 213,
      "Visibility": "All",
      "DisplayValue": "voluptatum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 104
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
      "FieldLength": 396
    }
  }
}
```