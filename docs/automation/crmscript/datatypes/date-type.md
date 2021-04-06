---
uid: crmscript_datatypes_date
title: Date data type
author:
so.date:
keywords:
so.topic:
---

# Date data type

**Date** is a complex data type representing a day, month, and year on ISO format. The default value is now.

Format: YYYY-MM-DD

```crmscript!
Date d;
print(d.toString());
```

This will print today's date.

## Constructors

### Date Date(Date p0)

Pass a `Date` object to copy into a new object.

```crmscript!
Date d;
Date next = Date(d);
printLine(next.toString());
```

### Date Date(String date)

Pass a `String` containing a date on format **YYYY-MM-DD**. The constructor will parse the text and create a `Date` object.

```crmscript!
String newYearsDay = "2020-01-01";
Date q1 = Date(newYearsDay);
Date birthDay = Date("2011-01-13");
printLine(q1.toString() + "\n" + birthDay.toString());
```

## Dates as strings

### String toString()

`toString()` is one of the most frequently used methods, typically when you are going to output something. It returns a string representation of a Date.

```crmscript
Date d;
String s = d.toString();
```

## Setting and updating dates

Day, month, and year are set relative to when the Date object was created.

* Dates in the future are specified as increments (a positive amount)
* Dates in the past are specified as decrements (a negative amount)

The amount must be provided as an Integer input parameter.

### Date addDay(Integer num)

`addDay()` will adjust the currently set date with the given number of days.
The parameter granularity is *days*.

```crmscript!
Date d;
d.addDay(3);
printLine("Three days from now: "  + d.toString());

Date d2;
d2.addDay(-2);
printLine("Two days ago: "  + d2.toString());
```

### Date addMonth(Integer num)

`addMonth()` will adjust the currently set date with the given number of months.
The parameter granularity is *months*.

```crmscript!
Date d;
d.addMonth(3);
printLine("Three months from now: "  + d.toString());

Date d2;
d2.addMonth(-6);
printLine("Six months ago: "  + d2.toString());
```

Notice that the day remains unchanged regardless of the number of days in the months added or subtracted. However, if the update would result in February 29th in a year that is not a **leap year**, CRMScript automatically corrects it to March 1st.

### Date addYear(Integer num)

`addYear()` will adjust the currently set date with the given number of years.
The parameter granularity is *years*.

```crmscript!
Date d;
d.addYear(1);
printLine("A year from now: "  + d.toString());

Date d2;
d2.addYear(-10);
printLine("10 years ago: "  + d2.toString());
```

## Retrieving properties of dates

You can retrieve the day, month, and year as well as the day of the week and the week number.

### Integer getMDay()

`getMDay()` returns the day of the month as an Integer \[1-31\].

```crmscript!
Date d;
print(d.getMDay().toString());
```

### Integer getMonth()

`getMonth()` returns the month as an Integer \[1-12\].

```crmscript!
Date d;
print(d.getMonth().toString());
```

### Integer getWeek()

`getWeek()` returns the number of the week as an Integer \[1-53\].

```crmscript!
Date d;
print(d.getWeek().toString());
```

### Integer getWeekDay()

`getWeekDay()` returns the day of the week as an Integer \[0-6\].

```crmscript!
Date d;
print(d.getWeekDay().toString());
```

> [!CAUTION]
> The 1st day of the week is Monday and has index 0!

### Integer getYear()

`getYear()` returns the year as an Integer.

```crmscript!
Date d;
print(d.getYear().toString());
```

## No value

Before a Date is initialized, it has no value. This is commonly written as NULL, NUL, or NIL in other programming languages.

CRMScript automatically initializes Date objects when declared to the current date. Thus this situation is uncommon. However, it is a good habit to always test that you have a value before using it.

### Bool isNull()

`isNull()` will return **true** if it has no value and **false** if it does.

```crmscript!
Date d;
print(d.isNull().toString());
```
