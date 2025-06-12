---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 293,
  "Name": "Haag, Crona and Schiller",
  "Department": "",
  "OrgNr": "1707474",
  "Number1": "651378",
  "Number2": "1025359",
  "UpdatedDate": "2018-07-04T17:54:02.835846+02:00",
  "CreatedDate": "2016-12-27T17:54:02.835846+01:00",
  "Emails": [
    {
      "Value": "eligendi",
      "StrippedValue": "est",
      "Description": "Integrated assymetric flexibility"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "est",
      "Description": "Integrated assymetric flexibility"
    }
  ],
  "Interests": [
    {
      "Id": 229,
      "Name": "Kuphal Group",
      "ToolTip": "Deleniti reprehenderit sed.",
      "Deleted": false,
      "Rank": 79,
      "Type": "dolor",
      "ColorBlock": 289,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2017-11-23T17:54:02.835846+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "libero",
      "Hidden": true,
      "FullName": "Mr. Augustus Romaguera"
    }
  ],
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "ut",
      "Description": "Networked global middleware"
    },
    {
      "Value": "inventore",
      "StrippedValue": "ut",
      "Description": "Networked global middleware"
    }
  ],
  "Phones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "eligendi",
      "Description": "Enhanced bandwidth-monitored superstructure"
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "eligendi",
      "Description": "Enhanced bandwidth-monitored superstructure"
    }
  ],
  "Faxes": [
    {
      "Value": "consectetur",
      "StrippedValue": "eos",
      "Description": "Distributed real-time forecast"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "eos",
      "Description": "Distributed real-time forecast"
    }
  ],
  "Description": "Cross-group dedicated workforce",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolores",
      "PersonId": 141,
      "Mrmrs": "iste",
      "Firstname": "Edmund",
      "Lastname": "Pfannerstill",
      "MiddleName": "O'Hara-Wiza",
      "Title": "excepturi",
      "Description": "Business-focused tangible access",
      "Email": "odessa.hansen@kriswilliamson.uk",
      "FullName": "Rod Chance Parker IV",
      "DirectPhone": "649-521-0504 x888",
      "FormalName": "Rogahn, Stamm and Barton",
      "CountryId": 691,
      "ContactId": 448,
      "ContactName": "Graham, Maggio and Huel",
      "Retired": 249,
      "Rank": 565,
      "ActiveInterests": 252,
      "ContactDepartment": "",
      "ContactCountryId": 236,
      "ContactOrgNr": "684957",
      "FaxPhone": "017.683.7325 x1227",
      "MobilePhone": "567-708-3762",
      "ContactPhone": "676.533.9545 x103",
      "AssociateName": "Hickle-Wiegand",
      "AssociateId": 574,
      "UsePersonAddress": true,
      "ContactFax": "quam",
      "Kanafname": "quibusdam",
      "Kanalname": "quis",
      "Post1": "quibusdam",
      "Post2": "omnis",
      "Post3": "dicta",
      "EmailName": "rylan@becker.com",
      "ContactFullName": "Arden Bernier",
      "ActiveErpLinks": 388,
      "TicketPriorityId": 127,
      "SupportLanguageId": 958,
      "SupportAssociateId": 489,
      "CategoryName": "VIP Customer",
      "PersonNumber": "994754"
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 73,
  "GroupId": 24,
  "ActiveStatusMonitorId": 220,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 580,
  "DbiAgentId": 788,
  "DbiLastSyncronized": "2010-10-15T17:54:02.835846+02:00",
  "DbiKey": "doloremque",
  "DbiLastModified": "2018-04-01T17:54:02.835846+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 29,
  "ActiveErpLinks": 776,
  "BounceEmails": [
    "lina_fadel@jacobimarquardt.co.uk",
    "jaqueline@batz.biz"
  ],
  "Domains": [
    "suscipit",
    "tenetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1783048592",
    "SuperOffice:2": "155835111"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 980,
  "Name": "Stanton, Cruickshank and Beier",
  "Department": "",
  "OrgNr": "1280789",
  "Number1": "744220",
  "Number2": "1128480",
  "UpdatedDate": "1999-08-04T17:54:02.835846+02:00",
  "CreatedDate": "2006-02-28T17:54:02.835846+01:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "mollitia",
      "Description": "Right-sized background task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "mollitia",
      "Description": "Right-sized background task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 748,
      "Name": "Hegmann LLC",
      "ToolTip": "Sint et reprehenderit occaecati.",
      "Deleted": true,
      "Rank": 279,
      "Type": "sint",
      "ColorBlock": 778,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2000-05-21T17:54:02.835846+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "blanditiis",
      "StyleHint": "tenetur",
      "Hidden": true,
      "FullName": "Ezekiel Monahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "animi",
      "Description": "Implemented motivating open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "animi",
      "Description": "Implemented motivating open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "omnis",
      "Description": "Down-sized discrete conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 456
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "omnis",
      "Description": "Down-sized discrete conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 456
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "optio",
      "Description": "Right-sized logistical service-desk",
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
      "Value": "quae",
      "StrippedValue": "optio",
      "Description": "Right-sized logistical service-desk",
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
  "Description": "Assimilated 24/7 productivity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "deserunt",
      "PersonId": 111,
      "Mrmrs": "omnis",
      "Firstname": "Clementine",
      "Lastname": "Gorczany",
      "MiddleName": "Erdman LLC",
      "Title": "rerum",
      "Description": "Enterprise-wide incremental task-force",
      "Email": "june.nienow@abernathy.co.uk",
      "FullName": "Liza Gutkowski",
      "DirectPhone": "(413)209-5039",
      "FormalName": "Lockman, Marks and Bergnaum",
      "CountryId": 97,
      "ContactId": 54,
      "ContactName": "Little, Raynor and Ledner",
      "Retired": 979,
      "Rank": 500,
      "ActiveInterests": 394,
      "ContactDepartment": "",
      "ContactCountryId": 323,
      "ContactOrgNr": "1364968",
      "FaxPhone": "549.329.0837 x989",
      "MobilePhone": "831.835.5743",
      "ContactPhone": "1-369-699-2512 x6024",
      "AssociateName": "Dibbert, Reichel and Denesik",
      "AssociateId": 846,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "velit",
      "Kanalname": "non",
      "Post1": "aperiam",
      "Post2": "repellat",
      "Post3": "non",
      "EmailName": "lavada_fahey@keeblercorkery.us",
      "ContactFullName": "Freddie Waelchi PhD",
      "ActiveErpLinks": 706,
      "TicketPriorityId": 65,
      "SupportLanguageId": 580,
      "SupportAssociateId": 490,
      "CategoryName": "VIP Customer",
      "PersonNumber": "278968",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "odit",
  "Xstop": true,
  "ActiveInterests": 2,
  "GroupId": 257,
  "ActiveStatusMonitorId": 558,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 998,
  "DbiAgentId": 389,
  "DbiLastSyncronized": "2004-01-31T17:54:02.835846+01:00",
  "DbiKey": "odio",
  "DbiLastModified": "2010-07-04T17:54:02.835846+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 686,
  "ActiveErpLinks": 774,
  "BounceEmails": [
    "marge@green.co.uk",
    "edgardo@williamson.uk"
  ],
  "Domains": [
    "deleniti",
    "explicabo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Selena Kaci Doyle"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "corporis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 431
    }
  }
}
```