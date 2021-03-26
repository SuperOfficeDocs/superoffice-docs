---
title: POST Agents/User/SetFunctionalRights
id: v1UserAgent_SetFunctionalRights
---

# POST Agents/User/SetFunctionalRights

```http
POST /api/v1/Agents/User/SetFunctionalRights
```

Set all functional rights for the given role.

Functional rights not specified here will be removed from the role. 


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/SetFunctionalRights?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

RoleId, FunctionalRightIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| RoleId | int32 |  |
| FunctionalRightIds | array |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |