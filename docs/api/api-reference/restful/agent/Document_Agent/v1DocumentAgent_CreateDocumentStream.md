---
title: CreateDocumentStream
id: v1DocumentAgent_CreateDocumentStream
---

# CreateDocumentStream

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 841,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "expedita",
    "Header": "et",
    "Name": "Rath-Moore",
    "OurRef": "aut",
    "YourRef": "in",
    "CreatedDate": "2016-10-31T14:58:03.9764679+01:00",
    "UpdatedDate": "2008-10-24T14:58:03.9764679+02:00",
    "Description": "Seamless mission-critical matrices",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2020-03-17T14:58:03.9764679+01:00",
    "ExternalRef": "autem",
    "Completed": "Completed",
    "ActiveLinks": 434,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 447,
    "Snum": 178,
    "UserDefinedFields": {
      "SuperOffice:1": "Kendall Veum",
      "SuperOffice:2": "Mr. Janae Von"
    },
    "ExtraFields": {
      "ExtraFields1": "omnis",
      "ExtraFields2": "quaerat"
    },
    "CustomFields": {
      "CustomFields1": "accusamus",
      "CustomFields2": "voluptatem"
    },
    "PublishEventDate": "2021-04-09T14:58:03.9764679+02:00",
    "PublishTo": "2000-05-09T14:58:03.9764679+02:00",
    "PublishFrom": "1994-08-09T14:58:03.9764679+02:00",
    "IsPublished": false,
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