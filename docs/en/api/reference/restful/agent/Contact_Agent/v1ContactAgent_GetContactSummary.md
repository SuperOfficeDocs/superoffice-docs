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
  "ContactId": 932,
  "Limit": 145
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
      "TicketId": 715,
      "TicketStatus": 634,
      "Title": "deleniti",
      "Registered": "2014-09-10T03:44:52.3708918+02:00",
      "IconHint": "iste"
    },
    {
      "TicketId": 715,
      "TicketStatus": 634,
      "Title": "deleniti",
      "Registered": "2014-09-10T03:44:52.3708918+02:00",
      "IconHint": "iste"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 497,
      "DocumentId": 854,
      "Date": "2006-08-16T03:44:52.3708918+02:00",
      "Description": "Fundamental clear-thinking capacity",
      "Completed": "Completed",
      "Registered": "2007-07-27T03:44:52.3708918+02:00"
    },
    {
      "AppointmentId": 497,
      "DocumentId": 854,
      "Date": "2006-08-16T03:44:52.3708918+02:00",
      "Description": "Fundamental clear-thinking capacity",
      "Completed": "Completed",
      "Registered": "2007-07-27T03:44:52.3708918+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 511,
      "DocumentId": 142,
      "Date": "2017-08-25T03:44:52.3708918+02:00",
      "Description": "Synchronised hybrid orchestration",
      "Completed": "Completed",
      "Registered": "2019-08-05T03:44:52.3708918+02:00"
    },
    {
      "AppointmentId": 511,
      "DocumentId": 142,
      "Date": "2017-08-25T03:44:52.3708918+02:00",
      "Description": "Synchronised hybrid orchestration",
      "Completed": "Completed",
      "Registered": "2019-08-05T03:44:52.3708918+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 302,
      "SaleDate": "2017-01-03T03:44:52.3708918+01:00",
      "Probability": 488,
      "Heading": "quia",
      "Amount": 3102.66,
      "Currency": "provident",
      "AmountInBaseCurrency": 19850.755999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-11-19T03:44:52.3708918+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 968,
      "Name": "White LLC",
      "CompanyName": "Buckridge, Hettinger and Jakubowski",
      "FirstMessage": "ut",
      "LastMessage": "consequatur",
      "WhenRequested": "2002-03-29T03:44:52.3708918+01:00",
      "WhenEnded": "2012-08-15T03:44:52.3708918+02:00"
    }
  ]
}
```