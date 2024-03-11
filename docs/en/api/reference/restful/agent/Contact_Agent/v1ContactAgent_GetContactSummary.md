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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 872,
  "Limit": 841
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
      "TicketId": 136,
      "TicketStatus": 98,
      "Title": "omnis",
      "Registered": "1998-10-09T14:23:46.1887063+02:00",
      "IconHint": "unde"
    },
    {
      "TicketId": 136,
      "TicketStatus": 98,
      "Title": "omnis",
      "Registered": "1998-10-09T14:23:46.1887063+02:00",
      "IconHint": "unde"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 100,
      "DocumentId": 406,
      "Date": "2003-09-29T14:23:46.1887063+02:00",
      "Description": "Pre-emptive non-volatile secured line",
      "Completed": "Completed",
      "Registered": "2020-06-16T14:23:46.1887063+02:00"
    },
    {
      "AppointmentId": 100,
      "DocumentId": 406,
      "Date": "2003-09-29T14:23:46.1887063+02:00",
      "Description": "Pre-emptive non-volatile secured line",
      "Completed": "Completed",
      "Registered": "2020-06-16T14:23:46.1887063+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 353,
      "DocumentId": 48,
      "Date": "2010-04-26T14:23:46.1887063+02:00",
      "Description": "Advanced secondary firmware",
      "Completed": "Completed",
      "Registered": "1996-12-03T14:23:46.1887063+01:00"
    },
    {
      "AppointmentId": 353,
      "DocumentId": 48,
      "Date": "2010-04-26T14:23:46.1887063+02:00",
      "Description": "Advanced secondary firmware",
      "Completed": "Completed",
      "Registered": "1996-12-03T14:23:46.1887063+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 776,
      "SaleDate": "2015-07-13T14:23:46.1887063+02:00",
      "Probability": 921,
      "Heading": "qui",
      "Amount": 16713.622,
      "Currency": "ut",
      "AmountInBaseCurrency": 5023.802,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-03-25T14:23:46.1887063+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 857,
      "Name": "Von Inc and Sons",
      "CompanyName": "Pfannerstill Group",
      "FirstMessage": "vero",
      "LastMessage": "non",
      "WhenRequested": "2011-01-19T14:23:46.1887063+01:00",
      "WhenEnded": "2007-06-30T14:23:46.1887063+02:00"
    }
  ]
}
```