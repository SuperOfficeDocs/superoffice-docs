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
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "consequatur",
    "value": {
      "value1": {
        "PrimaryKey": 1947,
        "EntityName": "person",
        "personId": 1947,
        "fullName": "Cesar Swift"
      },
      "value2": {
        "PrimaryKey": 15,
        "EntityName": "person",
        "personId": 15,
        "fullName": "Ariel Metz"
      }
    }
  },
  {
    "op": "add",
    "path": "consequatur",
    "value": {
      "value1": {
        "PrimaryKey": 1947,
        "EntityName": "person",
        "personId": 1947,
        "fullName": "Cesar Swift"
      },
      "value2": {
        "PrimaryKey": 15,
        "EntityName": "person",
        "personId": 15,
        "fullName": "Ariel Metz"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SelectionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Synergized multimedia process improvement",
  "Postit": "amet",
  "Associate": {
    "AssociateId": 700,
    "Name": "Gorczany, Jacobson and Waters",
    "PersonId": 95,
    "Rank": 370,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 459,
    "FullName": "Alyce Hansen",
    "FormalName": "Thiel-Okuneva",
    "Deleted": true,
    "EjUserId": 862,
    "UserName": "Turcotte-Dicki",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "drive dot-com infomediaries"
        },
        "FieldType": "System.String",
        "FieldLength": 571
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 466,
    "Name": "White, Koelpin and Waters",
    "PersonId": 453,
    "Rank": 891,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 709,
    "FullName": "Elton West",
    "FormalName": "Lindgren Group",
    "Deleted": true,
    "EjUserId": 898,
    "UserName": "Weissnat-Emmerich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 285
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 509,
    "Name": "Considine LLC",
    "PersonId": 428,
    "Rank": 394,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 794,
    "FullName": "Jermey Buckridge",
    "FormalName": "Olson, Jast and Stoltenberg",
    "Deleted": true,
    "EjUserId": 155,
    "UserName": "McLaughlin, Flatley and Kuphal",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 806
      }
    }
  },
  "SelectionCategory": {
    "Id": 134,
    "Value": "dolore",
    "Tooltip": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 569
      }
    }
  },
  "GroupIdx": 327,
  "IncludePerson": 172,
  "MemberCount": 667,
  "Name": "Torphy Inc and Sons",
  "PostitTextId": 73,
  "CreatedDate": "2011-11-23T15:05:42.7466688+01:00",
  "SelectionId": 36,
  "SoundEx": "necessitatibus",
  "Source": 22,
  "TextId": 739,
  "UpdatedDate": "2007-02-08T15:05:42.7466688+01:00",
  "UpdatedCount": 357,
  "Visibility": 173,
  "SelectionType": "Combined",
  "CompanyUnique": false,
  "TargetTableNumber": 693,
  "TargetTableName": "Schuster LLC",
  "Completed": false,
  "LeftSelectionId": 925,
  "RightSelectionId": 589,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Murazik-Fadel",
  "ShadowProviderName": "Ratke-Koepp",
  "ChartKey": "explicabo",
  "LastLoaded": "2019-05-12T15:05:42.7466688+02:00",
  "LastLoadedBy": 693,
  "LastLoadedByAssociate": {
    "AssociateId": 526,
    "Name": "Balistreri, Lakin and D'Amore",
    "PersonId": 145,
    "Rank": 555,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 397,
    "FullName": "Dr. Gracie Gutmann",
    "FormalName": "Will Group",
    "Deleted": false,
    "EjUserId": 771,
    "UserName": "Robel-Reinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 134
      }
    }
  },
  "LastMembershipChange": "2005-12-01T15:05:42.7466688+01:00",
  "LastMembershipChangeBy": 539,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 425,
    "Name": "Nolan LLC",
    "PersonId": 665,
    "Rank": 648,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 93,
    "FullName": "Abbigail Schulist",
    "FormalName": "Schmitt Inc and Sons",
    "Deleted": false,
    "EjUserId": 738,
    "UserName": "Crist, Price and Labadie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 117
      }
    }
  },
  "MainHeading": "aut",
  "MemberTabHeading": "accusantium",
  "MailingsProviderName": "Anderson, Wolff and Flatley",
  "VisibleFor": [
    {
      "VisibleId": 192,
      "Visibility": "All",
      "DisplayValue": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    },
    {
      "VisibleId": 192,
      "Visibility": "All",
      "DisplayValue": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 275
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
      "FieldLength": 433
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```