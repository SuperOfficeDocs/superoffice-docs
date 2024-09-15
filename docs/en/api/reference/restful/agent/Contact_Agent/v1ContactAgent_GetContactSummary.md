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
  "ContactId": 117,
  "Limit": 86
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
      "TicketId": 972,
      "TicketStatus": 538,
      "Title": "est",
      "Registered": "2020-01-30T04:02:01.5030113+01:00",
      "IconHint": "quo"
    },
    {
      "TicketId": 972,
      "TicketStatus": 538,
      "Title": "est",
      "Registered": "2020-01-30T04:02:01.5030113+01:00",
      "IconHint": "quo"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 887,
      "DocumentId": 117,
      "Date": "1999-04-18T04:02:01.5030113+02:00",
      "Description": "Realigned bottom-line budgetary management",
      "Completed": "Completed",
      "Registered": "2015-10-04T04:02:01.5030113+02:00"
    },
    {
      "AppointmentId": 887,
      "DocumentId": 117,
      "Date": "1999-04-18T04:02:01.5030113+02:00",
      "Description": "Realigned bottom-line budgetary management",
      "Completed": "Completed",
      "Registered": "2015-10-04T04:02:01.5030113+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 663,
      "DocumentId": 899,
      "Date": "2007-08-13T04:02:01.5030113+02:00",
      "Description": "Ameliorated bottom-line migration",
      "Completed": "Completed",
      "Registered": "2000-04-19T04:02:01.5030113+02:00"
    },
    {
      "AppointmentId": 663,
      "DocumentId": 899,
      "Date": "2007-08-13T04:02:01.5030113+02:00",
      "Description": "Ameliorated bottom-line migration",
      "Completed": "Completed",
      "Registered": "2000-04-19T04:02:01.5030113+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 347,
      "SaleDate": "2000-07-20T04:02:01.5030113+02:00",
      "Probability": 955,
      "Heading": "sunt",
      "Amount": 2400.644,
      "Currency": "error",
      "AmountInBaseCurrency": 8164.07,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2015-01-17T04:02:01.5030113+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 224,
      "Name": "Nader-Abernathy",
      "CompanyName": "Simonis, King and Ortiz",
      "FirstMessage": "nihil",
      "LastMessage": "rem",
      "WhenRequested": "2005-01-22T04:02:01.5030113+01:00",
      "WhenEnded": "2017-02-07T04:02:01.5030113+01:00"
    }
  ]
}
```