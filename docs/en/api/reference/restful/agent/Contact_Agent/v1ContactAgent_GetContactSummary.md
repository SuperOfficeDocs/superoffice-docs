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
  "ContactId": 243,
  "Limit": 278
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
      "TicketId": 110,
      "TicketStatus": 201,
      "Title": "consectetur",
      "Registered": "2006-06-22T16:00:40.4612623+02:00",
      "IconHint": "labore"
    },
    {
      "TicketId": 110,
      "TicketStatus": 201,
      "Title": "consectetur",
      "Registered": "2006-06-22T16:00:40.4612623+02:00",
      "IconHint": "labore"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 950,
      "DocumentId": 664,
      "Date": "1997-07-03T16:00:40.4612623+02:00",
      "Description": "Cross-platform 3rd generation definition",
      "Completed": "Completed",
      "Registered": "1997-01-26T16:00:40.4612623+01:00"
    },
    {
      "AppointmentId": 950,
      "DocumentId": 664,
      "Date": "1997-07-03T16:00:40.4612623+02:00",
      "Description": "Cross-platform 3rd generation definition",
      "Completed": "Completed",
      "Registered": "1997-01-26T16:00:40.4612623+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 518,
      "DocumentId": 703,
      "Date": "2022-08-28T16:00:40.4612623+02:00",
      "Description": "Organized national intranet",
      "Completed": "Completed",
      "Registered": "1997-06-09T16:00:40.4612623+02:00"
    },
    {
      "AppointmentId": 518,
      "DocumentId": 703,
      "Date": "2022-08-28T16:00:40.4612623+02:00",
      "Description": "Organized national intranet",
      "Completed": "Completed",
      "Registered": "1997-06-09T16:00:40.4612623+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 524,
      "SaleDate": "2004-09-28T16:00:40.4612623+02:00",
      "Probability": 716,
      "Heading": "distinctio",
      "Amount": 7380.57,
      "Currency": "sit",
      "AmountInBaseCurrency": 2877.0119999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2012-05-29T16:00:40.4612623+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 87,
      "Name": "Metz, Heaney and Walker",
      "CompanyName": "Welch, Schulist and West",
      "FirstMessage": "non",
      "LastMessage": "et",
      "WhenRequested": "2022-06-26T16:00:40.4612623+02:00",
      "WhenEnded": "2021-11-10T16:00:40.4612623+01:00"
    }
  ]
}
```