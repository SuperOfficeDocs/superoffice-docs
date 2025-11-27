---
title: DEL List/DeliveryTerm/Items/{id}
uid: v1DeliveryTermsList_DeleteDeliveryTerm
generated: true
content_type: reference
---

# DEL List/DeliveryTerm/Items/{id}

```http
DELETE /api/v1/List/DeliveryTerm/Items/{id}
```

Marks the existing DeliveryTerm list item as deleted.


Calls the List agent service SaveFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of DeliveryTerm list item to be marked as deleted. **Required** |



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

[!include[sample request](../../samples/rest/request/v1DeliveryTermsList_DeleteDeliveryTerm.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1DeliveryTermsList_DeleteDeliveryTerm.md)]