---
uid: help-no-saint-status-create
title: Opprette ny status
description: Opprette ny status
keywords: SAINT, statusovervåking
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Opprette ny status

[!include[Requirement](../includes/note-saint-req.md)]

## Hvorfor bør du opprette en statusovervåking?

Du vil overvåke firmaer som du har svært få aktiviteter med, for å unngå misfornøyde kunder og kundeavgang. Med denne statusovervåkingen ser du enkelt alle kundene som må vies oppmerksomhet.

![Opprett en statusovervåking ved å klikke på Legg til-knappen på skjermen -screenshot][img1]

## Trinn

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Klikk på **Legg til** under listen **Statusovervåking**.

1. Fyll ut disse feltene i dialogboksen:

    * **Navn**: Angi et beskrivende navn på statusen du skal legge til.

        Valgfritt: Klikk på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til oversettelser][8] av statusnavnet.

    * **Beskrivelse**: Angi en forklarende beskrivelse av statusen, og hvilke tiltak som kreves eller anbefales. I dette feltet kan du i tillegg bruke [malvariabler][9] for å skreddersy teksten til gjeldende firma, person eller prosjekt.

    Navnet og beskrivelsen vises i SuperOffice CRM når brukeren holder musepekeren over statusbildet eller åpner statusbildet for firmaet. Du kan deretter [redigere beskrivelsen][2].

1. Klikk på **Lagre**. Statusen vises i statuslisten.

1. Hvis det er flere statuser i listen, angir du prioriteten du vil at den nye statusen skal ha. Klikk på statusen, og bruk pilknappene til høyre for statuslisten for å flytte den opp eller ned på listen.

### Hva inneholder statuslisten?

* **Visualiser**-ikonet (<i class="ph ph-eye" aria-hidden="true"></i>) indikerer om det skal [vises statusbilde][3] på firma, person- eller prosjektkort som oppfyller statuskriteriene. Ikonet vises bare hvis du har merket av for **Visualiser** i fanen **Bilde** for den aktuelle statusen.

* Et rødt kryss indikerer at statusen må regenereres. [Statusen må regenereres][4] hver gang du har lagt til, endret eller slettet et kriterium, eller hvis du for eksempel har endret en hensikt for en oppgave. Statuser med rødt kryss har ikke blitt oppdatert og returnerer ikke oppdaterte data ved bruk i SuperOffice CRM.

* **Navn** – navnet på statusene. Slettede statuser vises med rød tekst **Vis slettede** er merket av.

* **Prioritet** – prioriteten til statusene. Prioriteten bestemmer hvilken status som vises hvis et firma, en person eller et prosjekt oppfyller kriteriene til flere statuser.

## Hvorfor må jeg angi prioritet?

Et firma, en person eller et prosjekt kan oppfylle kriteriene til flere ulike statuser, men det er kun mulig å vise ett statusbilde på firma-, person- eller prosjektkortet i SuperOffice CRM. Derfor må det angis en prioritert rekkefølge for visning av statuser i SuperOffice CRM. Hvis et firma, en person eller et prosjekt ikke oppfyller kriteriene til statusen med høyest prioritet, vises statusen med nest høyest prioritet. Hvis firmaet, personen eller prosjektet heller ikke oppfyller disse kriteriene, vises neste status, og så videre.

Hvis et firma, en person eller et prosjekt har flere aktive statuser, vises statusene som ikke har høyest prioritet, som koblinger i dialogboksen for status. Denne dialogboksen vises når brukeren klikker på statusbildet i SuperOffice CRM eller velger **Vis statusinformasjon** på **Firma**-, **Person**- eller **Prosjekt**-menyen for et firma, en person eller et prosjekt med aktiv status.

## Aktuelt innhold

* [Velge bilde for status][3]
* [Velge standard oppfølgingstype for status][5]
* [Angi statuskriterier][6]
* [Angi periodelengde][7]
* [Administrere statusovervåking][4]

<!-- Referenced links -->
[2]: edit-status.md
[3]: select-image-for-status.md
[4]: manage-status-monitors.md
[5]: select-default-follow-up-type-for-status.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
