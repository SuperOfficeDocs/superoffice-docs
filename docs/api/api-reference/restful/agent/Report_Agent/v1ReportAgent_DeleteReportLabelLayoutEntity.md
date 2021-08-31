---
title: DeleteReportLabelLayoutEntity
id: v1ReportAgent_DeleteReportLabelLayoutEntity
---

# DeleteReportLabelLayoutEntity

```http
POST /api/v1/Agents/Report/DeleteReportLabelLayoutEntity
```

Deletes the ReportLabelLayoutEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ReportLabelLayoutEntityId | int32 | **Required** The id of the ReportLabelLayoutEntity to be deleted. |

```http
POST /api/v1/Agents/Report/DeleteReportLabelLayoutEntity?ReportLabelLayoutEntityId=96
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