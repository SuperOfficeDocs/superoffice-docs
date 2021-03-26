---
title: POST Contact/{id}/MergeTo/{id}
id: v1ContactEntity_Merge
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
POST /api/v1/Contact/{sourceContactId}/MergeTo/{destinationContactId}?mergeIdenticalPersons=True
POST /api/v1/Contact/{sourceContactId}/MergeTo/{destinationContactId}?replaceEmptyFieldsOnDestination=False
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