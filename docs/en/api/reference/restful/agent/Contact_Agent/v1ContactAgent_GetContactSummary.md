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
  "ContactId": 59,
  "Limit": 709
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
      "TicketId": 915,
      "TicketStatus": 84,
      "Title": "et",
      "Registered": "2020-09-20T17:54:02.8983424+02:00",
      "IconHint": "ut"
    },
    {
      "TicketId": 915,
      "TicketStatus": 84,
      "Title": "et",
      "Registered": "2020-09-20T17:54:02.8983424+02:00",
      "IconHint": "ut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 90,
      "DocumentId": 275,
      "Date": "2022-02-07T17:54:02.8983424+01:00",
      "Description": "Progressive contextually-based benchmark",
      "Completed": "Completed",
      "Registered": "2019-10-28T17:54:02.8983424+01:00"
    },
    {
      "AppointmentId": 90,
      "DocumentId": 275,
      "Date": "2022-02-07T17:54:02.8983424+01:00",
      "Description": "Progressive contextually-based benchmark",
      "Completed": "Completed",
      "Registered": "2019-10-28T17:54:02.8983424+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 308,
      "DocumentId": 969,
      "Date": "2016-11-06T17:54:02.8983424+01:00",
      "Description": "Self-enabling dedicated methodology",
      "Completed": "Completed",
      "Registered": "2023-06-13T17:54:02.8983424+02:00"
    },
    {
      "AppointmentId": 308,
      "DocumentId": 969,
      "Date": "2016-11-06T17:54:02.8983424+01:00",
      "Description": "Self-enabling dedicated methodology",
      "Completed": "Completed",
      "Registered": "2023-06-13T17:54:02.8983424+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 196,
      "SaleDate": "2021-06-06T17:54:02.8983424+02:00",
      "Probability": 57,
      "Heading": "accusamus",
      "Amount": 19537.356,
      "Currency": "est",
      "AmountInBaseCurrency": 8750.128,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-06-03T17:54:02.8983424+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 483,
      "Name": "Breitenberg-Nitzsche",
      "CompanyName": "Goldner Inc and Sons",
      "FirstMessage": "ab",
      "LastMessage": "rem",
      "WhenRequested": "2012-12-14T17:54:02.8983424+01:00",
      "WhenEnded": "1998-02-23T17:54:02.8983424+01:00"
    }
  ]
}
```