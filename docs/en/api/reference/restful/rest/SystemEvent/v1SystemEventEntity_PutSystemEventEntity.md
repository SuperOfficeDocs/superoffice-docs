---
title: PUT SystemEvent/{id}
uid: v1SystemEventEntity_PutSystemEventEntity
generated: true
content_type: reference
---

# PUT SystemEvent/{id}

```http
PUT /api/v1/SystemEvent/{id}
```

Updates the existing SystemEventEntity


NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SystemEventEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/SystemEvent/{id}?$select=name,department,category/id
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

The SystemEventEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SystemEventId | Integer |  |
| Scope | String |  |
| Eta | String |  |
| Eventkey | String |  |
| Eventmess | String |  |
| ExtraInfo | Integer |  |
| Owner | Integer |  |
| UpdatedCount | Integer |  |
| Registered | String |  |
| ActivatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |

## Response:

SystemEventEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | SystemEventEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: SystemEventEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| SystemEventId | int32 |  |
| Scope | string |  |
| Eta | date-time |  |
| Eventkey | string |  |
| Eventmess | string |  |
| ExtraInfo | int32 |  |
| Owner | int32 |  |
| UpdatedCount | int32 |  |
| Registered | date-time |  |
| ActivatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/SystemEvent/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 988,
  "Scope": "Database",
  "Eta": "2013-01-01T03:40:56.2890936+01:00",
  "Eventkey": "quo",
  "Eventmess": "voluptate",
  "ExtraInfo": 191,
  "Owner": 349,
  "UpdatedCount": 433,
  "Registered": "2009-04-09T03:40:56.2890936+02:00",
  "ActivatedBy": null
}
```

## Sample response

```http_
HTTP/1.1 200 SystemEventEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 924,
  "Scope": "Database",
  "Eta": "2013-11-12T03:40:56.320343+01:00",
  "Eventkey": "odio",
  "Eventmess": "omnis",
  "ExtraInfo": 402,
  "Owner": 903,
  "UpdatedCount": 644,
  "Registered": "2010-01-01T03:40:56.320343+01:00",
  "ActivatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 112
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```