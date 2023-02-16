---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 973
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 235,
  "Name": "Willms-Yost",
  "Department": "",
  "OrgNr": "636756",
  "Number1": "1677365",
  "Number2": "914795",
  "UpdatedDate": "2008-01-21T14:19:03.0261539+01:00",
  "CreatedDate": "2006-05-09T14:19:03.0261539+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "iusto",
      "Description": "Sharable exuding circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "iusto",
      "Description": "Sharable exuding circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 149,
      "Name": "Cummerata, Homenick and Doyle",
      "ToolTip": "Et blanditiis ut iste.",
      "Deleted": false,
      "Rank": 451,
      "Type": "eum",
      "ColorBlock": 218,
      "IconHint": "ipsa",
      "Selected": true,
      "LastChanged": "1996-05-28T14:19:03.0261539+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "exercitationem",
      "Hidden": true,
      "FullName": "Mrs. Rachael Fritsch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "tempore",
      "Description": "Streamlined 4th generation strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "tempore",
      "Description": "Streamlined 4th generation strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "deserunt",
      "Description": "De-engineered motivating success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "deserunt",
      "Description": "De-engineered motivating success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "et",
      "Description": "Realigned 4th generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "et",
      "Description": "Realigned 4th generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    }
  ],
  "Description": "Reverse-engineered full-range benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nam",
      "PersonId": 855,
      "Mrmrs": "illo",
      "Firstname": "Jeremie",
      "Lastname": "Koepp",
      "MiddleName": "Gutmann LLC",
      "Title": "provident",
      "Description": "User-friendly modular structure",
      "Email": "samanta@goldnerbradtke.name",
      "FullName": "Mrs. Alayna Welch",
      "DirectPhone": "(873)355-8528 x040",
      "FormalName": "Farrell-Jacobson",
      "CountryId": 864,
      "ContactId": 318,
      "ContactName": "Turcotte LLC",
      "Retired": 8,
      "Rank": 326,
      "ActiveInterests": 513,
      "ContactDepartment": "",
      "ContactCountryId": 336,
      "ContactOrgNr": "1060015",
      "FaxPhone": "251-190-1354 x30949",
      "MobilePhone": "(228)969-6944 x3880",
      "ContactPhone": "050-724-3529 x5655",
      "AssociateName": "Osinski-Rippin",
      "AssociateId": 746,
      "UsePersonAddress": false,
      "ContactFax": "occaecati",
      "Kanafname": "nobis",
      "Kanalname": "atque",
      "Post1": "quaerat",
      "Post2": "cupiditate",
      "Post3": "laboriosam",
      "EmailName": "wilber.leannon@torp.co.uk",
      "ContactFullName": "Noe Hagenes",
      "ActiveErpLinks": 19,
      "TicketPriorityId": 702,
      "SupportLanguageId": 279,
      "SupportAssociateId": 151,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 308
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "distinctio",
  "Xstop": true,
  "ActiveInterests": 841,
  "GroupId": 929,
  "ActiveStatusMonitorId": 172,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 26,
  "DbiAgentId": 532,
  "DbiLastSyncronized": "2016-01-16T14:19:03.0261539+01:00",
  "DbiKey": "repellat",
  "DbiLastModified": "2009-01-21T14:19:03.0261539+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 118,
  "ActiveErpLinks": 83,
  "BounceEmails": [
    "ofelia@steuber.uk",
    "lottie_spencer@emmerichcruickshank.co.uk"
  ],
  "Domains": [
    "aut",
    "quas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "427790804",
    "SuperOffice:2": "Nicklaus Kuvalis"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "velit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 229
    }
  }
}
```