---
title: POST Agents/Selection/CreateTemporaryContactSelection
id: v1SelectionAgent_CreateTemporaryContactSelection
---

# POST Agents/Selection/CreateTemporaryContactSelection

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection
```

Creates a temporary selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Persevering impactful support",
  "Postit": "voluptatem",
  "Associate": {
    "AssociateId": 646,
    "Name": "Breitenberg LLC",
    "PersonId": 712,
    "Rank": 422,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 824,
    "FullName": "Katelyn Conn",
    "FormalName": "Kohler-Senger",
    "Deleted": false,
    "EjUserId": 876,
    "UserName": "Lindgren-Waters",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 577
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 933,
    "Name": "Tillman Inc and Sons",
    "PersonId": 968,
    "Rank": 787,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 316,
    "FullName": "Era Mante",
    "FormalName": "Hermiston Group",
    "Deleted": false,
    "EjUserId": 636,
    "UserName": "Lindgren Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 525
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 705,
    "Name": "Gerlach-Rath",
    "PersonId": 334,
    "Rank": 809,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 781,
    "FullName": "Colton Marquardt",
    "FormalName": "Bashirian, Wintheiser and Aufderhar",
    "Deleted": false,
    "EjUserId": 254,
    "UserName": "Kunze, Hackett and Schuppe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 205
      }
    }
  },
  "SelectionCategory": {
    "Id": 60,
    "Value": "fugiat",
    "Tooltip": "dicta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 153
      }
    }
  },
  "GroupIdx": 638,
  "IncludePerson": 817,
  "MemberCount": 977,
  "Name": "Willms-Lynch",
  "PostitTextId": 635,
  "CreatedDate": "2013-09-13T16:48:30.6869355+02:00",
  "SelectionId": 83,
  "SoundEx": "aperiam",
  "Source": 852,
  "TextId": 140,
  "UpdatedDate": "2005-05-30T16:48:30.6869355+02:00",
  "UpdatedCount": 725,
  "Visibility": 771,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 25,
  "TargetTableName": "Schulist-Wisoky",
  "Completed": true,
  "LeftSelectionId": 11,
  "RightSelectionId": 605,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Brakus, Kilback and Dickens",
  "ShadowProviderName": "Waelchi-Larson",
  "ChartKey": "sit",
  "LastLoaded": "2015-08-21T16:48:30.6869355+02:00",
  "LastLoadedBy": 857,
  "LastLoadedByAssociate": {
    "AssociateId": 746,
    "Name": "Weimann, Pacocha and Littel",
    "PersonId": 214,
    "Rank": 897,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 221,
    "FullName": "Ms. Earnestine Daugherty",
    "FormalName": "Stroman-Harvey",
    "Deleted": false,
    "EjUserId": 722,
    "UserName": "Turner, Dietrich and Medhurst",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 211
      }
    }
  },
  "LastMembershipChange": "2018-02-10T16:48:30.6879345+01:00",
  "LastMembershipChangeBy": 331,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 254,
    "Name": "Larson Group",
    "PersonId": 62,
    "Rank": 795,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 756,
    "FullName": "Miracle Friesen PhD",
    "FormalName": "Ziemann, Torp and Upton",
    "Deleted": true,
    "EjUserId": 293,
    "UserName": "Lockman-Okuneva",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 526
      }
    }
  },
  "MainHeading": "qui",
  "MemberTabHeading": "voluptatem",
  "MailingsProviderName": "Daniel, Bailey and Orn",
  "VisibleFor": [
    {
      "VisibleId": 973,
      "Visibility": "All",
      "DisplayValue": "modi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    },
    {
      "VisibleId": 973,
      "Visibility": "All",
      "DisplayValue": "modi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 70
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
      "FieldLength": 847
    }
  }
}
```