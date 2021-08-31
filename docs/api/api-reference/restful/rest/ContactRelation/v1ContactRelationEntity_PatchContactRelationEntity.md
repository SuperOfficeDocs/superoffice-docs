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
    "path": "voluptate",
    "value": {
      "value1": {
        "PrimaryKey": 5087,
        "EntityName": "sale",
        "saleId": 5087,
        "contactId": 8586,
        "name": "Boyle LLC"
      },
      "value2": {
        "PrimaryKey": 6277,
        "EntityName": "person",
        "personId": 6277,
        "fullName": "Dr. Walton Maggio"
      }
    }
  },
  {
    "op": "add",
    "path": "voluptate",
    "value": {
      "value1": {
        "PrimaryKey": 5087,
        "EntityName": "sale",
        "saleId": 5087,
        "contactId": 8586,
        "name": "Boyle LLC"
      },
      "value2": {
        "PrimaryKey": 6277,
        "EntityName": "person",
        "personId": 6277,
        "fullName": "Dr. Walton Maggio"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ContactRelationEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 388,
  "SourcePersonId": 528,
  "DestinationContactId": 273,
  "DestinationPersonId": 241,
  "RelationId": 916,
  "Comment": "ut",
  "RelationDefinitionId": 878,
  "Reversed": 854,
  "UpdatedDate": "2010-12-21T15:05:42.0200027+01:00",
  "CreatedDate": "2017-09-02T15:05:42.0200027+02:00",
  "CreatedBy": {
    "AssociateId": 664,
    "Name": "Morissette, Hammes and Grant",
    "PersonId": 689,
    "Rank": 336,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 463,
    "FullName": "Titus Konopelski",
    "FormalName": "Bogisich Group",
    "Deleted": true,
    "EjUserId": 263,
    "UserName": "Vandervort Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 193
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 996,
    "Name": "Parker Inc and Sons",
    "PersonId": 300,
    "Rank": 11,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 765,
    "FullName": "Zita Corkery",
    "FormalName": "Russel Group",
    "Deleted": true,
    "EjUserId": 376,
    "UserName": "Mayer, Heaney and Russel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 591
      }
    }
  },
  "SourceContactName": "Greenfelder-Feest",
  "SourcePersonName": "Herman, Braun and Zemlak",
  "DestinationContactName": "Pouros Inc and Sons",
  "DestinationPersonName": "Hills-Mertz",
  "ActiveText": "sapiente",
  "PassiveText": "et",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "evolve frictionless web services"
      },
      "FieldType": "System.String",
      "FieldLength": 95
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```