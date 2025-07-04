---
uid: help-sv-mergefield-ref
title: Merge field referens
description: Merge field referens
keywords: merge field, sammanslagningsfält
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
content_type: reference
language: en
index: true
---

# Merge field referens

Referens för merge fields

> [!NOTE]
> Nummer, datum och tid är [kulturspecifika][2].
>
> Om dokument lagras i Google Drive stöds inte merge fields.

## Moms

När du vill beräkna moms korrekt måste du först dra av ALLA rabatter, inklusive alternativ rabatt (orderrabatt). Detta måste göras för varje offertlinje (produkt).

Vi kallar detta "Totalpris med alternativ rabatt".

Vi multiplicerar "Totalpris med alternativ rabatt" med momsen (-procent). Det resulterande beloppet kallar vi **VATAmount**.

Dessa värden summeras i alternativets VATAmount-fält.

Slutligen adderas alternativets TotalPrice och alternativets VATAmount till fältet vi kallar **TotalPriceIncVAT**.

<!-- Referenced links -->
[2]: ../learn/quote-templates.md#culture
