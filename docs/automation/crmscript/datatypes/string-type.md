---
title: crmscript_datatypes_string
description: String data type
author:
so.date:
keywords:
so.topic:
---

# String data type

A text string is a sequence of characters written with quotes.
You can use single or double quotes, but they must always come in pairs. Quotes can also be nested, by alternating between single and double quotes.

```crmscript
String myCompany = "SuperOffice";
String myLocation = 'Oslo';
String onion = "The 'onion' has many layers.";
```

## Constructors

### String String(String value)

Pass a `String` to copy into a new object.

```crmscript!
String squash = "yellow crook neck";
String favSquash = String(squash);
String winterSquash = String("butternut");
printLine("Summer favorite: " + favSquash + "\nFall favorite: " + winterSquash);
```

### String String(Byte[] byteArray)

Pass a byte array to build a new `String` object.

```crmscript!
String fallTreat = "Roasted pumpkin seeds are awesome";
Byte[] secret = fallTreat.toByteArray();
String jackO = String(secret);
printLine(jackO);
```

> [!NOTE]
> This constructor doesn't support Unicode.

### String String(Byte[] byteArray, String codepage)

Same as above, but also takes a [code page identifier](https://docs.microsoft.com/en-us/windows/win32/intl/code-page-identifiers).

### String String(NSStream byteArray)

Pass a byte array from an NSStream to build a new `String` object.

```crmscript!
String hot = "Ghost";
NSStream stream = decodeBase64AsStream(encodeBase64(hot.toByteArray()));
String hotPepper = String(stream);
printLine("Insanely hot chili pepper: " + hotPepper);
```

> [!NOTE]
> This constructor doesn't support Unicode.

### String String(NSStream byteArray, String codepage)

Same as above, but also takes a [code page identifier](https://docs.microsoft.com/en-us/windows/win32/intl/code-page-identifiers).

## Special characters

Some characters are part of the CRMScript syntax and must be escaped with a backslash. These are:

* Semicolon ;
* Single and double quotes "" ''
* Backslash \

```crmscript!
printLine("The reserved characters are: \; \" \' \\");
```

### Whitespace

Some characters produce whitespace and can be used to structure your text. These are:

* Backspace \b
* Newline \n
* Tab \t

## Length

The length of a text string is the number of characters in it, including whitespace. The 1st character is in position 0, similar to [arrays](../fundamentals/arrays.md).

### Integer getLength()

To find the length of a string, use the built-in `getLength()` method. It will return the number of characters as an Integer.

```crmscript!
String txt = "Wergelandsveien";
printLine(txt.getLength().toString());
```

## Case

If your script processes case-sensitive data, you probably need to validate input. Or perhaps you are preparing formatted output and need to make your subject lines and headings stand out. CRMScript has built-in capabilities for both scenarios.

### Changing case

#### String toLower()

`toLower()` will convert the string to its lower-case representation (all lower-case).

```crmscript
String s = "SuperOffice";
String sLow = s.toLower();
```

#### String toUpper()

`toUpper()` will convert the string to its upper-case representation (all upper-case).

```crmscript
String s = "SuperOffice";
String sUp = s.toUpper();
```

### Checking case

> [!NOTE]
> If any white-space characters are present in the string, these methods will return false!

#### Bool isLower()

`isLower()` determines if the string contains lower-case characters only. Will return **true** if no upper-case characters are found, otherwise **false**.

#### Bool isUpper()

`isUpper()` determines if the string contains upper-case characters only. Will return **true** if no lower-case characters are found, otherwise **false**.

## Comparing text

### Matching exact string

You can determine if there is an exact match between 2 strings either case sensitive or ignoring any differences in case.
Both methods take the string representing your pattern as the input parameter.

#### Bool equals()

Case sensitive comparison.

```crmscript!
String s1 = "apple";
String s2 = "Apple";
if (s1.equals(s2))
  print(s1 + " is identical to " + s2);
else
  print(s1 + " differs from " + s2);
```

#### Bool equalsIgnoreCase()

Case ignorant comparison. Same as using `toLower()` on both strings before calling `equals()`.

```crmscript!
String s1 = "apple";
String s2 = "Apple";
if (s1.equalsIgnoreCase(s2))
  print(s1 + " is identical to " + s2);
else
  print(s1 + " differs from " + s2);
```

### Matching start or end of a string

The pattern you wish to match against must be given as an input parameter.
The methods will return **true** if the beginning or end of your string matches the pattern, otherwise **false**.
`beginsWith()` and `endsWith()` are case sensitive, but they also have case ignorant variants.

#### beginsWith()

```crmscript!
String s1 = "apple";
String s2 = "appletree";
if (s2.beginsWith(s1))
  print(s2 + " begins with " + s1);
else
  print("No match found.");
```

To ignore case, use `caseBeginsWith()` instead.

#### endsWith()

```crmscript!
String s1 = "dog";
String s2 = "hotdog";
if (s2.endsWith(s1))
  print(s2 + " ends with " + s1);
else
  print("No match found.");
```

To ignore case, use `caseEndsWith()` instead.

### Determining lexicographic order

Strings are commonly sorted in **lexicographic order**. This is the dictionary order with 1 small exception: upper case letters precede lower case letters.

Two strings are lexicographic identical if they are the same length and they also contain the same characters in the same position.

To determine which string comes 1st, compare the corresponding characters from left to right. The 1st position where the 2 strings differ determines which string comes 1st.

* All uppercase letters come before lowercase letters. Thus *B* comes before *a*.
* If both characters have the same case, they are compared by alphabetical order. Thus *A* comes before *B*.
* If both strings contain the same characters in the same position, the shortest string comes 1st. Thus *ship* comes before *shipping*.

#### Understanding return values

| String    | Relation     | Parameter | s1.compare(s2) returns |
|-----------|--------------|-----------|------------------------|
| String s1 | less than    | String s2 | negative Integer       |
| String s1 | equal        | String s2 | zero                   |
| String s1 | greater than | String s2 | positive Integer       |

> [!NOTE]
> When s1 precedes s2, the result is negative, while when the order is s2 s1, you get a positive result. Think of it as a number axis where 0 represents identical strings. If s1 sorts 1st, it will be to the left of 0, thus negative. If s1 sorts last, it will be to the right of 0, thus positive.

#### Integer compare()

Case sensitive comparison.

```crmscript!
String s1 = "a";
String s2 = "B";
if (s1.compare(s2) < 0)  
  print(s1 + " comes before " + s2);
else if (s1.compare(s2) == 0)
  print(s1 + " is identical to " + s2);
else
  print(s2 + " comes before " + s1);
```

#### Integer caseCompare()

Case ignorant comparison. Same as applying the standard dictionary or alphabetic order.

```crmscript
String s1 = "a";
String s2 = "B";
Integer sortOrder = s1.caseCompare(s2);
```

The sort order here is a, B (negative).

## Joining strings

We are concatenating texts so frequently that this task has its own operator, `+`. You've seen it in most of the previous print statements.

Remember that the operands must be either String literals or String variables. If they're any other type, you must convert the value. Typically with `toString()`.

```crmscript
String s = "Back" + " to " + "the future";
```

### Appending text

Concatenation doesn't alter the original string *unless you combine with assignment*. To append s2 to s1, do one of the following:

```crmscript
s1 = s1 + s2;
s1 += s2;
s1.append(s2);
```

Using the `append()` method is currently faster than `+=`.

## Substituting text

Text substitution works as search-and-replace and will update **all** occurrences.

### String substitute(String src, String dest)

```crmscript
String s = "Superoffice";
print(s.substitute("o","O"));
```

## Searching strings

Find the start position (index) of a substring within the full string. The position will be an Integer between 0 and 1 less than the length of the string. However, if the substring is not found, the returned position will be -1.

You must provide the search pattern as a String input parameter.

This is useful for example if you need to start parsing after a special marker.

### Integer find(String subStr)

Finds the 1st occurrence of the substring and returns the index it starts at.

```crmscript!
String s = "SuperOffice";
printLine(s.find("O").toString());

String t = "TEAM";
printLine(t.find("I").toString());
```

The 1st output will be 5. The next output will be -1 because there is no *I* in *team*.

> [!TIP]
> `find()` is case-sensitive. If you want to disregard case in your search, use `findCase()` instead.

### Integer findLast(String p0)

Same as `find()` except it will return the position of the **last** occurrence of the pattern.

```crmscript!
String s = "SuperOffice";
printLine(s.findLast("e").toString());
```

## Extracting a part of the text

We just saw that `find()` returns the **position** of a pattern within a string. Now, we'll look at retrieving substrings. You can extract both a specified segment and relative to a given pattern.

### String subString(Integer pos, Integer len)

`subString()` will create a new String of a given length. It will copy characters from the original string starting at the given position.

The position must be less than `s.getLength()`. If the starting position is outside the original string, you will get an error.

However, CRMScript is forgiving if you specify a length exceeding the boundaries of the original string.
In other words, pos + len might be greater than `s.getLength()`.

```crmscript!
String s = "SuperOffice";
String t = s.subString(5,6);
print(t);
```

This will print *Office*.

### String until(String s)

If you don't know the exact segment length you wish to extract, 1 option is to copy from start until you encounter a given pattern (1st occurrence).

If the pattern is not found, a copy of this original string is returned.

```crmscript!
String s = "name := test";
String t = s.until(":=");
print(t);
```

This will extract and print *name*.

### String before(String s)

Same usage and result as `until()`.

### String beforeLast(String s)

Similar to `before()`, but will continue copying until the **last** occurrence of the pattern rather than stopping at the 1st.

Useful for example if you are parsing a path or URI and want everything except the document name.

```crmscript
String s = "https://community.superoffice.com/sdk-doc/Reference.htm";
String t = s.beforeLast("/");
```

### String after(String s)

Another option is to start copying after you encounter the pattern and continue extracting until you reach the end of the original string.

If the pattern is not found in this, an empty string is returned.

```crmscript!
String s = "name := value";
String t = s.after(":=");
print(t);
```

This will extract and print *value*.

### String afterLast(String s)

Similar to `after()`, but will not start copying until after the **last** occurrence of the pattern rather than starting after the 1st.

## Splitting strings

Rather than extracting a substring, you might want to split the original string in multiple segments and keep all of them. In other words, you need an array of substrings. The original string is not altered.

### String[] split(String delimiter)

> [!TIP]
> You can't split between every character (can't use an empty string as the delimiter).

**Split at white-space:**

```crmscript
String s = "Live now; make now always the most precious time. Now will never come again.";
String[] a = s.split(" ");
```

**Split at a word:**

```crmscript!
String s = "Change is the essential process of all existence.";
String[] a = s.split(" is ");
for (Integer i = 0; i < a.length(); i++) {
  printLine(a[i]);
}
```

Notice how the delimiter is excluded from the result.

## Determining character type

CRMScript has multiple methods for determining what kind of characters the string contains.
We've already looked at `isLower()` and `isUpper()`.

### Bool isAlpha()

`isAlpha()` determines if the string exclusively contains upper-case and lower-case letters. Will return **true** if the restriction applies, otherwise **false**.

> [!NOTE]
> If any white-space characters are present in the string, the method will return false!

```crmscript!
String s = "SuperOffice";
print(s.isAlpha().toString());
```

This will print *true*. However, if we change the string to "SuperOffice AS", `isAlpha()` will return false.

### Bool isDigit()

`isDigit()`determine if the string contains **numeric** characters \[0-9\] only.

### Bool isAlphanumeric()

`isAlphanumeric()` combines the criteria of `isAlpha()` and `isDigit()`, and will return true if the string is restricted to any combination of lower-case and upper-case letters and digits \[0-9\].

As before, if any white-space characters are present, the result will be false!

In situations where special characters are not permitted, `isAlphanumeric()` could be the starting point for a simple validator.

## Empty vs. no value

Before a String is initialized, it has no value. This is commonly written as NULL, NUL, or NIL in other languages.

Null is different from empty, which is actually means it contains no characters.

CRMScript is usually forgiving and interprets null as empty. However, it is a good habit to always test that you have a value before using it.

### Bool isNull()

`isNull()` returns **true** if the string is NULL/NUL/NIL, otherwise **false**.

### Bool isEmpty()

`isEmpty()` returns **true** if the string is empty ("") or NULL/NUL/NIL, meaning it contains no characters.

There is a subtle difference between these 2 methods. Choose the one that best suits your needs.

```crmscript!
String s;
printLine(s.isNull().toString());
s = "";
printLine(s.isNull().toString());
printLine(s.isEmpty().toString());
```

The 1st output will be *true* because we haven't initialized s yet. The next call to `isNull()` will return **false** because s now has the value "". However, there are still no characters in s, thus ìsEmpty()` will return **true**.
