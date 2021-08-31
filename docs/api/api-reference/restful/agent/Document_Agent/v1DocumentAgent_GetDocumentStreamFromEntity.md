---
title: GetDocumentStreamFromEntity
id: v1DocumentAgent_GetDocumentStreamFromEntity
---

# GetDocumentStreamFromEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 605,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "harum",
    "Header": "perspiciatis",
    "Name": "Satterfield, Rippin and Windler",
    "OurRef": "possimus",
    "YourRef": "nam",
    "CreatedDate": "2009-01-22T14:58:03.9644605+01:00",
    "UpdatedDate": "2006-07-11T14:58:03.9644605+02:00",
    "Description": "Programmable logistical migration",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2011-05-16T14:58:03.9644605+02:00",
    "ExternalRef": "repellat",
    "Completed": "Completed",
    "ActiveLinks": 31,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 469,
    "Snum": 591,
    "UserDefinedFields": {
      "SuperOffice:1": "Clement Fisher",
      "SuperOffice:2": "Ima Reichert"
    },
    "ExtraFields": {
      "ExtraFields1": "minus",
      "ExtraFields2": "aut"
    },
    "CustomFields": {
      "CustomFields1": "sapiente",
      "CustomFields2": "non"
    },
    "PublishEventDate": "2014-01-05T14:58:03.9644605+01:00",
    "PublishTo": "2011-10-14T14:58:03.9644605+02:00",
    "PublishFrom": "2000-05-05T14:58:03.9644605+02:00",
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