---
title: AddMessageFromMailData
id: v1CustomerServiceAgent_AddMessageFromMailData
---

# AddMessageFromMailData

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
| TicketId | int32 |  |
| Data | string |  |


## Response: object

A small carrier that contains information about a ticket



Carrier object for TicketInfo.
Services for the TicketInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CustomerService/AddMessageFromMailData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 741,
  "Data": "possimus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 154,
  "Title": "laborum",
  "OwnerName": "Pfannerstill LLC",
  "CategoryName": "VIP Customer",
  "PriorityName": "Botsford, Volkman and Lakin",
  "TicketUrl": "http://www.example.com/",
  "PersonName": "Sawayn, Dibbert and Fay",
  "ContactName": "Kautzer-Breitenberg",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 969
    }
  }
}
```