---
uid: help-no-document-template-defaults
title: Standardverdier for nye dokumentmaler
description: Standardverdier for nye dokumentmaler
keywords: nummertildeling, ny teller, dokumentmal teller, standardverdier
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: document
topic: template
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /no/admin/options/learn/number-allocation/document-template-defaults
language: no
---

# Standardverdier for nye dokumentmaler

Hvis du vil, kan du angi [standardverdier][1] for nye dokumentmaler. Dette betyr at verdien i feltet **Vår ref.** i bildet Dokument øker med 1 hver gang denne malen brukes. Hvis det ikke er merket av for **Opprett nye tellere automatisk for nye dokumentmaler**, brukes samme teller på alle dokumentmaler, slik at verdien i **Vår ref**-feltet øker med 1 hver gang en mal brukes, uavhengig av hvilken mal det er.

> [!NOTE]
> On feltet **Vår ref.** i bildet Dokument fungerer som tellerfelt, avhenger av om {snum} malvariabelen er angitt for den aktuelle malen. Dette defineres i Lister-bildet: Klikk på **Dokumentmal**, dobbeltklikk på dokumentmalen under **Forekomster**, og rediger deretter feltet **Vår ref (standard)** i **Rediger forekomst**-dialogboksen.

## Slik angir du at nye dokumentmaler skal få egen teller

1. Gå til Innstillinger og vedlikehold, og velg deretter <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Systemvalg**.

1. Velg fanen **Nummertildeling**.

1. Nederst i fanen velger du **Opprett nye tellere automatisk for nye dokumentmaler**.

1. Klikk på **Standarder**.

1. Merk av for **Unik** hvis du vil at tellerverdiene i **Vår ref**-feltet skal være unike. Nyttig når SuperOffice CRM-brukere tildeler verdier selv.

1. Merk av for **Tillat tom** for å tillate tomme tellerfelt. Nyttig når tellerverdiene må være unike. Hvis det er merket av for **Tillat tomt**, betyr det at kravet om unike verdier ikke gjelder tomme felt.

1. Merk av for **Kun lesbar** hvis du ikke vil at SuperOffice CRM-brukerne skal kunne skrive inn verdier i **Vår ref**-feltet selv.

1. Merk av for **Tildel** for å bruke den automatiske tellerfunksjonen, slik at systemet legger inn verdier i **Vår ref.**-feltet for deg.

    [Se resultatene av ulike kombinasjoner av disse verdiene][1].

1. Skriv inn verdien du vil at telleren skal starte på, i feltet **Neste nummer**.

1. Klikk på **Lagre**.

<!-- Referenced links -->
[1]: ../../../admin/options/configure-number-allocation.md

<!-- Referenced images -->
