---
title: POST Agents/CustomerService/AddMessageFromMailData
uid: v1CustomerServiceAgent_AddMessageFromMailData
generated: true
---

# POST Agents/CustomerService/AddMessageFromMailData

```http
POST /api/v1/Agents/CustomerService/AddMessageFromMailData
```

This method will add a message to an existing request in the sam way as importMail would do it from an email.


It accepts RFC822 formatted data






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/AddMessageFromMailData?$select=name,department,category/id
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

TicketId, Data 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |
| Data | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The id of the created ticket |
| Title | string | The title/subject of the created ticket |
| OwnerName | string | The name of the owner which the request was assigned to |
| CategoryName | string | The name of the category for the request |
| PriorityName | string | The name of the priority for the request |
| TicketUrl | string | A URL leading directly to the created request. This is a URL ment to be used by a Service user |
| PersonName | string | The name of the person/customer connected to the ticket |
| ContactName | string | The name of the contact/company connected to the ticket |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/AddMessageFromMailData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 528,
  "Data": "quaerat"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 898,
  "Title": "laborum",
  "OwnerName": "Robel-Reynolds",
  "CategoryName": "VIP Customer",
  "PriorityName": "Bogisich, Cronin and Bosco",
  "TicketUrl": "http://www.example.com/",
  "PersonName": "Wyman, Johns and Kuvalis",
  "ContactName": "Kirlin Inc and Sons",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 393
    }
  }
}
```