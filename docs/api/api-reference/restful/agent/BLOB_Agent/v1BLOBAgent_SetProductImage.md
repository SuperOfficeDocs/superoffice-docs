---
title: SetProductImage
id: v1BLOBAgent_SetProductImage
---

# SetProductImage

```http
POST /api/v1/Agents/BLOB/SetProductImage
```

Stores the product image that is displayed in the CRM application.

The image is scaled down to max 1000x1000. This method operates only the main (rank=1) image; future extensions may support multiple images. A thumbnail of size 75x75 is also automatically set.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BLOB/SetProductImage?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ProductId, Image 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProductId | int32 |  |
| Image | byte |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |