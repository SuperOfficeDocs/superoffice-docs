---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 6
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 128,
  "Name": "Mayert-Nolan",
  "Department": "",
  "OrgNr": "549280",
  "Number1": "1059975",
  "Number2": "1052338",
  "UpdatedDate": "2017-02-11T02:30:46.9757163+01:00",
  "CreatedDate": "2008-06-24T02:30:46.9757163+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "natus",
      "Description": "Adaptive web-enabled toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "natus",
      "Description": "Adaptive web-enabled toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 650,
      "Name": "Gaylord, Grimes and Treutel",
      "ToolTip": "Est iusto in et.",
      "Deleted": false,
      "Rank": 364,
      "Type": "ipsam",
      "ColorBlock": 908,
      "IconHint": "ea",
      "Selected": true,
      "LastChanged": "2016-01-17T02:30:46.9757163+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "possimus",
      "Hidden": false,
      "FullName": "Onie Lesch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 743
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Re-contextualized multi-state intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Re-contextualized multi-state intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "totam",
      "StrippedValue": "dolor",
      "Description": "Balanced multi-state open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "dolor",
      "Description": "Balanced multi-state open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "quia",
      "Description": "Configurable radical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 197
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "quia",
      "Description": "Configurable radical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 197
        }
      }
    }
  ],
  "Description": "Team-oriented composite archive",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 685,
      "Mrmrs": "et",
      "Firstname": "Vaughn",
      "Lastname": "Crist",
      "MiddleName": "Turner, Hodkiewicz and Wunsch",
      "Title": "odio",
      "Description": "Triple-buffered demand-driven infrastructure",
      "Email": "willa_howe@mosciskifarrell.info",
      "FullName": "Molly Yundt",
      "DirectPhone": "1-148-946-3977",
      "FormalName": "Spencer, Wisozk and Hettinger",
      "CountryId": 256,
      "ContactId": 226,
      "ContactName": "Shields-Osinski",
      "Retired": 170,
      "Rank": 90,
      "ActiveInterests": 196,
      "ContactDepartment": "",
      "ContactCountryId": 815,
      "ContactOrgNr": "554830",
      "FaxPhone": "1-607-373-6173",
      "MobilePhone": "1-472-337-2032",
      "ContactPhone": "252-646-5804 x1215",
      "AssociateName": "Wehner, Wilkinson and Frami",
      "AssociateId": 766,
      "UsePersonAddress": true,
      "ContactFax": "delectus",
      "Kanafname": "unde",
      "Kanalname": "qui",
      "Post1": "omnis",
      "Post2": "harum",
      "Post3": "id",
      "EmailName": "meta@haleyschroeder.uk",
      "ContactFullName": "Dylan Heathcote",
      "ActiveErpLinks": 600,
      "TicketPriorityId": 424,
      "SupportLanguageId": 848,
      "SupportAssociateId": 666,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1506085",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "necessitatibus",
  "Xstop": false,
  "ActiveInterests": 898,
  "GroupId": 216,
  "ActiveStatusMonitorId": 413,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 501,
  "DbiAgentId": 917,
  "DbiLastSyncronized": "2005-06-20T02:30:46.9757163+02:00",
  "DbiKey": "maxime",
  "DbiLastModified": "2004-03-10T02:30:46.9757163+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 280,
  "ActiveErpLinks": 460,
  "BounceEmails": [
    "sarai@boyer.info",
    "osborne@padberg.biz"
  ],
  "Domains": [
    "ab",
    "itaque"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Roxane Gerhold",
    "SuperOffice:2": "Tremaine Nienow"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "amet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 424
    }
  }
}
```