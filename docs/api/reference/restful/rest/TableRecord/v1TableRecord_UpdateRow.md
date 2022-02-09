---
title: PUT Table/{tableName}/{id}
id: v1TableRecord_UpdateRow
---

# PUT Table/{tableName}/{id}

```http
PUT /api/v1/Table/{tableName}/{id}
```

Update a row in a table



## Online Restricted: ## The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.




| Path Part | Type | Description |
|-----------|------|-------------|
| tableName | string | The name of the table to update; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable **Required** |
| id | int32 | The id of the row to update **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: values  

A StringDictionary with the values to update. You do not need to specify all the values in the table. The omitted ones will remain unchanged 



## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |
| 400 | Bad request. Entity to save is not in request body. |