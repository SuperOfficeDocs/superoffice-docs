---
title: PATCH Selection/{id}
id: v1SelectionEntity_PatchSelectionEntity
---

# PATCH Selection/{id}

```http
PATCH /api/v1/Selection/{id}
```

Update a SelectionEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.ISelectionAgent} service SaveSelectionEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SelectionEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Selection/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object




SelectionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SelectionEntity  updated. |
| 404 | SelectionEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because SelectionEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "dolor",
    "value": {
      "value1": {
        "PrimaryKey": 7412,
        "EntityName": "sale",
        "saleId": 7412,
        "contactId": 9784,
        "name": "Murphy, Torphy and Lueilwitz"
      },
      "value2": {
        "PrimaryKey": 4530,
        "EntityName": "person",
        "personId": 4530,
        "fullName": "Madyson Davis Jr."
      }
    }
  },
  {
    "op": "add",
    "path": "dolor",
    "value": {
      "value1": {
        "PrimaryKey": 7412,
        "EntityName": "sale",
        "saleId": 7412,
        "contactId": 9784,
        "name": "Murphy, Torphy and Lueilwitz"
      },
      "value2": {
        "PrimaryKey": 4530,
        "EntityName": "person",
        "personId": 4530,
        "fullName": "Madyson Davis Jr."
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SelectionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Compatible 3rd generation function",
  "Postit": "magnam",
  "Associate": {
    "AssociateId": 11,
    "Name": "Sauer Group",
    "PersonId": 194,
    "Rank": 332,
    "Tooltip": "optio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 692,
    "FullName": "Hillary Rowe",
    "FormalName": "Braun-Homenick",
    "Deleted": true,
    "EjUserId": 747,
    "UserName": "Kihn Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 560
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 234,
    "Name": "Jast LLC",
    "PersonId": 653,
    "Rank": 558,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 153,
    "FullName": "Eda Crooks",
    "FormalName": "Bosco-Brekke",
    "Deleted": false,
    "EjUserId": 651,
    "UserName": "Quigley, Dickens and O'Conner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "productize cross-media solutions"
        },
        "FieldType": "System.Int32",
        "FieldLength": 764
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 30,
    "Name": "Beier-Kertzmann",
    "PersonId": 197,
    "Rank": 961,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 68,
    "FullName": "Nannie Schmidt DVM",
    "FormalName": "Johnson-Boyle",
    "Deleted": true,
    "EjUserId": 155,
    "UserName": "Hauck, Kautzer and Walsh",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 583
      }
    }
  },
  "SelectionCategory": {
    "Id": 719,
    "Value": "vel",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 719
      }
    }
  },
  "GroupIdx": 626,
  "IncludePerson": 845,
  "MemberCount": 967,
  "Name": "Schneider-Dach",
  "PostitTextId": 438,
  "CreatedDate": "2005-12-14T18:25:51.098944+01:00",
  "SelectionId": 689,
  "SoundEx": "iure",
  "Source": 674,
  "TextId": 889,
  "UpdatedDate": "2003-08-09T18:25:51.098944+02:00",
  "UpdatedCount": 863,
  "Visibility": 473,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 427,
  "TargetTableName": "Labadie-Pacocha",
  "Completed": false,
  "LeftSelectionId": 827,
  "RightSelectionId": 380,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Wolff-Cartwright",
  "ShadowProviderName": "Welch, Watsica and Fadel",
  "ChartKey": "quibusdam",
  "LastLoaded": "2014-12-02T18:25:51.098944+01:00",
  "LastLoadedBy": 270,
  "LastLoadedByAssociate": {
    "AssociateId": 523,
    "Name": "Cummings Group",
    "PersonId": 345,
    "Rank": 700,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 831,
    "FullName": "Jose Kozey",
    "FormalName": "Heaney LLC",
    "Deleted": true,
    "EjUserId": 211,
    "UserName": "Barton, Connelly and Funk",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 463
      }
    }
  },
  "LastMembershipChange": "1999-03-08T18:25:51.098944+01:00",
  "LastMembershipChangeBy": 23,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 455,
    "Name": "Cummings-Swaniawski",
    "PersonId": 608,
    "Rank": 204,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 609,
    "FullName": "Wellington Conroy PhD",
    "FormalName": "Robel-Windler",
    "Deleted": true,
    "EjUserId": 647,
    "UserName": "Mills, Kuhn and Bernhard",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 131
      }
    }
  },
  "MainHeading": "aut",
  "MemberTabHeading": "sed",
  "MailingsProviderName": "Stroman, Nolan and Leffler",
  "DashboardTileDefinitionId": 462,
  "VisibleFor": [
    {
      "VisibleId": 663,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 548
        }
      }
    },
    {
      "VisibleId": 663,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 548
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
      "FieldLength": 492
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```