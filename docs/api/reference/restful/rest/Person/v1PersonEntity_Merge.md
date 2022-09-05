---
title: POST Person/{id}/MergeTo/{id}
uid: v1PersonEntity_Merge
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
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}?moveAfterDate=05/28/2005 11:10:55
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}?deleteSource=False
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}?replaceEmptyFieldsOnDestination=True
```


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

Response body: 


## Sample request

```http!
POST /api/v1/Person/{sourcePersonId}/MergeTo/{destinationPersonId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```