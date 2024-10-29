---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 314,
  "Name": "Johnson, Jaskolski and Gorczany",
  "Department": "",
  "OrgNr": "410786",
  "Number1": "804498",
  "Number2": "794182",
  "UpdatedDate": "2008-03-28T13:14:05.6788931+01:00",
  "CreatedDate": "2005-04-15T13:14:05.6788931+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "enim",
      "Description": "Customer-focused mission-critical array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 584
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "enim",
      "Description": "Customer-focused mission-critical array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 584
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 738,
      "Name": "Reilly, Turcotte and Turner",
      "ToolTip": "Sed quod.",
      "Deleted": true,
      "Rank": 489,
      "Type": "consequatur",
      "ColorBlock": 556,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2010-07-03T13:14:05.6788931+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Anastasia Flatley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "quia",
      "Description": "Re-engineered modular extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 549
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "quia",
      "Description": "Re-engineered modular extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 549
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nihil",
      "StrippedValue": "iusto",
      "Description": "Total user-facing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "iusto",
      "Description": "Total user-facing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "soluta",
      "StrippedValue": "dolor",
      "Description": "Centralized regional policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "dolor",
      "Description": "Centralized regional policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "Description": "Re-engineered coherent definition",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "expedita",
      "PersonId": 411,
      "Mrmrs": "quo",
      "Firstname": "Rupert",
      "Lastname": "McLaughlin",
      "MiddleName": "Beer Inc and Sons",
      "Title": "atque",
      "Description": "Exclusive interactive support",
      "Email": "leila_grimes@pfannerstillschuppe.info",
      "FullName": "Dr. Lilian Kuhlman V",
      "DirectPhone": "074-429-7334",
      "FormalName": "Runolfsdottir, Hane and Labadie",
      "CountryId": 680,
      "ContactId": 233,
      "ContactName": "Ondricka Group",
      "Retired": 62,
      "Rank": 102,
      "ActiveInterests": 698,
      "ContactDepartment": "",
      "ContactCountryId": 528,
      "ContactOrgNr": "1183941",
      "FaxPhone": "1-554-244-4888 x944",
      "MobilePhone": "756.311.1263 x2406",
      "ContactPhone": "1-809-017-0521 x64076",
      "AssociateName": "Mayer-Wintheiser",
      "AssociateId": 633,
      "UsePersonAddress": false,
      "ContactFax": "ea",
      "Kanafname": "et",
      "Kanalname": "voluptas",
      "Post1": "modi",
      "Post2": "dicta",
      "Post3": "ut",
      "EmailName": "malika@jerde.uk",
      "ContactFullName": "Ms. Milan Gerlach DDS",
      "ActiveErpLinks": 880,
      "TicketPriorityId": 794,
      "SupportLanguageId": 157,
      "SupportAssociateId": 170,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 118
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "repudiandae",
  "Xstop": true,
  "ActiveInterests": 497,
  "GroupId": 643,
  "ActiveStatusMonitorId": 76,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 692,
  "DbiAgentId": 767,
  "DbiLastSyncronized": "2011-06-28T13:14:05.6788931+02:00",
  "DbiKey": "velit",
  "DbiLastModified": "2019-07-30T13:14:05.6788931+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 97,
  "ActiveErpLinks": 113,
  "BounceEmails": [
    "marcelle.reynolds@dicki.co.uk",
    "santiago@lind.biz"
  ],
  "Domains": [
    "cum",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "931230213",
    "SuperOffice:2": "Dr. Annette Leuschke Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "a"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 570
    }
  }
}
```