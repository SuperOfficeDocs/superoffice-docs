---
title: GET Relation/{id}
id: v1ContactRelationEntity_GetContactRelationEntity
---

# GET Relation/{id}

```http
GET /api/v1/Relation/{id}
```

Gets a ContactRelationEntity object.

Calls the Relation agent service GetContactRelationEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactRelationEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/Relation/{id}?$select=name,department,category/id
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

Relationship between a (contact/person) and another (contact/person), as described by the RelationDefinition.



ContactRelationEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactRelationEntity found. |
| 304 | ContactRelationEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
GET /api/v1/Relation/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 ContactRelationEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 20 Sep 2018 18:25:50 G9T

{
  "SourceContactId": 587,
  "SourcePersonId": 769,
  "DestinationContactId": 706,
  "DestinationPersonId": 859,
  "RelationId": 177,
  "Comment": "ea",
  "RelationDefinitionId": 379,
  "Reversed": 121,
  "UpdatedDate": "2018-09-20T18:25:50.3905955+02:00",
  "CreatedDate": "2002-12-11T18:25:50.3916228+01:00",
  "CreatedBy": {
    "AssociateId": 14,
    "Name": "Rodriguez, Kohler and Davis",
    "PersonId": 640,
    "Rank": 184,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 628,
    "FullName": "Maritza Boyer",
    "FormalName": "Morissette Inc and Sons",
    "Deleted": true,
    "EjUserId": 105,
    "UserName": "Marvin, Keeling and Quigley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 634
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 222,
    "Name": "VonRueden-Langosh",
    "PersonId": 809,
    "Rank": 655,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 764,
    "FullName": "Mrs. Merlin Hegmann",
    "FormalName": "Turcotte Inc and Sons",
    "Deleted": false,
    "EjUserId": 839,
    "UserName": "Ruecker Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix value-added eyeballs"
        },
        "FieldType": "System.Int32",
        "FieldLength": 580
      }
    }
  },
  "SourceContactName": "Baumbach, Lueilwitz and Sipes",
  "SourcePersonName": "Willms LLC",
  "DestinationContactName": "Lesch Group",
  "DestinationPersonName": "Simonis Inc and Sons",
  "ActiveText": "at",
  "PassiveText": "magni",
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
      "FieldLength": 744
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```