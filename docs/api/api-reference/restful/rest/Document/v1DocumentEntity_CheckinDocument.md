---
title: PUT Document/{id}/Lock
id: v1DocumentEntity_CheckinDocument
---

# PUT Document/{id}/Lock

```http
PUT /api/v1/Document/{documentId}/Lock
```

Check in a currently checked-out document






| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document Id **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| allowedReturnTypes | array |  List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.&lt;br/&gt;Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests. |
| versionDescription | string |  Optional textual description related to this version of the document; may be blank, and is discarded if the document/plugin do not support versioning. |
| versionExtraFields | array |  Optional extra metadata related to the new version (as opposed to metadata related to the document as a whole). Discarded if the document/plugin do not support versioning. |

```http
PUT /api/v1/Document/{documentId}/Lock?allowedReturnTypes=Message
PUT /api/v1/Document/{documentId}/Lock?versionDescription=Ergonomic fresh-thinking help-desk
PUT /api/v1/Document/{documentId}/Lock?versionExtraFields=accusantium,aut
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ExternalReference | string |  |
| VersionId | string |  |
| Success | bool |  |
| Type | string |  |
| Value | string |  |
| AdditionalInfo | string |  |

## Sample Request

```http!
PUT /api/v1/Document/{documentId}/Lock
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExternalReference": "omnis",
  "VersionId": "nobis",
  "Success": true,
  "Type": "CustomGui",
  "Value": "corrupti",
  "AdditionalInfo": "cum"
}
```