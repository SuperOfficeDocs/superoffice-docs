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
Accept-Language: en
```

```http_
HTTP/1.1 200 ContactRelationEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 05 May 2017 09:40:59 G5T

{
  "SourceContactId": 380,
  "SourcePersonId": 249,
  "DestinationContactId": 101,
  "DestinationPersonId": 941,
  "RelationId": 859,
  "Comment": "doloremque",
  "RelationDefinitionId": 850,
  "Reversed": 910,
  "UpdatedDate": "2017-05-05T09:40:59.0153724+02:00",
  "CreatedDate": "2002-03-01T09:40:59.0153724+01:00",
  "CreatedBy": {
    "AssociateId": 67,
    "Name": "Donnelly, Erdman and Koelpin",
    "PersonId": 703,
    "Rank": 177,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 402,
    "FullName": "Maxwell McCullough",
    "FormalName": "Champlin-Witting",
    "Deleted": true,
    "EjUserId": 104,
    "UserName": "Collier-Moore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 671
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 618,
    "Name": "Rutherford, Rau and Halvorson",
    "PersonId": 854,
    "Rank": 441,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 952,
    "FullName": "Delmer Feeney IV",
    "FormalName": "Funk-Wehner",
    "Deleted": false,
    "EjUserId": 252,
    "UserName": "Hermann-Harris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 808
      }
    }
  },
  "SourceContactName": "Macejkovic-Kirlin",
  "SourcePersonName": "Turner LLC",
  "DestinationContactName": "Bogan, Herman and Brakus",
  "DestinationPersonName": "Botsford, Little and Luettgen",
  "ActiveText": "recusandae",
  "PassiveText": "dolor",
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
      "FieldLength": 361
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```