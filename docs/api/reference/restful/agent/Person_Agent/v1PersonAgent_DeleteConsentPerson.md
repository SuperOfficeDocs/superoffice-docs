---
title: POST Agents/Person/DeleteConsentPerson
id: v1PersonAgent_DeleteConsentPerson
---

# POST Agents/Person/DeleteConsentPerson

```http
POST /api/v1/Agents/Person/DeleteConsentPerson
```

Deletes the ConsentPerson







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ConsentPersonId | int32 | **Required** The id of the ConsentPerson to be deleted. |

```http
POST /api/v1/Agents/Person/DeleteConsentPerson?ConsentPersonId=597
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |