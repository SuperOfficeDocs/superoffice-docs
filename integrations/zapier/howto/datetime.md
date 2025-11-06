---
uid: zapier-datetime
title: Formatting date and time
description: How to format date and time when working with Zapier.
keywords: Zapier formatter, date format, time format
author: Miguel Lemos
date: 11.05.2025
content_type: howto
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: /en/automation/zapier/howto/datetime
---

# Formatting date and time

Dates and times in SuperOffice follow the ISO standard format: 'yyyy-mm-ddThh:mm:ssZ', where Z indicates the UTC time zone.

A Zapier Formatter helper step can be used to convert this value into a different format.

![Action/Search -screenshot][img1]

## Select formatter

A formatter can, for example, convert an appointment start date value from the default format into an American-style date such as '06/19/2019'.

![Select Formatter by Zapier Action -screenshot][img2]

## Adjust value

The Formatter in Zapier provides three transformation options for handling date and time values:
    
![Add/Subtract Time -screenshot][img3]

1. **Add/Subtract Time** – Manipulates a date or time value by adding or subtracting days, months, years, hours, minutes, or seconds.

    ![Add/Subtract Time -screenshot][img4]

1. **Compare Dates** – Calculates the duration between two dates in days, hours, minutes, and seconds, and determines whether the dates are identical.
    
    ![Compare Dates -screenshot][img5]

1. **Format** – Converts a date or time value into a different format or style.
    
    ![Format -screenshot][img6]

## Related content

* [Insert the time your Zap runs into a field][1]

<!-- Referenced links -->
[1]: https://help.zapier.com/hc/en-us/articles/8496275717261#adjusting-dates-and-times

<!-- Referenced images -->
[img1]: media/common/formatter-step.png
[img2]: media/common/select-formatter.png
[img3]: media/common/tranform-date-configure.png
[img4]: media/common/add-subtract-option-date.png
[img5]: media/common/compare-dates.png
[img6]: media/common/format-date.png
