---
title: POST Agents/CustomObject/DeleteCustomObject
uid: v1CustomObjectAgent_DeleteCustomObject
generated: true
content_type: reference
---

# POST Agents/CustomObject/DeleteCustomObject

```http
POST /api/v1/Agents/CustomObject/DeleteCustomObject
```

Deletes a single Custom Object row by primary key.


NsApiSlow threshold: 5000 ms.


## Experimental: ## The CustomObject agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomObject/DeleteCustomObject?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

DefinitionName, Id 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefinitionName | String |  |
| Id | Integer |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/agent/request/v1CustomObjectAgent_DeleteCustomObject.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CustomObjectAgent_DeleteCustomObject.md)]