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
  "ToCountryId": 995
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 195,
  "Name": "Hansen-Lesch",
  "Department": "",
  "OrgNr": "902240",
  "Number1": "1445216",
  "Number2": "342047",
  "UpdatedDate": "2020-03-23T15:29:21.1828198+01:00",
  "CreatedDate": "1996-01-29T15:29:21.1828198+01:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "provident",
      "Description": "Expanded user-facing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "provident",
      "Description": "Expanded user-facing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 815,
      "Name": "Cruickshank, Botsford and Bailey",
      "ToolTip": "Velit illo autem repellat quia sunt consequatur eos.",
      "Deleted": true,
      "Rank": 526,
      "Type": "neque",
      "ColorBlock": 775,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2020-03-28T15:29:21.1828198+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "distinctio",
      "StyleHint": "voluptas",
      "Hidden": true,
      "FullName": "Favian D'Amore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 233
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Enhanced upward-trending framework",
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
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Enhanced upward-trending framework",
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
  "Phones": [
    {
      "Value": "architecto",
      "StrippedValue": "eum",
      "Description": "Pre-emptive executive project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "eum",
      "Description": "Pre-emptive executive project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aliquam",
      "StrippedValue": "vero",
      "Description": "Stand-alone regional moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "vero",
      "Description": "Stand-alone regional moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "Description": "Seamless motivating installation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 898,
      "Mrmrs": "dolor",
      "Firstname": "Sienna",
      "Lastname": "Kreiger",
      "MiddleName": "Corwin Inc and Sons",
      "Title": "eveniet",
      "Description": "Advanced 3rd generation archive",
      "Email": "heath@wolf.biz",
      "FullName": "Torey Flatley",
      "DirectPhone": "1-369-402-7459",
      "FormalName": "Koelpin-Von",
      "CountryId": 88,
      "ContactId": 830,
      "ContactName": "Yost, Hodkiewicz and Bogisich",
      "Retired": 196,
      "Rank": 206,
      "ActiveInterests": 786,
      "ContactDepartment": "",
      "ContactCountryId": 196,
      "ContactOrgNr": "1480350",
      "FaxPhone": "1-347-337-3904 x6761",
      "MobilePhone": "417-122-2352",
      "ContactPhone": "885-634-6965 x961",
      "AssociateName": "Morar Inc and Sons",
      "AssociateId": 987,
      "UsePersonAddress": false,
      "ContactFax": "corporis",
      "Kanafname": "totam",
      "Kanalname": "et",
      "Post1": "soluta",
      "Post2": "tempora",
      "Post3": "et",
      "EmailName": "mason@raynor.com",
      "ContactFullName": "Prof. Benton Brielle Stroman",
      "ActiveErpLinks": 428,
      "TicketPriorityId": 547,
      "SupportLanguageId": 715,
      "SupportAssociateId": 628,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 388,
  "GroupId": 814,
  "ActiveStatusMonitorId": 16,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 430,
  "DbiAgentId": 564,
  "DbiLastSyncronized": "2013-07-24T15:29:21.1878195+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2016-07-10T15:29:21.1878195+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 344,
  "ActiveErpLinks": 51,
  "BounceEmails": [
    "jimmie.veum@paucek.uk",
    "janae@mitchell.info"
  ],
  "Domains": [
    "voluptatem",
    "hic"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Maureen Felicita Schimmel DDS",
    "SuperOffice:2": "625413699"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 153
    }
  }
}
```