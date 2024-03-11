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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 432
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 144,
  "Name": "Balistreri Group",
  "Department": "",
  "OrgNr": "1598649",
  "Number1": "944422",
  "Number2": "1386198",
  "UpdatedDate": "2005-06-28T14:23:46.1574569+02:00",
  "CreatedDate": "2004-09-13T14:23:46.1574569+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Distributed encompassing customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Distributed encompassing customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 974,
      "Name": "Schmidt, Zulauf and Wunsch",
      "ToolTip": "Et est expedita eaque explicabo quo laboriosam.",
      "Deleted": false,
      "Rank": 734,
      "Type": "suscipit",
      "ColorBlock": 104,
      "IconHint": "possimus",
      "Selected": false,
      "LastChanged": "2016-10-06T14:23:46.1574569+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "facilis",
      "Hidden": false,
      "FullName": "Mrs. Eda Felicita Witting",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "quam",
      "Description": "Fundamental local architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "quam",
      "Description": "Fundamental local architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "tempore",
      "Description": "Inverse executive product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "tempore",
      "Description": "Inverse executive product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iure",
      "StrippedValue": "consequatur",
      "Description": "Innovative tertiary throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "consequatur",
      "Description": "Innovative tertiary throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    }
  ],
  "Description": "Progressive exuding policy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsa",
      "PersonId": 440,
      "Mrmrs": "cum",
      "Firstname": "Flavio",
      "Lastname": "Zieme",
      "MiddleName": "Weimann-Schamberger",
      "Title": "quia",
      "Description": "Exclusive analyzing moratorium",
      "Email": "reginald@kuhlmanstracke.uk",
      "FullName": "Cathy Schulist",
      "DirectPhone": "364-830-2695",
      "FormalName": "Kautzer-Dickinson",
      "CountryId": 801,
      "ContactId": 839,
      "ContactName": "Schmitt-Aufderhar",
      "Retired": 351,
      "Rank": 252,
      "ActiveInterests": 854,
      "ContactDepartment": "",
      "ContactCountryId": 660,
      "ContactOrgNr": "1428147",
      "FaxPhone": "(678)614-3051 x211",
      "MobilePhone": "230.309.0131",
      "ContactPhone": "632-811-1862 x932",
      "AssociateName": "Rogahn, Simonis and Kautzer",
      "AssociateId": 606,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "ex",
      "Kanalname": "aperiam",
      "Post1": "voluptas",
      "Post2": "consectetur",
      "Post3": "ut",
      "EmailName": "loraine@weimann.name",
      "ContactFullName": "Benedict Jonathon Paucek II",
      "ActiveErpLinks": 13,
      "TicketPriorityId": 58,
      "SupportLanguageId": 864,
      "SupportAssociateId": 64,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "earum",
  "Xstop": true,
  "ActiveInterests": 846,
  "GroupId": 146,
  "ActiveStatusMonitorId": 617,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 996,
  "DbiAgentId": 745,
  "DbiLastSyncronized": "2023-07-14T14:23:46.1730823+02:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2020-02-26T14:23:46.1730823+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 782,
  "ActiveErpLinks": 345,
  "BounceEmails": [
    "rod_haley@prohaska.com",
    "eulah@batz.ca"
  ],
  "Domains": [
    "at",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "633482796",
    "SuperOffice:2": "1743742271"
  },
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "magni"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 618
    }
  }
}
```