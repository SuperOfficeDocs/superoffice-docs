---
uid: help-no-customer-center-config
title: Kundesenterkonfigurasjon
description: Finn ut hvordan du konfigurerer kundesenteret ditt i denne guiden.
author: SuperOffice RnD
date: 03.16.2023
keywords: Tjeneste, Kundesenter, CEP
topic: howto
language: no
---

# Konfigurere kundesenter <i class="ph ph-question" aria-label="Question mark"></i>

[!include[Requirement](../../learn/includes/req-cep.md)]

Du kan redigere stilen og layouten til kundesenteret og forhåndsvise endringene.

![Konfigurer chatwidgeten i kundesenteret, slik at kunder kan chatte med deg når de besøker websiden din -screenshot][img2]

Hvis kundesenteret ditt er flerspråklig, kan du angi valg (for eksempel velkomsttekst, åpningstider og telefonnumre) individuelt for hvert språk.

> [!NOTE]
> Hvis du vil redigere HTML-koden for de forskjellige sidene, må du [oppdatere kildefilene][1].

## Trinn

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Velg **Kundesenter** > **Konfigurer**. Det er to faner i **Kundesenter**-bildet: **Stil** og **Systemvalg**. Øverst på denne siden finner du en kobling til en forhåndsvisning av Kundesenter-siden.

1. I fanen **Stil** kan du tilpasse utseendet til kundesenteret: Logo, foretrukket bredde, farger og skrifttyper. Forhåndsvisningen oppdateres automatisk.

    ![Forhåndsvise kundesentersidene -screenshot][img3]

1. Gå til fanen**Innstillinger**.

1. Velg språkversjonen du vil redigere.

1. Rediger alternativene. Se detaljer om hvert alternativ nedenfor.

1. Klikk på **Lagre**.

1. Gjenta trinn 4-6 for å angi alternativene for et annet språk.

1. Klikk på **Lagre** når du er ferdig.

## Systemvalg

| Alternativ | Beskrivelse |
|---|---|
| Logo-URL | Koblingen til logobildet. |
| Nettstedsnavn | Tittelen på websiden. |
| Velkommen, topptekst | Titteltekst som vises i topptekstfeltet. |
| Velkommen, brødtekst | Brødtekst som vises i topptekstfeltet. |
| Vis åpningstider | Velg dette alternativet hvis du vil vise åpningstider ved siden av topptekstfeltet. Skriv inn åpningstidene i feltet nedenfor. |
| Vis telefonnummer | Velg dette alternativet for å vise telefonnummeret ditt ved siden av topptekstfeltet. Skriv inn telefonnummeret i feltet nedenfor. |
| Vis søk på startsiden | Velg dette alternativet for å vise FAQ-søk i topptekstfeltet. Skriv inn plassholdertekst i feltet nedenfor. Eksempel: "Skriv inn tekst her for å søke i FAQ". |
| Vis informasjon på startsiden | Velg dette alternativet for å vise et tekstfelt under topptekstfeltet. Klikk på **Rediger** for å skrive inn tekst. |
| Vis vanligste FAQer på startsiden | Velg dette alternativet for å vise de vanligste og nyeste spørsmålene. |
| Vis bunntekst | Velg dette alternativet for å vise en bunntekst nederst på siden. Klikk på **Rediger** for å skrive inn tekst. |
| Vis nettprat | Velg dette alternativet for å aktivere chatvinduet nederst til høyre på siden. Velg **Alltid** hvis du vil at chatvinduet skal være tilgjengelig for alle som besøker kundesenteret. Ellers velger du **Innloggede kunder** for å kreve at brukere logger på for å få tilgang til chatvinduet. |
| Chatkanal | Velg chatkanalen du vil bruke. Hvis ingen chatkanal er valgt, vil ikke chatvinduet være tilgjengelig. |
| Bruk egendefinert "kontakt oss"-skjema | Velg dette alternativet for å bruke et egendefinert skjema i stedet for standardskjemaet. Velg et skjema fra listen.|

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/customer-center/customer-centre-chat-with-agents.jpg
[img3]: ../../../media/loc/en/customer-center/config-cust-centre.png
