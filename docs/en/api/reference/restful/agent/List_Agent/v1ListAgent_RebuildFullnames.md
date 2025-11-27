---
title: POST Agents/List/RebuildFullnames
uid: v1ListAgent_RebuildFullnames
generated: true
content_type: reference
---

# POST Agents/List/RebuildFullnames

```http
POST /api/v1/Agents/List/RebuildFullnames
```

Update the fullname field of all categories.


Use this e.g. when changing parentId or renaming a category with children.
NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/RebuildFullnames?$select=name,department,category/id
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

[!include[sample request](../../samples/agent/request/v1ListAgent_RebuildFullnames.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_RebuildFullnames.md)]