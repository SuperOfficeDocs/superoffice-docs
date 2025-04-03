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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 374,
  "Name": "Cremin-Huel",
  "Department": "",
  "OrgNr": "1062625",
  "Number1": "1429186",
  "Number2": "1171552",
  "UpdatedDate": "2012-04-24T14:28:26.8051995+02:00",
  "CreatedDate": "1998-12-18T14:28:26.8051995+01:00",
  "Emails": [
    {
      "Value": "expedita",
      "StrippedValue": "sapiente",
      "Description": "Cross-group explicit utilisation"
    },
    {
      "Value": "expedita",
      "StrippedValue": "sapiente",
      "Description": "Cross-group explicit utilisation"
    }
  ],
  "Interests": [
    {
      "Id": 117,
      "Name": "Bailey-Gislason",
      "ToolTip": "Maiores laborum.",
      "Deleted": false,
      "Rank": 918,
      "Type": "omnis",
      "ColorBlock": 471,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "2017-08-31T14:28:26.8051995+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nemo",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Mrs. Kennedy Moore"
    }
  ],
  "Urls": [
    {
      "Value": "porro",
      "StrippedValue": "enim",
      "Description": "Secured mobile hardware"
    },
    {
      "Value": "porro",
      "StrippedValue": "enim",
      "Description": "Secured mobile hardware"
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "facilis",
      "Description": "Programmable tangible open system"
    },
    {
      "Value": "sit",
      "StrippedValue": "facilis",
      "Description": "Programmable tangible open system"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Streamlined contextually-based challenge"
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Streamlined contextually-based challenge"
    }
  ],
  "Description": "Configurable interactive capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quos",
      "PersonId": 52,
      "Mrmrs": "distinctio",
      "Firstname": "Ramon",
      "Lastname": "Denesik",
      "MiddleName": "Kiehn-Torphy",
      "Title": "aut",
      "Description": "Expanded secondary encryption",
      "Email": "emmett@spencerweimann.name",
      "FullName": "Angel Schneider",
      "DirectPhone": "844-318-3439 x42053",
      "FormalName": "Tremblay, Bergnaum and Koch",
      "CountryId": 638,
      "ContactId": 966,
      "ContactName": "Boehm-Dooley",
      "Retired": 65,
      "Rank": 183,
      "ActiveInterests": 444,
      "ContactDepartment": "",
      "ContactCountryId": 133,
      "ContactOrgNr": "716521",
      "FaxPhone": "1-144-752-5277",
      "MobilePhone": "559.790.3428",
      "ContactPhone": "460-704-1232 x461",
      "AssociateName": "Farrell Group",
      "AssociateId": 406,
      "UsePersonAddress": false,
      "ContactFax": "provident",
      "Kanafname": "rerum",
      "Kanalname": "hic",
      "Post1": "autem",
      "Post2": "nihil",
      "Post3": "vitae",
      "EmailName": "twila@goyettehoppe.com",
      "ContactFullName": "Mrs. Dejuan Daugherty DVM",
      "ActiveErpLinks": 986,
      "TicketPriorityId": 157,
      "SupportLanguageId": 954,
      "SupportAssociateId": 806,
      "CategoryName": "VIP Customer",
      "PersonNumber": "796577"
    }
  ],
  "NoMailing": true,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 633,
  "GroupId": 733,
  "ActiveStatusMonitorId": 603,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 35,
  "DbiAgentId": 433,
  "DbiLastSyncronized": "1999-08-23T14:28:26.820824+02:00",
  "DbiKey": "illo",
  "DbiLastModified": "2005-05-20T14:28:26.820824+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 182,
  "ActiveErpLinks": 631,
  "BounceEmails": [
    "remington_fadel@wyman.info",
    "domenic.quitzon@boyer.uk"
  ],
  "Domains": [
    "minima",
    "temporibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1650697835",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "ipsum",
    "CustomFields2": "sed"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 933,
  "Name": "Buckridge LLC",
  "Department": "",
  "OrgNr": "151330",
  "Number1": "1615714",
  "Number2": "997907",
  "UpdatedDate": "2007-10-03T14:28:26.820824+02:00",
  "CreatedDate": "2020-02-08T14:28:26.820824+01:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "nisi",
      "Description": "Customer-focused cohesive model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "nisi",
      "Description": "Customer-focused cohesive model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 326,
      "Name": "Prosacco, Ruecker and Muller",
      "ToolTip": "Et vel sit et.",
      "Deleted": true,
      "Rank": 377,
      "Type": "non",
      "ColorBlock": 487,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2023-08-07T14:28:26.820824+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "vel",
      "Hidden": false,
      "FullName": "Miss Aliyah Williamson MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "ducimus",
      "Description": "Fundamental homogeneous contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "ducimus",
      "Description": "Fundamental homogeneous contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "libero",
      "StrippedValue": "ut",
      "Description": "User-friendly bandwidth-monitored parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 401
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "ut",
      "Description": "User-friendly bandwidth-monitored parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 401
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "perferendis",
      "StrippedValue": "repellendus",
      "Description": "Extended demand-driven flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "repellendus",
      "Description": "Extended demand-driven flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "Description": "Focused national Graphic Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorum",
      "PersonId": 894,
      "Mrmrs": "sit",
      "Firstname": "Pauline",
      "Lastname": "Abernathy",
      "MiddleName": "Homenick Inc and Sons",
      "Title": "vel",
      "Description": "Programmable explicit hierarchy",
      "Email": "arnaldo@stokes.co.uk",
      "FullName": "Marvin Rolfson",
      "DirectPhone": "430.944.3489 x7981",
      "FormalName": "Williamson Inc and Sons",
      "CountryId": 369,
      "ContactId": 836,
      "ContactName": "Fritsch LLC",
      "Retired": 547,
      "Rank": 536,
      "ActiveInterests": 55,
      "ContactDepartment": "",
      "ContactCountryId": 183,
      "ContactOrgNr": "993582",
      "FaxPhone": "1-439-929-5858 x220",
      "MobilePhone": "535-911-0289 x377",
      "ContactPhone": "911-350-3358 x0175",
      "AssociateName": "Bartell LLC",
      "AssociateId": 836,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "ea",
      "Kanalname": "et",
      "Post1": "sed",
      "Post2": "repudiandae",
      "Post3": "rerum",
      "EmailName": "cierra_lueilwitz@leannon.biz",
      "ContactFullName": "Mr. Frankie Barton III",
      "ActiveErpLinks": 725,
      "TicketPriorityId": 189,
      "SupportLanguageId": 469,
      "SupportAssociateId": 36,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1030242",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 486
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quaerat",
  "Xstop": false,
  "ActiveInterests": 635,
  "GroupId": 626,
  "ActiveStatusMonitorId": 326,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 803,
  "DbiAgentId": 881,
  "DbiLastSyncronized": "2001-04-19T14:28:26.820824+02:00",
  "DbiKey": "sed",
  "DbiLastModified": "2003-12-05T14:28:26.820824+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 489,
  "ActiveErpLinks": 242,
  "BounceEmails": [
    "damion.lesch@keelingquigley.com",
    "sonny@rodriguezherzog.com"
  ],
  "Domains": [
    "dolorem",
    "fugiat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1216298907",
    "SuperOffice:2": "Mrs. Pietro Huel II"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 595
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```