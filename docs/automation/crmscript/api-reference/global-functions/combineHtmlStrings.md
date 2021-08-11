---
title: String combineHtmlStrings(Vector htmlStrings)
description: String combineHtmlStrings(Vector htmlStrings)
intellisense: Void.combineHtmlStrings
langref: 1
keywords: combineHtmlStrings(Vector)
so.topic: reference
---

# String combineHtmlStrings(Vector htmlStrings)

This function will take several strings, each containing an HTML document, and combine them into one HTML string.

The head contents in each string is combined into the head tag of the output string, except for the title tag. The title tag is taken from the first string in the vector.

The body content is likewise combined into the body tag of the output string. All strings except for the first will have their body tags converted to div tags.

The first string of the vector is considered to be the "main" HTML document, which the other ones are appended to.
