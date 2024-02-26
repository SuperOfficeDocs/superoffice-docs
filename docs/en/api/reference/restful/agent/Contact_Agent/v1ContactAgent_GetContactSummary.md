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
  "ContactId": 883,
  "Limit": 539
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
      "TicketId": 961,
      "TicketStatus": 728,
      "Title": "neque",
      "Registered": "2022-07-21T10:30:23.3824403+02:00",
      "IconHint": "minima"
    },
    {
      "TicketId": 961,
      "TicketStatus": 728,
      "Title": "neque",
      "Registered": "2022-07-21T10:30:23.3824403+02:00",
      "IconHint": "minima"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 92,
      "DocumentId": 707,
      "Date": "2021-01-24T10:30:23.3824403+01:00",
      "Description": "Grass-roots high-level process improvement",
      "Completed": "Completed",
      "Registered": "2016-11-26T10:30:23.3824403+01:00"
    },
    {
      "AppointmentId": 92,
      "DocumentId": 707,
      "Date": "2021-01-24T10:30:23.3824403+01:00",
      "Description": "Grass-roots high-level process improvement",
      "Completed": "Completed",
      "Registered": "2016-11-26T10:30:23.3824403+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 869,
      "DocumentId": 465,
      "Date": "2013-09-26T10:30:23.3824403+02:00",
      "Description": "Switchable optimal function",
      "Completed": "Completed",
      "Registered": "2014-12-22T10:30:23.3824403+01:00"
    },
    {
      "AppointmentId": 869,
      "DocumentId": 465,
      "Date": "2013-09-26T10:30:23.3824403+02:00",
      "Description": "Switchable optimal function",
      "Completed": "Completed",
      "Registered": "2014-12-22T10:30:23.3824403+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 392,
      "SaleDate": "2017-08-16T10:30:23.3824403+02:00",
      "Probability": 198,
      "Heading": "quia",
      "Amount": 12686.431999999999,
      "Currency": "omnis",
      "AmountInBaseCurrency": 21427.158,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-02-23T10:30:23.3824403+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 470,
      "Name": "Murphy-Lesch",
      "CompanyName": "Kertzmann LLC",
      "FirstMessage": "saepe",
      "LastMessage": "eos",
      "WhenRequested": "2015-03-02T10:30:23.3824403+01:00",
      "WhenEnded": "2013-10-19T10:30:23.3824403+02:00"
    }
  ]
}
```