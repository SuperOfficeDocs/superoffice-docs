---
uid: help-da-mergefield-ref
title: Fletfeltreference
description: Fletfeltreference
keywords: fletfelt
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
topic: reference
language: en
---

# Fletfeltreference

> [!NOTE]
> Tal, datoer og tid er [kulturspecifikke][2].
>
> Hvis dokumenter er gemt i Google Drive, understøttes fletfelter ikke.

## Moms

Når du vil beregne moms korrekt, skal du først trække ALLE rabatter fra, inklusive alternativ rabat (ordrerabat). Dette skal gøres for hver tilbudslinje (produkt).

Vi kalder dette "Totalpris med alternativ rabat".

Vi multiplicerer "Totalpris med alternativ rabat" med momsen (procent). Det resulterende tal kalder vi **VATAmount**.

Disse værdier summeres i alternativets VATAmount-felt.

Endelig lægges alternativets TotalPrice og alternativets VATAmount sammen i feltet, som vi kalder **TotalPriceIncVAT**.

<!-- Referenced links -->
[2]: ../learn/quote-templates.md#culture
