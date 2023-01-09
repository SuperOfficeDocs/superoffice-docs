---
title: PUT Relation/{id}
uid: v1ContactRelationEntity_PutContactRelationEntity
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
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Relation/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 692,
  "SourcePersonId": 891,
  "DestinationContactId": 322,
  "DestinationPersonId": 513,
  "RelationId": 716,
  "Comment": "possimus",
  "RelationDefinitionId": 974,
  "Reversed": 861,
  "UpdatedDate": "2021-08-15T17:37:38.4748628+02:00",
  "CreatedDate": "2016-03-10T17:37:38.4748628+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Kuhn, Lynch and Kshlerin",
  "SourcePersonName": "Maggio Inc and Sons",
  "DestinationContactName": "Dach-Walsh",
  "DestinationPersonName": "Jewess LLC",
  "ActiveText": "qui",
  "PassiveText": "vel"
}
```

## Sample response

```http_
HTTP/1.1 200 ContactRelationEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 78,
  "SourcePersonId": 234,
  "DestinationContactId": 164,
  "DestinationPersonId": 470,
  "RelationId": 691,
  "Comment": "maxime",
  "RelationDefinitionId": 891,
  "Reversed": 641,
  "UpdatedDate": "2013-12-04T17:37:38.4788649+01:00",
  "CreatedDate": "2002-04-24T17:37:38.4788649+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Ullrich-Dare",
  "SourcePersonName": "Dietrich LLC",
  "DestinationContactName": "Miller-Beatty",
  "DestinationPersonName": "Denesik-Torphy",
  "ActiveText": "nobis",
  "PassiveText": "aut",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 572
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```