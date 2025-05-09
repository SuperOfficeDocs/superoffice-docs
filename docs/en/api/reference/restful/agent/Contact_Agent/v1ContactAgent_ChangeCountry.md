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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 696
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 850,
  "Name": "Smitham, Lang and Rohan",
  "Department": "",
  "OrgNr": "696788",
  "Number1": "1838049",
  "Number2": "331615",
  "UpdatedDate": "1998-11-22T16:32:38.4927881+01:00",
  "CreatedDate": "2014-01-24T16:32:38.4927881+01:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "consequatur",
      "Description": "Cloned tertiary project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 623
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "consequatur",
      "Description": "Cloned tertiary project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 623
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 784,
      "Name": "Christiansen-Heaney",
      "ToolTip": "Id aut deleniti inventore.",
      "Deleted": true,
      "Rank": 463,
      "Type": "dolores",
      "ColorBlock": 487,
      "IconHint": "totam",
      "Selected": true,
      "LastChanged": "1999-05-17T16:32:38.4927881+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "beatae",
      "StyleHint": "veniam",
      "Hidden": false,
      "FullName": "Mrs. Arnold Rogelio Haley DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "consectetur",
      "Description": "Customer-focused assymetric instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 195
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "consectetur",
      "Description": "Customer-focused assymetric instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 195
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptas",
      "StrippedValue": "molestias",
      "Description": "Intuitive interactive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "molestias",
      "Description": "Intuitive interactive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "velit",
      "Description": "Focused encompassing hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 327
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "velit",
      "Description": "Focused encompassing hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 327
        }
      }
    }
  ],
  "Description": "Re-contextualized client-server moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 172,
      "Mrmrs": "aut",
      "Firstname": "Annie",
      "Lastname": "Predovic",
      "MiddleName": "Hintz Inc and Sons",
      "Title": "fugit",
      "Description": "Organized discrete middleware",
      "Email": "esperanza_funk@sipesdaniel.us",
      "FullName": "Miss Cleve Kristina Konopelski",
      "DirectPhone": "1-676-702-8345 x4967",
      "FormalName": "Haag-Shanahan",
      "CountryId": 936,
      "ContactId": 805,
      "ContactName": "Sipes, Bednar and Mosciski",
      "Retired": 127,
      "Rank": 417,
      "ActiveInterests": 473,
      "ContactDepartment": "",
      "ContactCountryId": 283,
      "ContactOrgNr": "1641064",
      "FaxPhone": "095.084.9217 x2900",
      "MobilePhone": "(831)831-5484",
      "ContactPhone": "(156)131-2215 x70116",
      "AssociateName": "Abbott, Von and Johnston",
      "AssociateId": 687,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "quis",
      "Kanalname": "excepturi",
      "Post1": "et",
      "Post2": "laborum",
      "Post3": "suscipit",
      "EmailName": "aditya@reillyrosenbaum.us",
      "ContactFullName": "Hector Schulist",
      "ActiveErpLinks": 294,
      "TicketPriorityId": 387,
      "SupportLanguageId": 345,
      "SupportAssociateId": 715,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1401652",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 254,
  "GroupId": 558,
  "ActiveStatusMonitorId": 824,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 426,
  "DbiAgentId": 207,
  "DbiLastSyncronized": "2007-10-25T16:32:38.5084092+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2011-11-14T16:32:38.5084092+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 968,
  "ActiveErpLinks": 451,
  "BounceEmails": [
    "nicola_strosin@renner.biz",
    "elva_bernhard@hane.com"
  ],
  "Domains": [
    "praesentium",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Joel Veum",
    "SuperOffice:2": "1555276679"
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "eius",
    "CustomFields2": "dolore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 549
    }
  }
}
```