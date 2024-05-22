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
  "ContactId": 626,
  "Limit": 372
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
      "TicketId": 641,
      "TicketStatus": 873,
      "Title": "distinctio",
      "Registered": "2001-12-21T12:57:33.6024486+01:00",
      "IconHint": "praesentium"
    },
    {
      "TicketId": 641,
      "TicketStatus": 873,
      "Title": "distinctio",
      "Registered": "2001-12-21T12:57:33.6024486+01:00",
      "IconHint": "praesentium"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 751,
      "DocumentId": 418,
      "Date": "2016-05-18T12:57:33.6024486+02:00",
      "Description": "Reactive fresh-thinking migration",
      "Completed": "Completed",
      "Registered": "2017-10-13T12:57:33.6024486+02:00"
    },
    {
      "AppointmentId": 751,
      "DocumentId": 418,
      "Date": "2016-05-18T12:57:33.6024486+02:00",
      "Description": "Reactive fresh-thinking migration",
      "Completed": "Completed",
      "Registered": "2017-10-13T12:57:33.6024486+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 431,
      "DocumentId": 181,
      "Date": "2004-02-07T12:57:33.6024486+01:00",
      "Description": "Balanced even-keeled projection",
      "Completed": "Completed",
      "Registered": "2002-01-13T12:57:33.6024486+01:00"
    },
    {
      "AppointmentId": 431,
      "DocumentId": 181,
      "Date": "2004-02-07T12:57:33.6024486+01:00",
      "Description": "Balanced even-keeled projection",
      "Completed": "Completed",
      "Registered": "2002-01-13T12:57:33.6024486+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 482,
      "SaleDate": "2004-08-02T12:57:33.6024486+02:00",
      "Probability": 824,
      "Heading": "error",
      "Amount": 7004.49,
      "Currency": "dolores",
      "AmountInBaseCurrency": 12761.648,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-11-28T12:57:33.6024486+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 956,
      "Name": "VonRueden, Glover and Durgan",
      "CompanyName": "Douglas Group",
      "FirstMessage": "velit",
      "LastMessage": "facere",
      "WhenRequested": "2019-01-03T12:57:33.6024486+01:00",
      "WhenEnded": "2015-05-16T12:57:33.6024486+02:00"
    }
  ]
}
```