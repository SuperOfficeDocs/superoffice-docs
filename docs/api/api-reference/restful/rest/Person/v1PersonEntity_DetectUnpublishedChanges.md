---
title: GET Person/UdefLayout/Changed
id: v1PersonEntity_DetectUnpublishedChanges
---

# GET Person/UdefLayout/Changed

```http
GET /api/v1/Person/UdefLayout/Changed
```

Is the UDef Layout changed? This may or may not involve moving data (which takes longer).

True if the PersonEntity user-defined field layout has been changed.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| columnChangesOnly | bool |  True: Check if we need to move data.  Default/False: Check if layout has changed. |

```http
GET /api/v1/Person/UdefLayout/Changed?columnChangesOnly=False
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


## Response: bool



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: bool


## Sample Request

```http!
GET /api/v1/Person/UdefLayout/Changed
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

true
```