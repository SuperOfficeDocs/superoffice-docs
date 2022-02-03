---
title: POST Agents/Marketing/DeleteFormSubmissionEntity
id: v1MarketingAgent_DeleteFormSubmissionEntity
---

# POST Agents/Marketing/DeleteFormSubmissionEntity

```http
POST /api/v1/Agents/Marketing/DeleteFormSubmissionEntity
```

Deletes the FormSubmissionEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| FormSubmissionEntityId | int32 | **Required** The id of the FormSubmissionEntity to be deleted. |

```http
POST /api/v1/Agents/Marketing/DeleteFormSubmissionEntity?FormSubmissionEntityId=257
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