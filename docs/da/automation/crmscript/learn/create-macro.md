---
uid: help-da-automation-macro-create
title: Opret en makro - eksempel fra SuperOffice
description: Eksempel på, hvordan du opretter en makro i SuperOffice.
author: SuperOffice RnD
date: 03.16.2023
keywords: script, makro
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Opret en makro - eksempel fra SuperOffice

Mange virksomheder modtager ofte sager, der vedrører fakturering. Sådanne sager skal gå direkte til regnskabsafdelingen. I stedet for at redigere hver enkelt sag og ændre kategori og ejer kan vi oprette en makro, som udfører alle disse handlinger. Makroen kan tildeles til **Handlinger** i skærmbilledet Sag. Fakturaspørgsmål kan således delegeres til regnskabsafdelingen med et enkelt klik.

> [!TIP]
> Processen kan fuldautomatiseres ved at oprette et e-mail-filter til at søge efter ordet "faktura" i meddelelsestitlerne og derefter køre makroen for at tildele sagen til den rigtige afdeling.

Vi vil nu oprette en makro baseret på det ovenstående eksempel.

## Trin

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Vælg <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** og fanen for **Makroer og script**. Gør ét af følgende:
    * Sådan opretter du en ny makro: Klik på **Ny makro**.
    * Sådan redigeres en eksisterende makro: Klik på makronavnet.

1. Under fanen **Information** skal du indtaste "Send sag til regnskabsafd." i feltet **Navn** og angive en beskrivelse i feltet nedenunder.

1. Vælg **Ny menu** for at gøre makroen tilgængelig fra knappen **Handling** på skærmen Firma, Kontaktskærmen eller Sagsskærmen eller fanen **Meddelelse**.

1. Gå til fanen **Handlinger**, og vælg **Vælg handlingstype** > **Skift en anmodning**.

1. Marker **Kategori**, og vælg en kategori på listen (for eksempel *Regnskab*).

1. Marker **Ejer**, og vælg en bruger.

    > [!TIP]
    > Alternativt kan du vælge **Automatisk tildelt** for at tillade systemet at fordele sagen efter de aktuelle fordelingsregler.

1. Marker **Intern meddelelse**, og skriv en kort standardmeddelelse til regnskabsafdelingen om, hvorfor de har modtaget denne sag.

1. Klik på **OK**, når du er færdig.

## Relateret indhold

* [Få mere at vide om avancerede makrofunktioner og udløsere][1]

<!-- Referenced links -->
[1]: trigger.md
