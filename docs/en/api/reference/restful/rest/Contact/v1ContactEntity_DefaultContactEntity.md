---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 07 Feb 2011 13:38:17 G2T

{
  "ContactId": 168,
  "Name": "Kutch, Doyle and Goodwin",
  "Department": "",
  "OrgNr": "1375093",
  "Number1": "1231691",
  "Number2": "1351810",
  "UpdatedDate": "2011-02-07T13:38:17.218095+01:00",
  "CreatedDate": "2007-09-07T13:38:17.218095+02:00",
  "Emails": [
    {
      "Value": "neque",
      "StrippedValue": "aliquid",
      "Description": "Visionary directional budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "aliquid",
      "Description": "Visionary directional budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 547,
      "Name": "Sipes Inc and Sons",
      "ToolTip": "Quidem et velit illo commodi cum et sit.",
      "Deleted": false,
      "Rank": 321,
      "Type": "id",
      "ColorBlock": 675,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "1999-04-19T13:38:17.218095+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "cumque",
      "Hidden": false,
      "FullName": "Mr. Darren Daron Durgan MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "omnis",
      "Description": "Profound incremental middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 555
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "omnis",
      "Description": "Profound incremental middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 555
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nihil",
      "StrippedValue": "id",
      "Description": "Enhanced 4th generation structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 292
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "id",
      "Description": "Enhanced 4th generation structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 292
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "sequi",
      "Description": "Ergonomic 24 hour utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 960
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "sequi",
      "Description": "Ergonomic 24 hour utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 960
        }
      }
    }
  ],
  "Description": "Synchronised high-level methodology",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sunt",
      "PersonId": 174,
      "Mrmrs": "perspiciatis",
      "Firstname": "Elijah",
      "Lastname": "Nader",
      "MiddleName": "Green Group",
      "Title": "illo",
      "Description": "Quality-focused global matrices",
      "Email": "maryse_wintheiser@rosenbaum.us",
      "FullName": "Eva Jaskolski",
      "DirectPhone": "(522)333-1799 x487",
      "FormalName": "Ortiz-Blanda",
      "CountryId": 135,
      "ContactId": 356,
      "ContactName": "Sawayn LLC",
      "Retired": 338,
      "Rank": 785,
      "ActiveInterests": 632,
      "ContactDepartment": "",
      "ContactCountryId": 926,
      "ContactOrgNr": "1494488",
      "FaxPhone": "394.152.5312 x987",
      "MobilePhone": "(147)703-7874",
      "ContactPhone": "(423)690-2938 x7752",
      "AssociateName": "Batz Group",
      "AssociateId": 521,
      "UsePersonAddress": true,
      "ContactFax": "quibusdam",
      "Kanafname": "voluptate",
      "Kanalname": "maxime",
      "Post1": "quae",
      "Post2": "nemo",
      "Post3": "et",
      "EmailName": "cale@schaefer.ca",
      "ContactFullName": "Kendall Armstrong",
      "ActiveErpLinks": 243,
      "TicketPriorityId": 899,
      "SupportLanguageId": 664,
      "SupportAssociateId": 844,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 699
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quasi",
  "Xstop": false,
  "ActiveInterests": 289,
  "GroupId": 803,
  "ActiveStatusMonitorId": 291,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 427,
  "DbiAgentId": 26,
  "DbiLastSyncronized": "2015-07-03T13:38:17.218095+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "1998-01-03T13:38:17.218095+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 669,
  "ActiveErpLinks": 479,
  "BounceEmails": [
    "lauretta_powlowski@hartmann.ca",
    "brittany.nitzsche@konopelskikuhic.ca"
  ],
  "Domains": [
    "eos",
    "eum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Erwin Jared Effertz I",
    "SuperOffice:2": "Mrs. Kacey Shayne Boyle"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 574
    }
  }
}
```