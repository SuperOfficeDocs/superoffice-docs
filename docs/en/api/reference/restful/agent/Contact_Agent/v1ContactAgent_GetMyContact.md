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
  "ContactId": 996,
  "Name": "Rath, Schoen and Ziemann",
  "Department": "",
  "OrgNr": "1395423",
  "Number1": "1055265",
  "Number2": "728888",
  "UpdatedDate": "2003-05-04T16:54:54.9727418+02:00",
  "CreatedDate": "2017-12-31T16:54:54.9727418+01:00",
  "Emails": [
    {
      "Value": "cumque",
      "StrippedValue": "soluta",
      "Description": "Public-key multi-state attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "soluta",
      "Description": "Public-key multi-state attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 267,
      "Name": "Runolfsson-Donnelly",
      "ToolTip": "Quo quia.",
      "Deleted": false,
      "Rank": 706,
      "Type": "aperiam",
      "ColorBlock": 506,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2004-07-12T16:54:54.9727418+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "esse",
      "Hidden": true,
      "FullName": "Ms. Akeem Herman II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "non",
      "Description": "Focused responsive alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "non",
      "Description": "Focused responsive alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "quos",
      "Description": "Implemented multi-tasking middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 639
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "quos",
      "Description": "Implemented multi-tasking middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 639
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolor",
      "StrippedValue": "perferendis",
      "Description": "Configurable optimizing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "perferendis",
      "Description": "Configurable optimizing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "Description": "Inverse interactive array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptates",
      "PersonId": 727,
      "Mrmrs": "voluptate",
      "Firstname": "Anne",
      "Lastname": "Weber",
      "MiddleName": "McGlynn-Murray",
      "Title": "consequuntur",
      "Description": "Programmable upward-trending database",
      "Email": "rosetta.jones@mccullough.uk",
      "FullName": "Dr. Scottie Zulauf Jr.",
      "DirectPhone": "210-889-4235 x3671",
      "FormalName": "Bartoletti Group",
      "CountryId": 671,
      "ContactId": 47,
      "ContactName": "Bergnaum, Schulist and DuBuque",
      "Retired": 438,
      "Rank": 944,
      "ActiveInterests": 974,
      "ContactDepartment": "",
      "ContactCountryId": 523,
      "ContactOrgNr": "1138572",
      "FaxPhone": "011.379.0650",
      "MobilePhone": "195-869-2592",
      "ContactPhone": "966-021-6378",
      "AssociateName": "Farrell Inc and Sons",
      "AssociateId": 115,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "animi",
      "Kanalname": "fuga",
      "Post1": "facere",
      "Post2": "quod",
      "Post3": "distinctio",
      "EmailName": "ruthie@nitzsche.ca",
      "ContactFullName": "Dr. Arnoldo Presley Macejkovic",
      "ActiveErpLinks": 249,
      "TicketPriorityId": 731,
      "SupportLanguageId": 915,
      "SupportAssociateId": 610,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nemo",
  "Xstop": false,
  "ActiveInterests": 144,
  "GroupId": 894,
  "ActiveStatusMonitorId": 16,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 219,
  "DbiAgentId": 108,
  "DbiLastSyncronized": "2001-08-11T16:54:54.9767494+02:00",
  "DbiKey": "veritatis",
  "DbiLastModified": "1999-01-08T16:54:54.9767494+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 381,
  "ActiveErpLinks": 996,
  "BounceEmails": [
    "neha@greenfelder.name",
    "lon@jakubowskiwelch.co.uk"
  ],
  "Domains": [
    "hic",
    "maiores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "795911584",
    "SuperOffice:2": "Margarett Wolf"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "distinctio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 313
    }
  }
}
```