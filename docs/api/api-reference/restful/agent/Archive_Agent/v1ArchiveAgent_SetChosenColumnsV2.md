---
title: SetChosenColumnsV2
id: v1ArchiveAgent_SetChosenColumnsV2
---

# SetChosenColumnsV2

```http
POST /api/v1/Agents/Archive/SetChosenColumnsV2
```

Set the currently chosen columns for the given gui name/provider name combination.

This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveColumns: plus the archive provider name and gui name as its additionalInfo.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/SetChosenColumnsV2?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

GuiName, ProviderName, Context, OwnerKeys, ChosenColumns 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | string |  |
| ProviderName | string |  |
| Context | string |  |
| OwnerKeys | string |  |
| ChosenColumns | array |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |