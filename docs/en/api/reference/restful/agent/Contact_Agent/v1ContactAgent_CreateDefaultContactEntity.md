---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Loading default values into a new ContactEntity.


NsApiSlow threshold: 2000 ms.







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 287,
  "Name": "Terry, Streich and McCullough",
  "Department": "whiteboard world-class platforms",
  "OrgNr": "1574269",
  "Number1": "1179094",
  "Number2": "1714818",
  "UpdatedDate": "2011-09-05T02:30:46.9444678+02:00",
  "CreatedDate": "2018-06-24T02:30:46.9444678+02:00",
  "Emails": [
    {
      "Value": "dicta",
      "StrippedValue": "fuga",
      "Description": "Organic reciprocal hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "fuga",
      "Description": "Organic reciprocal hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 127,
      "Name": "Jaskolski-Price",
      "ToolTip": "Veniam aliquam dignissimos.",
      "Deleted": true,
      "Rank": 916,
      "Type": "et",
      "ColorBlock": 575,
      "IconHint": "provident",
      "Selected": true,
      "LastChanged": "2013-08-02T02:30:46.9444678+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Walter Keeling",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "accusantium",
      "Description": "Streamlined full-range architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "accusantium",
      "Description": "Streamlined full-range architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vitae",
      "StrippedValue": "ullam",
      "Description": "Mandatory tertiary attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "ullam",
      "Description": "Mandatory tertiary attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Customer-focused client-driven synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Customer-focused client-driven synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "Description": "Inverse explicit contingency",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "earum",
      "PersonId": 983,
      "Mrmrs": "ut",
      "Firstname": "Kenya",
      "Lastname": "Yost",
      "MiddleName": "Aufderhar, Williamson and Lang",
      "Title": "quibusdam",
      "Description": "Down-sized mission-critical application",
      "Email": "virginie@oconnerlittle.com",
      "FullName": "Eli Hickle",
      "DirectPhone": "(826)467-0215 x804",
      "FormalName": "Schroeder, Treutel and Spinka",
      "CountryId": 715,
      "ContactId": 951,
      "ContactName": "Kassulke Inc and Sons",
      "Retired": 407,
      "Rank": 274,
      "ActiveInterests": 915,
      "ContactDepartment": "",
      "ContactCountryId": 537,
      "ContactOrgNr": "802749",
      "FaxPhone": "(481)046-5315 x8841",
      "MobilePhone": "619.506.9865",
      "ContactPhone": "(018)244-3585 x441",
      "AssociateName": "Kling-Stark",
      "AssociateId": 874,
      "UsePersonAddress": false,
      "ContactFax": "dolorem",
      "Kanafname": "saepe",
      "Kanalname": "quasi",
      "Post1": "pariatur",
      "Post2": "et",
      "Post3": "aut",
      "EmailName": "xavier@grady.info",
      "ContactFullName": "Eli Veum",
      "ActiveErpLinks": 351,
      "TicketPriorityId": 644,
      "SupportLanguageId": 833,
      "SupportAssociateId": 192,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1529058",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 820
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sint",
  "Xstop": true,
  "ActiveInterests": 343,
  "GroupId": 350,
  "ActiveStatusMonitorId": 185,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 966,
  "DbiAgentId": 986,
  "DbiLastSyncronized": "1998-11-01T02:30:46.9444678+01:00",
  "DbiKey": "voluptas",
  "DbiLastModified": "2016-08-12T02:30:46.9444678+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 206,
  "ActiveErpLinks": 692,
  "BounceEmails": [
    "garland@ryan.name",
    "camren.collier@labadierunolfsson.info"
  ],
  "Domains": [
    "neque",
    "accusamus"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Neil Noemy Oberbrunner DVM",
    "SuperOffice:2": "Mrs. Foster Luella Lindgren Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "corporis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 14
    }
  }
}
```