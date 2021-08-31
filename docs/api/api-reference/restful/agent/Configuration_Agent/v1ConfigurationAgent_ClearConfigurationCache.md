---
title: ClearConfigurationCache
id: v1ConfigurationAgent_ClearConfigurationCache
---

# ClearConfigurationCache

```http
POST /api/v1/Agents/Configuration/ClearConfigurationCache
```

Configuration XML's may be expensive to build and parse, and are therefore cached to the database.

&lt;para/&gt;Cahcing is per application/instance/associate, and can be turned off through the config file. &lt;para/&gt;If caching is on, and the configuration is changed, it is necessary to clear the cached configurations from the database, through this call.&lt;para/&gt;Note that changes to the externalapplication table require cache invalidation. SoAdmin will do so automatically.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/ClearConfigurationCache?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

Application, Instance, ForAllAssociates 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Application | string |  |
| Instance | string |  |
| ForAllAssociates | bool |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |