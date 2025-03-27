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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 764
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 693,
  "Name": "Towne LLC",
  "Department": "",
  "OrgNr": "1150391",
  "Number1": "1270100",
  "Number2": "1776164",
  "UpdatedDate": "1999-01-17T02:38:21.0733177+01:00",
  "CreatedDate": "2016-04-08T02:38:21.0733177+02:00",
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "totam",
      "Description": "Customizable local monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "totam",
      "Description": "Customizable local monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 965,
      "Name": "Koch, Wisoky and Armstrong",
      "ToolTip": "Nostrum soluta consequatur temporibus aut dolores ut et.",
      "Deleted": false,
      "Rank": 436,
      "Type": "perferendis",
      "ColorBlock": 545,
      "IconHint": "aperiam",
      "Selected": false,
      "LastChanged": "1998-01-16T02:38:21.0733177+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quisquam",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Mr. Elroy Okuneva PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "earum",
      "Description": "Devolved bi-directional open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "earum",
      "Description": "Devolved bi-directional open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 662
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aliquam",
      "StrippedValue": "enim",
      "Description": "Proactive bottom-line superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "enim",
      "Description": "Proactive bottom-line superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "sed",
      "Description": "Re-contextualized non-volatile forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 514
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "sed",
      "Description": "Re-contextualized non-volatile forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 514
        }
      }
    }
  ],
  "Description": "Sharable bandwidth-monitored interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 278,
      "Mrmrs": "distinctio",
      "Firstname": "Rosanna",
      "Lastname": "Dibbert",
      "MiddleName": "Ryan-Botsford",
      "Title": "voluptas",
      "Description": "Customer-focused human-resource installation",
      "Email": "randal@weber.co.uk",
      "FullName": "Mrs. Kristopher Shakira Lind IV",
      "DirectPhone": "(548)843-4485",
      "FormalName": "Schaden Group",
      "CountryId": 784,
      "ContactId": 850,
      "ContactName": "Legros LLC",
      "Retired": 903,
      "Rank": 797,
      "ActiveInterests": 376,
      "ContactDepartment": "",
      "ContactCountryId": 189,
      "ContactOrgNr": "1113972",
      "FaxPhone": "1-991-036-1905",
      "MobilePhone": "771.496.1571 x180",
      "ContactPhone": "355-663-2399 x37222",
      "AssociateName": "Stroman, Botsford and Sanford",
      "AssociateId": 977,
      "UsePersonAddress": true,
      "ContactFax": "dolorem",
      "Kanafname": "quod",
      "Kanalname": "ut",
      "Post1": "eveniet",
      "Post2": "aut",
      "Post3": "cum",
      "EmailName": "riley@kihn.com",
      "ContactFullName": "Mrs. Jody Manuela Stanton Jr.",
      "ActiveErpLinks": 526,
      "TicketPriorityId": 603,
      "SupportLanguageId": 201,
      "SupportAssociateId": 343,
      "CategoryName": "VIP Customer",
      "PersonNumber": "928115",
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
  "NoMailing": true,
  "Kananame": "consectetur",
  "Xstop": false,
  "ActiveInterests": 187,
  "GroupId": 178,
  "ActiveStatusMonitorId": 336,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 635,
  "DbiAgentId": 196,
  "DbiLastSyncronized": "2004-04-10T02:38:21.0733177+02:00",
  "DbiKey": "eum",
  "DbiLastModified": "2022-05-25T02:38:21.0733177+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 465,
  "ActiveErpLinks": 559,
  "BounceEmails": [
    "josie_treutel@schumm.name",
    "conner@brakus.info"
  ],
  "Domains": [
    "tenetur",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "773732747",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "dicta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 120
    }
  }
}
```