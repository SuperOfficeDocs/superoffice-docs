---
title: PUT List/ConsentPurpose/Items/{id}
uid: v1ConsentPurposeList_PutConsentPurpose
generated: true
---

# PUT List/ConsentPurpose/Items/{id}

```http
PUT /api/v1/List/ConsentPurpose/Items/{id}
```

Updates the existing ConsentPurpose


Calls the List agent service SaveConsentPurpose.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of ConsentPurpose to be saved. **Required** |



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

## Request Body: entity 

The details of ConsentPurpose to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPurposeId | Integer | Primary key |
| Name | String | Name of consent purpose |
| ConsentText | String | Form text used for the actual checkbox |
| FormText | String | Text for the consent form, the long text to be shown when asking the end-user for this kind of consent |
| Key | String | The key used to refer to this purpose, like #Process, #Emarketing etc. |
| Tooltip | String | List item tooltip |
| Active | Integer | Is the consent purpose active or not |
| UpdatedDate | String | The date the consent purpose was last updated  in UTC. |
| UpdatedBy | Associate | The associate that last updated the consent purpose |
| Deleted | Boolean | true if the ConsentPurpose is deleted |
| Rank | Integer | Rank of this consent source |
| PrivacyStatementDesc | String | Name or description for the privacy statement |
| PrivacyStatementUrl | String | Url referencing the actual privacy statement |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ConsentPurpose

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPurposeId | int32 | Primary key |
| Name | string | Name of consent purpose |
| ConsentText | string | Form text used for the actual checkbox |
| FormText | string | Text for the consent form, the long text to be shown when asking the end-user for this kind of consent |
| Key | string | The key used to refer to this purpose, like #Process, #Emarketing etc. |
| Tooltip | string | List item tooltip |
| Active | int32 | Is the consent purpose active or not |
| UpdatedDate | date-time | The date the consent purpose was last updated  in UTC. |
| UpdatedBy | Associate | The associate that last updated the consent purpose |
| Deleted | bool | true if the ConsentPurpose is deleted |
| Rank | int32 | Rank of this consent source |
| PrivacyStatementDesc | string | Name or description for the privacy statement |
| PrivacyStatementUrl | string | Url referencing the actual privacy statement |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/ConsentPurpose/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 94,
  "Name": "Hoeger LLC",
  "ConsentText": "suscipit",
  "FormText": "minima",
  "Key": "qui",
  "Tooltip": "enim",
  "Active": 606,
  "UpdatedDate": "2012-11-16T04:02:07.1034721+01:00",
  "UpdatedBy": null,
  "Deleted": false,
  "Rank": 385,
  "PrivacyStatementDesc": "eius",
  "PrivacyStatementUrl": "http://www.example.com/"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 390,
  "Name": "McGlynn, Hills and Koelpin",
  "ConsentText": "iusto",
  "FormText": "ea",
  "Key": "nobis",
  "Tooltip": "iure",
  "Active": 408,
  "UpdatedDate": "2019-12-11T04:02:07.1034721+01:00",
  "UpdatedBy": null,
  "Deleted": true,
  "Rank": 312,
  "PrivacyStatementDesc": "rerum",
  "PrivacyStatementUrl": "http://www.example.com/",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 230
    }
  }
}
```