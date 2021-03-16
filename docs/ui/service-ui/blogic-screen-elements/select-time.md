---
title: blogic_select_time
description: Select Time
author:
so.date:
keywords:
so.topic: reference
---

# Select Time

This element is used to get [Time][1]. as input.

## Configuration

| Setting | Description                                                                                                 |
|:--------|:------------------------------------------------------------------------------------------------------------|
| minInc  | Sets the gap in minutes between each allowable entry<br>Fewer options per hour makes the drop-down smaller |

## Example

```crmscript
minInc = 15
```

This setting gives you 15-minute increments - 4 options per hour.

## Functions

### setValue(String time)

Sets the selected `Time`. The value must be formatted as **HH:MI:SS**.

### toString()

Returns the time as a string formatted as **HH:MI:SS**.

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/crmscript/blob/main/docs/datatypes/time-type.md
