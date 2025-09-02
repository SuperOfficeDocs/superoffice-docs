---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
content_type: reference
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
  "ContactId": 579,
  "Limit": 4
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
      "TicketId": 994,
      "TicketStatus": 356,
      "Title": "nisi",
      "Registered": "2018-05-11T03:46:54.5507645+02:00",
      "IconHint": "neque"
    },
    {
      "TicketId": 994,
      "TicketStatus": 356,
      "Title": "nisi",
      "Registered": "2018-05-11T03:46:54.5507645+02:00",
      "IconHint": "neque"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 688,
      "DocumentId": 876,
      "Date": "2010-11-24T03:46:54.5507645+01:00",
      "Description": "Balanced value-added collaboration",
      "Completed": "Completed",
      "Registered": "2022-03-15T03:46:54.5507645+01:00"
    },
    {
      "AppointmentId": 688,
      "DocumentId": 876,
      "Date": "2010-11-24T03:46:54.5507645+01:00",
      "Description": "Balanced value-added collaboration",
      "Completed": "Completed",
      "Registered": "2022-03-15T03:46:54.5507645+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 481,
      "DocumentId": 2,
      "Date": "2004-11-25T03:46:54.5507645+01:00",
      "Description": "Fundamental mobile core",
      "Completed": "Completed",
      "Registered": "2014-05-25T03:46:54.5507645+02:00"
    },
    {
      "AppointmentId": 481,
      "DocumentId": 2,
      "Date": "2004-11-25T03:46:54.5507645+01:00",
      "Description": "Fundamental mobile core",
      "Completed": "Completed",
      "Registered": "2014-05-25T03:46:54.5507645+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 816,
      "SaleDate": "2018-03-15T03:46:54.5507645+01:00",
      "Probability": 147,
      "Heading": "autem",
      "Amount": 10038.202,
      "Currency": "consectetur",
      "AmountInBaseCurrency": 9480.35,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-11-19T03:46:54.5507645+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 191,
      "Name": "Toy Inc and Sons",
      "CompanyName": "Crist, McClure and Hahn",
      "FirstMessage": "libero",
      "LastMessage": "sunt",
      "WhenRequested": "2004-03-20T03:46:54.5507645+01:00",
      "WhenEnded": "2021-07-09T03:46:54.5507645+02:00"
    }
  ]
}
```