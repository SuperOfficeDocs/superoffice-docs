---
title: SOTimezone
uid: webapi_sotimezone
description: SuperOffice can support multiple time zones
author: Bergfrid Dias
so.date: 11.19.2021
keywords: timezone, date, timeanddate
so.topic: concept 
---

# SOTimezone

Time zones are tricky, because both the server, the browser, and JSON all have opinions about them.

SuperOffice can support multiple time zones - this is enabled in admin. When enabled, all existing data
is defined as belonging to a **base time zone**. This is the time zone that data is stored in.

## Time zone

SuperOffice uses time zones named by country-codes, so Norway sits in the `NO` time zone, while Denmark is in `DK`, and New York is in `US-NY`.

Each time zone has its own daylight savings rules and offsets from UTC, the universal coordinated time zone.

C# and JavaScript have a limited understanding of time zones: they can keep track of dates in the UTC zone, and Local zone (where local is defined by whatever your local computer is configured to believe). C# also understands that sometimes we don't know, and these dates have an *unspecified* zone.

For example, JavaScript automatically converts to the local time zone when displaying dates:

```javascript
// Javascript
let d = new Date();
d.toISOString();
// "2018-12-07T15:35:39.350Z"
d
// Fri Dec 07 2018 16:35:39 GMT+0100 (Central European Standard Time)
```

## Timezones API endpoint

```http
GET /api/v1/timezone
```

Returns an array of all known timezones:

| id | timeZone | country | region | offset | daylight | isActive |
|---|---|---|---|---|---|---|
|  1  | UTC | | UTC/GMT| 0 | | 1 |
|  36 | AU-ACT | Australia | Capital Territory | +10:00 | +11:00 | 1 |
|  50 | BD | Bangladesh | | +6:00 |  |  1 |
| 114 | CA-QC | Canada | Quebec  | -5:00 | -4:00 | 1 |
| 140 | DK | Denmark | | +1:00 | +2:00 | 1 |
| 156 | FR | France | | +1:00 | +2:00 | 1 |
| 261 | NO | Norway | | +1:00 | +2:00 | 1 |
| 425 | US-CA | United States | California| -8:00 | -7:00 | 1 |
| 433 | US-HI | United States | Hawaii | -10:00 | | 1 |
| 460 | US-NY | United States | New York | -5:00 | -4:00| 1 |

## Base time zone by default

If you don't specify anything, then the base time zone is assumed, and nothing changes.

```http
POST /api/v1/example
Content-Type: application/json

"2018-12-24T12:34:45"
```

| Who | Date time example | Time zone |
|---|---|---|
| Client | `"2018-12-24T12:34:45"` | unspecified |
| NetServer| `"2018-12-24T12:34:45"` | unspecified |
| Database | `"2018-12-24T12:34:45"` | base time zone|
| NetServer| `"2018-12-24T12:34:45"` | unspecified |
| Result | `"2018-12-24T12:34:45"` | unspecified |

NetServer stores the date+time unchanged. If you specify the base time zone, then nothing changes.

For example, when the base time zone is *Norway* (Time zone "NO")

```http
POST /api/v1/example
Content-Type: application/json
SO-TimeZone: NO

"2018-12-24T12:34:45"
```

| Who | Date time example | Time zone |
|---|---|---|
| Client | `"2018-12-24T12:34:45"` | NO |
| NetServer | `"2018-12-24T12:34:45"` | NO |
| Database | `"2018-12-24T12:34:45"` | NO = base time zone |
| NetServer | `"2018-12-24T12:34:45"` | NO |
| Result | `"2018-12-24T12:34:45"` | NO |

The result is the same as before since we are in the same time zone.

## Different time zone

If you specify a different time zone, then the dates are converted to the time zone in question.

For example, when the base time zone is *Norway*, but the request is for *US - New York* (Time zone "US-NY"), this gets converted to base time zone when stored in the database.

```http
POST /api/v1/example
Content-Type: application/json
SO-TimeZone: US-NY

"2018-12-24T12:34:45"
```

| Who | Date time example | Time zone |
|---|---|---|
| Client | `"2018-12-24T12:34:45"` | US-NY (-5:00) |
| NetServer| `"2018-12-24T12:34:45"` | US-NY |
| Database | `"2018-12-24T18:34:45"` | NO (+1:00) = base time zone |
| NetServer| `"2018-12-24T12:34:45"` | US-NY |
| Result | `"2018-12-24T12:34:45"` | US-NY |

The client gets back the time in the requested time zone.

> [!NOTE]
> Javascript and C# will parse the returned value, and treat it as a datetime and apply its own time zone logic.

Javascript will assume it is in the local time zone (since it does not specify a time zone), and convert it to UTC internally.

