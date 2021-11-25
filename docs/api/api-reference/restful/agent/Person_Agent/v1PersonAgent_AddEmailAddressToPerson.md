---
title: POST Agents/Person/AddEmailAddressToPerson
id: v1PersonAgent_AddEmailAddressToPerson
---

# POST Agents/Person/AddEmailAddressToPerson

```http
POST /api/v1/Agents/Person/AddEmailAddressToPerson
```

Sets the primary email address on person, possibly re-ranking email addresses accordingly.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/AddEmailAddressToPerson?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

PersonId, EmailAddress, SetAsPrimaryEmail 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| EmailAddress | string |  |
| SetAsPrimaryEmail | bool |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |