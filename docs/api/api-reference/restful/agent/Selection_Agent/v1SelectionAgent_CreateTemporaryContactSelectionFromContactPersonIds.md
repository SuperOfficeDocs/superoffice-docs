---
title: CreateTemporaryContactSelectionFromContactPersonIds
id: v1SelectionAgent_CreateTemporaryContactSelectionFromContactPersonIds
---

# CreateTemporaryContactSelectionFromContactPersonIds

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
```

Creates a temporary selection with members from a collection of ContactPerson id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds?$select=name,department,category/id
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

ContactPersonIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactPersonIds | array |  |


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
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactPersonIds": [
    {
      "PersonId": 713,
      "ContactId": 381
    },
    {
      "PersonId": 713,
      "ContactId": 381
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Digitized multimedia process improvement",
  "Postit": "optio",
  "Associate": {
    "AssociateId": 905,
    "Name": "Cartwright LLC",
    "PersonId": 717,
    "Rank": 952,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 270,
    "FullName": "Leanne Kilback",
    "FormalName": "DuBuque, Ferry and Orn",
    "Deleted": true,
    "EjUserId": 588,
    "UserName": "Mills-Senger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 758
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 211,
    "Name": "Turcotte-McKenzie",
    "PersonId": 802,
    "Rank": 676,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 1001,
    "FullName": "Cathryn Huels",
    "FormalName": "Russel Inc and Sons",
    "Deleted": false,
    "EjUserId": 610,
    "UserName": "VonRueden-Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 514
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 171,
    "Name": "Romaguera Inc and Sons",
    "PersonId": 82,
    "Rank": 703,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 742,
    "FullName": "Ramona Pollich",
    "FormalName": "Botsford-Bartell",
    "Deleted": false,
    "EjUserId": 975,
    "UserName": "Toy LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 533
      }
    }
  },
  "SelectionCategory": {
    "Id": 35,
    "Value": "repellat",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 80
      }
    }
  },
  "GroupIdx": 633,
  "IncludePerson": 493,
  "MemberCount": 819,
  "Name": "Smitham-Gulgowski",
  "PostitTextId": 671,
  "CreatedDate": "2008-01-02T14:58:05.303628+01:00",
  "SelectionId": 438,
  "SoundEx": "alias",
  "Source": 262,
  "TextId": 101,
  "UpdatedDate": "2017-10-23T14:58:05.303628+02:00",
  "UpdatedCount": 351,
  "Visibility": 890,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 268,
  "TargetTableName": "Anderson, Borer and Runolfsson",
  "Completed": true,
  "LeftSelectionId": 564,
  "RightSelectionId": 48,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Orn, Gleichner and Thiel",
  "ShadowProviderName": "Oberbrunner, Moore and Smith",
  "ChartKey": "non",
  "LastLoaded": "2007-10-05T14:58:05.303628+02:00",
  "LastLoadedBy": 136,
  "LastLoadedByAssociate": {
    "AssociateId": 909,
    "Name": "Abbott LLC",
    "PersonId": 986,
    "Rank": 729,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 650,
    "FullName": "Ms. Jeff O'Reilly",
    "FormalName": "Bergstrom LLC",
    "Deleted": false,
    "EjUserId": 795,
    "UserName": "Schiller, Herman and Yundt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 169
      }
    }
  },
  "LastMembershipChange": "2004-11-05T14:58:05.3046328+01:00",
  "LastMembershipChangeBy": 488,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 306,
    "Name": "Padberg, Murazik and Ferry",
    "PersonId": 361,
    "Rank": 625,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 298,
    "FullName": "Bert Hansen",
    "FormalName": "Lueilwitz Group",
    "Deleted": true,
    "EjUserId": 172,
    "UserName": "Littel Inc and Sons",
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
  "MainHeading": "ut",
  "MemberTabHeading": "voluptatum",
  "MailingsProviderName": "Lynch-O'Kon",
  "VisibleFor": [
    {
      "VisibleId": 449,
      "Visibility": "All",
      "DisplayValue": "iusto",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    },
    {
      "VisibleId": 449,
      "Visibility": "All",
      "DisplayValue": "iusto",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "matrix dot-com interfaces"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 276
    }
  }
}
```