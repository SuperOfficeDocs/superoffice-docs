---
title: POST Agents/Configuration/GetSystemEventEntity
uid: v1ConfigurationAgent_GetSystemEventEntity
generated: true
content_type: reference
---

# POST Agents/Configuration/GetSystemEventEntity

```http
POST /api/v1/Agents/Configuration/GetSystemEventEntity
```

Gets a SystemEventEntity object.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| systemEventEntityId | int32 | **Required** The identifier of the SystemEventEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetSystemEventEntity?systemEventEntityId=33
POST /api/v1/Agents/Configuration/GetSystemEventEntity?$select=name,department,category/id
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

[!include[sample request](../../samples/agent/request/v1ConfigurationAgent_GetSystemEventEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ConfigurationAgent_GetSystemEventEntity.md)]