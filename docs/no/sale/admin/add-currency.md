---
uid: help-no-currency-add
title: Legge til forekomster på Valuta-listen
description: Legge til forekomster på Valuta-listen
keywords: valuta, listen Generelt – Valuta
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
  - /no/admin/lists/learn/adding-items-to-currency-list
  - /no/admin/lists/learn/currency
language: no
---

# Valuta

I fanene i Salg-bildet i SuperOffice CRM angir du blant annet salgsbeløp, kostnader og fortjeneste for salget. Hvilken valuta beløpene vises i, avhenger av hva som er angitt i [preferansene][2], der du velger din egen valuta og basisvaluta fra en liste som er definert i Lister-bildet.

## Legg til valuta

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Generelt – Valuta** fra fra rullegardinmenyen. Fanen **Forekomster** viser alle eksisterende valutaer.

1. Klikk på **Legg til** for å åpne dialogboksen **Rediger listeelement**.

1. Skriv inn ønsket navn på elementet i feltet **Navn**. *(Obligatorisk)*

1. Skriv inn valutakursen for den aktuelle valutaen i feltet **Kurs**.

    > [!NOTE]
    > Dette er kursen i forhold til basisvalutaen. Basisvalutaen er valutaen der kursen er satt til 1. Hvis basisvalutaen er EUR, beregnes kursen for de andre valutaene mot denne valutaen, i henhold til angitt enhet (se neste punkt). For eksempel tilsvarer 1 GBP 1,562 EUR etter dagens kurs, mens 100 NOK tilsvarer 12,677 EUR. Denne beregningen vises etter at du har angitt kurs og enhet.

1. Angi i feltet **Enhet** hvilken enhet som skal brukes i forhold til basisvalutaen. Standardverdien kan for eksempel være 100 for norske kroner og 1 for britiske pund.

1. Skriv eventuelt inn en beskrivelse av valutaen i feltet **Beskrivelse**.

1. Klikk på **Lagre**. Valutaen blir lagt til som et eget element i listen. Gjenta prosedyren for å legge til flere valutaer.

## Endre standardvaluta

For å endre standardvalutaen, åpne skjermbildet **Preferanser** og gå til **Fanen Globale preferanser** > **System** > **Ledende valuta**.

## Aktivere bruk av valuta

For å tillate registrering av salg i en annen valuta, åpne skjermbildet **Preferanser** og gå til **Fanen Preferanser** > **System** > **Aktiver bruk av valuta**.

<!-- Referenced links -->
[2]: ../../admin/preferences/index.md
