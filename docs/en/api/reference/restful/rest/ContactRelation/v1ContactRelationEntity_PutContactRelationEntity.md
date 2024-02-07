---
title: PUT Relation/{id}
uid: v1ContactRelationEntity_PutContactRelationEntity
generated: true
---

# PUT Relation/{id}

```http
PUT /api/v1/Relation/{id}
```

Updates the existing ContactRelationEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactRelationEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Relation/{id}?$select=name,department,category/id
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

## Request Body: entity 

The ContactRelationEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceContactId | Integer | Id of the source contact. The value is mandatory. |
| SourcePersonId | Integer | Id of the source person. The value is not mandatory. The person must belong to the source contact. |
| DestinationContactId | Integer | Id of the destination contact. The value is mandatory. |
| DestinationPersonId | Integer | Id of the destination person. The value is not mandatory. The person must belong to the destination contact. |
| RelationId | Integer | Primary key |
| Comment | String | Comment for relation |
| RelationDefinitionId | Integer | Reference to definition |
| Reversed | Integer | Is direction reversed relative to definition |
| UpdatedDate | String | Last updated when  in UTC. |
| CreatedDate | String | Registered when  in UTC. |
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | String | Name of the source contact. |
| SourcePersonName | String | Name of the source person. |
| DestinationContactName | String | Name of the destination contact. |
| DestinationPersonName | String | Name of the destination person. |
| ActiveText | String | Active text for the relation. |
| PassiveText | String | Passive text for the relation. |

## Response:

ContactRelationEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactRelationEntity updated. |
| 412 | Update stopped because ContactRelationEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactRelationEntityWithLinks

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
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Relation/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 19,
  "SourcePersonId": 736,
  "DestinationContactId": 379,
  "DestinationPersonId": 449,
  "RelationId": 897,
  "Comment": "ut",
  "RelationDefinitionId": 66,
  "Reversed": 625,
  "UpdatedDate": "2024-02-04T16:55:29.5218316+01:00",
  "CreatedDate": "2017-07-05T16:55:29.5218316+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Lakin Inc and Sons",
  "SourcePersonName": "Cummerata Group",
  "DestinationContactName": "Crist Inc and Sons",
  "DestinationPersonName": "Boyle, Ankunding and Von",
  "ActiveText": "voluptatem",
  "PassiveText": "quibusdam"
}
```

## Sample response

```http_
HTTP/1.1 200 ContactRelationEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 265,
  "SourcePersonId": 253,
  "DestinationContactId": 496,
  "DestinationPersonId": 887,
  "RelationId": 306,
  "Comment": "distinctio",
  "RelationDefinitionId": 690,
  "Reversed": 591,
  "UpdatedDate": "2010-11-01T16:55:29.5238364+01:00",
  "CreatedDate": "2019-02-10T16:55:29.5238364+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Howell-Block",
  "SourcePersonName": "Satterfield LLC",
  "DestinationContactName": "Mraz Inc and Sons",
  "DestinationPersonName": "Stoltenberg Inc and Sons",
  "ActiveText": "dicta",
  "PassiveText": "sapiente",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 503
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```