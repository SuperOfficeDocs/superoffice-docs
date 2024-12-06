---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 476,
  "Name": "Cronin-Kertzmann",
  "Department": "",
  "OrgNr": "1094384",
  "Number1": "1668786",
  "Number2": "1178031",
  "UpdatedDate": "2007-10-26T10:17:55.2383919+02:00",
  "CreatedDate": "2003-06-19T10:17:55.2383919+02:00",
  "Emails": [
    {
      "Value": "unde",
      "StrippedValue": "aut",
      "Description": "Focused multi-state parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 652
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "aut",
      "Description": "Focused multi-state parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 652
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 349,
      "Name": "Tremblay, Koelpin and Oberbrunner",
      "ToolTip": "Vel quidem velit ex dolorem neque voluptates.",
      "Deleted": false,
      "Rank": 282,
      "Type": "itaque",
      "ColorBlock": 58,
      "IconHint": "eligendi",
      "Selected": false,
      "LastChanged": "2008-09-06T10:17:55.2383919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "blanditiis",
      "StyleHint": "maxime",
      "Hidden": true,
      "FullName": "Mr. Akeem Felipa Jacobi II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "porro",
      "Description": "Front-line mission-critical standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 145
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "porro",
      "Description": "Front-line mission-critical standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 145
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laudantium",
      "StrippedValue": "aperiam",
      "Description": "Triple-buffered dynamic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 128
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "aperiam",
      "Description": "Triple-buffered dynamic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 128
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Seamless 3rd generation policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Seamless 3rd generation policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "Description": "Devolved high-level core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minima",
      "PersonId": 551,
      "Mrmrs": "enim",
      "Firstname": "Edgar",
      "Lastname": "Christiansen",
      "MiddleName": "Klocko, Kuhic and Grimes",
      "Title": "sit",
      "Description": "Re-contextualized optimizing alliance",
      "Email": "cristobal@mckenzie.info",
      "FullName": "Melvin Mills",
      "DirectPhone": "1-161-276-6788 x90501",
      "FormalName": "Gusikowski-Fay",
      "CountryId": 373,
      "ContactId": 98,
      "ContactName": "Greenholt Inc and Sons",
      "Retired": 443,
      "Rank": 774,
      "ActiveInterests": 223,
      "ContactDepartment": "",
      "ContactCountryId": 246,
      "ContactOrgNr": "160439",
      "FaxPhone": "(397)316-0912",
      "MobilePhone": "832-574-8712 x46195",
      "ContactPhone": "513-813-0931 x13559",
      "AssociateName": "Hudson-Kris",
      "AssociateId": 518,
      "UsePersonAddress": true,
      "ContactFax": "doloribus",
      "Kanafname": "aut",
      "Kanalname": "fugit",
      "Post1": "qui",
      "Post2": "laudantium",
      "Post3": "alias",
      "EmailName": "orlando.zulauf@champlin.name",
      "ContactFullName": "Lennie Lueilwitz",
      "ActiveErpLinks": 826,
      "TicketPriorityId": 217,
      "SupportLanguageId": 59,
      "SupportAssociateId": 256,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "autem",
  "Xstop": false,
  "ActiveInterests": 470,
  "GroupId": 109,
  "ActiveStatusMonitorId": 375,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 440,
  "DbiAgentId": 484,
  "DbiLastSyncronized": "2002-02-09T10:17:55.2383919+01:00",
  "DbiKey": "provident",
  "DbiLastModified": "2018-06-26T10:17:55.2383919+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 897,
  "ActiveErpLinks": 220,
  "BounceEmails": [
    "javonte_rogahn@moen.com",
    "clifton_beer@pourosmckenzie.ca"
  ],
  "Domains": [
    "incidunt",
    "sapiente"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Doris Hauck",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 22
    }
  }
}
```