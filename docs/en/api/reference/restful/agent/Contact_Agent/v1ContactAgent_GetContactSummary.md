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
  "ContactId": 397,
  "Limit": 26
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
      "TicketId": 767,
      "TicketStatus": 725,
      "Title": "et",
      "Registered": "2014-09-12T11:16:08.9440885+02:00",
      "IconHint": "sapiente"
    },
    {
      "TicketId": 767,
      "TicketStatus": 725,
      "Title": "et",
      "Registered": "2014-09-12T11:16:08.9440885+02:00",
      "IconHint": "sapiente"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 21,
      "DocumentId": 893,
      "Date": "2023-01-25T11:16:08.9440885+01:00",
      "Description": "Distributed multimedia model",
      "Completed": "Completed",
      "Registered": "2001-06-17T11:16:08.9440885+02:00"
    },
    {
      "AppointmentId": 21,
      "DocumentId": 893,
      "Date": "2023-01-25T11:16:08.9440885+01:00",
      "Description": "Distributed multimedia model",
      "Completed": "Completed",
      "Registered": "2001-06-17T11:16:08.9440885+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 682,
      "DocumentId": 295,
      "Date": "2021-12-14T11:16:08.9440885+01:00",
      "Description": "Persistent leading edge encoding",
      "Completed": "Completed",
      "Registered": "2000-01-03T11:16:08.9440885+01:00"
    },
    {
      "AppointmentId": 682,
      "DocumentId": 295,
      "Date": "2021-12-14T11:16:08.9440885+01:00",
      "Description": "Persistent leading edge encoding",
      "Completed": "Completed",
      "Registered": "2000-01-03T11:16:08.9440885+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 729,
      "SaleDate": "2017-01-09T11:16:08.9440885+01:00",
      "Probability": 577,
      "Heading": "quia",
      "Amount": 2413.18,
      "Currency": "qui",
      "AmountInBaseCurrency": 18641.032,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2009-01-20T11:16:08.9440885+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 147,
      "Name": "Koch, Kling and Predovic",
      "CompanyName": "King-Friesen",
      "FirstMessage": "illum",
      "LastMessage": "id",
      "WhenRequested": "2006-03-18T11:16:08.9440885+01:00",
      "WhenEnded": "2018-01-31T11:16:08.9440885+01:00"
    }
  ]
}
```