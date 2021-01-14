---
title: crmscript_fundamentals_arrays
description: Arrays
author:
so.date:
keywords:
so.topic:
---

# Arrays

An array is a special variable that can store more than 1 value at the same time. It can be 1-dimensional like a list, 2-dimensional like a spreadsheet, 3-dimensional like a cube, or multidimensional. The length and number of dimensions is virtually unlimited.

In CRMScript, arrays can only contain items of a single data type. All arrays are considered variables, which are passed, copied, and so on by reference.

SuperOffice currently has 5 user plans: standard, marketing, sales, service, and complete. To store these in a CRMScript, you could either declare 5 different variables of type String or put them all in a single array of type String.

## Creating an array

The definition of an array has 3 parts:

* the type of the array
* one or more pairs of square brackets []
* the name of the array followed by a semicolon

The following will create a 1-dimensional empty array of strings.

```crmscript
String[] s1;
```

> [!NOTE]
> Brackets must be immediately following the type and not the variable name as in C!

### Initializing

In the declaration, you can optionally set the initial length of each dimension. For example, the following creates an array of type Strings with 5 empty indexes.

```crmscript
String[5] s2;
```

If you don't initialize the array, you won't be able to use the indexes when adding elements.

## Accessing indexed elements

Any element can be accessed by the variableName\[pos\]. Remember that the index starts at 0. The first element is at \[0\], the second at \[1\], and so on.

The following code will set and then print the 1st element of the userPlans array.

```crmscript!
String[5] userPlans;
userPlans[0] = "Standard";
print(userPlans[0]);
```

### Length

You probably don't go around remembering the size of every array. And as we shall see later, that number can actually change for dynamic arrays. It is also hard to maintain your script if you hard-code the length in multiple places.

The `length()` function will return the number of indexable elements.
The last element will be at position `length() - 1`.

**To print the length:**

```crmscript
print(userPlans.length().toString());
```

**To access the last element:**

```crmscript!
String[5] userPlans;
userPlans[0] = "Standard";
userPlans[1] = "Marketing";
userPlans[2] = "Sales";
userPlans[3] = "Service";
userPlans[4] = "Complete";

print(userPlans[userPlans.length() -1]);
```

### First and last

CRMScript has a set of functions for retrieving the 1st and last element in a collection. This notation is often shorter than using \[pos\].

* first() returns the 1st element, same as \[0\]
* last() returns the last element, same as \[length() -1\]
* if the collection is empty, you will get an out-of-range exception

If we add the following code to the previous example, print would output the same value as before.

```crmscript
String plan = userPlans.last();
print(plan);
```

## Inserting element at position x

We have seen that we can use an assignment statement to insert elements to a given index.

You can also use the `insert()` function, which adds an element at the given index.

**Syntax:** insert (index, elem)

```crmscript
String[5] userPlans;
userPlans.insert(1, "Marketing");
```

## Looping indexed collections

You can use both [for][1] and [while][2] loops to iterate the collection.

> [!TIP]
> Remember that you can use the `length()` function to determine the number of elements.

```crmscript!
String[5] userPlans;
userPlans[0] = "Standard";
userPlans[1] = "Marketing";
userPlans[2] = "Sales";
userPlans[3] = "Service";
userPlans[4] = "Complete";

for(Integer i = 0; i < userPlans.length(); i++) {
  printLine(userPlans[i]);
}
```

## Multi-dimensional collections

So far, we have focused on 1-dimensional collections. However, we can extend this by nesting: rather than inserting a number at index \[0\], we can insert an array of numbers.

To create a 2-dimensional array, we need a double pair of square brackets in the declaration.

The following example will build a 5 by 5 matrix of (x,y) coordinate pairs and then print it.

```crmscript!
String[5][5] coordinates;

for (Integer x = 0; x < 5; x++) {
  for (Integer y = 0; y < 5; y++) {
    coordinates [x][y] = x.toString() + ", " + y.toString();
  }
}

for (Integer x = 0; x < 5; x++) {
  for (Integer y = 0; y < 5; y++) {
    print("(" + coordinates [x][y] + ")\t");
  }
  print("\n");
}
```

## Dynamic arrays

CRMScript supports collections that can grow and shrink dynamically.

When you declare an array without initializing it, it is by definition dynamic. A fixed-size array can also become dynamic if you use any of the functions listed here.

### Pushing and popping

The dynamics come from being able to either **push** something into the collection, or **pop** something out of it.

Think of the stack of plates at a restaurant buffet, often with a spring at the bottom. When the staff refills the stack, they push the new plates onto the top of the previous ones, and the bottom one gets lower and lower. When you grab a plate from the top, you pop it off, and the ones below rise upward.

#### Adding elements

You can push elements to either the front or the back.
If you specify the element, that's what's added. If you don't specify anything, an empty element will be added *and* initialized to the correct type.

**Add to front:**

* pushFront()
* pushFront(elem)

```crmscript!
String[] userPlans;
userPlans.pushFront();
printLine("Current length: " + userPlans.length().toString());
userPlans.pushFront("Standard");
printLine("Current length: " + userPlans.length().toString());

for(Integer i = 0; i < userPlans.length(); i++) {
  printLine("Contents of index " + i.toString() + ": " + userPlans[i]);
}
```

In this example, we start by pushing an empty element, and then we push \"Standard\" before it. Notice how the length increases and that we are able to use \[pos\] to access even the empty element.

**Add to back:**

The `pushBack()` functions will **append** an element behind the current last element.

* pushBack()
* pushBack(elem)

```crmscript!
String[] userPlans;
userPlans.pushBack();
printLine("Current length: " + userPlans.length().toString());
userPlans.pushBack("Service");
userPlans.pushBack("Complete");
printLine("Current length: " + userPlans.length().toString());

for(Integer i = 0; i < userPlans.length(); i++) {
  printLine("Contents of index " + i.toString() + ": " + userPlans[i]);
}
```

In this example, we start by pushing an empty element, and then we push 2 strings to the back.

> [!TIP]
> Remember that you can also use the `insert()` function to add an element at a specific index.

#### Removing elements

You can pop elements from either the front or the back. The element which is popped is returned. Be sure to catch it if you intend to do something with it.

* popFront() same as \[0\]
* popBack() same as \[length() -1\]

```crmscript!
String[] userPlans;
userPlans.pushBack("Standard");
userPlans.pushBack("Sales");
userPlans.pushBack("Marketing");
userPlans.pushBack("Service");
userPlans.pushBack("Complete");
printLine("Current length: " + userPlans.length().toString());

Integer i = 0;
while(userPlans.length() > 0) {
  printLine("Contents of index " + i.toString() + ": " + userPlans.popFront());
  i++;
}
printLine("Current length: " + userPlans.length().toString());
```

> [!NOTE]
> If the collection is empty, you will get an out-of-range exception

### Deleting all elements

If you need to **reset** a collection, use `clear()` to remove all the elements. The length after this call will be 0.

```crmscript!
String[] userPlans;
userPlans.pushBack("Standard");
userPlans.pushBack("Sales");
printLine("Current length: " + userPlans.length().toString());
userPlans.clear();
printLine("Current length: " + userPlans.length().toString());
```

If you want to do something with these elements before deletion, you should loop through and pop them instead.

To repopulate, you must use push since it is now uninitialized.

<!-- Referenced links -->
[1]: for-loops.md
[2]: while-loops.md
