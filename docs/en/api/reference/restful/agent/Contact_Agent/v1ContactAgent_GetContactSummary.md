---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
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

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 382,
  "Limit": 644
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 498,
      "TicketStatus": 109,
      "Title": "vero",
      "Registered": "2024-08-28T03:41:53.3088673+02:00",
      "IconHint": "aliquam"
    },
    {
      "TicketId": 498,
      "TicketStatus": 109,
      "Title": "vero",
      "Registered": "2024-08-28T03:41:53.3088673+02:00",
      "IconHint": "aliquam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 850,
      "DocumentId": 122,
      "Date": "2011-02-25T03:41:53.3088673+01:00",
      "Description": "Realigned attitude-oriented system engine",
      "Completed": "Completed",
      "Registered": "1998-10-24T03:41:53.3088673+02:00"
    },
    {
      "AppointmentId": 850,
      "DocumentId": 122,
      "Date": "2011-02-25T03:41:53.3088673+01:00",
      "Description": "Realigned attitude-oriented system engine",
      "Completed": "Completed",
      "Registered": "1998-10-24T03:41:53.3088673+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 952,
      "DocumentId": 741,
      "Date": "2018-07-10T03:41:53.3088673+02:00",
      "Description": "Innovative bi-directional matrix",
      "Completed": "Completed",
      "Registered": "1999-03-26T03:41:53.3088673+01:00"
    },
    {
      "AppointmentId": 952,
      "DocumentId": 741,
      "Date": "2018-07-10T03:41:53.3088673+02:00",
      "Description": "Innovative bi-directional matrix",
      "Completed": "Completed",
      "Registered": "1999-03-26T03:41:53.3088673+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 277,
      "SaleDate": "2018-09-13T03:41:53.3088673+02:00",
      "Probability": 286,
      "Heading": "corporis",
      "Amount": 16024.142,
      "Currency": "dolor",
      "AmountInBaseCurrency": 31089.28,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-09-27T03:41:53.3088673+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 360,
      "Name": "Durgan LLC",
      "CompanyName": "Monahan-Larson",
      "FirstMessage": "labore",
      "LastMessage": "et",
      "WhenRequested": "2001-09-12T03:41:53.3088673+02:00",
      "WhenEnded": "2019-02-16T03:41:53.3088673+01:00"
    }
  ]
}
```