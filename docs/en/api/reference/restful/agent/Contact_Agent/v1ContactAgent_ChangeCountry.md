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
  "ToCountryId": 303
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 889,
  "Name": "Bauch LLC",
  "Department": "",
  "OrgNr": "195478",
  "Number1": "1143454",
  "Number2": "1224798",
  "UpdatedDate": "2021-03-02T14:13:39.8598541+01:00",
  "CreatedDate": "2005-07-05T14:13:39.8598541+02:00",
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "reprehenderit",
      "Description": "Open-architected bi-directional monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "reprehenderit",
      "Description": "Open-architected bi-directional monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 988,
      "Name": "Heaney, Rempel and Orn",
      "ToolTip": "Quo qui sed.",
      "Deleted": true,
      "Rank": 514,
      "Type": "voluptates",
      "ColorBlock": 992,
      "IconHint": "quaerat",
      "Selected": true,
      "LastChanged": "2002-02-07T14:13:39.8598541+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Sebastian O'Hara V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "quibusdam",
      "Description": "User-friendly scalable neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 925
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "quibusdam",
      "Description": "User-friendly scalable neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 925
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "unde",
      "StrippedValue": "nulla",
      "Description": "Front-line systemic instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "nulla",
      "Description": "Front-line systemic instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "odit",
      "StrippedValue": "pariatur",
      "Description": "Balanced content-based project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "pariatur",
      "Description": "Balanced content-based project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    }
  ],
  "Description": "Exclusive needs-based ability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quidem",
      "PersonId": 930,
      "Mrmrs": "consectetur",
      "Firstname": "Leanna",
      "Lastname": "Quitzon",
      "MiddleName": "Cruickshank-Kuhic",
      "Title": "perferendis",
      "Description": "Persistent non-volatile service-desk",
      "Email": "florian@reichel.co.uk",
      "FullName": "Mrs. Unique Lambert Schinner V",
      "DirectPhone": "860.080.4749",
      "FormalName": "Stoltenberg, Halvorson and Thiel",
      "CountryId": 23,
      "ContactId": 845,
      "ContactName": "O'Reilly, Reynolds and Stoltenberg",
      "Retired": 498,
      "Rank": 933,
      "ActiveInterests": 688,
      "ContactDepartment": "",
      "ContactCountryId": 72,
      "ContactOrgNr": "410477",
      "FaxPhone": "568.172.6603",
      "MobilePhone": "(207)121-4743 x26003",
      "ContactPhone": "(137)591-6322 x7579",
      "AssociateName": "Murazik-Walker",
      "AssociateId": 37,
      "UsePersonAddress": false,
      "ContactFax": "magni",
      "Kanafname": "incidunt",
      "Kanalname": "dicta",
      "Post1": "at",
      "Post2": "eos",
      "Post3": "sed",
      "EmailName": "israel@lesch.info",
      "ContactFullName": "Ms. Kristin Harris PhD",
      "ActiveErpLinks": 570,
      "TicketPriorityId": 886,
      "SupportLanguageId": 864,
      "SupportAssociateId": 953,
      "CategoryName": "VIP Customer",
      "PersonNumber": "759711",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sint",
  "Xstop": false,
  "ActiveInterests": 766,
  "GroupId": 973,
  "ActiveStatusMonitorId": 147,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 301,
  "DbiAgentId": 508,
  "DbiLastSyncronized": "2019-05-29T14:13:39.8598541+02:00",
  "DbiKey": "saepe",
  "DbiLastModified": "2002-07-25T14:13:39.8598541+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 765,
  "ActiveErpLinks": 479,
  "BounceEmails": [
    "margarete@lakin.info",
    "leanne.jaskolski@hickle.co.uk"
  ],
  "Domains": [
    "dicta",
    "asperiores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Dario Lockman IV",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "tempore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 995
    }
  }
}
```