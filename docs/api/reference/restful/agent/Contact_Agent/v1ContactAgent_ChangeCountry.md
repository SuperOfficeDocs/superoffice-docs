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
| ContactEntity |  | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | int32 |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 782
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 78,
  "Name": "Marquardt-Sipes",
  "Department": "",
  "OrgNr": "266547",
  "Number1": "1459845",
  "Number2": "226533",
  "UpdatedDate": "1996-12-06T11:10:26.3284318+01:00",
  "CreatedDate": "2010-09-28T11:10:26.3284318+02:00",
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "hic",
      "Description": "Right-sized hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "hic",
      "Description": "Right-sized hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 899,
      "Name": "Bins-Miller",
      "ToolTip": "Exercitationem quis ullam autem aut numquam.",
      "Deleted": false,
      "Rank": 62,
      "Type": "labore",
      "ColorBlock": 21,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "1998-11-15T11:10:26.3284318+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quod",
      "StyleHint": "deserunt",
      "Hidden": false,
      "FullName": "Jamison Ferry",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "possimus",
      "Description": "Profound empowering capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "possimus",
      "Description": "Profound empowering capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptates",
      "StrippedValue": "dolor",
      "Description": "Triple-buffered optimal solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "dolor",
      "Description": "Triple-buffered optimal solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ducimus",
      "Description": "Expanded optimizing intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ducimus",
      "Description": "Expanded optimizing intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    }
  ],
  "Description": "Team-oriented zero administration infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "perferendis",
      "PersonId": 853,
      "Mrmrs": "non",
      "Firstname": "Elsie",
      "Lastname": "Wunsch",
      "MiddleName": "Trantow, Gerlach and Tillman",
      "Title": "qui",
      "Description": "Compatible secondary paradigm",
      "Email": "margarete@runte.com",
      "FullName": "Rollin Harvey Braun I",
      "DirectPhone": "(022)163-6055",
      "FormalName": "McClure Group",
      "CountryId": 625,
      "ContactId": 770,
      "ContactName": "Prosacco Group",
      "Retired": 805,
      "Rank": 973,
      "ActiveInterests": 57,
      "ContactDepartment": "",
      "ContactCountryId": 968,
      "ContactOrgNr": "1616528",
      "FaxPhone": "215-941-7759 x070",
      "MobilePhone": "949.923.8940 x056",
      "ContactPhone": "1-963-843-6588",
      "AssociateName": "McKenzie, Kuhn and Purdy",
      "AssociateId": 896,
      "UsePersonAddress": false,
      "ContactFax": "alias",
      "Kanafname": "quisquam",
      "Kanalname": "nihil",
      "Post1": "doloremque",
      "Post2": "omnis",
      "Post3": "qui",
      "EmailName": "justina_lind@kozey.ca",
      "ContactFullName": "Dr. Opal Kulas III",
      "ActiveErpLinks": 699,
      "TicketPriorityId": 164,
      "SupportLanguageId": 40,
      "SupportAssociateId": 708,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "earum",
  "Xstop": true,
  "ActiveInterests": 137,
  "GroupId": 898,
  "ActiveStatusMonitorId": 516,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 617,
  "DbiAgentId": 233,
  "DbiLastSyncronized": "2013-02-26T11:10:26.3324578+01:00",
  "DbiKey": "et",
  "DbiLastModified": "1997-08-13T11:10:26.3324578+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 960,
  "ActiveErpLinks": 808,
  "BounceEmails": [
    "tyrique.feeney@leuschke.us",
    "koby@fadel.info"
  ],
  "Domains": [
    "dolorem",
    "aspernatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Keara Parker",
    "SuperOffice:2": "Enos Marvin"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 163
    }
  }
}
```
