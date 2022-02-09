---
title: POST Agents/Diagnostics/ResyncUsers
id: v1DiagnosticsAgent_ResyncUsers
---

# POST Agents/Diagnostics/ResyncUsers

```http
POST /api/v1/Agents/Diagnostics/ResyncUsers
```

Resynchronize user information with SuperOffice Community, if opted-out then this call does nothing.

The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Diagnostics/ResyncUsers?$select=name,department,category/id
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