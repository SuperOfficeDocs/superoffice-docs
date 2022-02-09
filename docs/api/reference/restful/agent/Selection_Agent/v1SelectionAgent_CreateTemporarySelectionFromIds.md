---
title: POST Agents/Selection/CreateTemporarySelectionFromIds
id: v1SelectionAgent_CreateTemporarySelectionFromIds
---

# POST Agents/Selection/CreateTemporarySelectionFromIds

```http
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds
```

Creates a temporary selection with members from a collection of entity id's.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds?$select=name,department,category/id
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

Ids, TargetTableNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Ids | array |  |
| TargetTableNumber | int32 |  |


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
POST /api/v1/Agents/Selection/CreateTemporarySelectionFromIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Ids": [
    611,
    421
  ],
  "TargetTableNumber": 476
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Cross-platform fault-tolerant application",
  "Postit": "qui",
  "Associate": {
    "AssociateId": 801,
    "Name": "Shields-Skiles",
    "PersonId": 76,
    "Rank": 757,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 644,
    "FullName": "Krystina Welch",
    "FormalName": "Wehner Inc and Sons",
    "Deleted": false,
    "EjUserId": 634,
    "UserName": "Schaden, Powlowski and Jacobs",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 815
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 260,
    "Name": "Fahey Group",
    "PersonId": 115,
    "Rank": 686,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 632,
    "FullName": "Miss Maxine Muller",
    "FormalName": "Donnelly LLC",
    "Deleted": true,
    "EjUserId": 198,
    "UserName": "Schiller LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 761
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 198,
    "Name": "Price LLC",
    "PersonId": 930,
    "Rank": 599,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 32,
    "FullName": "Anahi Leffler",
    "FormalName": "Glover Group",
    "Deleted": false,
    "EjUserId": 308,
    "UserName": "Wehner Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 955
      }
    }
  },
  "SelectionCategory": {
    "Id": 295,
    "Value": "minus",
    "Tooltip": "temporibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 356
      }
    }
  },
  "GroupIdx": 490,
  "IncludePerson": 84,
  "MemberCount": 339,
  "Name": "Prohaska, Kunde and Prosacco",
  "PostitTextId": 440,
  "CreatedDate": "2018-05-18T18:28:50.1894421+02:00",
  "SelectionId": 208,
  "SoundEx": "reprehenderit",
  "Source": 646,
  "TextId": 196,
  "UpdatedDate": "2001-01-25T18:28:50.1894421+01:00",
  "UpdatedCount": 885,
  "Visibility": 647,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 483,
  "TargetTableName": "Wilkinson, Parisian and Douglas",
  "Completed": true,
  "LeftSelectionId": 637,
  "RightSelectionId": 566,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Purdy LLC",
  "ShadowProviderName": "Maggio-Daniel",
  "ChartKey": "amet",
  "LastLoaded": "2006-04-11T18:28:50.1894421+02:00",
  "LastLoadedBy": 977,
  "LastLoadedByAssociate": {
    "AssociateId": 606,
    "Name": "Feeney-Kuhn",
    "PersonId": 114,
    "Rank": 344,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 840,
    "FullName": "Brionna Considine",
    "FormalName": "Konopelski Inc and Sons",
    "Deleted": false,
    "EjUserId": 535,
    "UserName": "Collins-Jacobs",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 200
      }
    }
  },
  "LastMembershipChange": "2010-05-05T18:28:50.1894421+02:00",
  "LastMembershipChangeBy": 646,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 300,
    "Name": "Konopelski, Parisian and Marquardt",
    "PersonId": 315,
    "Rank": 672,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 336,
    "FullName": "Eulalia Lueilwitz",
    "FormalName": "Yost, Reinger and Hessel",
    "Deleted": true,
    "EjUserId": 564,
    "UserName": "Bogan-Lubowitz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 436
      }
    }
  },
  "MainHeading": "sed",
  "MemberTabHeading": "eos",
  "MailingsProviderName": "Pollich Group",
  "DashboardTileDefinitionId": 349,
  "VisibleFor": [
    {
      "VisibleId": 736,
      "Visibility": "All",
      "DisplayValue": "in",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 763
        }
      }
    },
    {
      "VisibleId": 736,
      "Visibility": "All",
      "DisplayValue": "in",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 763
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
      "FieldLength": 522
    }
  }
}
```