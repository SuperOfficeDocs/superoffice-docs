---
title: POST Agents/Configuration/RebuildCustomObjectArchivePanelDeltas
uid: v1ConfigurationAgent_RebuildCustomObjectArchivePanelDeltas
generated: true
content_type: reference
---

# POST Agents/Configuration/RebuildCustomObjectArchivePanelDeltas

```http
POST /api/v1/Agents/Configuration/RebuildCustomObjectArchivePanelDeltas
```

Flush and rebuild CustomObjectArchivePanel deltas.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/RebuildCustomObjectArchivePanelDeltas?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Configuration/RebuildCustomObjectArchivePanelDeltas
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```