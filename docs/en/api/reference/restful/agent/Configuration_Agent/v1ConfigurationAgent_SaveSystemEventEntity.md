---
title: POST Agents/Configuration/SaveSystemEventEntity
uid: v1ConfigurationAgent_SaveSystemEventEntity
generated: true
content_type: reference
---

# POST Agents/Configuration/SaveSystemEventEntity

```http
POST /api/v1/Agents/Configuration/SaveSystemEventEntity
```

Updates the existing SystemEventEntity or creates a new SystemEventEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: systemEventEntity 

The SystemEventEntity that is saved 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TimeZoneData

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

## Sample request

```http!
POST /api/v1/Agents/Configuration/SaveSystemEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 308,
  "Scope": "Database",
  "Eta": "2000-01-18T03:40:46.2488145+01:00",
  "Eventkey": "aut",
  "Eventmess": "unde",
  "ExtraInfo": 331,
  "Owner": 438,
  "UpdatedCount": 611,
  "Registered": "2003-03-14T03:40:46.2488145+01:00",
  "ActivatedBy": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 518,
  "Scope": "Database",
  "Eta": "2012-09-26T03:40:46.2488145+02:00",
  "Eventkey": "earum",
  "Eventmess": "perspiciatis",
  "ExtraInfo": 261,
  "Owner": 34,
  "UpdatedCount": 464,
  "Registered": "2015-08-12T03:40:46.2488145+02:00",
  "ActivatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 964
    }
  }
}
```