---
title: GetSelectionEntity
id: v1SelectionAgent_GetSelectionEntity
---

# GetSelectionEntity

```http
POST /api/v1/Agents/Selection/GetSelectionEntity
```

Gets a SelectionEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| selectionEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetSelectionEntity?selectionEntityId=26
POST /api/v1/Agents/Selection/GetSelectionEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Selection/GetSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Adaptive multi-state intranet",
  "Postit": "voluptatem",
  "Associate": {
    "AssociateId": 427,
    "Name": "Lesch-Kemmer",
    "PersonId": 528,
    "Rank": 430,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 503,
    "FullName": "Mrs. Shany Harber",
    "FormalName": "King Inc and Sons",
    "Deleted": false,
    "EjUserId": 964,
    "UserName": "Connelly, Kshlerin and Tremblay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 300
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 958,
    "Name": "Mraz, Langosh and DuBuque",
    "PersonId": 603,
    "Rank": 70,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 855,
    "FullName": "Tillman Kovacek III",
    "FormalName": "Kertzmann-Hegmann",
    "Deleted": false,
    "EjUserId": 464,
    "UserName": "Altenwerth-Rolfson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 624
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 886,
    "Name": "Rogahn, Bartell and Pouros",
    "PersonId": 968,
    "Rank": 131,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 989,
    "FullName": "Pearline Schultz",
    "FormalName": "Jacobs Inc and Sons",
    "Deleted": true,
    "EjUserId": 443,
    "UserName": "Heaney Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 30
      }
    }
  },
  "SelectionCategory": {
    "Id": 99,
    "Value": "rerum",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 186
      }
    }
  },
  "GroupIdx": 104,
  "IncludePerson": 941,
  "MemberCount": 414,
  "Name": "Daugherty Group",
  "PostitTextId": 403,
  "CreatedDate": "2017-03-20T14:58:05.236628+01:00",
  "SelectionId": 225,
  "SoundEx": "deleniti",
  "Source": 923,
  "TextId": 649,
  "UpdatedDate": "2017-09-08T14:58:05.236628+02:00",
  "UpdatedCount": 609,
  "Visibility": 746,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 542,
  "TargetTableName": "Cronin Group",
  "Completed": true,
  "LeftSelectionId": 873,
  "RightSelectionId": 665,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Casper Inc and Sons",
  "ShadowProviderName": "Littel-Feil",
  "ChartKey": "et",
  "LastLoaded": "2016-08-06T14:58:05.236628+02:00",
  "LastLoadedBy": 465,
  "LastLoadedByAssociate": {
    "AssociateId": 597,
    "Name": "Gibson Inc and Sons",
    "PersonId": 942,
    "Rank": 565,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 109,
    "FullName": "Minnie Hayes",
    "FormalName": "Wisoky Group",
    "Deleted": true,
    "EjUserId": 699,
    "UserName": "Greenfelder LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 535
      }
    }
  },
  "LastMembershipChange": "2014-01-28T14:58:05.236628+01:00",
  "LastMembershipChangeBy": 851,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 785,
    "Name": "Fisher, Breitenberg and Auer",
    "PersonId": 962,
    "Rank": 146,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 304,
    "FullName": "Lauriane Turcotte",
    "FormalName": "Dicki LLC",
    "Deleted": true,
    "EjUserId": 544,
    "UserName": "Carter, Kovacek and Renner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "maximize customized schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 558
      }
    }
  },
  "MainHeading": "nihil",
  "MemberTabHeading": "quo",
  "MailingsProviderName": "Boyle LLC",
  "VisibleFor": [
    {
      "VisibleId": 3,
      "Visibility": "All",
      "DisplayValue": "adipisci",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    },
    {
      "VisibleId": 3,
      "Visibility": "All",
      "DisplayValue": "adipisci",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 788
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
      "FieldLength": 942
    }
  }
}
```