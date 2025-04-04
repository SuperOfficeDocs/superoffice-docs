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
  "ContactId": 320,
  "Name": "Medhurst LLC",
  "Department": "",
  "OrgNr": "1371330",
  "Number1": "1163171",
  "Number2": "1285236",
  "UpdatedDate": "2011-11-26T13:13:59.8131957+01:00",
  "CreatedDate": "2009-06-17T13:13:59.8131957+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "id",
      "Description": "Front-line secondary contingency",
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
      "Value": "qui",
      "StrippedValue": "id",
      "Description": "Front-line secondary contingency",
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
  "Interests": [
    {
      "Id": 30,
      "Name": "Kovacek-Osinski",
      "ToolTip": "Blanditiis omnis eius ab facere odit sunt.",
      "Deleted": true,
      "Rank": 927,
      "Type": "excepturi",
      "ColorBlock": 113,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "2020-06-28T13:13:59.8131957+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "debitis",
      "Hidden": false,
      "FullName": "Nia Edyth Kirlin Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 328
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "omnis",
      "Description": "Fully-configurable zero administration Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "omnis",
      "Description": "Fully-configurable zero administration Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "vero",
      "Description": "Inverse modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 808
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "vero",
      "Description": "Inverse modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 808
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "ea",
      "Description": "Devolved bandwidth-monitored contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "ea",
      "Description": "Devolved bandwidth-monitored contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    }
  ],
  "Description": "Open-source disintermediate monitoring",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptate",
      "PersonId": 115,
      "Mrmrs": "tempora",
      "Firstname": "Nadia",
      "Lastname": "Lesch",
      "MiddleName": "Gibson-DuBuque",
      "Title": "et",
      "Description": "Advanced analyzing standardization",
      "Email": "maritza_shanahan@bins.co.uk",
      "FullName": "Monty VonRueden",
      "DirectPhone": "254.995.7946 x86985",
      "FormalName": "Altenwerth Inc and Sons",
      "CountryId": 688,
      "ContactId": 570,
      "ContactName": "Bosco-Gutkowski",
      "Retired": 127,
      "Rank": 237,
      "ActiveInterests": 108,
      "ContactDepartment": "",
      "ContactCountryId": 363,
      "ContactOrgNr": "1242176",
      "FaxPhone": "(306)864-2253 x33154",
      "MobilePhone": "(742)840-1538",
      "ContactPhone": "639-649-0590 x00752",
      "AssociateName": "Bahringer, Beier and Larson",
      "AssociateId": 70,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "consequatur",
      "Kanalname": "assumenda",
      "Post1": "sunt",
      "Post2": "quisquam",
      "Post3": "natus",
      "EmailName": "jackie.klein@heathcote.name",
      "ContactFullName": "Mr. Angelita Frami Sr.",
      "ActiveErpLinks": 926,
      "TicketPriorityId": 317,
      "SupportLanguageId": 183,
      "SupportAssociateId": 419,
      "CategoryName": "VIP Customer",
      "PersonNumber": "775669",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 390
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "vero",
  "Xstop": false,
  "ActiveInterests": 972,
  "GroupId": 69,
  "ActiveStatusMonitorId": 640,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 40,
  "DbiAgentId": 513,
  "DbiLastSyncronized": "2008-09-03T13:13:59.8131957+02:00",
  "DbiKey": "officia",
  "DbiLastModified": "2013-03-13T13:13:59.8131957+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 547,
  "ActiveErpLinks": 728,
  "BounceEmails": [
    "kasey@wuckertstracke.com",
    "tanya@kuhlman.co.uk"
  ],
  "Domains": [
    "consequatur",
    "possimus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Enos Sauer Sr.",
    "SuperOffice:2": "Miss Eldridge Rempel"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "temporibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  }
}
```