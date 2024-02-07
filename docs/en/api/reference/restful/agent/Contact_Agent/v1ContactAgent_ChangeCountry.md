---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 896
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 234,
  "Name": "Leffler, Simonis and Tillman",
  "Department": "",
  "OrgNr": "1497243",
  "Number1": "901720",
  "Number2": "91731",
  "UpdatedDate": "2009-08-15T16:54:55.000753+02:00",
  "CreatedDate": "2009-03-24T16:54:55.000753+01:00",
  "Emails": [
    {
      "Value": "quis",
      "StrippedValue": "illum",
      "Description": "Assimilated methodical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 66
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "illum",
      "Description": "Assimilated methodical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 66
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 759,
      "Name": "Denesik, Kreiger and Donnelly",
      "ToolTip": "Hic omnis saepe enim sed.",
      "Deleted": false,
      "Rank": 183,
      "Type": "quis",
      "ColorBlock": 505,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "1999-02-20T16:54:55.000753+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Amina O'Hara",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "est",
      "Description": "Horizontal zero defect task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "est",
      "Description": "Horizontal zero defect task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "magni",
      "Description": "Centralized maximized customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "magni",
      "Description": "Centralized maximized customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nam",
      "StrippedValue": "et",
      "Description": "Universal transitional emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "et",
      "Description": "Universal transitional emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "Description": "Front-line hybrid architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quos",
      "PersonId": 929,
      "Mrmrs": "tempore",
      "Firstname": "Christy",
      "Lastname": "Lakin",
      "MiddleName": "Kuphal, Reynolds and Marquardt",
      "Title": "iure",
      "Description": "Monitored empowering project",
      "Email": "pinkie@bashirianklocko.biz",
      "FullName": "Tod Ankunding",
      "DirectPhone": "1-284-593-9150 x00777",
      "FormalName": "Ryan, Zieme and Walker",
      "CountryId": 500,
      "ContactId": 267,
      "ContactName": "Torp-Stokes",
      "Retired": 520,
      "Rank": 140,
      "ActiveInterests": 120,
      "ContactDepartment": "",
      "ContactCountryId": 629,
      "ContactOrgNr": "1818953",
      "FaxPhone": "745.246.2368",
      "MobilePhone": "(881)257-6491",
      "ContactPhone": "(558)296-4587",
      "AssociateName": "Cole LLC",
      "AssociateId": 600,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "officiis",
      "Kanalname": "iste",
      "Post1": "esse",
      "Post2": "quisquam",
      "Post3": "aspernatur",
      "EmailName": "tessie@oconnellroob.co.uk",
      "ContactFullName": "Ephraim Leannon",
      "ActiveErpLinks": 560,
      "TicketPriorityId": 26,
      "SupportLanguageId": 674,
      "SupportAssociateId": 911,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aliquam",
  "Xstop": false,
  "ActiveInterests": 212,
  "GroupId": 343,
  "ActiveStatusMonitorId": 984,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 576,
  "DbiAgentId": 370,
  "DbiLastSyncronized": "2014-09-08T16:54:55.0027541+02:00",
  "DbiKey": "quis",
  "DbiLastModified": "2009-09-19T16:54:55.0027541+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 125,
  "ActiveErpLinks": 542,
  "BounceEmails": [
    "rosalyn_wuckert@stanton.com",
    "delaney_zemlak@kilback.co.uk"
  ],
  "Domains": [
    "soluta",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mozell Audreanne Prohaska IV",
    "SuperOffice:2": "Peggie Elmo Harvey Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 828
    }
  }
}
```