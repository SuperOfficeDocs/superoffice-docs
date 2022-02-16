---
title: Changes in 9.1R3
uid: 91_r_3_date_time_changes
description: Changes in 9.1R3 - Date, Time, and DateTime in archive providers
author: Marek Vokáč
so-date: 10.01.2020
keywords:
so.topic: article
so.envir: cloud
so.client: online
---

# Changes in 9.1R3: Date, Time, and DateTime in archive providers

A column in an archive provider can, but doesn't **have to**, be bound to a field in a database table. Because of this, and a desire to be able to control how things are shown and queried, the archive providers have their own type-system.

* **DisplayType** tells the GUI how a cell should be displayed
* **RestrictionType** controls the filter/criteria GUI
* **DisplayValue** in each row/column is the actual data

The mapping between these systems is deliberately somewhat loose. The `DisplayType` can be a String, while the `RestrictionType` is ListAny because a list item is shown as a string, but if you want to search for it, it's nice to have a list of entries to choose from.

Since serialization of arbitrary objects is somewhat problematic - that's why we have JSON, BSON, XML, ASN.1, and what-have-you - we decided to make our own, self-identifying format for archive values. In our code, it lives in the beautifully named class [CultureDataFormatter][1], and we use it all over the place, particularly in the archive providers. Both values going out through `DisplayValue` and values coming in view `ArchiveRestrictionInfo.Values[]` use this format.

The format is generally defined as `[<marker>:<data>]`, where **marker** is a short string that defines the type, and **data** is what you get if you say `.ToString(CultureInfo.InvariantInfo)` in C# on an object of the corresponding type.

As an example, the encoding of an int looks like this:

```csharp
public static string EncodeInt(int val)
{
  StringBuilder result = new StringBuilder();
  result.Append(BeginTag);
  result.Append(IntMarker);
  result.Append(MarkerSeparator);
  resu­lt.Append(val.ToString(NumberFormatInfo.InvariantInfo));
  result.Append(EndTag);
  return result.ToString();
}
```

The result for the number 123 would be `[I:123]`. The `InvariantInfo` qualification is important, even for Ints, as there are some funny edge cases. The Swiss use a single quote as their 1000-separator, just to mention one.

Now I can reveal the main reason for writing this: we made a change to some columns in our archives, and we didn't tell you. The change means that a lot of datetime columns changed their marker from `[DT:` to `[D:`, but the actual data hasn't changed, you still get both date *and* time. But if your parser is single-minded and expects DT, then it may not work. **Sorry about not telling you upfront**, that was my fault. Though it has been running in SOD since mid-August.

## Why are we doing this?

It's an old technical debt being paid back. Many years ago we defined both Date and DateTime as `DisplayType` values in the archive-provider system and created the D and DT markers in the data formatter. DateTime was shown in archives *with* a time, and Date was shown without. We still included the time in the \[D: data. Imagine you have a list of appointments... all on the same day... you still want them sorted *by time* within that day, so you need the time part, even if you don't show it.

Then, someone decided that we should only show the date part, regardless, in our GUI. The "easy fix" was simply to change the GUI code, to stop showing the time, regardless of Date or DateTime as `DisplayType`. Similarly, the criteria GUI didn't show times either, only dates. Tada, problem solved.

Fast forward a decade and we actually start caring about time. So now we have to un-break the GUI, so it follows the differences between Date, Time, DateTime, and (new!) TimeSpan - both for display and criteria. It follows that we then have to adjust the `DisplayType` and `RestrictionType` in the backend, to keep the correct end-to-end behavior.

Thus, with 9.1R3 we specify the `date` column of the various activities (document, followup, checklist, ...) as Date. The same goes for `registered` and `lastUpdated`. As a result, those now get transmitted with a `[D:` marker instead of `[DT:`.  And because even NetServer isn't perfect, there may be cases where you have a mix, some rows with D and some with DT if they have different sources.

We really have to do this - there's no good way to achieve consistency without making this change. So I have to ask you all to adapt to it.

For the record, the full list of markers, taken from `SuperOffice.CRM.Globalization.CultureDataFormatter` is as follows:

```csharp
public const string DateMarker = "D";
public const string DateTimeMarker = "DT";
public const string TimeMarker = "T";
public const string TimeSpanMarker = "TS";
public const string DoubleMarker = "F";
public const string IntMarker = "I";
public const string MoneyMarker = "M";
public const string BinaryMarker = "B";
public const string IntArrMarker = "A";
```

Encoding of D, DT, and T shares the same code:

```csharp
StringBuilder result = new StringBuilder();
result.Append(BeginTag);
result.Append(marker);
result.Append(MarkerSeparator);
result.­Append(dateTime.ToString("d", DateTimeFormatInfo.InvariantInfo));
result.Append(" ");
result.Append(dateTime.ToString(TimePattern, DateTimeFormatInfo.InvariantInfo));
result.Append(EndTag);
return result.ToString();
```

* The new TS (for TimeSpan) marker is followed by an integer, which is the number of seconds of the time-span (duration).
* The new A (for int-Array) marker is followed by a comma-separated list of integers, the elements of the array - \[A:1,4,2,19\]

<!-- Referenced links -->
[1]: ../../docs/globalization-and-localization/culture/culturedataformatter.md

<!-- Referenced images -->
