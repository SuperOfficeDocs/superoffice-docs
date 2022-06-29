---
uid: help-en-results-of-number-allocation
title: Results of number allocation
description: Results of number allocation
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Results of number allocations

The table below shows the consequences of different combinations of the values **Allocate** (A), **Unique** (U), **Read only** (R) and **Allow empty/blank** (B) in practice:

<table>
<tbody>
<tr>
<td><p><strong>A</strong></p></td>
<td><p><strong>U</strong></p></td>
<td><p><strong>R</strong></p></td>
<td><p><strong>B</strong></p></td>
<td><p><strong>Result</strong></p></td>
</tr>
<tr>
<td><p> </p></td>
<td><p> </p></td>
<td><p> </p></td>
<td><p> </p></td>
<td><p>Users can enter what they want.</p></td>
</tr>
<tr>
<td><p>x</p></td>
<td><p> </p></td>
<td><p> </p></td>
<td><p> </p></td>
<td><p>A number is allocated which the user can change.</p></td>
</tr>
<tr>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p> </p></td>
<td><p>A number is allocated which the user can change to a unique value. The database can only have one empty field.</p></td>
</tr>
<tr>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p>A number is allocated which the user cannot change.</p></td>
</tr>
<tr>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p>A number is allocated which the user cannot change.</p></td>
</tr>
<tr>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p>x</p></td>
<td><p>A number is allocated which the user can change to a unique value or remove. The database can have unlimited empty fields.</p></td>
</tr>
<tr>
<td><p>x</p></td>
<td><p> </p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p>A number is allocated which the user cannot change. If any external processes change the number, no check is performed as to whether the new number is unique.</p></td>
</tr>
<tr>
<td><p> </p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p> </p></td>
<td><p>No number is allocated. The user can specify a number, but it must be unique. The database can only have one empty field.</p></td>
</tr>
<tr>
<td><p> </p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p>x</p></td>
<td><p>No number is allocated. The user can specify a number, but it must be unique. The database can have unlimited empty fields.</p></td>
</tr>
<tr>
<td><p> </p></td>
<td><p> </p></td>
<td><p>x</p></td>
<td><p>x</p></td>
<td><p>No number is allocated, nor may the user specify a number. Useful when using counters from third party suppliers.</p></td>
</tr>
<tr>
<td><p> </p></td>
<td><p> </p></td>
<td><p>x</p></td>
<td><p> </p></td>
<td><p>No number is allocated, nor may the user specify a number. The database can only have one empty field. (Not recommended.)</p></td>
</tr>
</tbody>
</table>
