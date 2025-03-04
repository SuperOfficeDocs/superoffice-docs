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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 651,
  "Name": "Wyman, Beahan and Gaylord",
  "Department": "",
  "OrgNr": "930628",
  "Number1": "1143674",
  "Number2": "1481816",
  "UpdatedDate": "2006-11-29T14:13:48.4914217+01:00",
  "CreatedDate": "2017-09-03T14:13:48.4914217+02:00",
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "pariatur",
      "Description": "Managed secondary interface"
    },
    {
      "Value": "officia",
      "StrippedValue": "pariatur",
      "Description": "Managed secondary interface"
    }
  ],
  "Interests": [
    {
      "Id": 201,
      "Name": "Shields-Robel",
      "ToolTip": "Provident qui error doloribus sunt inventore dolorem accusantium.",
      "Deleted": false,
      "Rank": 307,
      "Type": "ullam",
      "ColorBlock": 323,
      "IconHint": "id",
      "Selected": true,
      "LastChanged": "2012-08-15T14:13:48.4914217+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Ms. Eleanora Shanahan"
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "earum",
      "Description": "Front-line cohesive alliance"
    },
    {
      "Value": "eaque",
      "StrippedValue": "earum",
      "Description": "Front-line cohesive alliance"
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "autem",
      "Description": "Proactive systemic initiative"
    },
    {
      "Value": "non",
      "StrippedValue": "autem",
      "Description": "Proactive systemic initiative"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Digitized static utilisation"
    },
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Digitized static utilisation"
    }
  ],
  "Description": "Optimized leading edge architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eveniet",
      "PersonId": 114,
      "Mrmrs": "ut",
      "Firstname": "Evert",
      "Lastname": "Rath",
      "MiddleName": "White-Howe",
      "Title": "perferendis",
      "Description": "Persistent contextually-based artificial intelligence",
      "Email": "ollie_bernhard@larson.us",
      "FullName": "Emmie Hettinger",
      "DirectPhone": "1-061-370-8640 x8713",
      "FormalName": "Powlowski LLC",
      "CountryId": 887,
      "ContactId": 364,
      "ContactName": "Eichmann Group",
      "Retired": 381,
      "Rank": 77,
      "ActiveInterests": 425,
      "ContactDepartment": "",
      "ContactCountryId": 411,
      "ContactOrgNr": "378561",
      "FaxPhone": "(052)051-9934 x55742",
      "MobilePhone": "(036)511-8503",
      "ContactPhone": "092.311.7796",
      "AssociateName": "Mann LLC",
      "AssociateId": 519,
      "UsePersonAddress": false,
      "ContactFax": "accusantium",
      "Kanafname": "ut",
      "Kanalname": "dolor",
      "Post1": "ad",
      "Post2": "sed",
      "Post3": "et",
      "EmailName": "genevieve@daniel.biz",
      "ContactFullName": "Mrs. Gabriel Santos Cassin II",
      "ActiveErpLinks": 804,
      "TicketPriorityId": 270,
      "SupportLanguageId": 700,
      "SupportAssociateId": 200,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1027401"
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 175,
  "GroupId": 308,
  "ActiveStatusMonitorId": 496,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 647,
  "DbiAgentId": 968,
  "DbiLastSyncronized": "2005-09-01T14:13:48.5070431+02:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2010-09-01T14:13:48.5070431+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 212,
  "ActiveErpLinks": 119,
  "BounceEmails": [
    "clemens@bednar.biz",
    "jody_gislason@shanahan.co.uk"
  ],
  "Domains": [
    "ipsa",
    "dicta"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1845757662",
    "SuperOffice:2": "1926257002"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 440,
  "Name": "Bailey LLC",
  "Department": "",
  "OrgNr": "1375493",
  "Number1": "1123410",
  "Number2": "891281",
  "UpdatedDate": "2014-10-02T14:13:48.5070431+02:00",
  "CreatedDate": "2002-11-07T14:13:48.5070431+01:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "ea",
      "Description": "Re-engineered optimal encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "ea",
      "Description": "Re-engineered optimal encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 23,
      "Name": "O'Reilly LLC",
      "ToolTip": "Amet nemo dolor sint repellendus facilis.",
      "Deleted": false,
      "Rank": 670,
      "Type": "quae",
      "ColorBlock": 880,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "2008-06-11T14:13:48.5070431+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reprehenderit",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Shany Krajcik",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "molestias",
      "Description": "Profit-focused maximized frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "molestias",
      "Description": "Profit-focused maximized frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "User-friendly full-range intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "User-friendly full-range intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "est",
      "Description": "Grass-roots radical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "est",
      "Description": "Grass-roots radical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    }
  ],
  "Description": "Versatile bottom-line open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veritatis",
      "PersonId": 119,
      "Mrmrs": "consequatur",
      "Firstname": "Skye",
      "Lastname": "Boehm",
      "MiddleName": "Sauer-Ferry",
      "Title": "laudantium",
      "Description": "Balanced regional customer loyalty",
      "Email": "frederik.hegmann@champlin.ca",
      "FullName": "Estrella Barrows",
      "DirectPhone": "1-635-209-9100",
      "FormalName": "Klein LLC",
      "CountryId": 321,
      "ContactId": 448,
      "ContactName": "Schmidt Group",
      "Retired": 661,
      "Rank": 408,
      "ActiveInterests": 100,
      "ContactDepartment": "iterate magnetic networks",
      "ContactCountryId": 522,
      "ContactOrgNr": "411042",
      "FaxPhone": "821.801.3608 x70660",
      "MobilePhone": "(910)987-2573",
      "ContactPhone": "608-641-1642",
      "AssociateName": "Rempel, Bartoletti and Witting",
      "AssociateId": 391,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "rerum",
      "Kanalname": "magnam",
      "Post1": "nam",
      "Post2": "nemo",
      "Post3": "soluta",
      "EmailName": "vidal@bergstrom.com",
      "ContactFullName": "Jeff Bogisich",
      "ActiveErpLinks": 930,
      "TicketPriorityId": 595,
      "SupportLanguageId": 272,
      "SupportAssociateId": 514,
      "CategoryName": "VIP Customer",
      "PersonNumber": "758794",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "beatae",
  "Xstop": false,
  "ActiveInterests": 200,
  "GroupId": 649,
  "ActiveStatusMonitorId": 270,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 908,
  "DbiAgentId": 834,
  "DbiLastSyncronized": "2015-05-27T14:13:48.5070431+02:00",
  "DbiKey": "dicta",
  "DbiLastModified": "2023-03-16T14:13:48.5070431+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 519,
  "ActiveErpLinks": 891,
  "BounceEmails": [
    "allie@dicki.com",
    "adrien_marvin@ohara.ca"
  ],
  "Domains": [
    "mollitia",
    "rem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Jarret Sporer"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 829
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```