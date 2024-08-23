---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 481,
  "Name": "Borer-Bode",
  "Department": "",
  "OrgNr": "1362575",
  "Number1": "1846511",
  "Number2": "1470302",
  "UpdatedDate": "2021-07-12T13:28:22.2730371+02:00",
  "CreatedDate": "2003-09-15T13:28:22.2730371+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "repellendus",
      "Description": "Virtual modular instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 905
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "repellendus",
      "Description": "Virtual modular instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 905
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 295,
      "Name": "Hoppe-Raynor",
      "ToolTip": "Laboriosam quod vero voluptatibus rem fugit ut.",
      "Deleted": true,
      "Rank": 506,
      "Type": "mollitia",
      "ColorBlock": 260,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2007-05-17T13:28:22.2730371+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "recusandae",
      "Hidden": true,
      "FullName": "Bradly Waelchi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsum",
      "StrippedValue": "nihil",
      "Description": "Diverse asynchronous local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "nihil",
      "Description": "Diverse asynchronous local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "facere",
      "StrippedValue": "aperiam",
      "Description": "Realigned web-enabled concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "aperiam",
      "Description": "Realigned web-enabled concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "ipsum",
      "Description": "Self-enabling next generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "ipsum",
      "Description": "Self-enabling next generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    }
  ],
  "Description": "Exclusive user-facing knowledge base",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 181,
      "Mrmrs": "et",
      "Firstname": "Libby",
      "Lastname": "Lakin",
      "MiddleName": "Nitzsche-Cummings",
      "Title": "illum",
      "Description": "Streamlined context-sensitive leverage",
      "Email": "priscilla@farrellbarrows.info",
      "FullName": "Dr. Sofia Cary Langosh",
      "DirectPhone": "1-723-419-2409 x310",
      "FormalName": "Treutel-Wehner",
      "CountryId": 200,
      "ContactId": 687,
      "ContactName": "Senger-Ebert",
      "Retired": 501,
      "Rank": 880,
      "ActiveInterests": 405,
      "ContactDepartment": "",
      "ContactCountryId": 459,
      "ContactOrgNr": "1050206",
      "FaxPhone": "647-524-6539",
      "MobilePhone": "(630)335-5545 x54489",
      "ContactPhone": "850.088.5749 x915",
      "AssociateName": "Reichel-Stehr",
      "AssociateId": 673,
      "UsePersonAddress": false,
      "ContactFax": "nam",
      "Kanafname": "nobis",
      "Kanalname": "quia",
      "Post1": "deleniti",
      "Post2": "quas",
      "Post3": "ut",
      "EmailName": "elda@ziemann.us",
      "ContactFullName": "Ottis Shields",
      "ActiveErpLinks": 210,
      "TicketPriorityId": 95,
      "SupportLanguageId": 430,
      "SupportAssociateId": 287,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "commodi",
  "Xstop": false,
  "ActiveInterests": 473,
  "GroupId": 148,
  "ActiveStatusMonitorId": 545,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 87,
  "DbiAgentId": 357,
  "DbiLastSyncronized": "2016-02-07T13:28:22.2730371+01:00",
  "DbiKey": "sapiente",
  "DbiLastModified": "2002-07-24T13:28:22.2730371+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 540,
  "ActiveErpLinks": 776,
  "BounceEmails": [
    "elbert.ferry@heller.uk",
    "karelle.bode@friesen.co.uk"
  ],
  "Domains": [
    "non",
    "deleniti"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1430656045"
  },
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 692
    }
  }
}
```