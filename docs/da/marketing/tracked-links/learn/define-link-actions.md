---
uid: help-da-define-link-actions
title: Definer automatiserede linkhandlinger
description: I denne vejledning lærer du, hvordan du bruger links i udsendelser til at automatisere handlinger.
keywords: Marketing, udsendelse, linkhandling, automatisere
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: concept
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Definer automatiserede linkhandlinger

Opdatering af 500 kontaktkort manuelt er tidskrævende og unødvendigt. Automatiske linkhandlinger kan strømline denne proces.

Sådan fungerer automatiske linkhandlinger:

* En modtagers klik på et CTA link kan automatisk tilføje dem til et udtræk eller et projekt i SuperOffice CRM.
* SuperOffice CRM kan automatisk opdatere relevante oplysninger, som interesser, på kontaktkortet.

Automatisering sparer tid, der ellers ville være brugt på at håndtere svar. Når en læser klikker på et link i din udsendelse, udfører systemet linkhandlinger for dig!

Du kan udnytte de indsamlede oplysninger på flere måder:

* Generer et udtræk baseret på hvem der klikkede på et specifikt link, og send et målrettet svar til denne gruppe med en tilpasset besked.
* Planlæg opfølgningsaktiviteter for dine teammedlemmer så de personligt kan følge op på de kontakter, der har svaret.
* Opret Service-sager til dit kundeserviceteam for at tage sig af og undersøge sagen.

![Definer dine linkhandlinger -screenshot][img3]

## Tilgængelige handlinger

Baseret på din udsendelses mål og call-to-action kan du opdatere din database. Disse oplysninger kan forbedre segmenteringen eller hjælpe med at følge op med interesserede enkeltpersoner. Du kan vælge mere end én handling for et sporet link.

| Fane | Handling |
|---|---|
| [Respons](#response) | Tilføje landingsside eller standardtekst, eller åbne en formular. |
| [Indstille felt](#set-field) | Tilføje en værdi til et [ekstrafelt][5] for kundekontakter |
| [Interesser](#interests) | Opdatere interesser |
| [Udtræk/projekt](#selection) | Tilføje/fjerne person fra et udtræk eller projekt |
| [Opfølgning](#follow-up) | Oprette en opfølgning (opgave eller møde) i SuperOffice CRM |
| [Sag](#request) | Oprette en ny sag |
| [Script](#script) | Køre et script |

> [!TIP]
> Når du opdaterer et sporet link, skal du huske, at det muligvis bruges af flere e-mails og/eller automatiserede flows. Du bør sikre dig, at der ikke er nogen duplikerede eller modstridende handlinger.

## <a id="response"></a>Respons

Vælg, hvad der skal ske, når modtageren klikker på linket.

* **Omdirigere til ny webside**: Indtast webadressen i det angivne felt.
* Eller, **Vise tilpasset tekst**: Indtast teksten, der skal vises. Klik på ![ikon][img4] redigeringsknappen for at vise værktøjslinjen til formateret tekst.
* Eller, **Åbn formular**: Vælg navnet på formularen. Vælg eventuelt hvilke felter, der skal forudfyldes med kendte kontaktoplysninger.

## <a id="set-field"></a>Indstille felt

I fanen **Indstil felt** kan du angive en værdi, der skal tilføjes til et ekstrafelt, når modtageren klikker på linket. Dette registrerer yderligere kundeoplysninger.

Vælg et felt og indtast en værdi.

## <a id="interests"></a>Interesser

Angiv, at et linkklik skal ændre personens interesser. For eksempel, tilføj interessen "Produktnyheder", hvis linket "Ja tak! Jeg vil gerne vide mere om nye produkter" bliver klikket på, eller fjern den, hvis linket "Afmeld mailingliste" bliver klikket på.

* **Angiv interesse**: vælg en interesse, der skal tilføjes for personerne, når de klikker på linket.
* **Fjern interesse**: vælg en interesse, der skal fjernes for personerne, når de klikker på linket.

[Sådan opretter du en tilmeldingsformular til nyhedsbrevet][1]

## <a id="selection"></a>Udtræk/projekt

Specificér, at modtagere, der klikker på linket, vil blive tilføjet eller fjernet fra udtræk eller projekter. Begynd at skrive et navn for at starte en hurtigsøgning.

## <a id="follow-up"></a>Opfølgning (møde/opgave)

På fanen **Opfølgning** kan du angive et linkklik for at generere møder eller opgaver i SuperOffice CRM. Vælg opfølgningstypen, angiv en beskrivelse, link den til et projekt, vælg opgavetypen, tildel ansvar og angiv varigheden.
Aktivér denne funktion ved at vælge **Opfølgning**.

[Sådan oprettes en opfølgning][4]

> [!TIP]
> Som beskrivelse skal du angive, hvilken udsendelse det drejer sig om, hvilket link modtageren klikkede på, og eventuelt hvordan opgaven eller mødet skal følges op.
>
> Når du angiver **Oprettet af** eller **Standardmodtager**, kan du klikke på knappen **Angiv aktiv bruger** (<i class="ph ph-user-circle" aria-hidden="true"></i>) for at vælge dig selv.

## <a id="request"></a>Sag

På fanen **Sag** kan du angive et linkklik for at oprette en sag i SuperOffice Service. Markér af i boksen for at registrere en ny sag, angiv en titel, vælg prioritet og kategori, og vælg ejeren. Du kan også vælge **Automatisk tildelt** eller **Ikke tildelt**.

[Sådan oprettes en sag][3]

## <a id="script"></a>Script

På fanen **Script** kan du vælge et CRMScript eller makro, der skal køres, når linket klikkes. Aktivér denne funktion ved at vælge **Kør script** og vælg derefter det nødvendige script fra listen.

Variabler tilgængelige i scriptet inkluderer custId, linkId, shipmentId, linkUrl, linkHits og returnUrl.

[Sådan oprettes eller redigeres et CRMScript][6]

<!-- Referenced links -->
[1]: ../../forms/learn/tutorial-sign-up.md
[3]: ../../../request/learn/create.md
[4]: ../../../diary/learn/create-follow-up.md
[5]: ../../../custom-objects/learn/extra-field.md
[6]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
[img4]: ../../../../media/icons/marketing-and-forms/side-panel-content-text.png
