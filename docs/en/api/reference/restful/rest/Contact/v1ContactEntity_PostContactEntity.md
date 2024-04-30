---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity 

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

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 247,
  "Name": "Crona-Lesch",
  "Department": "",
  "OrgNr": "683327",
  "Number1": "1757201",
  "Number2": "477997",
  "UpdatedDate": "2006-04-05T11:16:13.7775209+02:00",
  "CreatedDate": "2006-09-27T11:16:13.7775209+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "sed",
      "Description": "Expanded analyzing hub"
    },
    {
      "Value": "est",
      "StrippedValue": "sed",
      "Description": "Expanded analyzing hub"
    }
  ],
  "Interests": [
    {
      "Id": 549,
      "Name": "Olson Inc and Sons",
      "ToolTip": "Vel quis.",
      "Deleted": false,
      "Rank": 765,
      "Type": "ut",
      "ColorBlock": 681,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "1999-11-19T11:16:13.7775209+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "earum",
      "StyleHint": "distinctio",
      "Hidden": true,
      "FullName": "Miss Nicholas Reichert IV"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "fugiat",
      "Description": "Multi-tiered actuating function"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "fugiat",
      "Description": "Multi-tiered actuating function"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "enim",
      "Description": "Self-enabling dynamic ability"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "enim",
      "Description": "Self-enabling dynamic ability"
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "quod",
      "Description": "Advanced coherent structure"
    },
    {
      "Value": "eum",
      "StrippedValue": "quod",
      "Description": "Advanced coherent structure"
    }
  ],
  "Description": "Face to face 24 hour function",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "necessitatibus",
      "PersonId": 328,
      "Mrmrs": "deleniti",
      "Firstname": "Lelah",
      "Lastname": "Collins",
      "MiddleName": "Runte, Johnston and Heathcote",
      "Title": "qui",
      "Description": "Customizable assymetric local area network",
      "Email": "llewellyn@wehner.co.uk",
      "FullName": "Mozelle Kris",
      "DirectPhone": "(447)089-8358 x3820",
      "FormalName": "Grady LLC",
      "CountryId": 315,
      "ContactId": 228,
      "ContactName": "Halvorson, Johnston and Johns",
      "Retired": 498,
      "Rank": 725,
      "ActiveInterests": 875,
      "ContactDepartment": "",
      "ContactCountryId": 559,
      "ContactOrgNr": "916480",
      "FaxPhone": "578.460.5577",
      "MobilePhone": "980-212-7682 x93213",
      "ContactPhone": "(832)272-1954 x58166",
      "AssociateName": "Lueilwitz Group",
      "AssociateId": 462,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "qui",
      "Kanalname": "nihil",
      "Post1": "voluptatem",
      "Post2": "nostrum",
      "Post3": "est",
      "EmailName": "darrick@considineosinski.uk",
      "ContactFullName": "Mitchel Gunner Mertz Sr.",
      "ActiveErpLinks": 393,
      "TicketPriorityId": 452,
      "SupportLanguageId": 421,
      "SupportAssociateId": 386,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "illum",
  "Xstop": true,
  "ActiveInterests": 611,
  "GroupId": 816,
  "ActiveStatusMonitorId": 912,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 390,
  "DbiAgentId": 76,
  "DbiLastSyncronized": "2003-06-14T11:16:13.7775209+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2000-12-24T11:16:13.7775209+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 624,
  "ActiveErpLinks": 912,
  "BounceEmails": [
    "russ@klingtillman.uk",
    "jennyfer@feilveum.name"
  ],
  "Domains": [
    "aperiam",
    "totam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ulices Simonis",
    "SuperOffice:2": "409514507"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "in"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 52,
  "Name": "Bergnaum LLC",
  "Department": "",
  "OrgNr": "477972",
  "Number1": "537574",
  "Number2": "1022382",
  "UpdatedDate": "2018-01-24T11:16:13.7925618+01:00",
  "CreatedDate": "2021-07-30T11:16:13.7925618+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Quality-focused client-server interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Quality-focused client-server interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 113,
      "Name": "Lakin, Conn and Goldner",
      "ToolTip": "Mollitia quasi qui.",
      "Deleted": false,
      "Rank": 209,
      "Type": "facere",
      "ColorBlock": 422,
      "IconHint": "animi",
      "Selected": true,
      "LastChanged": "2015-12-21T11:16:13.7925618+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "illo",
      "Hidden": false,
      "FullName": "Nikko Bruen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 972
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "vitae",
      "Description": "Right-sized 3rd generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "vitae",
      "Description": "Right-sized 3rd generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "minus",
      "Description": "Exclusive 24/7 product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "minus",
      "Description": "Exclusive 24/7 product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "natus",
      "StrippedValue": "aliquam",
      "Description": "Extended user-facing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "aliquam",
      "Description": "Extended user-facing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "Description": "Fully-configurable real-time data-warehouse",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "facilis",
      "PersonId": 126,
      "Mrmrs": "optio",
      "Firstname": "Allen",
      "Lastname": "Ritchie",
      "MiddleName": "Gutkowski, Dietrich and Haley",
      "Title": "vel",
      "Description": "Open-source zero tolerance product",
      "Email": "rachael_conroy@jerdeullrich.info",
      "FullName": "Mr. Llewellyn Laura McDermott",
      "DirectPhone": "942.682.3466",
      "FormalName": "Larkin, Klocko and Johnson",
      "CountryId": 666,
      "ContactId": 255,
      "ContactName": "King Inc and Sons",
      "Retired": 311,
      "Rank": 743,
      "ActiveInterests": 212,
      "ContactDepartment": "",
      "ContactCountryId": 912,
      "ContactOrgNr": "716874",
      "FaxPhone": "469.402.8170 x2238",
      "MobilePhone": "892-220-0677",
      "ContactPhone": "692-457-1328",
      "AssociateName": "O'Conner, Upton and Monahan",
      "AssociateId": 56,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "beatae",
      "Kanalname": "reiciendis",
      "Post1": "autem",
      "Post2": "iusto",
      "Post3": "libero",
      "EmailName": "stanton_kuhlman@sanfordpadberg.ca",
      "ContactFullName": "Marguerite Koepp",
      "ActiveErpLinks": 638,
      "TicketPriorityId": 474,
      "SupportLanguageId": 548,
      "SupportAssociateId": 333,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 837,
  "GroupId": 427,
  "ActiveStatusMonitorId": 713,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 818,
  "DbiAgentId": 866,
  "DbiLastSyncronized": "2011-10-13T11:16:13.7925618+02:00",
  "DbiKey": "dignissimos",
  "DbiLastModified": "2011-04-26T11:16:13.7925618+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 653,
  "ActiveErpLinks": 572,
  "BounceEmails": [
    "gianni@hoeger.info",
    "myrl.johns@wisoky.com"
  ],
  "Domains": [
    "in",
    "corporis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1135577854",
    "SuperOffice:2": "314164995"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 756
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```