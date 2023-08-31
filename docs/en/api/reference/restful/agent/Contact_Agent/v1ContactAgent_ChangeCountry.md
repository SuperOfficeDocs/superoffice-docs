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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 897
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 378,
  "Name": "Price, Bogisich and Altenwerth",
  "Department": "",
  "OrgNr": "392661",
  "Number1": "1901663",
  "Number2": "1735627",
  "UpdatedDate": "2019-11-13T03:31:25.9165935+01:00",
  "CreatedDate": "2014-02-27T03:31:25.9165935+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "harum",
      "Description": "Up-sized optimal Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "harum",
      "Description": "Up-sized optimal Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 234,
      "Name": "Robel, Parker and Dietrich",
      "ToolTip": "Voluptatem et velit et tempore.",
      "Deleted": false,
      "Rank": 719,
      "Type": "magnam",
      "ColorBlock": 427,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "1998-05-06T03:31:25.9321948+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Earline Morissette",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "praesentium",
      "Description": "Focused analyzing secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "praesentium",
      "Description": "Focused analyzing secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dicta",
      "StrippedValue": "enim",
      "Description": "Horizontal interactive firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "enim",
      "Description": "Horizontal interactive firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "fuga",
      "Description": "Virtual tangible service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "fuga",
      "Description": "Virtual tangible service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "Description": "Multi-layered heuristic Graphic Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 435,
      "Mrmrs": "dolorem",
      "Firstname": "Shirley",
      "Lastname": "Sporer",
      "MiddleName": "Adams Inc and Sons",
      "Title": "eos",
      "Description": "Switchable actuating infrastructure",
      "Email": "hubert@denesik.name",
      "FullName": "Marilyne Kulas",
      "DirectPhone": "027.250.7375 x0044",
      "FormalName": "Zemlak Inc and Sons",
      "CountryId": 450,
      "ContactId": 34,
      "ContactName": "Sanford, Toy and Brown",
      "Retired": 111,
      "Rank": 412,
      "ActiveInterests": 906,
      "ContactDepartment": "",
      "ContactCountryId": 387,
      "ContactOrgNr": "1222369",
      "FaxPhone": "700.976.3312",
      "MobilePhone": "(330)748-5123",
      "ContactPhone": "(354)165-5891",
      "AssociateName": "Krajcik Inc and Sons",
      "AssociateId": 274,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "inventore",
      "Kanalname": "corrupti",
      "Post1": "beatae",
      "Post2": "harum",
      "Post3": "aliquam",
      "EmailName": "callie.dubuque@lindgren.co.uk",
      "ContactFullName": "Estella Hauck",
      "ActiveErpLinks": 817,
      "TicketPriorityId": 914,
      "SupportLanguageId": 526,
      "SupportAssociateId": 266,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "quaerat",
  "Xstop": true,
  "ActiveInterests": 756,
  "GroupId": 637,
  "ActiveStatusMonitorId": 404,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 288,
  "DbiAgentId": 212,
  "DbiLastSyncronized": "2018-10-04T03:31:25.9321948+02:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2006-04-27T03:31:25.9321948+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 813,
  "ActiveErpLinks": 204,
  "BounceEmails": [
    "blaise@lebsackkunze.name",
    "george_collins@mayertmuller.com"
  ],
  "Domains": [
    "odio",
    "alias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kip Glover",
    "SuperOffice:2": "741393148"
  },
  "ExtraFields": {
    "ExtraFields1": "adipisci",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 372
    }
  }
}
```