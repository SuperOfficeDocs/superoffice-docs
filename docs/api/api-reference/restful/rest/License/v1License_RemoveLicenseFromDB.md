---
title: DEL License/{moduleOwner}
id: v1License_RemoveLicenseFromDB
---

# DEL License/{moduleOwner}

```http
DELETE /api/v1/License/{moduleOwner}
```

Remove the license from a particular module owner from the database.

It is not permitted to remove licenses from SuperOffice




| Path Part | Type | Description |
|-----------|------|-------------|
| moduleOwner | string | Name of the module owner to remove license from. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Carrier object for LicenseResult.
Services for the LicenseResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ILicenseAgent">License Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Succeeded | bool |  |
| Reason | string |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
DELETE /api/v1/License/{moduleOwner}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Succeeded": false,
  "Reason": "",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 921
    }
  }
}
```