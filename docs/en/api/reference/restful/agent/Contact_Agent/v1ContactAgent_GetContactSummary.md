---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
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
| ContactId | int32 |  |
| Limit | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
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
  "ContactId": 787,
  "Limit": 489
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
      "TicketId": 472,
      "TicketStatus": 767,
      "Title": "est",
      "Registered": "2020-11-04T02:49:43.9972802+01:00",
      "IconHint": "non"
    },
    {
      "TicketId": 472,
      "TicketStatus": 767,
      "Title": "est",
      "Registered": "2020-11-04T02:49:43.9972802+01:00",
      "IconHint": "non"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 991,
      "DocumentId": 706,
      "Date": "2008-06-07T02:49:43.9972802+02:00",
      "Description": "Grass-roots multi-tasking array",
      "Completed": "Completed",
      "Registered": "2018-03-25T02:49:43.9972802+01:00"
    },
    {
      "AppointmentId": 991,
      "DocumentId": 706,
      "Date": "2008-06-07T02:49:43.9972802+02:00",
      "Description": "Grass-roots multi-tasking array",
      "Completed": "Completed",
      "Registered": "2018-03-25T02:49:43.9972802+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 417,
      "DocumentId": 820,
      "Date": "2001-12-07T02:49:43.9972802+01:00",
      "Description": "Synergized even-keeled framework",
      "Completed": "Completed",
      "Registered": "2003-12-02T02:49:43.9972802+01:00"
    },
    {
      "AppointmentId": 417,
      "DocumentId": 820,
      "Date": "2001-12-07T02:49:43.9972802+01:00",
      "Description": "Synergized even-keeled framework",
      "Completed": "Completed",
      "Registered": "2003-12-02T02:49:43.9972802+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 644,
      "SaleDate": "2015-07-25T02:49:43.9972802+02:00",
      "Probability": 767,
      "Heading": "amet",
      "Amount": 11417.162,
      "Currency": "distinctio",
      "AmountInBaseCurrency": 14457.142,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-09-11T02:49:43.9972802+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 779,
      "Name": "DuBuque, O'Kon and Gislason",
      "CompanyName": "Bogan LLC",
      "FirstMessage": "voluptas",
      "LastMessage": "repellendus",
      "WhenRequested": "2012-02-08T02:49:43.9972802+01:00",
      "WhenEnded": "2017-06-20T02:49:43.9972802+02:00"
    }
  ]
}
```