---
title: POST Project/{id}/MergeTo/{id}
id: v1ProjectEntity_Merge
---

# POST Project/{id}/MergeTo/{id}

```http
POST /api/v1/Project/{sourceProjectId}/MergeTo/{destinationProjectId}
```

Merge two projects into one, removing the source project in the process






| Path Part | Type | Description |
|-----------|------|-------------|
| sourceProjectId | int32 | Id of source project for merge. This project is removed after the merge is completed. **Required** |
| destinationProjectId | int32 | Id of destination project to merge to. This project is updated with info from the source. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| replaceEmptyFieldsOnDestination | bool |  Fill in empty fields on destination from source? |

```http
POST /api/v1/Project/{sourceProjectId}/MergeTo/{destinationProjectId}?replaceEmptyFieldsOnDestination=False
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