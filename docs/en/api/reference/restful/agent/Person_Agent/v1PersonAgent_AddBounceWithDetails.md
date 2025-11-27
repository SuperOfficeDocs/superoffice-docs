---
title: POST Agents/Person/AddBounceWithDetails
uid: v1PersonAgent_AddBounceWithDetails
generated: true
content_type: reference
---

# POST Agents/Person/AddBounceWithDetails

```http
POST /api/v1/Agents/Person/AddBounceWithDetails
```

Add a number of bounce counts on the email address if it exists, and with possible bounce code and reason


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/AddBounceWithDetails?$select=name,department,category/id
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

EmailAddress, Counts, Code, Reason 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | String |  |
| Counts | Integer |  |
| Code | Integer |  |
| Reason | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/agent/request/v1PersonAgent_AddBounceWithDetails.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1PersonAgent_AddBounceWithDetails.md)]