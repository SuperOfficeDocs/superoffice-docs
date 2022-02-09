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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 529,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "soluta",
    "Header": "et",
    "Name": "Heathcote Group",
    "OurRef": "beatae",
    "YourRef": "et",
    "CreatedDate": "2010-06-29T18:28:48.8649617+02:00",
    "UpdatedDate": "2005-07-01T18:28:48.8649617+02:00",
    "Description": "Focused dedicated neural-net",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2002-01-11T18:28:48.8649617+01:00",
    "ExternalRef": "et",
    "Completed": "Completed",
    "ActiveLinks": 787,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 433,
    "Snum": 265,
    "UserDefinedFields": {
      "SuperOffice:1": "445021927",
      "SuperOffice:2": "Casimir Feeney"
    },
    "ExtraFields": {
      "ExtraFields1": "atque",
      "ExtraFields2": "rerum"
    },
    "CustomFields": {
      "CustomFields1": "quisquam",
      "CustomFields2": "perferendis"
    },
    "PublishEventDate": "2016-05-09T18:28:48.8649617+02:00",
    "PublishTo": "2017-05-18T18:28:48.8649617+02:00",
    "PublishFrom": "2020-03-04T18:28:48.8649617+01:00",
    "IsPublished": true,
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