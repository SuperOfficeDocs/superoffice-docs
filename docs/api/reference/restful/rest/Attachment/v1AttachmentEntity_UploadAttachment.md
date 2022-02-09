---
title: POST Attachment/{id}/Content
id: v1AttachmentEntity_UploadAttachment
---

# POST Attachment/{id}/Content

```http
POST /api/v1/Attachment/{attachmentId}/Content
```

Upload an attachment and return the attachment id






| Path Part | Type | Description |
|-----------|------|-------------|
| attachmentId | int32 | The id of the attachment row, for which to attach the upload data **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `multipart/form-data`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: content  

A stream to the content to be uploaded 



## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |