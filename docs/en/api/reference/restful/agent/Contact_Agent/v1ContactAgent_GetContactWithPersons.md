---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







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
  "ContactId": 344
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 31,
  "Name": "Hegmann Group",
  "Department": "",
  "OrgNr": "175682",
  "Number1": "152220",
  "Number2": "814852",
  "UpdatedDate": "2020-10-21T04:22:26.230935+02:00",
  "CreatedDate": "1999-02-14T04:22:26.230935+01:00",
  "Emails": [
    {
      "Value": "libero",
      "StrippedValue": "labore",
      "Description": "Ergonomic bifurcated archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "labore",
      "Description": "Ergonomic bifurcated archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 550,
      "Name": "Leffler Inc and Sons",
      "ToolTip": "Et necessitatibus libero dolorum.",
      "Deleted": false,
      "Rank": 737,
      "Type": "itaque",
      "ColorBlock": 231,
      "IconHint": "explicabo",
      "Selected": true,
      "LastChanged": "2008-10-01T04:22:26.230935+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "Waylon Beatty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "veritatis",
      "StrippedValue": "vel",
      "Description": "Organic next generation matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "vel",
      "Description": "Organic next generation matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "repellendus",
      "Description": "Future-proofed methodical emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 994
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "repellendus",
      "Description": "Future-proofed methodical emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 994
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "expedita",
      "StrippedValue": "doloribus",
      "Description": "Customizable clear-thinking application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "doloribus",
      "Description": "Customizable clear-thinking application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "Description": "Organic regional structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nisi",
      "PersonId": 821,
      "Mrmrs": "aperiam",
      "Firstname": "Laverna",
      "Lastname": "Hagenes",
      "MiddleName": "Tremblay-Monahan",
      "Title": "consectetur",
      "Description": "Grass-roots interactive monitoring",
      "Email": "chelsie_fadel@hagenes.com",
      "FullName": "Bella Botsford",
      "DirectPhone": "(232)105-3153 x100",
      "FormalName": "Zulauf, Price and Stracke",
      "CountryId": 132,
      "ContactId": 122,
      "ContactName": "Lubowitz LLC",
      "Retired": 910,
      "Rank": 423,
      "ActiveInterests": 547,
      "ContactDepartment": "",
      "ContactCountryId": 791,
      "ContactOrgNr": "1164622",
      "FaxPhone": "(246)035-7054",
      "MobilePhone": "(378)587-3509",
      "ContactPhone": "(235)561-3674",
      "AssociateName": "Dickens LLC",
      "AssociateId": 403,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "nihil",
      "Kanalname": "et",
      "Post1": "doloribus",
      "Post2": "aut",
      "Post3": "omnis",
      "EmailName": "skyla@doyle.com",
      "ContactFullName": "Ms. Roosevelt Little",
      "ActiveErpLinks": 842,
      "TicketPriorityId": 299,
      "SupportLanguageId": 989,
      "SupportAssociateId": 205,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aliquam",
  "Xstop": true,
  "ActiveInterests": 475,
  "GroupId": 780,
  "ActiveStatusMonitorId": 506,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 571,
  "DbiAgentId": 292,
  "DbiLastSyncronized": "2001-03-18T04:22:26.230935+01:00",
  "DbiKey": "harum",
  "DbiLastModified": "2004-05-03T04:22:26.230935+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 692,
  "ActiveErpLinks": 209,
  "BounceEmails": [
    "walker@schuppe.uk",
    "lucy.huels@bashirian.name"
  ],
  "Domains": [
    "non",
    "explicabo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "234001504",
    "SuperOffice:2": "Ahmed Schuster"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 769
    }
  }
}
```