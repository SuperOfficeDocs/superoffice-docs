---
title: POST Agents/Audience/DeleteConfigParameter
id: v1AudienceAgent_DeleteConfigParameter
---

# POST Agents/Audience/DeleteConfigParameter

```http
POST /api/v1/Agents/Audience/DeleteConfigParameter
```

Deletes an Audience configuration parameter belonging to a Audience layout







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/DeleteConfigParameter?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

LayoutName, ParameterName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LayoutName | string |  |
| ParameterName | string |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |