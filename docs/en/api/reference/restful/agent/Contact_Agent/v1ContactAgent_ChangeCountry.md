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
  "ToCountryId": 851
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 767,
  "Name": "Lindgren Group",
  "Department": "",
  "OrgNr": "1747247",
  "Number1": "526645",
  "Number2": "457412",
  "UpdatedDate": "2016-04-24T17:54:02.8827182+02:00",
  "CreatedDate": "2007-06-08T17:54:02.8827182+02:00",
  "Emails": [
    {
      "Value": "occaecati",
      "StrippedValue": "aliquid",
      "Description": "Switchable eco-centric system engine",
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
      "Value": "occaecati",
      "StrippedValue": "aliquid",
      "Description": "Switchable eco-centric system engine",
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
  "Interests": [
    {
      "Id": 398,
      "Name": "Effertz, Batz and Steuber",
      "ToolTip": "Ratione eaque.",
      "Deleted": false,
      "Rank": 839,
      "Type": "repellat",
      "ColorBlock": 237,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "2019-09-12T17:54:02.8827182+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Diego Gutkowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "tempore",
      "Description": "Adaptive value-added archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "tempore",
      "Description": "Adaptive value-added archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "fuga",
      "StrippedValue": "expedita",
      "Description": "Advanced contextually-based installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "expedita",
      "Description": "Advanced contextually-based installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "a",
      "StrippedValue": "et",
      "Description": "Realigned methodical Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "et",
      "Description": "Realigned methodical Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    }
  ],
  "Description": "Horizontal 6th generation database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "id",
      "PersonId": 486,
      "Mrmrs": "quis",
      "Firstname": "Monserrat",
      "Lastname": "Hegmann",
      "MiddleName": "Satterfield LLC",
      "Title": "dignissimos",
      "Description": "Ergonomic scalable policy",
      "Email": "wilber_deckow@boehm.ca",
      "FullName": "Ashtyn Hobart Little I",
      "DirectPhone": "293.970.4858 x6439",
      "FormalName": "Baumbach, Swaniawski and Abshire",
      "CountryId": 341,
      "ContactId": 671,
      "ContactName": "Abshire, Abshire and Block",
      "Retired": 127,
      "Rank": 86,
      "ActiveInterests": 592,
      "ContactDepartment": "",
      "ContactCountryId": 652,
      "ContactOrgNr": "1250530",
      "FaxPhone": "1-816-940-0542 x2449",
      "MobilePhone": "(518)591-6419 x635",
      "ContactPhone": "732-752-4119 x190",
      "AssociateName": "Nitzsche, Stoltenberg and Ferry",
      "AssociateId": 550,
      "UsePersonAddress": false,
      "ContactFax": "nemo",
      "Kanafname": "at",
      "Kanalname": "rerum",
      "Post1": "distinctio",
      "Post2": "sapiente",
      "Post3": "asperiores",
      "EmailName": "brandt@bashirian.uk",
      "ContactFullName": "Prof. Claudia Marcella Goldner PhD",
      "ActiveErpLinks": 971,
      "TicketPriorityId": 359,
      "SupportLanguageId": 885,
      "SupportAssociateId": 860,
      "CategoryName": "VIP Customer",
      "PersonNumber": "572772",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quis",
  "Xstop": true,
  "ActiveInterests": 71,
  "GroupId": 103,
  "ActiveStatusMonitorId": 435,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 601,
  "DbiAgentId": 443,
  "DbiLastSyncronized": "2024-11-03T17:54:02.8827182+01:00",
  "DbiKey": "dicta",
  "DbiLastModified": "2018-08-14T17:54:02.8827182+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 605,
  "ActiveErpLinks": 786,
  "BounceEmails": [
    "lea@wildermanmills.uk",
    "stacey@keebler.uk"
  ],
  "Domains": [
    "ea",
    "esse"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "May Connelly",
    "SuperOffice:2": "1551217093"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "suscipit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 654
    }
  }
}
```