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


NsApiSlow threshold: 2000 ms.






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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ToCountryId": 86
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 392,
  "Name": "Wilkinson Inc and Sons",
  "Department": "",
  "OrgNr": "1145126",
  "Number1": "579163",
  "Number2": "1638011",
  "UpdatedDate": "2003-04-12T02:30:46.9913411+02:00",
  "CreatedDate": "2013-12-05T02:30:46.9913411+01:00",
  "Emails": [
    {
      "Value": "voluptatum",
      "StrippedValue": "assumenda",
      "Description": "Profound motivating algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "assumenda",
      "Description": "Profound motivating algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 522,
      "Name": "Homenick-Little",
      "ToolTip": "Mollitia modi est nobis odio amet.",
      "Deleted": false,
      "Rank": 277,
      "Type": "ut",
      "ColorBlock": 10,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2025-11-01T02:30:46.9913411+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "possimus",
      "Hidden": true,
      "FullName": "Aaliyah Wiegand PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 757
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "ut",
      "Description": "Multi-lateral neutral orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "ut",
      "Description": "Multi-lateral neutral orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "amet",
      "StrippedValue": "doloremque",
      "Description": "De-engineered intermediate function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "doloremque",
      "Description": "De-engineered intermediate function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "adipisci",
      "StrippedValue": "voluptas",
      "Description": "Distributed empowering protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 26
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "voluptas",
      "Description": "Distributed empowering protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 26
        }
      }
    }
  ],
  "Description": "User-centric optimizing neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "est",
      "PersonId": 605,
      "Mrmrs": "natus",
      "Firstname": "Geoffrey",
      "Lastname": "Bauch",
      "MiddleName": "Rodriguez Group",
      "Title": "ut",
      "Description": "Configurable modular structure",
      "Email": "bethany.kertzmann@okeefebechtelar.com",
      "FullName": "Bryana Reinger",
      "DirectPhone": "1-492-435-9386 x228",
      "FormalName": "Walsh Group",
      "CountryId": 14,
      "ContactId": 316,
      "ContactName": "Hansen-Olson",
      "Retired": 695,
      "Rank": 524,
      "ActiveInterests": 432,
      "ContactDepartment": "",
      "ContactCountryId": 817,
      "ContactOrgNr": "730496",
      "FaxPhone": "928.032.3040 x8094",
      "MobilePhone": "908-147-1241 x40393",
      "ContactPhone": "1-186-727-6513 x428",
      "AssociateName": "Blick, Turcotte and Kihn",
      "AssociateId": 843,
      "UsePersonAddress": false,
      "ContactFax": "voluptatibus",
      "Kanafname": "sed",
      "Kanalname": "sequi",
      "Post1": "enim",
      "Post2": "necessitatibus",
      "Post3": "excepturi",
      "EmailName": "monica.thompson@oreillyrau.com",
      "ContactFullName": "Betty Satterfield",
      "ActiveErpLinks": 140,
      "TicketPriorityId": 845,
      "SupportLanguageId": 203,
      "SupportAssociateId": 772,
      "CategoryName": "VIP Customer",
      "PersonNumber": "934331",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "perferendis",
  "Xstop": false,
  "ActiveInterests": 863,
  "GroupId": 267,
  "ActiveStatusMonitorId": 429,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 549,
  "DbiAgentId": 741,
  "DbiLastSyncronized": "2023-12-22T02:30:46.9913411+01:00",
  "DbiKey": "corrupti",
  "DbiLastModified": "2024-08-16T02:30:46.9913411+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 459,
  "ActiveErpLinks": 392,
  "BounceEmails": [
    "delilah.glover@boyer.biz",
    "jose.cronin@thielgreenholt.name"
  ],
  "Domains": [
    "rem",
    "ut"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Katheryn Farrell Jr.",
    "SuperOffice:2": "904173236"
  },
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "commodi"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "alias"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 128
    }
  }
}
```