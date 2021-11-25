---
title: POST Agents/List/SaveConsentPurpose
id: v1ListAgent_SaveConsentPurpose
---

# POST Agents/List/SaveConsentPurpose

```http
POST /api/v1/Agents/List/SaveConsentPurpose
```

Save a ConsentPurpose object







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveConsentPurpose?$select=name,department,category/id
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

ConsentPurpose 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPurpose |  | Carrier object for ConsentPurpose. Services for the ConsentPurpose Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |


## Response: object

Carrier object for ConsentPurpose.
Services for the ConsentPurpose Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| UpdatedBy |  | The associate that last updated the consent purpose |
| Deleted | bool | true if the ConsentPurpose is deleted |
| Rank | int32 | Rank of this consent source |
| PrivacyStatementDesc | string | Name or description for the privacy statement |
| PrivacyStatementUrl | string | Url referencing the actual privacy statement |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/SaveConsentPurpose
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConsentPurpose": {
    "ConsentPurposeId": 183,
    "Name": "Heaney Group",
    "ConsentText": "nemo",
    "FormText": "itaque",
    "Key": "adipisci",
    "Tooltip": "impedit",
    "Active": 323,
    "UpdatedDate": "2013-10-05T18:28:49.4200904+02:00",
    "UpdatedBy": {},
    "Deleted": true,
    "Rank": 612,
    "PrivacyStatementDesc": "voluptatem",
    "PrivacyStatementUrl": "http://www.example.com/"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPurposeId": 669,
  "Name": "Mills, Eichmann and McKenzie",
  "ConsentText": "officia",
  "FormText": "eligendi",
  "Key": "velit",
  "Tooltip": "delectus",
  "Active": 145,
  "UpdatedDate": "2012-07-08T18:28:49.4200904+02:00",
  "UpdatedBy": {
    "AssociateId": 345,
    "Name": "Watsica-Bogan",
    "PersonId": 424,
    "Rank": 708,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 348,
    "FullName": "Michel VonRueden III",
    "FormalName": "Lang, Macejkovic and Schoen",
    "Deleted": true,
    "EjUserId": 559,
    "UserName": "Breitenberg-Legros",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 719
      }
    }
  },
  "Deleted": true,
  "Rank": 250,
  "PrivacyStatementDesc": "optio",
  "PrivacyStatementUrl": "http://www.example.com/",
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
      "FieldType": "System.Int32",
      "FieldLength": 792
    }
  }
}
```