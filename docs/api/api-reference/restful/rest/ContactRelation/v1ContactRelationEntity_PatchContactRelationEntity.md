---
title: PATCH Relation/{id}
id: v1ContactRelationEntity_PatchContactRelationEntity
---

# PATCH Relation/{id}

```http
PATCH /api/v1/Relation/{id}
```

Update a ContactRelationEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IRelationAgent} service SaveContactRelation.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactRelationEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Relation/{id}?$select=name,department,category/id
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

Relationship between a (contact/person) and another (contact/person), as described by the RelationDefinition.



ContactRelationEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactRelationEntity  updated. |
| 404 | ContactRelationEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactRelationEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceContactId | int32 | Id of the source contact. The value is mandatory. |
| SourcePersonId | int32 | Id of the source person. The value is not mandatory. The person must belong to the source contact. |
| DestinationContactId | int32 | Id of the destination contact. The value is mandatory. |
| DestinationPersonId | int32 | Id of the destination person. The value is not mandatory. The person must belong to the destination contact. |
| RelationId | int32 | Primary key |
| Comment | string | Comment for relation |
| RelationDefinitionId | int32 | Reference to definition |
| Reversed | int32 | Is direction reversed relative to definition |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedDate | date-time | Registered when  in UTC. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Relation/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "in",
    "value": {
      "value1": {
        "PrimaryKey": 7328,
        "EntityName": "person",
        "personId": 7328,
        "fullName": "Mr. Eulah Stark"
      },
      "value2": {
        "PrimaryKey": 264,
        "EntityName": "sale",
        "saleId": 264,
        "contactId": 8315,
        "name": "Luettgen LLC"
      }
    }
  },
  {
    "op": "add",
    "path": "in",
    "value": {
      "value1": {
        "PrimaryKey": 7328,
        "EntityName": "person",
        "personId": 7328,
        "fullName": "Mr. Eulah Stark"
      },
      "value2": {
        "PrimaryKey": 264,
        "EntityName": "sale",
        "saleId": 264,
        "contactId": 8315,
        "name": "Luettgen LLC"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ContactRelationEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 812,
  "SourcePersonId": 329,
  "DestinationContactId": 878,
  "DestinationPersonId": 366,
  "RelationId": 755,
  "Comment": "nulla",
  "RelationDefinitionId": 371,
  "Reversed": 575,
  "UpdatedDate": "1996-07-17T09:40:59.0538863+02:00",
  "CreatedDate": "2010-01-19T09:40:59.0538863+01:00",
  "CreatedBy": {
    "AssociateId": 791,
    "Name": "Cruickshank Inc and Sons",
    "PersonId": 442,
    "Rank": 393,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 114,
    "FullName": "Elfrieda O'Keefe",
    "FormalName": "Labadie LLC",
    "Deleted": false,
    "EjUserId": 448,
    "UserName": "Grant, Kuphal and Lueilwitz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deploy virtual technologies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 560
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 806,
    "Name": "Schneider-Spencer",
    "PersonId": 510,
    "Rank": 535,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 288,
    "FullName": "Willard Robel",
    "FormalName": "Stroman-Balistreri",
    "Deleted": true,
    "EjUserId": 224,
    "UserName": "Frami Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 615
      }
    }
  },
  "SourceContactName": "Feeney, Carter and Zulauf",
  "SourcePersonName": "Botsford, Wunsch and Larson",
  "DestinationContactName": "Wisozk LLC",
  "DestinationPersonName": "Kling, Corkery and Pfeffer",
  "ActiveText": "iusto",
  "PassiveText": "nesciunt",
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
      "FieldLength": 139
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```