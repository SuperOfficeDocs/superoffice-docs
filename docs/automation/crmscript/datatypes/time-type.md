---
title: crmscript_datatypes_time
description: Time data type
author:
so.date:
keywords:
so.topic:
---

# Time data type

**Time** is a complex data type representing the time of the day in hours, minutes, and seconds. The default value is now. ISO 8601 uses the 24-hour clock system.

Format: hh:mm:ss

```crmscript!
Time t;
print(t.toString());
```

This will print the current time.

## Constructors

### Time Time(Time time)

Pass a `Time` object to copy into a new object.

```crmscript!
Time t;
Time prev = Time(t);
printLine(prev.toString());
```

### Time Time(String time)

Pass a `String` containing a timestamp on format **HH:MM:SS**. The constructor will parse the text and create a `Time` object.

```crmscript!
String noon = "12:00:00";
Time lunch = Time(noon);
Time dailyMeeting = Time("08:00:00");
printLine(lunch.toString() + "\n" + dailyMeeting.toString());
```

## Time as strings

### String toString()

`toString()` is one of the most frequently used methods, typically when you are going to output something. It returns a string representation of a Time object.

```crmscript
Time t;
String s = t.toString();
```

## Setting and updating time

Hours, minutes, and seconds are set to the exact value provided as an Integer input parameter.

### Void setHour(Integer hour)

`setHour()` will overwrite the current time and set hours to the given number \[0-23\].
The parameter granularity is *hours*.

```crmscript
Time t;
t.setHour(14);
```

### Void setMin(Integer min)

`setMin()` will overwrite the current time and set minutes to the given number \[0-59\].
The parameter granularity is *minutes*.

```crmscript
Time t;
t.setMin(37);
```

### Void setSec(Integer sec)

`setSet()` will overwrite the current time and set seconds to the given number \[0-59\].
The parameter granularity is *seconds*.

```crmscript
Time t;
t.setSec(0);
```

## Retrieving properties of time

You can retrieve the hour, minutes, and seconds of the current time.

### Integer getHour()

`getHour()` returns the hour portion of the time as an Integer.

```crmscript!
Time t;
print(t.getHour().toString());
```

### Integer getMin()

`getMin()` returns the minutes portion of the time as an Integer.

```crmscript!
Time t;
print(t.getMin().toString());
```

### Integer getSec()

`getSec()` returns the seconds portion of the time as an Integer.

```crmscript!
Time t;
print(t.getSec().toString());
```

## No value

Before a Time object is initialized, it has no value. This is commonly written as NULL, NUL, or NIL in other programming languages.

CRMScript automatically initializes Time objects when declared to the current time. Thus this situation is uncommon. However, it is a good habit to always test that you have a value before using it.

### Bool isNull()

`isNull()` will return **true** if it has no value and **false** if it does.

```crmscript!
Time t;
print(t.isNull().toString());
```
