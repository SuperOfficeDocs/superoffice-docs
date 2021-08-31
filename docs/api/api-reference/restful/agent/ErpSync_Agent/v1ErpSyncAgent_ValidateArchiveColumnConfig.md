---
title: ValidateArchiveColumnConfig
id: v1ErpSyncAgent_ValidateArchiveColumnConfig
---

# ValidateArchiveColumnConfig

```http
POST /api/v1/Agents/ErpSync/ValidateArchiveColumnConfig
```

Clear field info from table SUPERLISTCOLUMNSIZE if field mapping changed on given connection



## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/ValidateArchiveColumnConfig?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ListOwner, ErpConnectionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ListOwner | string |  |
| ErpConnectionId | int32 |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |