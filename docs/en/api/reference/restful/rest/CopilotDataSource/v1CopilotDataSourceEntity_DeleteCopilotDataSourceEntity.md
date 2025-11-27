---
title: DEL CopilotDataSource/{id}
uid: v1CopilotDataSourceEntity_DeleteCopilotDataSourceEntity
generated: true
content_type: reference
---

# DEL CopilotDataSource/{id}

```http
DELETE /api/v1/CopilotDataSource/{id}
```

Deletes the CopilotDataSourceEntity


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners. Calls the AI agent service DeleteCopilotDataSourceEntity.
NsApiSlow threshold: 1000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CopilotDataSourceEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

CopilotDataSourceEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | CopilotDataSourceEntity deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1CopilotDataSourceEntity_DeleteCopilotDataSourceEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CopilotDataSourceEntity_DeleteCopilotDataSourceEntity.md)]