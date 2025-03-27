---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 27 Sep 2000 02:38:25 G9T

{
  "ContactId": 156,
  "Name": "Lowe-Wintheiser",
  "Department": "",
  "OrgNr": "999555",
  "Number1": "1322847",
  "Number2": "295162",
  "UpdatedDate": "2000-09-27T02:38:25.9642073+02:00",
  "CreatedDate": "2012-01-20T02:38:25.9642073+01:00",
  "Emails": [
    {
      "Value": "illo",
      "StrippedValue": "laudantium",
      "Description": "Visionary incremental service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "laudantium",
      "Description": "Visionary incremental service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 285,
      "Name": "Durgan Group",
      "ToolTip": "Quia dolorem mollitia ratione est velit quo.",
      "Deleted": false,
      "Rank": 949,
      "Type": "sit",
      "ColorBlock": 149,
      "IconHint": "eaque",
      "Selected": true,
      "LastChanged": "2021-06-26T02:38:25.9642073+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "vero",
      "Hidden": false,
      "FullName": "Morris Klocko",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "corrupti",
      "Description": "Secured exuding emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 538
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "corrupti",
      "Description": "Secured exuding emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 538
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ullam",
      "StrippedValue": "molestiae",
      "Description": "Front-line incremental attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "molestiae",
      "Description": "Front-line incremental attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "deleniti",
      "Description": "Object-based object-oriented secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "deleniti",
      "Description": "Object-based object-oriented secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    }
  ],
  "Description": "Total attitude-oriented ability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 595,
      "Mrmrs": "cum",
      "Firstname": "Holden",
      "Lastname": "Kunde",
      "MiddleName": "Kris-Johns",
      "Title": "aut",
      "Description": "Multi-tiered interactive migration",
      "Email": "kevin_ullrich@collins.biz",
      "FullName": "Tito Kreiger IV",
      "DirectPhone": "416.115.4547 x9506",
      "FormalName": "Cummings Inc and Sons",
      "CountryId": 849,
      "ContactId": 982,
      "ContactName": "Trantow Group",
      "Retired": 401,
      "Rank": 254,
      "ActiveInterests": 436,
      "ContactDepartment": "empower viral systems",
      "ContactCountryId": 698,
      "ContactOrgNr": "971322",
      "FaxPhone": "906-991-1166 x2926",
      "MobilePhone": "(068)008-8186",
      "ContactPhone": "111-057-2471 x65699",
      "AssociateName": "Schumm Inc and Sons",
      "AssociateId": 856,
      "UsePersonAddress": false,
      "ContactFax": "blanditiis",
      "Kanafname": "iure",
      "Kanalname": "dicta",
      "Post1": "eaque",
      "Post2": "nisi",
      "Post3": "velit",
      "EmailName": "cecelia@ferryoreilly.us",
      "ContactFullName": "Rafael Stracke",
      "ActiveErpLinks": 470,
      "TicketPriorityId": 746,
      "SupportLanguageId": 929,
      "SupportAssociateId": 408,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1389721",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 106,
  "GroupId": 133,
  "ActiveStatusMonitorId": 692,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 982,
  "DbiAgentId": 508,
  "DbiLastSyncronized": "2014-09-20T02:38:25.9642073+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2017-05-17T02:38:25.9642073+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 177,
  "ActiveErpLinks": 35,
  "BounceEmails": [
    "harmony@moenjones.ca",
    "destini@kutch.info"
  ],
  "Domains": [
    "et",
    "libero"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Izabella Nathen McLaughlin IV",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "perspiciatis"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "iusto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 697
    }
  }
}
```