---
title: Headers
uid: webapi_headers
description: "HTTP headers that the SuperOffice WebAPI understands."
author: Bergfrid Dias
so.date: 12.02.2021
keywords: API, WebAPI, headers, Accept-Language, Content-Type, If-Modified-Since, If-Unmodified-Since, internationalization, SO-Language, SO-Culture, Accept, If-Modified-Since, If-Unmodified-Since, SO-TimeZone, includeTZOffset
so.topic: concept 
---

# Headers

HTTP headers that the SuperOffice WebAPI understands:

* Accept-Language
* Content-Type
* If-Modified-Since and If-Unmodified-Since (REST only)
* SO-TimeZone

## <a name="accept-language"></a>Multiple languages

The API supports internationalization.

A request without an `Accept-Language` header returns the string identifiers unchanged. Multi-language names are unchanged.

```http
GET /api/v1/List/Category/Items/2
```

This returns a multi-language string `NO:"Leverandør";US:"Supplier"` - which is not so useful when we want to show something to the user.

If we add the `Accept-Language: en` header, then we get back a **parsed result:**

```http
Accept-Language: en
GET /api/v1/List/Category/Items/2
```

This returns just `Supplier`.

Similarly, string resource IDs are replaced when a language is specified. This applies to some archive headings and entity properties.

**Field properties** contain reasons why fields are required. Without an `Accept-Language` header, you get back `FieldProperties` like this:

```json
"FieldRight": {
  "Mask": "Update, UIHintMandatory",
  "Reason": "[SR_MANDATORY_FIELD_1281]" },
```

With an `Accept-Language: fr` header, we get back:

```json
"FieldRight": {
  "Mask": "Update, UIHintMandatory",
  "Reason": "Nom de société" }
```

### SO-Language

Sometimes the browser doesn't want to change the `Accept-Language` it is using. We can override the `Accept-Language` header with the custom `SO-Language` header.

```http
 GET /api/v1/List/Category/Items/2
 Accept-Language: en-us; en-gb
 SO-Language: nb-no
```

The above will result in Norwegian language strings being returned, rather than English values.

You can pass a `*` or an `x` to signal you want to cancel language translation.

```http
 GET /api/v1/List/Category/Items/2
 Accept-Language: en-us; en-gb
 SO-Language: x
```

This will return un-translated values.

### SO-Culture

Some cultures have variations in number formatting and so on. These can be handled using the `SO-Culture` header.

For the most part, dates and numbers are passed in neutral culture form. The JSON date is always going to be in ISO format `2019-09-23T12:34:45Z` and a decimal number is always going to be with a period decimal point `3.14159`.

But if an API returns a string containing a value `"3.14159"` rather than the value itself, the `SO-Culture` header will handle these for you.

SO-Culture defaults to the language, so you only need to specify it when it is different. The following tells the API to use the Norwegian strings and labels, but format numbers and dates as Swedish.

```http
 GET /api/v1/List/Category/Items/2
 Accept-Language: en-us; en-gb
 SO-Language: nb-no
 SO-Culture: sv
```

## <a name="content-type"></a>Content types

The API supports both JSON and XML responses. Use the `Accept` header to specify which you would like to receive.

### XML

**Agents:**

```http
POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=123
Accept: application/xml
```

**REST:**

```http
GET /api/v1/Contact/123
Accept: application/xml
```

Returns an XML representation of the contact:

```xml
<ContactEntity>
  <ContactId>123</ContactId>
  <Name>Elan Hoppski</Name>
  <Department>EAvdeling</Department>
  <OrgNr></OrgNr>
  <Number1>123</Number1>
</ContactEntity>
```

### JSON

**Agents:**

```http
POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=123
Accept: application/json
```

**REST:**

```http
GET /api/v1/Contact/123
Accept: application/json
```

Returns a JSON representation of the same (contact 123):

```json
{ "ContactId": 123,
  "Name": "Elan Hoppski",
  "Department": "EAvdeling",
  "OrgNr": "",
  "Number1": "123"
}
```

## <a name="modified-unmodified"></a>Modified or unmodified

> [!NOTE]
> These headers apply only to the **REST WebAPI** (not Agents).

These headers apply to the major entities (Contact, Project,...) that have last modified date fields on them.

### If-Modified-Since

Returns HTTP code **304 Not Modified** if the entity has not been modified since the given date+time on the GET request.

`GET /api/v1/Contact/123` always returns a contact object.

```http
GET /api/v1/Contact/123
If-Modified-Since: Wed, 21 Oct 2015 07:28:00 GMT
```

The above will return a **304 Not Modified** response if the contact has not been modified since October 2015. This tells you that your cached copy of the data is still good.

### If-Unmodified-Since

Returns HTTP code **412 Precondition failed** if the entity has been modified since the given date+time on the PUT update request.

```http
PUT /api/v1/Contact/123 
{ Name: "Some updates" }
```

The above always updates the contact object.

```http
PUT /api/v1/Contact/123
If-Unmodified-Since: Wed, 21 Oct 2015 07:28:00 GMT
{ Name: "Some updates" }
```

This will return a **412 Precondition failed** response if the contact has been modified after October 2015.

This is telling you that your cached copy of the data is no good anymore. It has been modified on the server after you fetched it.

## <a name="so-timezone"></a>SO-TIMEZONE

You specify the [time zone][1] using the `SO-TIMEZONE` HTTP header. It can be either an ID or a time-zone name.

The following blocks are the same because the `/api/v1/timezone` archive lists the Norway time zone code as 261.

```http
GET /appointment/123
Accept: application/json
SO-TimeZone: NO
```

```http
GET /appointment/123
Accept: application/json
SO-TimeZone: 261
```

This will convert dates to/from the given time zone, but it will leave the dates without a time zone specifier.

This is the way that the WCF service API works, and how the WebAPI has worked since its release. It leaves time zones up to the client.

### <a name="includetzoffset"></a>includeTZOffset

```http
GET /appointment/123
Accept: application/json
SO-TimeZone: NO, includeTZOffset
```

Adding `includeTZOffset` to the `SO-TIMEZONE` header will cause the time zone offsets to be included in the JSON. This makes JavaScript adjust the dates to UTC correctly and will affect date-time calculations done by clients since the timezone is no longer unspecified.

For example:

```javascript
// SO-TimeZone: US-NY
// StartDate: "2018-12-24T07:34:45" 

x = a.StartDate
// Mon Dec 24 2018 07:34:45 GMT+0100 (Central European Standard Time)

x.ToISOString();
// "2018-12-24T06:34:45.000Z"

x.getHours()
// 7

x.getUtcHours()
// 6
```

So here we get the expected time back, but it is attached to the wrong time zone, so the UTC time is wrong.

But if we specify the SO-TimeZone header to include the TZ Offset:

```js
// SO-TimeZone: US-NY, includeTZOffset
// StartDate: "2018-12-24T07:34:45-0500" 

x = a.StartDate
// Mon Dec 24 2018 13:34:45 GMT+0100 (Central European Standard Time)

x.toISOString()
//"2018-12-24T12:34:45.000Z"

x.getHours()
// 13

x.getUtcHours()
// 12
```

Now the time we get back is not what we expected (7 hours) (because JavaScript is converting to local (Norwegian) time automatically), but the time zone and UTC values are correct.

Which behavior you want depends on what sort of the date processing you are doing.

<!-- Referenced links -->
[1]: ../so-timezone.md

<!-- Referenced images -->
