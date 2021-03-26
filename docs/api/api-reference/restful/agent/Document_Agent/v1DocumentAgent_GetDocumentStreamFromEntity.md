---
title: POST Agents/Document/GetDocumentStreamFromEntity
id: v1DocumentAgent_GetDocumentStreamFromEntity
---

# POST Agents/Document/GetDocumentStreamFromEntity

```http
POST /api/v1/Agents/Document/GetDocumentStreamFromEntity
```

Get the document as a stream







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetDocumentStreamFromEntity?$select=name,department,category/id
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

DocumentEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntity |  | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |


## Response: 



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 


## Sample Request

```http!
POST /api/v1/Agents/Document/GetDocumentStreamFromEntity
Authorization: Basic dGplMDpUamUw
Accept: binary/octet-stream
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 61,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "aut",
    "Header": "harum",
    "Name": "Bashirian, Abbott and Jenkins",
    "OurRef": "at",
    "YourRef": "aliquid",
    "CreatedDate": "2000-11-16T16:48:29.3899221+01:00",
    "UpdatedDate": "2004-04-05T16:48:29.3899221+02:00",
    "Description": "Enterprise-wide well-modulated adapter",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1994-01-04T16:48:29.3899221+01:00",
    "ExternalRef": "consequatur",
    "Completed": "Completed",
    "ActiveLinks": 661,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 541,
    "Snum": 623,
    "UserDefinedFields": {
      "SuperOffice:1": "Opal O'Hara",
      "SuperOffice:2": "Mr. Zoe Littel"
    },
    "ExtraFields": {
      "ExtraFields1": "totam",
      "ExtraFields2": "perspiciatis"
    },
    "CustomFields": {
      "CustomFields1": "consequatur",
      "CustomFields2": "perspiciatis"
    },
    "PublishEventDate": "2002-08-21T16:48:29.3909247+02:00",
    "PublishTo": "2001-07-19T16:48:29.3909247+02:00",
    "PublishFrom": "1999-09-13T16:48:29.3909247+02:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: binary/octet-stream

GIF89....File contents as raw bytes...
```