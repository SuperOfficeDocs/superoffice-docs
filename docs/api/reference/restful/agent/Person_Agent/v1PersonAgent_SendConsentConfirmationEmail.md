---
title: POST Agents/Person/SendConsentConfirmationEmail
uid: v1PersonAgent_SendConsentConfirmationEmail
---

# POST Agents/Person/SendConsentConfirmationEmail

```http
POST /api/v1/Agents/Person/SendConsentConfirmationEmail
```

Send confirmation email to the provided person, email address (id), using the document template

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/SendConsentConfirmationEmail?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

PersonId, EmailAddress, EmailTemplateId, CultureLcidId, Subject

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| EmailAddress | string |  |
| EmailTemplateId | int32 |  |
| CultureLcidId | int32 |  |
| Subject | string |  |

## Response

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body:

## Sample request

```http!
POST /api/v1/Agents/Person/SendConsentConfirmationEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 256,
  "EmailAddress": "marcelo@haag.co.uk",
  "EmailTemplateId": 229,
  "CultureLcidId": 559,
  "Subject": "sapiente"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
