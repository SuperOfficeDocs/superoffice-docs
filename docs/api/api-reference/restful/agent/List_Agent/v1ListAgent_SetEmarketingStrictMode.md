---
title: POST Agents/List/SetEmarketingStrictMode
id: v1ListAgent_SetEmarketingStrictMode
---

# POST Agents/List/SetEmarketingStrictMode

```http
POST /api/v1/Agents/List/SetEmarketingStrictMode
```

Turn on the Emarketing strict mode, which will enable full GDPR rules concerning Emarketing consents and subscriptions







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetEmarketingStrictMode?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

Enable 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Enable | bool |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |