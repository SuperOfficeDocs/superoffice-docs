---
title: POST Agents/NumberAllocation/SaveDefaultNumbering
id: v1NumberAllocationAgent_SaveDefaultNumbering
---

# POST Agents/NumberAllocation/SaveDefaultNumbering

```http
POST /api/v1/Agents/NumberAllocation/SaveDefaultNumbering
```

Saves default numbering values in preferences







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/NumberAllocation/SaveDefaultNumbering?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

RefCountEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| RefCountEntity |  | A refcount entity for a number allocation <para /> Carrier object for RefCountEntity. Services for the RefCountEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.INumberAllocationAgent">NumberAllocation Agent</see>. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |