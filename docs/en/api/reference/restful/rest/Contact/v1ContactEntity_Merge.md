---
title: POST Contact/{id}/MergeTo/{id}
uid: v1ContactEntity_Merge
generated: true
---

# POST Contact/{id}/MergeTo/{id}

```http
POST /api/v1/Contact/{sourceContactId}/MergeTo/{destinationContactId}
```

Merge two contacts.


The destination contact will remain.





| Path Part | Type | Description |
|-----------|------|-------------|
| sourceContactId | int32 | Source contact to merge from. This contact will disappear after the merge. **Required** |
| destinationContactId | int32 | Destination contact to merge into **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| mergeIdenticalPersons | bool |  Persons with identical names will be merged |
| replaceEmptyFieldsOnDestination | bool |  If true, empty fields on destination will be replaced by values from source. |

```http
POST /api/v1/Contact/{sourceContactId}/MergeTo/{destinationContactId}?mergeIdenticalPersons=False
POST /api/v1/Contact/{sourceContactId}/MergeTo/{destinationContactId}?replaceEmptyFieldsOnDestination=True
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

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Contact/{sourceContactId}/MergeTo/{destinationContactId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```