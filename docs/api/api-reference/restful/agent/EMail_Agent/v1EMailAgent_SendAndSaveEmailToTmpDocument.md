---
title: POST Agents/EMail/SendAndSaveEmailToTmpDocument
id: v1EMailAgent_SendAndSaveEmailToTmpDocument
---

# POST Agents/EMail/SendAndSaveEmailToTmpDocument

```http
POST /api/v1/Agents/EMail/SendAndSaveEmailToTmpDocument
```

Send the provided e-mail and create tmp document ready to archive



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SendAndSaveEmailToTmpDocument?$select=name,department,category/id
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

Email, StripAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Email |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| StripAttachments | bool |  |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/Agents/EMail/SendAndSaveEmailToTmpDocument
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Email": {
    "To": [
      {},
      {}
    ],
    "Cc": [
      {},
      {}
    ],
    "Bcc": [
      {},
      {}
    ],
    "Subject": "ipsa",
    "HTMLBody": "rerum",
    "From": {},
    "Sent": "1999-06-11T16:48:29.5309245+02:00",
    "Size": 805,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "quaerat",
    "PlainBody": "et",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 508,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Conroy-Olson",
    "EmailItemId": 31,
    "AccountId": 761,
    "ReceivedAt": "2010-04-14T16:48:29.5309245+02:00",
    "InReplyTo": {},
    "RepliedAt": "2008-10-23T16:48:29.5309245+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted"
  },
  "StripAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"leda.mohr@kassulke.info"
```