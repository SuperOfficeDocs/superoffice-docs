---
uid: crmscript_datatypes_map
title: Map data type
author:
so.date:
keywords:
so.topic: concept
---

# Map data type

A map is a collection of key-value pairs. Both the key and the value are strings.

The elements in a map are automatically sorted on their keys.

## Constructors

### Map Map()

Creates an empty map.

### Map Map(String value)

Pass a `String` containing key-value pairs separated by "\n":

"key=value\nkey=value\nkey=value,..."

```crmscript
Map m = Map("roses = red\nviolets = blue");
```

> [!NOTE]
> Don't add space between \n and the 1st character of the key!

## Adding elements to maps

### Map insert(String key, String value)

`insert()` adds a new key-value pair to the map.

```crmscript
Map m;
m.insert("Super", "Office");
```

## Accessing elements in maps

### Bool exists(String key)

`exists()` checks if the map contains the given key.

```crmscript!
Map m = Map("height = 25\nwidth = 10\ndepth = 7");
String key = "height";

printLine(m.exists(key).toString());
```

### Integer size()

`size()` counts the elements in the map and returns that number.

```crmscript
Map m = Map("height=25\nwidth=10\ndepth=7");

printLine(m.size().toString());
```

An empty map has size == 0.

```crmscript!
Map m;

if (m.size() == 0) {
  printLine("This map is empty");
}
```

### String get(String key)

Returns the value for the given key.

```crmscript
Map m = Map("height=25\nwidth=10;
String key = depth;

printLine(m.get(key));
```

`getKey()` and `getVal()` also retrieve data from the map. These methods depend on the internal iterator of the map and are described in the *Looping* section.

## Updating elements

When working with numeric strings, you can increment values stored in the map. The increment can be given as either Integer or Float.

In both cases, you provide the key to look up the element and the **value to add** to the currently stored value.

### Void increaseValueForKey(String key, Integer value)

```crmscript
Map m = Map("height=25\nwidth=10");
m.increaseValueForKey("height", -5);
```

### Void increaseValueForKey(String key, Float value)

```crmscript
Map m = Map("height=25\nwidth=10");
m.increaseValueForKey("width", 2.5);
```

## Removing elements

You can remove either a specific element identified by its key, or you can remove all elements.

### Void remove(String key)

Removes the element with the given key.

```crmscript
Map m = Map("roses = red\nviolets = blue");
m.remove("violets");
```

### Void clear()

Removes **all** elements from the map.

```crmscript
Map m = Map("roses = red\nviolets = blue");
m.clear();
```

## Looping maps

Looping (or iterating) maps is similar to looping an array. However, where you would declare and update the Integer iterator for the array index, Maps have a built-in iterator that you **position**.

> [!NOTE]
> `insert()` resets the map iterator when called.

### Bool eof()

Returns true if the map iterator has moved past the end of the map, otherwise false.

```crmscript
Map m;

if (m.eof()) {
  printLine("You have reached the final frontier");
}
```

> [!NOTE]
> That `eof()` returns true is **not** the same as the map is empty. It can be, but it doesn't have to be. Use `size()` to check if the map is truly empty.

### Bool first()

Rewinds the internal iterator to the 1st element.

`first()` returns false if the map is empty.

```crmscript
Map m = Map("height=25\nwidth=10");
m.first();
```

### Bool next()

Moves the map iterator to next position.

`next()` returns false if eof().

```crmscript
Map m = Map("height=25\nwidth=10");
m.next();
```

### String getKey()

Returns the key pointed to by the map iterator.

```crmscript!
Map m = Map("height=25\nwidth=10");
printLine(m.getKey());
```

### String getVal()

Returns the value pointed to by the map iterator.

```crmscript!
Map m = Map("height=25\nwidth=10");
printLine(m.getVal());
```

### Putting it together

```crmscript!
Map m = Map("height=25\nwidth=10");

m.first();
while (!m.eof()){
  printLine(m.getKey() + " = " + m.getVal());
  m.next();
}
```

## JSON

You can convert both ways between Maps and JSON.

**Format:**

{"key": "value", "foo": "bar"}

### String toJson()

Converts the Map to JSON.

```crmscript!
Map m = Map("height=25\nwidth=10");
printLine(m.toJson());
```

### Void fromJson(String json)

Converts a JSON string to a map.

```crmscript
String s = "{"depth":"7","height":"20","width":"12.500000"}";
Map m;
m.fromJson(s);
```
