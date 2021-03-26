---
title: POST Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
id: v1SelectionAgent_CreateTemporaryContactSelectionFromContactPersonIds
---

# POST Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds

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
      "PersonId": 399,
      "ContactId": 250
    },
    {
      "PersonId": 399,
      "ContactId": 250
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Persevering fresh-thinking monitoring",
  "Postit": "sit",
  "Associate": {
    "AssociateId": 925,
    "Name": "Carter Group",
    "PersonId": 915,
    "Rank": 610,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 246,
    "FullName": "Agustina Blick",
    "FormalName": "Turcotte Group",
    "Deleted": false,
    "EjUserId": 452,
    "UserName": "Lueilwitz Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 846
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 55,
    "Name": "Franecki, Crist and Wunsch",
    "PersonId": 997,
    "Rank": 603,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 817,
    "FullName": "Fredrick Lowe",
    "FormalName": "Smitham, West and VonRueden",
    "Deleted": false,
    "EjUserId": 161,
    "UserName": "Koelpin, Beahan and Durgan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 465
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 129,
    "Name": "Tremblay-Powlowski",
    "PersonId": 908,
    "Rank": 869,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 463,
    "FullName": "Delpha Crooks",
    "FormalName": "Yost-Kuvalis",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "Treutel-Grady",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
      }
    }
  },
  "SelectionCategory": {
    "Id": 54,
    "Value": "officia",
    "Tooltip": "eaque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 140
      }
    }
  },
  "GroupIdx": 400,
  "IncludePerson": 511,
  "MemberCount": 859,
  "Name": "Labadie LLC",
  "PostitTextId": 694,
  "CreatedDate": "2018-11-09T16:48:30.6759073+01:00",
  "SelectionId": 178,
  "SoundEx": "aut",
  "Source": 446,
  "TextId": 1000,
  "UpdatedDate": "2008-02-19T16:48:30.6759073+01:00",
  "UpdatedCount": 479,
  "Visibility": 542,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 199,
  "TargetTableName": "Davis LLC",
  "Completed": false,
  "LeftSelectionId": 790,
  "RightSelectionId": 792,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Glover, Borer and Mraz",
  "ShadowProviderName": "Nader, Effertz and Bahringer",
  "ChartKey": "voluptatum",
  "LastLoaded": "2003-06-23T16:48:30.6759073+02:00",
  "LastLoadedBy": 968,
  "LastLoadedByAssociate": {
    "AssociateId": 790,
    "Name": "DuBuque Inc and Sons",
    "PersonId": 543,
    "Rank": 319,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 398,
    "FullName": "Mr. Thad Feest",
    "FormalName": "Wolff Group",
    "Deleted": false,
    "EjUserId": 733,
    "UserName": "Harber LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 557
      }
    }
  },
  "LastMembershipChange": "2005-08-11T16:48:30.6759073+02:00",
  "LastMembershipChangeBy": 378,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 235,
    "Name": "Hoppe, Abbott and Toy",
    "PersonId": 155,
    "Rank": 524,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 869,
    "FullName": "Mateo Harber",
    "FormalName": "Mertz, Cronin and Tremblay",
    "Deleted": false,
    "EjUserId": 680,
    "UserName": "Feeney-Bergnaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 637
      }
    }
  },
  "MainHeading": "quas",
  "MemberTabHeading": "velit",
  "MailingsProviderName": "Rogahn, Reichel and Fahey",
  "VisibleFor": [
    {
      "VisibleId": 78,
      "Visibility": "All",
      "DisplayValue": "corporis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 126
        }
      }
    },
    {
      "VisibleId": 78,
      "Visibility": "All",
      "DisplayValue": "corporis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 126
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "morph dynamic synergies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 104
    }
  }
}
```