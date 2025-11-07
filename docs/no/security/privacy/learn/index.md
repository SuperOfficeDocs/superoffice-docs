---
uid: help-no-privacy
title: Personvern
description: Personvern-funksjonen i SuperOffice hjelper deg å beskytte personvernet til kundene dine og overholde EUs personvernforordning (GDPR).
keywords: personvern, GDPR, e-markedsføring, samtykke, rettslig grunnlag
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Personvern <i class="ph ph-shield" aria-label="Shield icon"></i>

**Personvern**-funksjonen i SuperOffice hjelper deg å beskytte personvernet til kundene dine og overholde EUs personvernforordning (GDPR).

Du må ha samtykke (tillatelse) fra en person hvis du (blant annet) skal

* Lagre og behandle dataene deres (for å selge til og/eller tilby tjenester til en person)
* Sende e-markedsføringsmateriell til vedkommende

Dette er to ulike formål for innhenting av samtykke fra en person. I SuperOffice kalles disse formålene **Salg og kundeservice** og **E-markedsføring**. Det kan også finnes andre formål som er relevante for virksomheten din.

I fanen **Samtykke** på skjermbildet **Personvern** kan du [opprette og redigere formål][2].

Du må dokumentere et rettslig grunnlag og kilde til samtykke for hvert formål (under import eller i SuperOffice CRM for enkeltpersoner eller flere brukere).

## <a id="legal-basis"></a>Rettslig grunnlag

Du må dokumentere det rettslige grunnlaget for hvert formål som er registrert på en person. I denne listen legger du til og vedlikeholder hjemlene som brukes når du redigerer personverninnstillingene for personer.

Eksempel: En person sender deg en sak via webskjema og klikker på alternativet "Abonner på nyhetsbrev" (eller tilsvarende). Dette betyr at vedkommende har samtykket til å motta e-postmarkedsføring fra firmaet ditt. Så hjemmelen er **Samtykke** til formålet E-markedsføring.

## <a id="source"></a>Kilde

Hvor og hvordan innhentet du samtykke fra en person? Eksempler: E-post, chat, webskjema og kundeportal.

## Alternativer i fanen Samtykke

Fanen **Samtykke** inneholder en liste over alle tilgjengelige formål.

## Aktivere eller deaktivere et formål

I kolonnen **Aktiv** kan du aktivere og deaktivere formål. Det anbefales at du heller deaktiverer et formål enn å slette den.

## Legge til et nytt formål

Klikk på **Legg til** under listen med formål. Se [Legge til formål][2].

## Angi standard hjemmel

Når det opprettes en person i SuperOffice CRM, er det ikke angitt hjemmel for formålet **Salg og kundeservice**. Du kan velge en standardhjemmel som skal brukes for formålet **Salg og kundeservice** når en person opprettes. Denne verdien vil også være standard hjemmel for importerte personer, med mindre en annen verdi er valgt under importen.

Velg alternativet **Angi standard hjemmel**, og velg hjemmel i listen. Denne hjemmelen blir angitt for alle nye kpersoner for formålet **Salg og kundeservice**.

[Legge til forekomster i listen Personvern - Hjemmel][3]

## Filtrere mottakere basert på samtykke til e-markedsføring og aktive abonnement

Hvis du velger dette alternativet, vil bare personer som har gitt sitt samtykke til å motta e-postmarkedsføring, eller som har et abonnement, legges til i listen over mottakere i en utsendelse.

Hvis du *ikke* velger dette alternativet, vil bare personer med **E-markedsføring** satt til **AV** og hjemmel satt til **Trukket tilbake** filtreres bort fra mottakerlisten. Dette fungerer på samme måte som for **Ingen utsendelser**.

## Relatert innhold

* [Legg til elementer i listen Personvern - Hjemmel][3]
* [Legge til elementer i listen Personvern - Kilde][4]
* [Konverteringssporing (UTM)][5]

<!-- Referenced links -->
[2]: ../admin/add-purpose.md
[3]: ../admin/add-legal-base.md
[4]: ../admin/add-source.md
[5]: ../../../marketing/utm/learn/index.md

<!-- Referenced images -->
