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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 94,
  "Name": "Kuphal, Maggio and Greenholt",
  "Department": "",
  "OrgNr": "1793652",
  "Number1": "1406945",
  "Number2": "759942",
  "UpdatedDate": "2001-02-23T14:28:21.6022855+01:00",
  "CreatedDate": "2017-04-15T14:28:21.6022855+02:00",
  "Emails": [
    {
      "Value": "repellat",
      "StrippedValue": "veritatis",
      "Description": "Reduced fresh-thinking migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "veritatis",
      "Description": "Reduced fresh-thinking migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 95,
      "Name": "Schinner-Zulauf",
      "ToolTip": "Facere et eius inventore eum.",
      "Deleted": false,
      "Rank": 479,
      "Type": "nulla",
      "ColorBlock": 981,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2019-07-24T14:28:21.6022855+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Garrett Kreiger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "sunt",
      "Description": "Organic actuating infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 876
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "sunt",
      "Description": "Organic actuating infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 876
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Advanced clear-thinking protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Advanced clear-thinking protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ab",
      "StrippedValue": "error",
      "Description": "Organic solution-oriented project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "error",
      "Description": "Organic solution-oriented project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "Description": "Profit-focused fault-tolerant system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatibus",
      "PersonId": 816,
      "Mrmrs": "optio",
      "Firstname": "Anastacio",
      "Lastname": "Thiel",
      "MiddleName": "Harvey Group",
      "Title": "veniam",
      "Description": "Balanced attitude-oriented intranet",
      "Email": "tyrique_feeney@schuster.us",
      "FullName": "Lester Sporer",
      "DirectPhone": "1-082-293-5184 x23467",
      "FormalName": "Rutherford-Bradtke",
      "CountryId": 805,
      "ContactId": 890,
      "ContactName": "Carroll-Price",
      "Retired": 561,
      "Rank": 31,
      "ActiveInterests": 236,
      "ContactDepartment": "",
      "ContactCountryId": 527,
      "ContactOrgNr": "448876",
      "FaxPhone": "566-392-6742 x695",
      "MobilePhone": "922-430-5392 x055",
      "ContactPhone": "1-725-633-5131",
      "AssociateName": "Schoen, Swift and Klocko",
      "AssociateId": 765,
      "UsePersonAddress": false,
      "ContactFax": "explicabo",
      "Kanafname": "officia",
      "Kanalname": "voluptatem",
      "Post1": "consequatur",
      "Post2": "id",
      "Post3": "non",
      "EmailName": "charlotte@doyle.info",
      "ContactFullName": "Milan Lincoln Bartoletti III",
      "ActiveErpLinks": 27,
      "TicketPriorityId": 634,
      "SupportLanguageId": 638,
      "SupportAssociateId": 879,
      "CategoryName": "VIP Customer",
      "PersonNumber": "977662",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolores",
  "Xstop": true,
  "ActiveInterests": 559,
  "GroupId": 404,
  "ActiveStatusMonitorId": 761,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 271,
  "DbiAgentId": 807,
  "DbiLastSyncronized": "2015-05-25T14:28:21.6022855+02:00",
  "DbiKey": "nulla",
  "DbiLastModified": "2017-06-26T14:28:21.6022855+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 582,
  "ActiveErpLinks": 578,
  "BounceEmails": [
    "rozella@haley.name",
    "ena@howe.co.uk"
  ],
  "Domains": [
    "ut",
    "reprehenderit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Alize Wehner",
    "SuperOffice:2": "1802406777"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "fuga"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 307
    }
  }
}
```