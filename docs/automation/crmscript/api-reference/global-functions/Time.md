---
uid: crmscript_global_time
title: Time()
description: CRMScript Time constructor
intellisense: Void.Time
langref: 1
keywords: Time(Time), Time(String)
so.topic: reference
---

# Time Time()

Time constructor. You can pass either a `Time` object to copy or a `String` to be parsed.

Returns a `Time` object.

## Time Time(Time time)

`Time` object to copy.

## Time Time(String time)

Parse `String` with format **HH:MM:SS** and create `Time` object.

## Examples

```crmscript!
Time t;
Time prev = Time(t);
printLine(prev.toString());
```

```crmscript!
String noon = "12:00:00";
Time lunch = Time(noon);
Time dailyMeeting = Time("08:00:00");
printLine(lunch.toString() + "\n" + dailyMeeting.toString());
```

For more examples, see the [Time datatype section][1].

<!-- Referenced links -->
[1]: ../../datatypes/time-type.md
