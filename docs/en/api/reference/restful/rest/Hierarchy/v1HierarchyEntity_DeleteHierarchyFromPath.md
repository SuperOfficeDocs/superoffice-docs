---
title: DEL Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_DeleteHierarchyFromPath
generated: true
content_type: reference
---

# DEL Hierarchy/{domain}/{path}

```http
DELETE /api/v1/Hierarchy/{domain}/{path}
```

Remove a hierarchy item and its children from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards, EmailFlows | Type of items to get **Required** |
| path | string | Hierarchy path to item to delete **Required** |



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

[!include[sample request](../../samples/rest/request/v1HierarchyEntity_DeleteHierarchyFromPath.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1HierarchyEntity_DeleteHierarchyFromPath.md)]