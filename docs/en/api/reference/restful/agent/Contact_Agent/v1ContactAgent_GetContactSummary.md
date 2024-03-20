---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 223,
  "Limit": 476
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
      "TicketId": 670,
      "TicketStatus": 834,
      "Title": "commodi",
      "Registered": "2001-05-28T12:19:44.9767019+02:00",
      "IconHint": "dicta"
    },
    {
      "TicketId": 670,
      "TicketStatus": 834,
      "Title": "commodi",
      "Registered": "2001-05-28T12:19:44.9767019+02:00",
      "IconHint": "dicta"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 187,
      "DocumentId": 602,
      "Date": "2018-01-29T12:19:44.9767019+01:00",
      "Description": "Open-source intangible implementation",
      "Completed": "Completed",
      "Registered": "2022-12-15T12:19:44.9767019+01:00"
    },
    {
      "AppointmentId": 187,
      "DocumentId": 602,
      "Date": "2018-01-29T12:19:44.9767019+01:00",
      "Description": "Open-source intangible implementation",
      "Completed": "Completed",
      "Registered": "2022-12-15T12:19:44.9767019+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 103,
      "DocumentId": 717,
      "Date": "2006-06-24T12:19:44.9767019+02:00",
      "Description": "Synergized assymetric instruction set",
      "Completed": "Completed",
      "Registered": "2020-11-25T12:19:44.9767019+01:00"
    },
    {
      "AppointmentId": 103,
      "DocumentId": 717,
      "Date": "2006-06-24T12:19:44.9767019+02:00",
      "Description": "Synergized assymetric instruction set",
      "Completed": "Completed",
      "Registered": "2020-11-25T12:19:44.9767019+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 920,
      "SaleDate": "1999-11-09T12:19:44.9767019+01:00",
      "Probability": 347,
      "Heading": "et",
      "Amount": 15638.66,
      "Currency": "amet",
      "AmountInBaseCurrency": 12388.702,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-09-06T12:19:44.9767019+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 810,
      "Name": "Ledner-Schoen",
      "CompanyName": "Streich Inc and Sons",
      "FirstMessage": "nulla",
      "LastMessage": "reiciendis",
      "WhenRequested": "2007-04-19T12:19:44.9767019+02:00",
      "WhenEnded": "2001-03-05T12:19:44.9767019+01:00"
    }
  ]
}
```