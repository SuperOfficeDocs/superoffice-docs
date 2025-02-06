---
uid: help-no-mail-link-create-template
title: Opprette e-postmaler
description: Opprette e-postmaler
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Opprette e-postmaler

Du kan lage dine egne maler som du kan bruke når du oppretter e-post fra SuperOffice CRM. Følg disse trinnene:

1. Opprett en ny e-post ved hjelp av for eksempel Outlook Express. Hvis du bruker standard dokumentmalvariabler, skriver du dem i klammeparenteser på følgende måte: `{name}`.

2. Lagre filen i *oft-format*, men angi filtypen til *.somail*. For eksempel *min-e-post.somail*.

3. Flytt filen til mappen *\\so_arc\\template*.

4. Åpne Innstillinger og vedlikehold.

5. Gå til **Lister**-bildet.

6. Velg fanen **Forekomster**.

7. [!include[Click arrow and select](includes/expand-list.md)] **Dokumentmal** fra nedtrekksmenyen **Liste** .

8. Klikk på knappen **Legg til** under listen **Forekomster**.

9. I dialogboksen skriver du inn ønsket navn på malen i det obligatoriske feltet **Navn** .

10. I feltet **Filnavn** klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger *.somail*-filen du nettopp opprettet.

11. I feltet **Retning** klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger **Utgående** fra nedtrekksmenyen.

12. I feltet **Radtype** klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger **E-post**.

13. I feltet **Dokument-plugin** velger du programmet som skal brukes til å vise dokumentet, ved å klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velge i nedtrekksmenyen.

14. I feltet **Hensikt** klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger et av de forhåndsdefinerte alternativene fra nedtrekksmenyen. Disse forekomstene brukes i forbindelse med statusovervåking i SuperOffice CRM (krever lisens for SAINT).

15. Merk av i boksen **Publiser** for å la en bruker velge, i dialogboksen Dokument, at den aktuelle dokumentmalen skal være tilgjengelig for eksterne brukere.

16. Angi standardoppsett for feltet **Vår ref (standard)** ved hjelp av malvariabler, for eksempel {auth} for avsenderens fornavn og etternavn.

17. I feltet **Lagre i database** velger du **Nei**.

18. I feltet **Registry Open Key** skriver du *SoMailParser.exe*.

19. Legg eventuelt inn en beskrivelse av e-postmalen i feltet **Beskrivelse**.

20. Klikk på **OK**. Malen blir nå lagt til som en egen forekomst i listen **Forekomster**.

21. Klikk på **Lagre**.

Du kan nå opprette nye e-poster fra SuperOffice CRM ved hjelp av denne malen.
