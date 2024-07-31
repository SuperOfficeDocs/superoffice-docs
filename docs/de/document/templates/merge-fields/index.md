---
uid: help-de-mergefield-ref
title: Referenz für Merge fields
description: Referenz für Merge fields
keywords: Merge field, Zusammenführungsfeld, Mehrwertsteuer
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
topic: reference
language: en
---

# Referenz für Merge fields

> [!NOTE]
> Zahlen, Daten und Uhrzeiten sind [kultursensitiv][2].
>
> Wenn Dokumente in Google Drive gespeichert sind, werden Merge fields nicht unterstützt.

## Mehrwertsteuer

Wenn Sie die Mehrwertsteuer korrekt berechnen möchten, müssen Sie zuerst ALLE Rabatte abziehen, einschließlich alternativer Rabatte (Bestellrabatt). Dies muss für jede Angebotszeile (Produkt) erfolgen.

Wir nennen dies den "Gesamtpreis mit alternativem Rabatt".

Wir multiplizieren den "Gesamtpreis mit alternativem Rabatt" mit der Mehrwertsteuer (-Prozentsatz). Die resultierende Zahl nennen wir **VATAmount**.

Diese Werte werden im VATAmount feld der Alternative summiert.

Schließlich werden der Gesamtpreis der Alternative und der VATAmount der Alternative zu dem Feld addiert, das wir **TotalPriceIncVAT** nennen.

<!-- Referenced links -->
[2]: ../learn/quote-templates.md#culture
