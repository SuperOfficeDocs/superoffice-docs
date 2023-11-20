---
title: POST Agents/Person/DeleteConsentPerson
uid: v1PersonAgent_DeleteConsentPerson
generated: true
---

# POST Agents/Person/DeleteConsentPerson

```http
POST /api/v1/Agents/Person/DeleteConsentPerson
```

Deletes the ConsentPerson







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ConsentPersonId | int32 | **Required** The id of the ConsentPerson to be deleted. |

```http
POST /api/v1/Agents/Person/DeleteConsentPerson?ConsentPersonId=369
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
POST /api/v1/Agents/Person/DeleteConsentPerson
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