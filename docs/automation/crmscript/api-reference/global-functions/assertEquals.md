---
uid: crmscript_global_assertequals
title: assertEquals
description: CRMScript function used primarily with unit testing. It will throw an AssertException if the 2 parameters are not equal.
intellisense: Void.assertEquals
langref: 1
keywords: assertEquals(Bool,Bool), assertEquals(Float,Float), assertEquals(String,String), assertEquals(Integer,Integer)
so.topic: reference
---

# Void assertEquals()

This method is used primarily with unit testing.

It will throw an `AssertException` if the 2 parameters are not equal. Specifically:

* if bool1!=bool2
* if float1!=float2
* if string1!=string2
* if integer1!=integer2

The exception contains the line number where the assert occurred.

## Functions

* Void assertEquals(Bool bool1, Bool bool2)
* Void assertEquals(Float float1, Float float2)
* Void assertEquals(String string1, String string2)
* Void assertEquals(Integer integer1, Integer integer2)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| bool1 | Bool | The first bool to test |
| bool2 | Bool | The second bool to test |
| float1 | Float | The first float to test |
| float2 | Float | The second float to test |
| string1 | String | The first string to test |
| string2 | String | The second string to test |
| integer1 | Integer | The first integer to test |
| integer2 | Integer | The second integer to test |
