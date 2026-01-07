---
uid: help-no-lead-category-automation
title: Automatiser lead-kategorisering
description: Konfigurer automatiske kategori-oppdateringer når salg endrer status eller lead-status oppdateres for å redusere manuelt arbeid og opprettholde datanøyaktighet.
keywords: lead-håndtering, kategori-automatisering, arbeidsflyt, lead-kategorisering, automatisk kategori-oppdatering
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: howto
category: sale
topic: lead
license: salespremium
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
language: no
---

# Automatiser lead-kategorisering

[!include[Must be admin](../../learn/includes/req-admin.md)]

Automatisering av firmakategori-oppdateringer bidrar til å redusere manuelt arbeid og sikrer at dataene dine forblir nøyaktige. Når statusen til et salg endres eller en lead-status oppdateres, kan det relaterte firmaet automatisk oppdateres med riktig kategori.

Du kan konfigurere automatiseringen til å kjøre fullstendig automatisk eller be brukeren om å bekrefte endringen før den brukes.

## Forutsetninger

* Du må ha administratorrettigheter for å få tilgang til **Innstillinger og vedlikehold**.
* Firmaets gjeldende kategori må tilhøre gruppen **Potensiell kunde** for å være kvalifisert for automatiske oppdateringer. Se [Firmakategori og kategorigruppe][1].
* For lead-statusbasert automatisering må **Lead-status** være aktivert for firmaets gjeldende kategori.

## Konfigurer kategori-automatiseringsregler

Du kan aktivere en eller alle av følgende automatiseringsregler:

| Automatiseringsregel | Beskrivelse |
|---|---|
| Oppdater kategori når et salg er vunnet | Oppdaterer automatisk firmakategorien når et salg er merket som **Vunnet**. |
| Oppdater kategori når et salg er tapt | Oppdaterer automatisk firmakategorien når et salg er merket som **Tapt**. |
| Oppdater kategori når et salg registreres hos firmaet | Oppdaterer automatisk firmakategorien når et nytt salg opprettes og kobles til firmaet. |
| Oppdater kategori når en lead-status settes til | Oppdaterer automatisk firmakategorien når en kontakts lead-status endres til en bestemt verdi, for eksempel *Kvalifisert* eller *Diskvalifisert*. Krever at lead-status er aktivert for kategorien. |

### Trinn

1. Åpne **Innstillinger og vedlikehold**.

1. Velg <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbeidsflyt** i navigatoren.

1. Velg fanen **Lead-kategorisering**. Dette skjermbildet viser automatiseringsalternativer.

    ![Admin arbeidsflyt - Fanen Lead-kategorisering som viser automatiserings-brytere -screenshot][img1]

1. Aktiver bryteren for regelen du vil aktivere.

1. Når du aktiverer en bryter, vises flere alternativer:

    * **Sett kategori til:** Velg målkategorien fra listen. Dette er kategorien firmaet vil bli oppdatert til når betingelsen er oppfylt.

        Du kan velge hvilken som helst kategori, uavhengig av kategorigruppen.

    * **Be om brukerbekreftelse før oppdatering:** Merk av i denne boksen hvis du vil at brukeren skal bekrefte kategoriendringen før den brukes.

        La den være uavmerket for fullstendig automatiske oppdateringer.

1. Gjenta for eventuelle andre regler du vil aktivere.

1. Klikk **Lagre** for å bruke endringene dine, eller klikk **Avbryt** for å forkaste dem.

> [!NOTE]
> **Lagre**-knappen er aktivert først etter at du har valgt en kategori i feltet **Sett kategori til** for alle aktiverte brytere.

## Når brukerbekreftelse skal brukes

Bestem om kategori-oppdateringer skal være automatiske eller kreve brukerbekreftelse basert på dine forretningsbehov:

* **Fullstendig automatisk:** Best for enkle lead-til-kunde-arbeidsflyter der kategoriendringer er forutsigbare og konsistente. For eksempel automatisk flytting av en lead til kategorien *Kunde* når et salg er merket som vunnet.

* **Brukerbekreftelse:** Anbefales når kategoriendringer krever vurdering eller når flere kategorier kan gjelde. For eksempel, hvis du jobber med flere kundenivåer (VIP, A, B, C), sikrer brukerforespørsel at riktig kategori velges.

Når **Be om brukerbekreftelse før oppdatering** er aktivert, vil brukeren se en dialogboks som foreslår kategoriendringen. De kan akseptere forslaget eller velge en annen kategori før lagring.

## Eksempel: Automatiser lead-til-kunde-overgang

Et vanlig brukstilfelle er å automatisk oppdatere en lead til en kundekategori når et salg er vunnet:

1. Aktiver **Oppdater kategori når et salg er vunnet**.

1. Sett **Sett kategori til** = *Kunde*.

1. La **Be om brukerbekreftelse før oppdatering** være uavmerket for full automatisering.

1. Klikk **Lagre**.

Nå, når et salg knyttet til et firma i gruppen *Potensiell kunde* merkes som vunnet, vil firmakategorien automatisk endres til *Kunde*.

## Relatert innhold

* [Firmakategori og kategorigruppe][1]
* [Oversikt over lead-håndtering][3]
* [Administrer lead-statuser][2]
* [Oppdater et salg][4]
* [Salgsguider][5]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[4]: ../../sale/learn/update.md
[5]: ../../sale/learn/sales-guides.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/lead-categorization.png
