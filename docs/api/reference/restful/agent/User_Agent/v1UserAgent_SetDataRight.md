---
title: POST Agents/User/SetDataRight
id: v1UserAgent_SetDataRight
---

# POST Agents/User/SetDataRight

```http
POST /api/v1/Agents/User/SetDataRight
```

Set one specific data right at the given position.

An exception will be thrown if non existing position is specified.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/SetDataRight?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

RoleId, TableName, RelationToOwner, DataRightValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| RoleId | int32 |  |
| TableName | string |  |
| RelationToOwner | string |  |
| DataRightValue | string |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |