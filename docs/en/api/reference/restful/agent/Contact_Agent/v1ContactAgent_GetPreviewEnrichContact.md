---
title: POST Agents/Contact/GetPreviewEnrichContact
uid: v1ContactAgent_GetPreviewEnrichContact
generated: true
content_type: reference
---

# POST Agents/Contact/GetPreviewEnrichContact

```http
POST /api/v1/Agents/Contact/GetPreviewEnrichContact
```

Get a contact from its ID







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetPreviewEnrichContact?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

EnrichId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EnrichId | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreviewContact

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| CountryId | int32 | Country |
| Number2 | string | Alphanumeric user field |
| DirectPhone | string | The contacts phone |
| URL | string | The internet address to this contact |
| EmailAddress | string | The contact email address |
| BusinessName | string | The business list item name |
| CategoryName | string | The category list item name |
| AssociateFullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| Address | Address | Contact address as a list of LocalizedFieldList objects. Used to store localized information such as formatted address data. Suitable for passing to an address control for display. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetPreviewEnrichContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EnrichId": "et"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 47,
  "Name": "Champlin, Kertzmann and Thiel",
  "Department": "",
  "CountryId": 622,
  "Number2": "1200097",
  "DirectPhone": "1-454-022-7855",
  "URL": "http://www.example.com/",
  "EmailAddress": "earl@gleasonbartell.ca",
  "BusinessName": "Information Technology",
  "CategoryName": "VIP Customer",
  "AssociateFullName": "Giovanni Parker Bernhard DDS",
  "Address": null
}
```