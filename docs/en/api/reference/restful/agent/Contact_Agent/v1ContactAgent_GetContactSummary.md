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
  "ContactId": 504,
  "Limit": 200
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
      "TicketId": 51,
      "TicketStatus": 277,
      "Title": "ut",
      "Registered": "2023-02-05T14:32:02.5148741+01:00",
      "IconHint": "qui"
    },
    {
      "TicketId": 51,
      "TicketStatus": 277,
      "Title": "ut",
      "Registered": "2023-02-05T14:32:02.5148741+01:00",
      "IconHint": "qui"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 756,
      "DocumentId": 242,
      "Date": "2003-12-14T14:32:02.5148741+01:00",
      "Description": "Pre-emptive methodical archive",
      "Completed": "Completed",
      "Registered": "2015-04-12T14:32:02.5148741+02:00"
    },
    {
      "AppointmentId": 756,
      "DocumentId": 242,
      "Date": "2003-12-14T14:32:02.5148741+01:00",
      "Description": "Pre-emptive methodical archive",
      "Completed": "Completed",
      "Registered": "2015-04-12T14:32:02.5148741+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 545,
      "DocumentId": 98,
      "Date": "2007-01-30T14:32:02.5148741+01:00",
      "Description": "Devolved scalable methodology",
      "Completed": "Completed",
      "Registered": "2012-01-08T14:32:02.5148741+01:00"
    },
    {
      "AppointmentId": 545,
      "DocumentId": 98,
      "Date": "2007-01-30T14:32:02.5148741+01:00",
      "Description": "Devolved scalable methodology",
      "Completed": "Completed",
      "Registered": "2012-01-08T14:32:02.5148741+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 991,
      "SaleDate": "2005-03-13T14:32:02.5148741+01:00",
      "Probability": 865,
      "Heading": "quasi",
      "Amount": 11473.574,
      "Currency": "iusto",
      "AmountInBaseCurrency": 19374.388,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-03-09T14:32:02.5148741+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 563,
      "Name": "Kovacek LLC",
      "CompanyName": "Effertz LLC",
      "FirstMessage": "voluptatem",
      "LastMessage": "consequuntur",
      "WhenRequested": "2011-08-28T14:32:02.5148741+02:00",
      "WhenEnded": "2007-11-02T14:32:02.5148741+01:00"
    }
  ]
}
```