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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "nemo",
    "value": {
      "value1": {
        "PrimaryKey": 5894,
        "EntityName": "sale",
        "saleId": 5894,
        "contactId": 3444,
        "name": "Shields Group"
      },
      "value2": {
        "PrimaryKey": 6546,
        "EntityName": "person",
        "personId": 6546,
        "fullName": "Ms. Wilton Johnson"
      }
    }
  },
  {
    "op": "add",
    "path": "nemo",
    "value": {
      "value1": {
        "PrimaryKey": 5894,
        "EntityName": "sale",
        "saleId": 5894,
        "contactId": 3444,
        "name": "Shields Group"
      },
      "value2": {
        "PrimaryKey": 6546,
        "EntityName": "person",
        "personId": 6546,
        "fullName": "Ms. Wilton Johnson"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SelectionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Description": "Business-focused human-resource secured line",
  "Postit": "ipsa",
  "Associate": {
    "AssociateId": 462,
    "Name": "Keeling LLC",
    "PersonId": 79,
    "Rank": 462,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 488,
    "FullName": "Taryn Koss",
    "FormalName": "Lebsack LLC",
    "Deleted": true,
    "EjUserId": 877,
    "UserName": "Ward LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 814
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 203,
    "Name": "Gorczany, Hyatt and Grimes",
    "PersonId": 354,
    "Rank": 417,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 768,
    "FullName": "Clay Hodkiewicz PhD",
    "FormalName": "Bashirian Inc and Sons",
    "Deleted": true,
    "EjUserId": 937,
    "UserName": "Kassulke-Hills",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 613
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 615,
    "Name": "Jaskolski LLC",
    "PersonId": 282,
    "Rank": 352,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 141,
    "FullName": "Candace Collier",
    "FormalName": "Kiehn-Beatty",
    "Deleted": false,
    "EjUserId": 759,
    "UserName": "Brakus-Kunde",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 865
      }
    }
  },
  "SelectionCategory": {
    "Id": 791,
    "Value": "praesentium",
    "Tooltip": "esse",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 742
      }
    }
  },
  "GroupIdx": 804,
  "IncludePerson": 329,
  "MemberCount": 15,
  "Name": "Kub Group",
  "PostitTextId": 465,
  "CreatedDate": "2007-06-13T09:40:59.7430502+02:00",
  "SelectionId": 147,
  "SoundEx": "aut",
  "Source": 957,
  "TextId": 105,
  "UpdatedDate": "2005-04-05T09:40:59.7430502+02:00",
  "UpdatedCount": 908,
  "Visibility": 380,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 351,
  "TargetTableName": "Buckridge, Ernser and Kling",
  "Completed": false,
  "LeftSelectionId": 627,
  "RightSelectionId": 493,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Brakus Inc and Sons",
  "ShadowProviderName": "Hyatt, Murphy and Huel",
  "ChartKey": "sed",
  "LastLoaded": "2020-03-25T09:40:59.7440591+01:00",
  "LastLoadedBy": 650,
  "LastLoadedByAssociate": {
    "AssociateId": 273,
    "Name": "Nienow, Zemlak and Frami",
    "PersonId": 578,
    "Rank": 497,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 556,
    "FullName": "Nolan Dietrich",
    "FormalName": "Stark LLC",
    "Deleted": false,
    "EjUserId": 871,
    "UserName": "Kiehn Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 888
      }
    }
  },
  "LastMembershipChange": "2012-05-14T09:40:59.7440591+02:00",
  "LastMembershipChangeBy": 706,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 328,
    "Name": "Bartoletti, Schamberger and Hayes",
    "PersonId": 6,
    "Rank": 892,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 977,
    "FullName": "Emery Raynor",
    "FormalName": "Nienow, Rath and Quigley",
    "Deleted": true,
    "EjUserId": 589,
    "UserName": "Sanford Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 207
      }
    }
  },
  "MainHeading": "consequuntur",
  "MemberTabHeading": "deserunt",
  "MailingsProviderName": "Fritsch-Schamberger",
  "VisibleFor": [
    {
      "VisibleId": 583,
      "Visibility": "All",
      "DisplayValue": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    },
    {
      "VisibleId": 583,
      "Visibility": "All",
      "DisplayValue": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 558
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
      "FieldLength": 727
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```