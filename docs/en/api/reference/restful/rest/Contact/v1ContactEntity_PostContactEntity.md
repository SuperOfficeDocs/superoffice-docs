---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 25,
  "Name": "Buckridge-Hessel",
  "Department": "",
  "OrgNr": "980094",
  "Number1": "775668",
  "Number2": "1170439",
  "UpdatedDate": "1998-09-14T03:51:33.2710559+02:00",
  "CreatedDate": "2006-03-22T03:51:33.2710559+01:00",
  "Emails": [
    {
      "Value": "quam",
      "StrippedValue": "soluta",
      "Description": "Persevering global core"
    },
    {
      "Value": "quam",
      "StrippedValue": "soluta",
      "Description": "Persevering global core"
    }
  ],
  "Interests": [
    {
      "Id": 246,
      "Name": "Yundt, Waters and Haag",
      "ToolTip": "Incidunt pariatur quia ullam eum sed et.",
      "Deleted": true,
      "Rank": 60,
      "Type": "praesentium",
      "ColorBlock": 503,
      "IconHint": "dolor",
      "Selected": true,
      "LastChanged": "2003-03-13T03:51:33.2710559+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "atque",
      "StyleHint": "quod",
      "Hidden": true,
      "FullName": "Ivory Bergstrom"
    }
  ],
  "Urls": [
    {
      "Value": "officia",
      "StrippedValue": "molestiae",
      "Description": "Vision-oriented executive adapter"
    },
    {
      "Value": "officia",
      "StrippedValue": "molestiae",
      "Description": "Vision-oriented executive adapter"
    }
  ],
  "Phones": [
    {
      "Value": "aperiam",
      "StrippedValue": "voluptatum",
      "Description": "Focused scalable instruction set"
    },
    {
      "Value": "aperiam",
      "StrippedValue": "voluptatum",
      "Description": "Focused scalable instruction set"
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "sunt",
      "Description": "Reactive asynchronous matrix"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "sunt",
      "Description": "Reactive asynchronous matrix"
    }
  ],
  "Description": "Digitized systemic instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "culpa",
      "PersonId": 27,
      "Mrmrs": "animi",
      "Firstname": "Delaney",
      "Lastname": "Jaskolski",
      "MiddleName": "Dare Inc and Sons",
      "Title": "consequatur",
      "Description": "Synchronised fresh-thinking approach",
      "Email": "raheem@cronin.name",
      "FullName": "Aryanna Dashawn Hodkiewicz II",
      "DirectPhone": "(441)098-8496",
      "FormalName": "Thompson, Krajcik and Satterfield",
      "CountryId": 871,
      "ContactId": 276,
      "ContactName": "Schinner, Ward and Jacobi",
      "Retired": 529,
      "Rank": 953,
      "ActiveInterests": 742,
      "ContactDepartment": "",
      "ContactCountryId": 38,
      "ContactOrgNr": "1631394",
      "FaxPhone": "392.555.7556 x554",
      "MobilePhone": "(145)925-4973",
      "ContactPhone": "(747)865-2898 x65204",
      "AssociateName": "Kerluke, Nikolaus and Price",
      "AssociateId": 305,
      "UsePersonAddress": false,
      "ContactFax": "quos",
      "Kanafname": "earum",
      "Kanalname": "delectus",
      "Post1": "fugiat",
      "Post2": "earum",
      "Post3": "in",
      "EmailName": "eugene@jerde.com",
      "ContactFullName": "Kurtis Larkin",
      "ActiveErpLinks": 862,
      "TicketPriorityId": 355,
      "SupportLanguageId": 343,
      "SupportAssociateId": 738,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "ducimus",
  "Xstop": false,
  "ActiveInterests": 655,
  "GroupId": 876,
  "ActiveStatusMonitorId": 620,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 13,
  "DbiAgentId": 801,
  "DbiLastSyncronized": "2015-01-25T03:51:33.2866744+01:00",
  "DbiKey": "rerum",
  "DbiLastModified": "2020-05-24T03:51:33.2866744+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 901,
  "ActiveErpLinks": 409,
  "BounceEmails": [
    "kacie_hammes@abernathycrooks.co.uk",
    "madelyn_ledner@walter.us"
  ],
  "Domains": [
    "iure",
    "ullam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Boyd Reichel",
    "SuperOffice:2": "811069660"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "iure"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 882,
  "Name": "Mills, Langworth and Reichert",
  "Department": "",
  "OrgNr": "142448",
  "Number1": "1146420",
  "Number2": "1123873",
  "UpdatedDate": "2015-12-02T03:51:33.2866744+01:00",
  "CreatedDate": "2019-01-09T03:51:33.2866744+01:00",
  "Emails": [
    {
      "Value": "sequi",
      "StrippedValue": "ut",
      "Description": "Customer-focused systemic interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "ut",
      "Description": "Customer-focused systemic interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 702,
      "Name": "Thiel Inc and Sons",
      "ToolTip": "Atque officia et tenetur.",
      "Deleted": false,
      "Rank": 269,
      "Type": "maiores",
      "ColorBlock": 787,
      "IconHint": "debitis",
      "Selected": true,
      "LastChanged": "1996-07-11T03:51:33.2866744+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Mrs. Nina Reynolds Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 343
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ex",
      "StrippedValue": "soluta",
      "Description": "Programmable disintermediate middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "soluta",
      "Description": "Programmable disintermediate middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "fuga",
      "Description": "Switchable methodical ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "fuga",
      "Description": "Switchable methodical ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maxime",
      "StrippedValue": "enim",
      "Description": "Managed didactic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "enim",
      "Description": "Managed didactic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    }
  ],
  "Description": "Universal local adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ducimus",
      "PersonId": 353,
      "Mrmrs": "nobis",
      "Firstname": "Alanna",
      "Lastname": "Green",
      "MiddleName": "Herzog LLC",
      "Title": "officia",
      "Description": "Function-based dynamic software",
      "Email": "niko_mayert@russelgleichner.biz",
      "FullName": "Jacklyn Osborne Kautzer II",
      "DirectPhone": "161.362.0879",
      "FormalName": "Dietrich-Roob",
      "CountryId": 98,
      "ContactId": 155,
      "ContactName": "Bruen LLC",
      "Retired": 969,
      "Rank": 206,
      "ActiveInterests": 592,
      "ContactDepartment": "",
      "ContactCountryId": 834,
      "ContactOrgNr": "1274953",
      "FaxPhone": "022.137.9001 x7143",
      "MobilePhone": "529.683.5205",
      "ContactPhone": "627-254-4835",
      "AssociateName": "White-Hamill",
      "AssociateId": 874,
      "UsePersonAddress": true,
      "ContactFax": "nobis",
      "Kanafname": "quia",
      "Kanalname": "totam",
      "Post1": "ut",
      "Post2": "et",
      "Post3": "provident",
      "EmailName": "adele.heller@millerlehner.biz",
      "ContactFullName": "Valentine Waters",
      "ActiveErpLinks": 411,
      "TicketPriorityId": 13,
      "SupportLanguageId": 453,
      "SupportAssociateId": 395,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "corporis",
  "Xstop": false,
  "ActiveInterests": 637,
  "GroupId": 944,
  "ActiveStatusMonitorId": 541,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 575,
  "DbiAgentId": 453,
  "DbiLastSyncronized": "2016-10-20T03:51:33.2866744+02:00",
  "DbiKey": "distinctio",
  "DbiLastModified": "2022-11-10T03:51:33.2866744+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 421,
  "ActiveErpLinks": 353,
  "BounceEmails": [
    "angus_witting@predovic.com",
    "katarina@auerturcotte.us"
  ],
  "Domains": [
    "facere",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Josefina Beer PhD",
    "SuperOffice:2": "Rahul Bernier Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "quam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 69
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```