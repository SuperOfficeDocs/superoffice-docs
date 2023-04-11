---
title: GET Relation/{id}
uid: v1ContactRelationEntity_GetContactRelationEntity
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


## Response:

ContactRelationEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactRelationEntity found. |
| 304 | ContactRelationEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
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
GET /api/v1/Relation/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ContactRelationEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 07 Jan 2016 15:29:29 G1T

{
  "SourceContactId": 871,
  "SourcePersonId": 938,
  "DestinationContactId": 884,
  "DestinationPersonId": 661,
  "RelationId": 657,
  "Comment": "ut",
  "RelationDefinitionId": 441,
  "Reversed": 460,
  "UpdatedDate": "2016-01-07T15:29:29.6117014+01:00",
  "CreatedDate": "2018-05-11T15:29:29.6117014+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Stanton-Wolf",
  "SourcePersonName": "Waelchi, Welch and Thiel",
  "DestinationContactName": "Hettinger Group",
  "DestinationPersonName": "Wintheiser Inc and Sons",
  "ActiveText": "aut",
  "PassiveText": "sit",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 100
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```