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
  "ContactId": 110,
  "Limit": 87
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
      "TicketId": 227,
      "TicketStatus": 682,
      "Title": "repudiandae",
      "Registered": "2019-07-28T14:45:05.1470865+02:00",
      "IconHint": "omnis"
    },
    {
      "TicketId": 227,
      "TicketStatus": 682,
      "Title": "repudiandae",
      "Registered": "2019-07-28T14:45:05.1470865+02:00",
      "IconHint": "omnis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 501,
      "DocumentId": 394,
      "Date": "2015-01-29T14:45:05.1470865+01:00",
      "Description": "Mandatory clear-thinking solution",
      "Completed": "Completed",
      "Registered": "2020-09-03T14:45:05.1470865+02:00"
    },
    {
      "AppointmentId": 501,
      "DocumentId": 394,
      "Date": "2015-01-29T14:45:05.1470865+01:00",
      "Description": "Mandatory clear-thinking solution",
      "Completed": "Completed",
      "Registered": "2020-09-03T14:45:05.1470865+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 651,
      "DocumentId": 917,
      "Date": "2016-09-09T14:45:05.1470865+02:00",
      "Description": "Multi-layered incremental instruction set",
      "Completed": "Completed",
      "Registered": "2021-04-26T14:45:05.1470865+02:00"
    },
    {
      "AppointmentId": 651,
      "DocumentId": 917,
      "Date": "2016-09-09T14:45:05.1470865+02:00",
      "Description": "Multi-layered incremental instruction set",
      "Completed": "Completed",
      "Registered": "2021-04-26T14:45:05.1470865+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 597,
      "SaleDate": "2006-09-06T14:45:05.1470865+02:00",
      "Probability": 718,
      "Heading": "quis",
      "Amount": 2363.036,
      "Currency": "non",
      "AmountInBaseCurrency": 4324.92,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-07-28T14:45:05.1470865+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 875,
      "Name": "Runolfsson Group",
      "CompanyName": "Haley, West and Satterfield",
      "FirstMessage": "esse",
      "LastMessage": "aliquam",
      "WhenRequested": "1999-01-08T14:45:05.1470865+01:00",
      "WhenEnded": "2000-09-25T14:45:05.1470865+02:00"
    }
  ]
}
```