---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
content_type: reference
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 110
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 394,
  "Name": "Effertz-Konopelski",
  "Department": "",
  "OrgNr": "1245402",
  "Number1": "923141",
  "Number2": "1482292",
  "UpdatedDate": "2014-11-21T03:46:54.53514+01:00",
  "CreatedDate": "2017-10-18T03:46:54.53514+02:00",
  "Emails": [
    {
      "Value": "vero",
      "StrippedValue": "est",
      "Description": "Mandatory tangible utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "est",
      "Description": "Mandatory tangible utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 116,
      "Name": "Goodwin LLC",
      "ToolTip": "Quos quod corporis laudantium aut.",
      "Deleted": false,
      "Rank": 583,
      "Type": "dolorem",
      "ColorBlock": 554,
      "IconHint": "recusandae",
      "Selected": false,
      "LastChanged": "2015-06-26T03:46:54.53514+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tenetur",
      "StyleHint": "enim",
      "Hidden": true,
      "FullName": "Dr. Jo Kuhn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "et",
      "Description": "Fully-configurable mobile archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "et",
      "Description": "Fully-configurable mobile archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "fugit",
      "StrippedValue": "expedita",
      "Description": "Virtual even-keeled success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "expedita",
      "Description": "Virtual even-keeled success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "cumque",
      "Description": "Synergistic user-facing interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 809
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "cumque",
      "Description": "Synergistic user-facing interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 809
        }
      }
    }
  ],
  "Description": "Optional high-level encryption",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "labore",
      "PersonId": 52,
      "Mrmrs": "molestiae",
      "Firstname": "Ike",
      "Lastname": "Kozey",
      "MiddleName": "Mosciski, Willms and Dickinson",
      "Title": "maxime",
      "Description": "Open-architected interactive framework",
      "Email": "dave_schaefer@gutkowski.info",
      "FullName": "Gaston O'Connell",
      "DirectPhone": "799.522.0256",
      "FormalName": "O'Reilly-Hintz",
      "CountryId": 65,
      "ContactId": 452,
      "ContactName": "Bailey Group",
      "Retired": 98,
      "Rank": 383,
      "ActiveInterests": 755,
      "ContactDepartment": "",
      "ContactCountryId": 487,
      "ContactOrgNr": "1432617",
      "FaxPhone": "1-581-189-0926 x461",
      "MobilePhone": "1-735-805-6002 x72491",
      "ContactPhone": "025.671.0517 x229",
      "AssociateName": "Kerluke, Bahringer and Fahey",
      "AssociateId": 171,
      "UsePersonAddress": true,
      "ContactFax": "cum",
      "Kanafname": "atque",
      "Kanalname": "aut",
      "Post1": "voluptatem",
      "Post2": "maxime",
      "Post3": "porro",
      "EmailName": "donna.christiansen@keeblersenger.com",
      "ContactFullName": "Alejandra Boyle",
      "ActiveErpLinks": 911,
      "TicketPriorityId": 62,
      "SupportLanguageId": 213,
      "SupportAssociateId": 455,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1301094",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 235
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ea",
  "Xstop": true,
  "ActiveInterests": 904,
  "GroupId": 676,
  "ActiveStatusMonitorId": 286,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 746,
  "DbiAgentId": 505,
  "DbiLastSyncronized": "2010-08-14T03:46:54.53514+02:00",
  "DbiKey": "fugit",
  "DbiLastModified": "2003-05-09T03:46:54.53514+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 925,
  "ActiveErpLinks": 695,
  "BounceEmails": [
    "ezequiel@purdy.co.uk",
    "sheridan@raynor.com"
  ],
  "Domains": [
    "corporis",
    "magnam"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Bruce Hintz",
    "SuperOffice:2": "871914317"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "impedit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 191
    }
  }
}
```