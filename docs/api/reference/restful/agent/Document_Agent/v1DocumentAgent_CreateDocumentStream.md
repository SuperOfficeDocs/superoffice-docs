---
title: POST Agents/Document/CreateDocumentStream
id: v1DocumentAgent_CreateDocumentStream
---

# POST Agents/Document/CreateDocumentStream

```http
POST /api/v1/Agents/Document/CreateDocumentStream
```

Creates a new Stream that can be used to store the document in the file archive.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateDocumentStream?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/json-patch+json`, `application/merge-patch+json`, `application/pdf`, `text/html`, `text/plain`, `multipart/related` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

DocumentEntity, OverwriteExistingData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntity |  | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |
| OverwriteExistingData | bool |  |


## Response: 



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 


## Sample Request

```http!
POST /api/v1/Agents/Document/CreateDocumentStream
Authorization: Basic dGplMDpUamUw
Accept: binary/octet-stream
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 594,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "ab",
    "Header": "nisi",
    "Name": "Dickens-Gaylord",
    "OurRef": "ea",
    "YourRef": "doloribus",
    "CreatedDate": "1998-06-08T18:28:48.8769625+02:00",
    "UpdatedDate": "2018-04-17T18:28:48.8769625+02:00",
    "Description": "Self-enabling well-modulated functionalities",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1997-07-08T18:28:48.8769625+02:00",
    "ExternalRef": "est",
    "Completed": "Completed",
    "ActiveLinks": 36,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 582,
    "Snum": 327,
    "UserDefinedFields": {
      "SuperOffice:1": "Jamil Funk",
      "SuperOffice:2": "Mr. Dallas Franecki"
    },
    "ExtraFields": {
      "ExtraFields1": "autem",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "eum",
      "CustomFields2": "ducimus"
    },
    "PublishEventDate": "2007-04-10T18:28:48.8779615+02:00",
    "PublishTo": "2018-06-21T18:28:48.8779615+02:00",
    "PublishFrom": "2017-10-11T18:28:48.8779615+02:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "OverwriteExistingData": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: binary/octet-stream

GIF89....File contents as raw bytes...
```