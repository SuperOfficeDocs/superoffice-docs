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
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 672,
  "Name": "Stanton, Bednar and Hane",
  "Department": "",
  "OrgNr": "578197",
  "Number1": "1110139",
  "Number2": "1765566",
  "UpdatedDate": "2005-06-11T11:06:41.5822408+02:00",
  "CreatedDate": "2021-02-07T11:06:41.5822408+01:00",
  "Emails": [
    {
      "Value": "eos",
      "StrippedValue": "eum",
      "Description": "Advanced dedicated array"
    },
    {
      "Value": "eos",
      "StrippedValue": "eum",
      "Description": "Advanced dedicated array"
    }
  ],
  "Interests": [
    {
      "Id": 30,
      "Name": "Abbott-Heller",
      "ToolTip": "Quo ipsum sapiente suscipit sit error.",
      "Deleted": false,
      "Rank": 62,
      "Type": "laudantium",
      "ColorBlock": 1001,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2022-10-26T11:06:41.5822408+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "sit",
      "Hidden": true,
      "FullName": "Beverly Koss"
    }
  ],
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "autem",
      "Description": "Optional bottom-line internet solution"
    },
    {
      "Value": "officiis",
      "StrippedValue": "autem",
      "Description": "Optional bottom-line internet solution"
    }
  ],
  "Phones": [
    {
      "Value": "illo",
      "StrippedValue": "dolorum",
      "Description": "Expanded bi-directional benchmark"
    },
    {
      "Value": "illo",
      "StrippedValue": "dolorum",
      "Description": "Expanded bi-directional benchmark"
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "repellat",
      "Description": "Enterprise-wide client-driven forecast"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "repellat",
      "Description": "Enterprise-wide client-driven forecast"
    }
  ],
  "Description": "Switchable client-server encryption",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cumque",
      "PersonId": 856,
      "Mrmrs": "quidem",
      "Firstname": "Vickie",
      "Lastname": "Krajcik",
      "MiddleName": "Rohan, Dickinson and Mante",
      "Title": "odit",
      "Description": "Multi-tiered interactive capacity",
      "Email": "lesly@west.us",
      "FullName": "Ms. Demarcus Kirlin",
      "DirectPhone": "644.754.6719",
      "FormalName": "Barrows Inc and Sons",
      "CountryId": 909,
      "ContactId": 514,
      "ContactName": "Nitzsche-Olson",
      "Retired": 979,
      "Rank": 934,
      "ActiveInterests": 334,
      "ContactDepartment": "",
      "ContactCountryId": 117,
      "ContactOrgNr": "1293891",
      "FaxPhone": "310-597-1207",
      "MobilePhone": "1-009-050-6076 x6099",
      "ContactPhone": "1-708-196-7489 x366",
      "AssociateName": "Cruickshank-Jacobson",
      "AssociateId": 390,
      "UsePersonAddress": false,
      "ContactFax": "quaerat",
      "Kanafname": "eligendi",
      "Kanalname": "maxime",
      "Post1": "aut",
      "Post2": "sint",
      "Post3": "laudantium",
      "EmailName": "maxine.lueilwitz@mraz.name",
      "ContactFullName": "Jayda Monahan",
      "ActiveErpLinks": 325,
      "TicketPriorityId": 474,
      "SupportLanguageId": 830,
      "SupportAssociateId": 204,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "molestiae",
  "Xstop": false,
  "ActiveInterests": 788,
  "GroupId": 427,
  "ActiveStatusMonitorId": 832,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 521,
  "DbiAgentId": 864,
  "DbiLastSyncronized": "2013-09-14T11:06:41.5822408+02:00",
  "DbiKey": "voluptate",
  "DbiLastModified": "1997-11-06T11:06:41.5822408+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 118,
  "ActiveErpLinks": 342,
  "BounceEmails": [
    "mariam_powlowski@harber.ca",
    "alize@gulgowski.co.uk"
  ],
  "Domains": [
    "sed",
    "voluptatibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Hortense Rodriguez"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "dolor"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 889,
  "Name": "Hickle LLC",
  "Department": "",
  "OrgNr": "1861644",
  "Number1": "1344910",
  "Number2": "190285",
  "UpdatedDate": "2013-05-29T11:06:41.597865+02:00",
  "CreatedDate": "2006-11-08T11:06:41.597865+01:00",
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "mollitia",
      "Description": "Configurable stable definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "mollitia",
      "Description": "Configurable stable definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 295,
      "Name": "Welch, Ryan and Schoen",
      "ToolTip": "Adipisci rerum et eligendi in et ipsa expedita.",
      "Deleted": false,
      "Rank": 364,
      "Type": "velit",
      "ColorBlock": 173,
      "IconHint": "delectus",
      "Selected": false,
      "LastChanged": "2006-12-24T11:06:41.597865+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempore",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Anne Joan Hilll II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "eos",
      "Description": "Focused bandwidth-monitored algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "eos",
      "Description": "Focused bandwidth-monitored algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "ut",
      "Description": "Adaptive high-level open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "ut",
      "Description": "Adaptive high-level open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quisquam",
      "StrippedValue": "facere",
      "Description": "Optimized even-keeled model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "facere",
      "Description": "Optimized even-keeled model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "Description": "Digitized full-range encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quod",
      "PersonId": 972,
      "Mrmrs": "magni",
      "Firstname": "Adrien",
      "Lastname": "Treutel",
      "MiddleName": "Hirthe, Johnson and Rogahn",
      "Title": "et",
      "Description": "Team-oriented executive strategy",
      "Email": "john@grahambogan.com",
      "FullName": "Chanel Lexi Hackett I",
      "DirectPhone": "1-394-945-7913 x9926",
      "FormalName": "Lubowitz, Schiller and Hoppe",
      "CountryId": 850,
      "ContactId": 576,
      "ContactName": "Dooley, Kris and Luettgen",
      "Retired": 58,
      "Rank": 252,
      "ActiveInterests": 411,
      "ContactDepartment": "",
      "ContactCountryId": 462,
      "ContactOrgNr": "1094078",
      "FaxPhone": "596-473-8738",
      "MobilePhone": "278-946-5677",
      "ContactPhone": "1-620-558-6561",
      "AssociateName": "Rempel Inc and Sons",
      "AssociateId": 263,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "doloremque",
      "Kanalname": "deleniti",
      "Post1": "possimus",
      "Post2": "esse",
      "Post3": "sed",
      "EmailName": "ernesto_corkery@dickens.us",
      "ContactFullName": "Dawn Doyle",
      "ActiveErpLinks": 849,
      "TicketPriorityId": 639,
      "SupportLanguageId": 640,
      "SupportAssociateId": 312,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "sunt",
  "Xstop": true,
  "ActiveInterests": 624,
  "GroupId": 861,
  "ActiveStatusMonitorId": 678,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 451,
  "DbiAgentId": 120,
  "DbiLastSyncronized": "2011-07-21T11:06:41.597865+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2007-07-20T11:06:41.597865+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 846,
  "ActiveErpLinks": 887,
  "BounceEmails": [
    "stephan@schaden.name",
    "fermin@rau.com"
  ],
  "Domains": [
    "non",
    "minus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1098126837",
    "SuperOffice:2": "Loyal Zieme"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "eos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 262
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```