---
title: POST Agents/Archive/SetColumnWidths
id: v1ArchiveAgent_SetColumnWidths
---

# POST Agents/Archive/SetColumnWidths

```http
POST /api/v1/Agents/Archive/SetColumnWidths
```

Set the column widths for the given set of columns and GUI name.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/SetColumnWidths?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

GuiName, ColumnWidths 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | string |  |
| ColumnWidths | array |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |