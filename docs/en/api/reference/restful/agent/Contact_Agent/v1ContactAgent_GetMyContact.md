---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 881,
  "Name": "Koepp, Quigley and Douglas",
  "Department": "",
  "OrgNr": "325803",
  "Number1": "1450545",
  "Number2": "1144434",
  "UpdatedDate": "2006-08-11T03:40:46.405616+02:00",
  "CreatedDate": "2005-10-24T03:40:46.405616+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "pariatur",
      "Description": "Distributed assymetric circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "pariatur",
      "Description": "Distributed assymetric circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 824,
      "Name": "Crooks, Purdy and Lakin",
      "ToolTip": "Veniam esse sit magni aliquam rem et aliquam.",
      "Deleted": false,
      "Rank": 375,
      "Type": "esse",
      "ColorBlock": 684,
      "IconHint": "fugiat",
      "Selected": false,
      "LastChanged": "2020-04-22T03:40:46.405616+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Mrs. Kayli Armani Klein",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "illum",
      "StrippedValue": "officiis",
      "Description": "Multi-lateral even-keeled ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 416
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "officiis",
      "Description": "Multi-lateral even-keeled ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 416
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "qui",
      "Description": "Universal interactive neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "qui",
      "Description": "Universal interactive neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "enim",
      "Description": "Optimized stable Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "enim",
      "Description": "Optimized stable Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    }
  ],
  "Description": "Public-key national circuit",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 820,
      "Mrmrs": "aliquam",
      "Firstname": "Tad",
      "Lastname": "Lang",
      "MiddleName": "Lindgren, Schaden and Murazik",
      "Title": "voluptates",
      "Description": "Customer-focused object-oriented capability",
      "Email": "meagan_kessler@rowe.co.uk",
      "FullName": "Mrs. Thaddeus Pfannerstill MD",
      "DirectPhone": "1-024-627-5646 x04273",
      "FormalName": "Ankunding, Volkman and Jakubowski",
      "CountryId": 656,
      "ContactId": 382,
      "ContactName": "Block Group",
      "Retired": 61,
      "Rank": 286,
      "ActiveInterests": 580,
      "ContactDepartment": "",
      "ContactCountryId": 4,
      "ContactOrgNr": "805623",
      "FaxPhone": "1-766-399-6821 x019",
      "MobilePhone": "814.701.6826 x494",
      "ContactPhone": "1-239-858-1319 x24252",
      "AssociateName": "Price-Welch",
      "AssociateId": 511,
      "UsePersonAddress": true,
      "ContactFax": "alias",
      "Kanafname": "et",
      "Kanalname": "reprehenderit",
      "Post1": "eum",
      "Post2": "consequatur",
      "Post3": "eveniet",
      "EmailName": "brennan.shields@lakinmurray.biz",
      "ContactFullName": "Broderick Pinkie Nicolas IV",
      "ActiveErpLinks": 405,
      "TicketPriorityId": 301,
      "SupportLanguageId": 498,
      "SupportAssociateId": 29,
      "CategoryName": "VIP Customer",
      "PersonNumber": "226857",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "nesciunt",
  "Xstop": true,
  "ActiveInterests": 267,
  "GroupId": 898,
  "ActiveStatusMonitorId": 721,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 958,
  "DbiAgentId": 958,
  "DbiLastSyncronized": "2025-07-20T03:40:46.421242+02:00",
  "DbiKey": "beatae",
  "DbiLastModified": "2010-01-06T03:40:46.421242+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 338,
  "ActiveErpLinks": 614,
  "BounceEmails": [
    "corine_lakin@spencer.info",
    "alford@stoltenberg.com"
  ],
  "Domains": [
    "vitae",
    "laborum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Elvie Harber",
    "SuperOffice:2": "Faustino Parisian I"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "beatae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 263
    }
  }
}
```