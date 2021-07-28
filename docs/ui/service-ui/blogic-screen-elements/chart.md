---
title: Chart
uid: blogic_chart
description: Chart
author:
so.date:
keywords:
so.topic: reference
---

# Chart

This element will use the JavaScript **charts** library to create a chart.

## Terminology

| Term       | Description                                                                          |
|:-----------|:-------------------------------------------------------------------------------------|
| key        | X-axis in the chart                                                                  |
| label      | User-friendly text to display for a value                                            |
| series     | A data series<br>If you add data without creating at least 1 series, the system will automatically add the first series. <br>Type *pie* can have only 1 series. |
| annotation | Optional text to annotate a datapoint (v. 8.2)<br>Overwritten if set multiple times |
| delta      | The value to add or subtract from the current value                                  |

## Configuration

| Setting | Description                                                             |
|:--------|:------------------------------------------------------------------------|
| type    | Area, areaspline, bar, bubble (v. 8.5R09), column, line, pie, scatter or spline |
| title   | The title on top of the chart                                           |
| stacked | Whether to stack multiple series - Bool (v. 8.4R05)                     |
| show3D  | Whether to show as 3D -Bool (v. 8.4R05)                                 |

> [!NOTE]
> Stacking and 3D are available only for some types.

## Example

```crmscript
type = pie
```

## Functions

### setFieldValue(String action, Map value)

> [!TIP]
> Use series = **-1** to specify the last series added.

| Action                | Map keys               | Description                                                             |
|:----------------------|:-----------------------|:------------------------------------------------------------------------|
| addSeries             | label<br>seriesType<br>yaxis2                  | Creates a new series of data                                            |
| addLabel              | key<br>label         | Adds a label for a key                                                  |
| setUrl                | key<br>url<br>series | Sets the URL for a key and optionally a series                          |
| setValue              | key<br>value<br>annotation<br>xValue<br>zValue<br>fillColor | Sets the value for a key in a series<br>xValue, zValue, and fillColor apply to bubble charts (v. 8.5R09) |
| increaseValue         | key<br>delta<br>series<br>annotation | Adds a delta to the value of a key in the given series |
| setXLabel             | label                  | Sets the label for the X-axis                                           |
| setX2Label             | label                  | Sets the label for the X2-axis                                           |
| setYLabel             | label                  | Sets the label for the Y-axis                                           |
| setY2Label             | label                  | Sets the label for the Y2-axis                                           |
| setZLabel             | label                  | Sets the label for the Z-axis (v. 8.5R09)                               |
| setYIsTimespan        | set                    | Whether the y-axis represents a time-span (in seconds) - Bool           |
| setYMin               | value                  | Sets minimum value for the Y-axis                                       |
| setY2Min               | value                  | Sets minimum value for the Y2-axis                                       |
| setXMax               | value                  | Sets maximum value for the X-axis                                       |
| setX2Max               | value                  | Sets maximum value for the X2-axis                                       |
| setAllowYAxisDecimals | set |    Set allow Y-axis decimals       |
| setAllowY2AxisDecimals | set |     Set allow Y2-axis decimals      |
| setYAxisInterval | value |       Set interval for Y-axis    |
| setY2AxisInterval | value |   Set interval for Y2-axis        |
