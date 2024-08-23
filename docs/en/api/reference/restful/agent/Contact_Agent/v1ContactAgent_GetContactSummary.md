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
  "ContactId": 994,
  "Limit": 246
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
      "TicketId": 28,
      "TicketStatus": 640,
      "Title": "nulla",
      "Registered": "2021-11-20T13:28:22.3355241+01:00",
      "IconHint": "dolores"
    },
    {
      "TicketId": 28,
      "TicketStatus": 640,
      "Title": "nulla",
      "Registered": "2021-11-20T13:28:22.3355241+01:00",
      "IconHint": "dolores"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 691,
      "DocumentId": 37,
      "Date": "1999-02-15T13:28:22.3355241+01:00",
      "Description": "Networked interactive task-force",
      "Completed": "Completed",
      "Registered": "2020-10-10T13:28:22.3355241+02:00"
    },
    {
      "AppointmentId": 691,
      "DocumentId": 37,
      "Date": "1999-02-15T13:28:22.3355241+01:00",
      "Description": "Networked interactive task-force",
      "Completed": "Completed",
      "Registered": "2020-10-10T13:28:22.3355241+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 847,
      "DocumentId": 532,
      "Date": "2010-12-02T13:28:22.3355241+01:00",
      "Description": "Adaptive contextually-based architecture",
      "Completed": "Completed",
      "Registered": "2023-05-28T13:28:22.3355241+02:00"
    },
    {
      "AppointmentId": 847,
      "DocumentId": 532,
      "Date": "2010-12-02T13:28:22.3355241+01:00",
      "Description": "Adaptive contextually-based architecture",
      "Completed": "Completed",
      "Registered": "2023-05-28T13:28:22.3355241+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 927,
      "SaleDate": "2002-05-30T13:28:22.3355241+02:00",
      "Probability": 934,
      "Heading": "voluptatibus",
      "Amount": 23141.456,
      "Currency": "omnis",
      "AmountInBaseCurrency": 244.452,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-07-01T13:28:22.3355241+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 626,
      "Name": "Waters LLC",
      "CompanyName": "Hudson Group",
      "FirstMessage": "est",
      "LastMessage": "consequatur",
      "WhenRequested": "2018-12-29T13:28:22.3355241+01:00",
      "WhenEnded": "2009-09-12T13:28:22.3355241+02:00"
    }
  ]
}
```