---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
content_type: reference
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 762
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 607,
  "Name": "Hodkiewicz, Cummings and Langworth",
  "Department": "",
  "OrgNr": "963605",
  "Number1": "1205712",
  "Number2": "485236",
  "UpdatedDate": "2013-03-20T03:46:54.5038911+01:00",
  "CreatedDate": "2011-07-13T03:46:54.5038911+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Profit-focused didactic protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Profit-focused didactic protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 538,
      "Name": "Graham, Ullrich and Bogisich",
      "ToolTip": "Est sint nemo sed ex quia.",
      "Deleted": true,
      "Rank": 851,
      "Type": "culpa",
      "ColorBlock": 526,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2024-10-21T03:46:54.5038911+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "recusandae",
      "Hidden": false,
      "FullName": "Kade Wintheiser",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "eligendi",
      "Description": "Fully-configurable demand-driven moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 503
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "eligendi",
      "Description": "Fully-configurable demand-driven moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 503
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iste",
      "StrippedValue": "minus",
      "Description": "Exclusive impactful moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 424
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "minus",
      "Description": "Exclusive impactful moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 424
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "eaque",
      "Description": "Exclusive static interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "eaque",
      "Description": "Exclusive static interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    }
  ],
  "Description": "Exclusive multimedia time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorum",
      "PersonId": 243,
      "Mrmrs": "in",
      "Firstname": "Dax",
      "Lastname": "Rutherford",
      "MiddleName": "Steuber, Volkman and Prohaska",
      "Title": "quasi",
      "Description": "Networked clear-thinking synergy",
      "Email": "caleigh@ondricka.info",
      "FullName": "Nat Roberts",
      "DirectPhone": "1-249-159-4021 x2841",
      "FormalName": "West-Okuneva",
      "CountryId": 675,
      "ContactId": 131,
      "ContactName": "Wiza-Reichert",
      "Retired": 492,
      "Rank": 435,
      "ActiveInterests": 890,
      "ContactDepartment": "",
      "ContactCountryId": 208,
      "ContactOrgNr": "381832",
      "FaxPhone": "1-309-391-9481 x587",
      "MobilePhone": "(462)798-8150",
      "ContactPhone": "437.392.6877 x27359",
      "AssociateName": "Ziemann-Ondricka",
      "AssociateId": 97,
      "UsePersonAddress": true,
      "ContactFax": "repellendus",
      "Kanafname": "nemo",
      "Kanalname": "dolorum",
      "Post1": "vel",
      "Post2": "ut",
      "Post3": "enim",
      "EmailName": "magnus@legros.co.uk",
      "ContactFullName": "Houston Wiza",
      "ActiveErpLinks": 90,
      "TicketPriorityId": 932,
      "SupportLanguageId": 497,
      "SupportAssociateId": 85,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1032790",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eaque",
  "Xstop": true,
  "ActiveInterests": 135,
  "GroupId": 128,
  "ActiveStatusMonitorId": 774,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 710,
  "DbiAgentId": 863,
  "DbiLastSyncronized": "2016-02-11T03:46:54.5038911+01:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2022-09-11T03:46:54.5038911+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 543,
  "ActiveErpLinks": 267,
  "BounceEmails": [
    "willow@hilpertauer.biz",
    "toney_reichel@nolan.com"
  ],
  "Domains": [
    "necessitatibus",
    "fugit"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Napoleon Shanahan",
    "SuperOffice:2": "313186294"
  },
  "ExtraFields": {
    "ExtraFields1": "quibusdam",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "magni"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 579
    }
  }
}
```