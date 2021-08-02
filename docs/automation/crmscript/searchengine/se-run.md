---
uid: search_engine_run
title: Running a query
author:
so.date:
keywords:
so.topic:
---

# Running a query

## Pre-run preparations

Before you run the SearchEngine query, you need to consider these 3 questions and possibly add some code:

* Should you run against NetServer with sentry rules, or do you require extended access and need to query the database directly (onsite only)?

* Do you need to convert the values you get back? If yes, consider writing your own function and register it as a **call-back**.

* Do you want the results in a specific format or is the default sufficient? This determines which flavor of `execute()` you call.

## Void bypassNetServer(Bool p0)

All queries are by default now sent via NetServer. `bypassNetServer()` allows you to circumvent NetServer and go directly to the database.

**Benefits:**

* Slightly faster
* Extended access to data

**Draw-backs:**

* No access to virtual (constructed) fields, such as emailAddress
* Must handle security yourself

Before you make the call, you must also set the **registry value** (reg_id = 235) to 1 ("Allow sentry to be bypassed"). Call it a double safe-guard.

```sql
UPDATE crm7.registry SET value = 1 WHERE reg_id = 235
```

Accomplish the same using CRMScript.

```crmscript
SearchEngine se;
se.addData("registry.value", "1");
se.addCriteria("registry.reg_id", "equals", "235");
se.update();
```

Since you can't bypass security in CRM Online, you can only use this bypass mechanism onsite.
For Online, use the dynamic archive provider instead of SearchEngine.

```crmscript
SearchEngine se;
// ...
se.bypassNetServer(true);
```

> [!CAUTION]
> Be aware of any security implications! You are running queries outside sentry restrictions, and might get access to data not intended for your eyes.

## Void setCallBack(String functionName)

Register you CRMScript function to convert data values as they come back. The function must be declared before calling `setCallBack()`.

## Run

## Integer execute()

Must be called to get the results.

```crmscript
SearchEngine se;
se.addField("contact.id");
se.execute();
```

If you need formatting, consider using one of the following methods instead.

When you have your result, it is time to [explore the data][8].

## Run and format the result

The following formats are available:

* StringMatrix
* text table (similar to MySQL)
* HTML table
* JSON (with or without JSONBuilder)

## Void executeInto(StringMatrix matrix)

Runs the query and returns a 2-dimensional string array. This is one of the built-in classes/complex data types of CRMScript.

## String executeTextTable()

Runs the query and returns a text-formatted table in a continuous string.

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
se.setLimit(10);
printLine(se.executeTextTable());
```

```text
- - - - - - - - - - - - - - - - - - - -
 sale.sale_id|sale.heading|sale.amount
- - - - - - - - - - - - - - - - - - - -
 1            SalgAAAA     500        
 2            SalgFAAF     220000     
```

> [!NOTE]
> `executeTextTable()` will have some overhead for large result sets!

## String executeHTMLTable()

Runs the query and returns an HTML formatted table in a continuous string.

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
se.setLimit(10);
printLine(se.executeHTMLTable());
```

Result:

```html
<table border='1' style='border-collapse: collapse'>
<tr><th>sale.sale_id</th><th>sale.heading</th><th>sale.amount</th></tr>
<tr><td>1</td><td>SalgAAAA</td><td>500</td></tr>...
```

(Line breaks have been added for presentation. They are not there in the result set.)

## String executeJSON()

Runs the query and returns a JSON formatted string. If you wish better control with the resulting JSON, use `executeToJSONBuilder()` instead.

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
se.setLimit(10);
printLine(se.executeJSON());
```

This example will produce JSON looking something like this:

```json
[{"sale.sale_id":"1","sale.heading":"SalgAAAA","sale.amount":"500"},...
```

## Void executeToJSONBuilder(JSONBuilder jb, String fields, String arrayName)

Runs the query and passes the result through a JSONBuilder. This gives you more control over the resulting JSON.

**A comma-separated list of label:fieldType elements:**

* label - the name the field gets in the JSON object
* fieldType can be any of the simple CRMScript types (Integer, Float, Bool, String). The JSON object member will be formatted accordingly

**arrayName:**
Becomes the name of the array in the JSONBuilder.

> [!TIP]
> This is useful if you want to populate an array in an existing JSONBuilder.

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
se.setLimit(10);
JSONBuilder jb;
jb.setPrettyPrint(4);
jb.pushObject("");
jb.addString("foo", "bar");
se.executeToJSONBuilder(jb, "id:Integer,heading:String,amount:Float", "sales");
jb.popLevel();
printLine(jb.getString());
```

This example will produce JSON looking something like this:

```json
{
    "foo": "bar",
    "sales": [
        {
            "id": 1,
            "heading": "SalgAAAA",
            "amount": 500.000000
        },...
```

<!-- Referenced links -->
[1]: se-results.md
