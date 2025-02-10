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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 716
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 660,
  "Name": "Gusikowski Group",
  "Department": "",
  "OrgNr": "479762",
  "Number1": "1247018",
  "Number2": "1163234",
  "UpdatedDate": "2011-09-22T12:01:27.4940057+02:00",
  "CreatedDate": "2006-05-07T12:01:27.4940057+02:00",
  "Emails": [
    {
      "Value": "tempora",
      "StrippedValue": "ut",
      "Description": "Fundamental bottom-line pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "ut",
      "Description": "Fundamental bottom-line pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 228,
      "Name": "Stracke-Nitzsche",
      "ToolTip": "Magnam tenetur quis error reiciendis.",
      "Deleted": true,
      "Rank": 344,
      "Type": "voluptas",
      "ColorBlock": 560,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2003-09-25T12:01:27.4940057+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "tempora",
      "Hidden": false,
      "FullName": "Emmalee Heidenreich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 466
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "veniam",
      "StrippedValue": "harum",
      "Description": "Switchable context-sensitive service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "harum",
      "Description": "Switchable context-sensitive service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "quisquam",
      "Description": "Up-sized transitional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quisquam",
      "Description": "Up-sized transitional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "perferendis",
      "Description": "Horizontal human-resource access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "perferendis",
      "Description": "Horizontal human-resource access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    }
  ],
  "Description": "Balanced logistical core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 628,
      "Mrmrs": "dolor",
      "Firstname": "Beth",
      "Lastname": "Feeney",
      "MiddleName": "Kris-Bradtke",
      "Title": "tempora",
      "Description": "Triple-buffered bandwidth-monitored extranet",
      "Email": "elmo_huel@dickijacobson.name",
      "FullName": "Rodger Hilll",
      "DirectPhone": "833-740-6871 x67870",
      "FormalName": "Hansen, Hintz and Upton",
      "CountryId": 281,
      "ContactId": 338,
      "ContactName": "Predovic Group",
      "Retired": 568,
      "Rank": 730,
      "ActiveInterests": 356,
      "ContactDepartment": "",
      "ContactCountryId": 304,
      "ContactOrgNr": "945458",
      "FaxPhone": "(217)774-5613 x708",
      "MobilePhone": "203.217.6950 x4234",
      "ContactPhone": "1-447-411-9205 x232",
      "AssociateName": "Runolfsdottir-O'Conner",
      "AssociateId": 568,
      "UsePersonAddress": false,
      "ContactFax": "error",
      "Kanafname": "dolores",
      "Kanalname": "rerum",
      "Post1": "voluptatum",
      "Post2": "et",
      "Post3": "aut",
      "EmailName": "dawson_koepp@harberheidenreich.biz",
      "ContactFullName": "Mr. Vance Virgil Cartwright",
      "ActiveErpLinks": 521,
      "TicketPriorityId": 81,
      "SupportLanguageId": 667,
      "SupportAssociateId": 911,
      "CategoryName": "VIP Customer",
      "PersonNumber": "877420",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quod",
  "Xstop": true,
  "ActiveInterests": 349,
  "GroupId": 11,
  "ActiveStatusMonitorId": 599,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 976,
  "DbiAgentId": 26,
  "DbiLastSyncronized": "2014-03-08T12:01:27.4940057+01:00",
  "DbiKey": "neque",
  "DbiLastModified": "2010-09-26T12:01:27.4940057+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 714,
  "ActiveErpLinks": 734,
  "BounceEmails": [
    "lea.flatley@pouros.ca",
    "lew@nolan.uk"
  ],
  "Domains": [
    "nam",
    "voluptatem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Imelda Stiedemann",
    "SuperOffice:2": "Prof. Diana Rollin Hudson"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 840
    }
  }
}
```