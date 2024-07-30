---
uid: help-no-mergefield-ref
title: Flettefeltreferanse
description: Flettefeltreferanse
keywords: flettefelt, MVA
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
topic: reference
language: en
---

# Flettefeltreferanse

> [!NOTE]
> Tall, datoer og tid er [kultursensitive][2].
>
> Hvis dokumenter er lagret i Google Drive, støttes ikke flettefelt.

## MVA

Når du vil beregne MVA korrekt, må du først trekke fra ALLE rabatter, inkludert alternativ rabatt (ordrerabatt). Dette må gjøres for hver tilbudslinje (produkt).

Vi kaller dette "Totalpris med alternativ rabatt".

Vi multipliserer "Totalpris med alternativ rabatt" med MVA (prosent). Det resulterende tallet kaller vi **VATAmount**.

Disse verdiene summeres i alternativets VATAmount-felt.

Til slutt legges alternativets TotalPrice og alternativets VATAmount sammen i feltet vi kaller **TotalPriceIncVAT**.

<!-- Referenced links -->
[2]: ../learn/quote-templates.md#culture
