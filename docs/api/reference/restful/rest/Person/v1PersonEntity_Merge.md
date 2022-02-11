---
title: POST Person/{id}/MergeTo/{id}
id: v1PersonEntity_Merge
---

# POST Person/{id}/MergeTo/{id}

```http
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}
```

Merge two persons.

The destination person will remain. You must specify the date after which activities will be moved along with the person.




| Path Part | Type | Description |
|-----------|------|-------------|
| sourcePersonId | int32 | The identifier for the person which will be merged into the destination person. The source person is deleted/marked retired after the merge. **Required** |
| destinationPersonId | int32 | The identifier for the person which will remain after the merge. The target person is updated. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| moveAfterDate | date-time | **Required** Merge activites after this date. Activities before this date are left alone. |
| deleteSource | bool |  If true, the source person will be deleted after the merge. If false, it will have its retired flag set |
| replaceEmptyFieldsOnDestination | bool |  If true, empty fields on destination will be replaced by values from source. |

```http
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}?moveAfterDate=11/08/1995 18:25:52
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}?deleteSource=True
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}?replaceEmptyFieldsOnDestination=True
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