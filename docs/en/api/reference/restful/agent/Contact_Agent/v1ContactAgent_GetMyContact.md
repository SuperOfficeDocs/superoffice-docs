---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 680,
  "Name": "Goodwin Group",
  "Department": "",
  "OrgNr": "1296746",
  "Number1": "1071080",
  "Number2": "982026",
  "UpdatedDate": "2023-01-27T14:28:21.6335339+01:00",
  "CreatedDate": "1999-04-09T14:28:21.6335339+02:00",
  "Emails": [
    {
      "Value": "pariatur",
      "StrippedValue": "commodi",
      "Description": "Re-engineered regional time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "commodi",
      "Description": "Re-engineered regional time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 405,
      "Name": "Bartoletti-Bayer",
      "ToolTip": "Itaque autem odio aut est dolorum.",
      "Deleted": true,
      "Rank": 72,
      "Type": "excepturi",
      "ColorBlock": 673,
      "IconHint": "perspiciatis",
      "Selected": false,
      "LastChanged": "2002-05-03T14:28:21.6335339+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Dr. Madison Regan Sauer III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "cupiditate",
      "Description": "Team-oriented human-resource moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 937
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "cupiditate",
      "Description": "Team-oriented human-resource moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 937
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Stand-alone full-range framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Stand-alone full-range framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "pariatur",
      "Description": "Reverse-engineered full-range model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "pariatur",
      "Description": "Reverse-engineered full-range model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 49
        }
      }
    }
  ],
  "Description": "Public-key tertiary core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 913,
      "Mrmrs": "exercitationem",
      "Firstname": "Ezra",
      "Lastname": "Herzog",
      "MiddleName": "Bartell Group",
      "Title": "harum",
      "Description": "Re-engineered attitude-oriented website",
      "Email": "wilson@pollich.com",
      "FullName": "Mrs. Ashton Grace Von Sr.",
      "DirectPhone": "1-973-456-1296",
      "FormalName": "Schoen LLC",
      "CountryId": 756,
      "ContactId": 348,
      "ContactName": "Brown-D'Amore",
      "Retired": 289,
      "Rank": 291,
      "ActiveInterests": 469,
      "ContactDepartment": "",
      "ContactCountryId": 832,
      "ContactOrgNr": "1128261",
      "FaxPhone": "830.369.1980 x621",
      "MobilePhone": "(414)860-3491 x025",
      "ContactPhone": "875-188-4235 x3822",
      "AssociateName": "Ledner, Dare and Reichel",
      "AssociateId": 909,
      "UsePersonAddress": false,
      "ContactFax": "commodi",
      "Kanafname": "voluptatem",
      "Kanalname": "ratione",
      "Post1": "libero",
      "Post2": "illum",
      "Post3": "maxime",
      "EmailName": "zita@kilback.ca",
      "ContactFullName": "Nichole Reynolds",
      "ActiveErpLinks": 947,
      "TicketPriorityId": 717,
      "SupportLanguageId": 571,
      "SupportAssociateId": 193,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1028179",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 678
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nobis",
  "Xstop": true,
  "ActiveInterests": 548,
  "GroupId": 701,
  "ActiveStatusMonitorId": 559,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 25,
  "DbiAgentId": 668,
  "DbiLastSyncronized": "2002-09-28T14:28:21.6335339+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2025-03-24T14:28:21.6335339+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 775,
  "ActiveErpLinks": 903,
  "BounceEmails": [
    "casimer_lind@huel.info",
    "helena.adams@prosacco.name"
  ],
  "Domains": [
    "architecto",
    "non"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2074358923",
    "SuperOffice:2": "Elyssa Stroman"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 435
    }
  }
}
```