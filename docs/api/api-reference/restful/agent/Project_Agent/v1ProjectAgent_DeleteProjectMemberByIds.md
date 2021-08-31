---
title: DeleteProjectMemberByIds
id: v1ProjectAgent_DeleteProjectMemberByIds
---

# DeleteProjectMemberByIds

```http
POST /api/v1/Agents/Project/DeleteProjectMemberByIds
```

Deletes projectmembers rows.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/DeleteProjectMemberByIds?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ProjectMemberIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectMemberIds | array |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |