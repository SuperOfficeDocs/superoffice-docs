---
uid: help-da-define-link-actions
title: Definer linkhandlinger
description: "I denne vejledning lærer du, hvordan du bruger links i udsendelser til at automatisere handlinger."
author: SuperOffice RnD
so.date: 02.20.2023
keywords: Marketing
so.topic: howto
language: da
---

# Bruge links til at automatisere forskellige handlinger

[!include[Requirement](includes/req-marketing.md)]

Du kan gøre dit arbejde hurtigere ved at behandle de svar, du får på en udsendelse, ved hjælp af automatiserede linkhandlinger.

Forestil dig, at din udsendelse er en stor succes. Over 500 personer åbnede din besked og klikkede på de links, du havde indsat. Det er så din opgave at behandle alle svarene fra modtagerne. Tænk på, hvor lang tid det ville tage, hvis du skulle gøre det manuelt.

I SuperOffice Marketing kan du forbinde dine links med handlinger. Disse handlinger udløses, når modtageren klikker på et link.

![Definere linkhandlinger -screenshot][img3]

| Fane | Handling |
|---|---|
| Respons | Tilføje landingsside eller standardtekst |
| Indstille felt | Tilføje en værdi til et ekstra felt for kundekontakter |
| Interesser | Opdatere interesser |
| Udtræk/projekt | Tilføje/fjerne person fra et udtræk/projekt |
| Opfølgning | Oprette en opfølgning (opgave eller møde) i SuperOffice CRM |
| Sag | Oprette en ny sag |
| Script | Køre et script |

## Respons

* **Omdirigere til ny webside**: Vælg denne valgmulighed for at omdirigere modtagerne til en webside, når de klikker på linket. Indtast webadressen i feltet **URL til ny side**.

* **Vise tilpasset tekst**: Vælg denne valgmulighed, hvis der skal vises en tilpasset tekst til modtagerne, når de klikker på linket. Indtast teksten i feltet nedenfor.

## Opdatere databasen

Du kan opdatere oplysningerne i din database i henhold til formålet med din udsendelse og dens opfordring til handling. Når en person klikker på linket i din mail, vil SuperOffice CRM gøre et af følgende:

* Give et brugerdefineret svar eller omdirigere til en webside
* Tilføje en kontakt til et specifikt projekt eller et udtræk
* Opdatere status for interessen hos en kontakt
* Tilføje information til et felt på visitkortet
* Oprette en opfølgende handling for en kontakt
* Oprette en service-sag på en kontakt
* Køre et script

Nogle af oplysningerne vil hjælpe dig med at segmentere din database endnu bedre, mens andre oplysninger vil hjælpe dig med at følge op på de personer, der har vist interesse for dit budskab.

## Indstille felt

I fanen **Indstil felt** kan du angive, at der skal tilføjes en værdi til et ekstra felt, når modtageren klikker på linket. Det kan være nyttigt, hvis du vil registrere ekstra oplysninger om kunder, der klikker på linket.

Vælg et felt i rullemenuen **Indstil ekstra felt** og indtast en værdi i feltet **Værdi**.

## <a id="interests" />Interesse

Her kan du angive, at klik på links skal tilføje eller fjerne interesser til eller fra personen. Du kan for eksempel tilføje interessen "Produktnyheder", hvis modtageren klikker på linket "Ja tak! Jeg vil gerne vide mere om nye produkter". Alternativt kan du fjerne interessen "Produktnyheder", hvis brugeren klikker på linket "Afmeld mailingliste" i et nyhedsbrev.

* I rullemenuen **Angiv interesse** kan du vælge en interesse, som skal tilføjes til personerne, hvis de klikker på linket.
* På fanen **Fjern interesse** kan du vælge en interesse, som skal fjernes fra personerne, hvis de klikker på linket.

Se også [Nulstil interesser i SuperOffice CRM][1].

## Udtræk/projekt

Her kan du angive, at modtagere, der klikker på linket, vil blive tilføjet til eller fjernet fra udtræk i SuperOffice Service eller udtræk/ projekter i SuperOffice CRM. Indtast de første bogstaver i navnet i feltet for at starte hurtigsøgningen.

## Opfølgning (opgave/møde)

I fanen **Opfølgning** kan du angive, at klik på links skal generere opgaver eller møder i SuperOffice CRM.

1. Markér **Opfølgning** for at aktivere denne funktion.

2. **Opgave/aftale**: Vælg, hvilken type opfølgning der skal foretages.

3. **Beskrivelse**: Angiv en beskrivelse af opfølgningen. For eksempel hvilken udsendelse det drejer sig om, hvilket link modtageren har klikket på, og eventuelt hvordan der skal følges op på opgaven/mødet.

4. **Projekt**: Her vælger du det projekt, som opfølgningen skal knyttes til. Indtast de første bogstaver i navnet i feltet for at starte hurtigsøgningen.

5. **Opgave**: Vælg den ønskede type opfølgning.

6. **Oprettet af**: Vælg, hvilken bruger der skal være ansvarlig for opfølgningen, eller klik på knappen **Angiv aktiv bruger**(![ikon][img1]) for at angive dig selv.

7. **Tildel til vores kontakt, hvis muligt**: Markér her, om opfølgningen skal tildeles "vores kontakt" for modtageren (det vil sige den kundeansvarlige for denne kunde).

8. **Standardmodtager**: Vælg en standardmodtager, der skal tildeles opfølgningen, eller klik på knappen **Angiv aktiv bruger** ![(ikonet)][img1] for at angive dig selv.

9. **Varighed**: Klik på knappen **Vælg tidsramme** ![ikonet)][img2] ved siden af dette felt for at angive varigheden af opfølgningen.

## Sag

På fanen **Sag** kan du angive, at der skal oprettes en sag i SuperOffice Service for personer, der klikker på et link.

1. **Opret ny sag**: Markér her, hvis du ønsker at oprette en ny sag, når kunden klikker på linket.
2. **Titel**: Her skal du indtaste den ønskede titel på den nye sag.
3. **Prioritet**: Vælg den prioritet, som du ønsker at sagen skal have.
4. **Kategori**: Vælg den ønskede kategori.
5. **Ejer**: Vælg den ejer, som du ønsker at sagen skal have. Du kan også vælge **Automatisk tildelt** eller **Ikke tildelt**.

## Script

I fanen **Script** kan du vælge et script eller makro, der skal køres, når kunden klikker på linket.

1. Marker **Kør script** for at aktivere denne funktion.
2. Klik på listen **Script** og vælg det ønskede script fra den liste, der vises. Følgende variabler er tilgængelige i scriptet: custId, linkId, shipmentId, linkUrl og linkHits. Du kan desuden anvende variablen returnUrl til at tilsidesætte den angivne URL-adresse til linket.

## Eksempel

Det tager tid at opdatere 500 visitkort manuelt, og det er virkelig unødvendigt. Lad os i stedet automatisere processen ved hjælp af automatiserede linkhandlinger.

Eksempler på automatiserede linkhandlinger:

* Når en modtager klikker på dit link med opfordring til handling, føjer SuperOffice CRM automatisk vedkommende til et udtræk eller et projekt.

* Alternativt opdaterer SuperOffice CRM automatisk de relevante oplysninger på kontaktens visitkort, f.eks. interesser.

Ved at automatisere opgaverne sparer du en masse tid, som du ellers ville have brugt på at behandle dine svar. Når læseren klikker på et link i din udsendelse, udfører systemet linkets handlinger for dig!

De oplysninger, du har indsamlet i forbindelse med mailudsendelsen, kan du bruge på flere forskellige måder:

* Automatisk generering af et udtræk baseret på personer, der har klikket på et bestemt link.  Derefter kan du sende en målrettet opfølgende mail til netop denne gruppe med en skræddersyet besked.

* Tilføje opfølgende handlinger i dine teammedlemmers dagbøger, så de personligt kan følge op på de kontakter, der har svaret.

* Oprette service-sager, som kundeservice kan tage sig af og undersøge sagen.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/add-unsubscribe-link.md#clear-interests

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-contact.png
[img2]: ../../../../../common/icons/pref-diary.png
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
