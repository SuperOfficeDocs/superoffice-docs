---
title: POST Agents/Selection/CreateSelectionEntity
id: v1SelectionAgent_CreateSelectionEntity
---

# POST Agents/Selection/CreateSelectionEntity

```http
POST /api/v1/Agents/Selection/CreateSelectionEntity
```

Create (but do not save) a new selection entity, for the current user and the given target table; other fields populated as by CreateDefaultSelectionEntity()







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateSelectionEntity?$select=name,department,category/id
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

TargetTableName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetTableName | string |  |


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
POST /api/v1/Agents/Selection/CreateSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TargetTableName": "Hilpert, Schiller and Rodriguez"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Reverse-engineered client-server functionalities",
  "Postit": "aperiam",
  "Associate": {
    "AssociateId": 488,
    "Name": "Flatley-Gorczany",
    "PersonId": 68,
    "Rank": 36,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 499,
    "FullName": "Carlo Kutch",
    "FormalName": "Koss Inc and Sons",
    "Deleted": true,
    "EjUserId": 245,
    "UserName": "Larson-Bartell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 648
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 301,
    "Name": "Kuphal Inc and Sons",
    "PersonId": 273,
    "Rank": 179,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 628,
    "FullName": "Mrs. Maximus Beer",
    "FormalName": "Leffler-Marvin",
    "Deleted": true,
    "EjUserId": 465,
    "UserName": "Legros-Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 643
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 941,
    "Name": "Reynolds, Abshire and Bernhard",
    "PersonId": 948,
    "Rank": 463,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 883,
    "FullName": "Carrie Hamill",
    "FormalName": "Lynch-Hessel",
    "Deleted": true,
    "EjUserId": 463,
    "UserName": "Jewess, Dibbert and Dickens",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 196
      }
    }
  },
  "SelectionCategory": {
    "Id": 249,
    "Value": "incidunt",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 259
      }
    }
  },
  "GroupIdx": 866,
  "IncludePerson": 138,
  "MemberCount": 559,
  "Name": "Schultz Inc and Sons",
  "PostitTextId": 292,
  "CreatedDate": "2003-11-18T18:28:50.2344133+01:00",
  "SelectionId": 647,
  "SoundEx": "vitae",
  "Source": 145,
  "TextId": 987,
  "UpdatedDate": "1995-04-29T18:28:50.2344133+02:00",
  "UpdatedCount": 708,
  "Visibility": 753,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 225,
  "TargetTableName": "Marvin, Ritchie and Lockman",
  "Completed": false,
  "LeftSelectionId": 754,
  "RightSelectionId": 215,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Roberts-Heaney",
  "ShadowProviderName": "Legros-Boehm",
  "ChartKey": "optio",
  "LastLoaded": "2015-10-02T18:28:50.2344133+02:00",
  "LastLoadedBy": 912,
  "LastLoadedByAssociate": {
    "AssociateId": 400,
    "Name": "Hegmann, Tremblay and Legros",
    "PersonId": 348,
    "Rank": 192,
    "Tooltip": "ab",
    "Type": "AnonymousAssociate",
    "GroupIdx": 147,
    "FullName": "Edd Bashirian",
    "FormalName": "Jakubowski-Kshlerin",
    "Deleted": false,
    "EjUserId": 126,
    "UserName": "Olson-Hagenes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 916
      }
    }
  },
  "LastMembershipChange": "2013-08-14T18:28:50.235413+02:00",
  "LastMembershipChangeBy": 864,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 553,
    "Name": "Powlowski Inc and Sons",
    "PersonId": 483,
    "Rank": 842,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 859,
    "FullName": "Mrs. Floyd Schoen",
    "FormalName": "Wilderman, Hills and Altenwerth",
    "Deleted": true,
    "EjUserId": 308,
    "UserName": "Cassin, Metz and Mohr",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 90
      }
    }
  },
  "MainHeading": "autem",
  "MemberTabHeading": "et",
  "MailingsProviderName": "Hansen LLC",
  "DashboardTileDefinitionId": 991,
  "VisibleFor": [
    {
      "VisibleId": 569,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 628
        }
      }
    },
    {
      "VisibleId": 569,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 628
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
      "FieldLength": 651
    }
  }
}
```