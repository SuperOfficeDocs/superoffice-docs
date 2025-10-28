---
uid: help-da-currency-add
title: Tilføjelse af forekomster på listen Valuta
description: Tilføjelse af forekomster på listen Valuta
keywords: listen Generelt – Valuta, valuta
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: sale
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /da/admin/lists/learn/adding-items-to-currency-list
  - /da/admin/lists/learn/currency
language: da
---

# Valuta

Under skærmbillederne Salg i SuperOffice CRM angiver du bl.a. salgsbeløb, omkostninger og fortjeneste for salget. Hvilken valuta beløbene vises i, afhænger af, hvad der er angivet i [Præferencer][2], hvor du vælger egen valuta og basisvaluta fra en liste, der er defineret i skærmbilledet Lister.

## Tilføj valuta

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigator.

1. Vælg **Generelt – Valuta** i fra rullemenuen. Fanen **Forekomster** viser alle eksisterende valutaer.

1. Klik på **Tilføj** for at åbne dialogboksen **Rediger listeforekomst**.

1. Indtast det ønskede navn i feltet **Navn**. *(Obligatorisk)*

1. Angiv kursen for den relevante valuta ved at angive et tal i feltet **Kurs**.

    > [!NOTE]
    > Dette er kursen i forhold til den ledende valuta. Basisvalutaen er den valuta, hvor kursen er angivet til 1. Hvis basisvalutaen er EUR, beregnes kursen for de øvrige valutaer i forhold til denne valuta i forhold til den angivne enhed (se næste punkt). 1 GBP svarer f.eks. til 1,562 EUR til dagens kurs, mens 100 NOK svarer til 12,677 EUR. Denne beregning vises, når du har angivet valutakursen og enheden.

1. Angiv den enhed, der skal bruges i forhold til basisvalutaen i feltet **Enhed**. Standarden kan f.eks. være 100 for norske kroner og 1 for britiske pund.

1. Angiv eventuelt en beskrivelse af valutaen i feltet **Beskrivelse**.

1. Klik på **Gem**. Valutaen bliver nu tilføjet som en særlig forekomst på listen **Forekomster**. Gentag proceduren, hvis du vil tilføje flere valutaer.

## Skift standardvaluta

For at ændre standardvalutaen skal du åbne skærmbilledet **Præferencer** og gå til fanen **Globale præferencer** > **System** > **Ledende valuta**.

## Aktivér brug af valuta

For at tillade, at salg registreres i en anden valuta, skal du åbne skærmbilledet **Præferencer** og gå til fanen **Præferencer** > **System** > **Aktivér brug af valuta**.

> [!NOTE]
> Hvis du vil aktivere brug af valuta, skal du gå til **Præferencer** > **Aktivér brug af valuta**.

<!-- Referenced links -->
[2]: ../../admin/preferences/index.md
