---
title: POST Agents/Contact/CreateDefaultPreviewContact
uid: v1ContactAgent_CreateDefaultPreviewContact
---

# POST Agents/Contact/CreateDefaultPreviewContact

```http
POST /api/v1/Agents/Contact/CreateDefaultPreviewContact
```

Set default values into a new PreviewContact.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Contact/CreateDefaultPreviewContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 569,
  "Name": "Wiegand-Botsford",
  "Department": "",
  "CountryId": 450,
  "Number2": "568635",
  "DirectPhone": "389-965-2833 x6733",
  "URL": "http://www.example.com/",
  "EmailAddress": "jeremy.crona@hirtheborer.uk",
  "BusinessName": "Information Technology",
  "CategoryName": "VIP Customer",
  "AssociateFullName": "Prof. Estella Hoppe",
  "Address": null
}
```