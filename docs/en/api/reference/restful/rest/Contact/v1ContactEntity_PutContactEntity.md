---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 577,
  "Name": "Wisozk, Koelpin and Strosin",
  "Department": "",
  "OrgNr": "556826",
  "Number1": "721955",
  "Number2": "1879848",
  "UpdatedDate": "2012-07-22T13:38:17.2337227+02:00",
  "CreatedDate": "2007-02-17T13:38:17.2337227+01:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "repellat",
      "Description": "Open-source national matrix"
    },
    {
      "Value": "qui",
      "StrippedValue": "repellat",
      "Description": "Open-source national matrix"
    }
  ],
  "Interests": [
    {
      "Id": 851,
      "Name": "Windler, Barton and Goldner",
      "ToolTip": "Facilis assumenda excepturi nulla hic odit quaerat.",
      "Deleted": false,
      "Rank": 954,
      "Type": "voluptatem",
      "ColorBlock": 187,
      "IconHint": "a",
      "Selected": false,
      "LastChanged": "2014-01-11T13:38:17.2337227+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Ms. Mossie Schumm"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "eos",
      "Description": "Vision-oriented demand-driven pricing structure"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "eos",
      "Description": "Vision-oriented demand-driven pricing structure"
    }
  ],
  "Phones": [
    {
      "Value": "quae",
      "StrippedValue": "molestiae",
      "Description": "Optimized bandwidth-monitored firmware"
    },
    {
      "Value": "quae",
      "StrippedValue": "molestiae",
      "Description": "Optimized bandwidth-monitored firmware"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "quibusdam",
      "Description": "Optimized coherent contingency"
    },
    {
      "Value": "ut",
      "StrippedValue": "quibusdam",
      "Description": "Optimized coherent contingency"
    }
  ],
  "Description": "Business-focused asynchronous orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "odit",
      "PersonId": 684,
      "Mrmrs": "qui",
      "Firstname": "Dallas",
      "Lastname": "Ruecker",
      "MiddleName": "Ernser-Langosh",
      "Title": "eveniet",
      "Description": "Devolved scalable hierarchy",
      "Email": "elmira@carroll.com",
      "FullName": "Miss Darius Wolf",
      "DirectPhone": "490.127.6786",
      "FormalName": "Rice, Rogahn and Turcotte",
      "CountryId": 22,
      "ContactId": 819,
      "ContactName": "Schumm, Bruen and Walter",
      "Retired": 902,
      "Rank": 732,
      "ActiveInterests": 560,
      "ContactDepartment": "",
      "ContactCountryId": 596,
      "ContactOrgNr": "1908754",
      "FaxPhone": "1-951-366-0974 x9641",
      "MobilePhone": "198-317-3800 x67199",
      "ContactPhone": "658.782.6104",
      "AssociateName": "Lubowitz Group",
      "AssociateId": 934,
      "UsePersonAddress": true,
      "ContactFax": "sunt",
      "Kanafname": "ratione",
      "Kanalname": "harum",
      "Post1": "esse",
      "Post2": "pariatur",
      "Post3": "eligendi",
      "EmailName": "nikita@jakubowski.com",
      "ContactFullName": "Keely Trantow",
      "ActiveErpLinks": 430,
      "TicketPriorityId": 230,
      "SupportLanguageId": 810,
      "SupportAssociateId": 579,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "recusandae",
  "Xstop": false,
  "ActiveInterests": 427,
  "GroupId": 791,
  "ActiveStatusMonitorId": 821,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 603,
  "DbiAgentId": 229,
  "DbiLastSyncronized": "2014-10-18T13:38:17.2337227+02:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2005-05-01T13:38:17.2337227+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 118,
  "ActiveErpLinks": 12,
  "BounceEmails": [
    "william.oconner@reynolds.co.uk",
    "albin@hilllparisian.info"
  ],
  "Domains": [
    "velit",
    "doloribus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Florida Schamberger",
    "SuperOffice:2": "1562160355"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "similique"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 475,
  "Name": "Gleason-Gaylord",
  "Department": "",
  "OrgNr": "371437",
  "Number1": "1118079",
  "Number2": "771594",
  "UpdatedDate": "2008-11-04T13:38:17.2493417+01:00",
  "CreatedDate": "2003-10-10T13:38:17.2493417+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "sequi",
      "Description": "Balanced optimal initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "sequi",
      "Description": "Balanced optimal initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 458,
      "Name": "Mitchell Inc and Sons",
      "ToolTip": "Nemo id deleniti odio cumque mollitia.",
      "Deleted": false,
      "Rank": 21,
      "Type": "illum",
      "ColorBlock": 313,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2002-04-22T13:38:17.2493417+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "amet",
      "Hidden": false,
      "FullName": "Cleo Bogisich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 550
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptate",
      "StrippedValue": "inventore",
      "Description": "Focused secondary paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "inventore",
      "Description": "Focused secondary paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laborum",
      "StrippedValue": "modi",
      "Description": "Object-based 24 hour secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "modi",
      "Description": "Object-based 24 hour secured line",
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
  "Faxes": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "minima",
      "Description": "Organized interactive parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "minima",
      "Description": "Organized interactive parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "Description": "Quality-focused composite synergy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quod",
      "PersonId": 320,
      "Mrmrs": "enim",
      "Firstname": "Colby",
      "Lastname": "Fisher",
      "MiddleName": "Armstrong LLC",
      "Title": "similique",
      "Description": "Fully-configurable systemic time-frame",
      "Email": "michele.senger@gottliebconnelly.ca",
      "FullName": "Kassandra Farrell",
      "DirectPhone": "(056)386-0798 x145",
      "FormalName": "Murazik, Rowe and Beer",
      "CountryId": 692,
      "ContactId": 171,
      "ContactName": "Wilderman-Schiller",
      "Retired": 888,
      "Rank": 952,
      "ActiveInterests": 380,
      "ContactDepartment": "",
      "ContactCountryId": 639,
      "ContactOrgNr": "1201429",
      "FaxPhone": "438-840-8160",
      "MobilePhone": "(181)460-3321",
      "ContactPhone": "837.825.8013",
      "AssociateName": "Hand-Daugherty",
      "AssociateId": 648,
      "UsePersonAddress": true,
      "ContactFax": "sint",
      "Kanafname": "molestias",
      "Kanalname": "ea",
      "Post1": "quia",
      "Post2": "sint",
      "Post3": "est",
      "EmailName": "ron.bode@glover.info",
      "ContactFullName": "Pinkie Bashirian",
      "ActiveErpLinks": 368,
      "TicketPriorityId": 651,
      "SupportLanguageId": 102,
      "SupportAssociateId": 725,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptate",
  "Xstop": true,
  "ActiveInterests": 552,
  "GroupId": 150,
  "ActiveStatusMonitorId": 403,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 729,
  "DbiAgentId": 216,
  "DbiLastSyncronized": "2002-01-02T13:38:17.2493417+01:00",
  "DbiKey": "atque",
  "DbiLastModified": "2022-04-07T13:38:17.2493417+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 860,
  "ActiveErpLinks": 970,
  "BounceEmails": [
    "vaughn@ankunding.biz",
    "nikki.gaylord@homenick.info"
  ],
  "Domains": [
    "deleniti",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Delilah Merritt Lang Jr.",
    "SuperOffice:2": "Dr. Delia Sheldon Zboncak II"
  },
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "consequuntur",
    "CustomFields2": "rem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 656
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```