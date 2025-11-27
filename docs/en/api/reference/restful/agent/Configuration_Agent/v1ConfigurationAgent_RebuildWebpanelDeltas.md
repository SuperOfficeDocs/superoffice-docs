---
title: POST Agents/Configuration/RebuildWebpanelDeltas
uid: v1ConfigurationAgent_RebuildWebpanelDeltas
generated: true
content_type: reference
---

# POST Agents/Configuration/RebuildWebpanelDeltas

```http
POST /api/v1/Agents/Configuration/RebuildWebpanelDeltas
```

Flush and rebuild webpanel deltas.


Mostly used after adding/editing webpanels or change group visibility of them
NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/RebuildWebpanelDeltas?$select=name,department,category/id
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

[!include[sample request](../../samples/agent/request/v1ConfigurationAgent_RebuildWebpanelDeltas.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ConfigurationAgent_RebuildWebpanelDeltas.md)]