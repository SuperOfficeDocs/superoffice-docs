---
uid: help-no-saint-status-create
title: Opprette ny status
description: Opprette ny status
keywords: SAINT, statusovervåking, bilde, visualiser, søk
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from: 
  - /no/sale/saint/learn/admin/create-status
  - /no/sale/saint/learn/admin/select-image-for-status
  - /no/saint/admin/select-image-for-status
index: true
---

# Opprette ny status

[!include[Requirement](../includes/note-saint-req.md)]

## Hvorfor bør du opprette en statusovervåking?

Du vil overvåke firmaer som du har svært få aktiviteter med, for å unngå misfornøyde kunder og kundeavgang. Med denne statusovervåkingen ser du enkelt alle kundene som må vies oppmerksomhet.

![Opprett en statusovervåking ved å klikke på Legg til-knappen på skjermen -screenshot][img1]

## Trinn

1. Åpne **SAINT**-bildet, og velg fanen **Firma**, **Person** eller **Prosjekt**.

1. Klikk på **Legg til** under listen **Statusovervåking**.

1. Fyll ut disse feltene i dialogboksen:

    * **Navn**: Angi et beskrivende navn på statusen du skal legge til.

        Valgfritt: Klikk på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til oversettelser][8] av statusnavnet.

    * **Beskrivelse**: Angi en forklarende beskrivelse av statusen, og hvilke tiltak som kreves eller anbefales. I dette feltet kan du i tillegg bruke [malvariabler][9] for å skreddersy teksten til gjeldende firma, person eller prosjekt.

    Navnet og beskrivelsen vises i SuperOffice CRM når brukeren holder musepekeren over statusbildet eller åpner statusbildet for firmaet. Du kan deretter [redigere beskrivelsen][2].

1. Klikk på **Lagre**. Statusen vises i statuslisten.

1. Hvis det er flere statuser i listen, angi **prioritet** for å bestemme hvilket statusbilde som vises på kortet.
    Et firma, en person eller et prosjekt kan samsvare med kriteriene for flere statuser, men bare ett bilde kan vises.
    Velg en status og bruk pilknappene under listen for å flytte den opp eller ned.

    ![Liste over statusmonitorer med prioritet -screenshot][img2]

### Angi kriterier for statusen

Hver status må inneholde minst ett kriterium. Etter å ha opprettet statusen:

1. Velg den nye statusen i listen.
1. Velg **Legg til** for å sette inn et nytt kriterium.
1. Velg en kriteriumtype, sett betingelsen og angi en verdi.
1. Gjenta etter behov, velg deretter **Regenerer valgt statusovervåking** for å aktivere statusen.

## <a id="image"></a>Velge et bilde for en status

Du kan legge til et bilde som skal vises på firma-, person- eller prosjektkort som oppfyller statuskriteriene. Bildet vises som et lett vannmerke (40% gjennomsiktighet) slik at det ikke skjuler annet innhold.

Å legge til et bilde er valgfritt. Det kan bidra til å tiltrekke oppmerksomhet og symbolisere handlingen du ønsker at brukerne skal utføre. Hvis du bare vil bruke statusen for søk eller utvalg, kan du utelate bilde.

1. I statuslisten velger du ønsket status.
1. På høyre side av skjermen merker du av for **Visualiser** for å vise bildet.
1. Velg **Endre bilde**.
1. Gjør ett av følgende:
    * Velg et av de eksisterende bildene fra **Bilder**-listen.
    * Velg **Legg til**, last opp en fil, skriv inn en beskrivelse og velg **Lagre**.
1. Velg **OK** for å bekrefte.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Bruk enkle, lysfarget bilder som representerer statusen på en meningsfull måte. For eksempel kan et edderkoppnett symbolisere inaktivitet.

## Aktuelt innhold

* [Angi statuskriterier][6]
* [Angi periodelengde][7]
* [Administrere statusovervåking][4]

<!-- Referenced links -->
[2]: edit-status.md
[4]: manage-status-monitors.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
