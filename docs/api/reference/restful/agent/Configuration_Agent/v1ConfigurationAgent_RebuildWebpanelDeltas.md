---
title: POST Agents/Configuration/RebuildWebpanelDeltas
id: v1ConfigurationAgent_RebuildWebpanelDeltas
---

# POST Agents/Configuration/RebuildWebpanelDeltas

```http
POST /api/v1/Agents/Configuration/RebuildWebpanelDeltas
```

Flush and rebuild webpanel deltas.

Mostly used after adding/editing webpanels or change group visibility of them

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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

| Response | Description |
|----------------|-------------|
| 204 | No Content |