```javascript
x = new Date("2018-12-24T12:34:45")
// Mon Dec 24 2018 12:34:45 GMT+0100 (Central European Standard Time)
x.ToISOString();
"2018-12-24T11:34:45.000Z"
```

Here we can see that JavaScript took the time as a local time, and converted it to a UTC time.

C# and Newtonsoft will treat the result as an *unspecified time*, due to the lack of a timezone specifier.

```cs
string result = "{ 'result': '2018-12-24T12:34:45' }";
dynamic jsonResult = JsonConvert.DeserializeObject<ExpandoObject>(result);
jsonResult.result
// [24.12.2018 12:34:45]
jsonResult.result.Kind
// DateTimeKind.Unspecified
```

Unspecified C# date-times are not local, not UTC. They won't automatically compensate or change unexpectedly.

## JSON has time zones

JSON and WebAPIs have another time zone value baked into every date object.

`2018-12-24T12:34:45` has no time zone, and is thus assumed to be in the local time zone (or in UTC, depending on the browser).

`2018-12-24T12:34:45Z` is specified as being in the UTC time zone (the Z suffix means 'Zulu' time, the military designation for UTC).

`2018-12-24T12:34:45+0100` is one hour after UTC, i.e. in the euro time zone (aka the Romance zone on Windows).

These time zone specifiers are added by Javascript (and C#/Newtonsoft) when the date is either UTC or has a known time zone offset (i.e. is local).

So you can specify one [time zone in the header][1], while the dates actually belong to a different zone.

For example, when the base time zone is *Norway* (`NO`), but the request is for *US - New York* (Time zone `US-NY`), but the date value is in UTC time (since it has a `Z` suffix). We also ask for the time zone offset to be included in the output.

```http
POST /api/v1/example
Content-Type: application/json
SO-TimeZone: US-NY, includeTZOffset

"2018-12-24T12:34:45Z"
```

| Who | Date time example | Time zone |
|---|---|---|
| Client | `"2018-12-24T12:34:45Z"` | UTC |
| NetServer| `"2018-12-24T07:34:45"` | US-NY (-5:00) |
| Database | `"2018-12-24T13:34:45"` | NO (+1:00) = base time zone |
| NetServer| `"2018-12-24T07:34:45"` | US-NY |
| Result | `"2018-12-24T07:34:45-0500"` | US-NY |

The client sends a UTC date in, which gets converted to the base time zone inside NetServer. It gets back the time in the requested time zone, with the UTC time converted to the New York time zone.

JavaScript knows the time zone ("-0500") and can convert it to UTC internally.

```javascript
x = new Date("2018-12-24T07:34:45-0500")
// Mon Dec 24 2018 13:34:45 GMT+0100 (Central European Standard Time)
x.toISOString()
"2018-12-24T12:34:45.000Z"
```

Here we can see that JavaScript has converted to local time, and internally uses UTC.

C# and Newtonsoft will treat the result as a local time, due to the timezone suffix.

```cs
string result = "{ 'result': '2018-12-24T07:34:45-0500' }";
dynamic jsonResult = JsonConvert.DeserializeObject<ExpandoObject>(result);
jsonResult.result
// [24.12.2018 13:34:45]
jsonResult.result.Kind
// DateTimeKind.Local
```

If we left off the [includeTZoffset][1] in the header, then the returned values would not be tagged with the right time zone, and fun ensues.

```http
POST /api/v1/example
Content-Type: application/json
SO-TimeZone: US-NY

"2018-12-24T12:34:45Z"
```

| Who | Date time example | Time zone |
|---|---|---|
| Client   | `"2018-12-24T12:34:45Z"` | UTC |
| NetServer | `"2018-12-24T07:34:45"` | US-NY (-5:00) |
| Database | `"2018-12-24T13:34:45"` | NO (+1:00) = base time zone |
| NetServer | `"2018-12-24T07:34:45"` | US-NY |
| Result   | `"2018-12-24T07:34:45"` | US-NY |

The result is not tagged with a time zone, and so the client will (probably) treat it as a local date.

```javascript
x = new Date("2018-12-24T07:34:45")
// Mon Dec 24 2018 07:34:45 GMT+0100 (Central European Standard Time)
x.toISOString()
"2018-12-24T06:34:45.000Z"
```

C# knows about unspecified time zones, so it handles this slightly better

```csharp
string result = "{ 'result': '2018-12-24T07:34:45' }";
dynamic jsonResult = JsonConvert.DeserializeObject<ExpandoObject>(result);

jsonResult.result
// [24.12.2018 07:34:45]

jsonResult.result.Kind
// DateTimeKind.Unspecified
```

## Created and updated date

These are always UTC, and so their values are not affected by the [TimeZone header][1]. If you specify `includeTZOffset` they are always tagged as UTC times.

<!-- Referenced links -->
[1]: endpoints/http-headers.md

<!-- Referenced images -->
