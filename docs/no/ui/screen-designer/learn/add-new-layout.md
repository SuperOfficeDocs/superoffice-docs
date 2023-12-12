---
uid: help-no-screen-designer-add-layout
title: Legg til ny skjermlayout
description: Slik legger du til et nytt oppsett for en brukergruppe.
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Skjermdesigner, format, hovedkort, arkiv
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Legg til ny skjermlayout

Hvis standard layout ikke gjenspeiler behovene til en brukergruppe, kan du opprette et nytt layout som samsvarer med brukergruppens unike informasjonsbehov. Et tilpasset layout for person- og firmakortene og de forskjellige arkivfanene/detaljkortene lar teamene og organisasjonen arbeide mer effektivt.

Med egendefinerte skjermlayouter for hvert av teamene dine vil det være enklere enn noen gang å finne kundedata. De mest relevante dataene vil alltid være tilgjengelige og synlige. Fjern, flytt eller skjul irrelevante eller mindre viktige data for å rydde opp i skjermbildene firma, person, salg, prosjekt, og sak. Legg til tilpassede arkiver med de mest relevante dataene for teamene dine. Resultatet blir et renere og mer ryddig bilde som teamene dine kan jobbe i.

## Hovedkortlayout

En tilpasset layout for skjermbildene Person og Firma lar teamene og organisasjonen jobbe mer effektivt, fordi det eliminerer den forstyrrende "informasjonsstøyen".

Hvis brukerstøtteteamet for eksempel sjelden bruker firmaadressen når de kommuniserer med firmaer og personer, bør du gjøre plass til andre felt som er viktigere på den første siden (fanen Firma). Flytt den ved å klikke på stolpene på venstre side av feltet og dra den over til **Mer**-fanen.

Se denne videoen, og finn ut hvordan du legger til et nytt layout, eller følg trinn-for-trinn-veiledningen nedenfor (videoen starter på 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

### Trinn

<!-- markdownlint-disable-file MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->

3. Velg **Hovedkort** eller **Arkiver** (også kjent som detaljkort).

4. Hvis det er relevant, klikker du på teksten ved siden av **Tilordne oppsett til**.

    Oppsettene kan som standard tilordnes til brukergrupper.
    Hvis du imidlertid legger til hovedkort-layouter for bildene Salg, Prosjekt, eller Sak kan du tilordne layoutene til salgstyper, prosjekttyper, eller sakstyper.

5. Klikk på **Legg til** under **Layouter**.

    ![Klikk på Legg til for å opprette en ny layout -screenshot][img1]

6. I dialogboksen **Legg til ny layout** velger du en layout i listen **Lag ny basert på**.

    Den nye layouten baseres på den valgte layouten.

7. I feltet **Navn** skriver du inn et navn på den nye layouten.

    ![Angi riktig navn og brukergruppene som skal brukes i denne layouten -screenshot][img2]

8. Klikk på **Tilordne**-feltet og velg brukergruppen(e) som skal bruke den nye layouten.

    Listen viser bare brukergrupper som bruker standardlayouten. En brukergruppe kan bare tilordnes til én layout. Salgs- prosjek- eller sakstyper vil være tilgjengelige her hvis du valgte disse alternativene i trinn 4.

9. Angi en beskrivelse av layouten i feltet **Beskrivelse**.

10. Klikk på **OK** når du er ferdig. Den nye layouten legges til i **Layout** -listen. Den har statusen **Utkast**, noe som betyr at den ennå ikke er synlig for brukere. Forhåndsvisningen vises til høyre på skjermen.

    > [!TIP]
    > Hvis du senere vil redigere layoutinnstillingene, dobbeltklikker du på layouten i listen for å åpne dialogboksen **Endre layoutinnstillinger**. Du kan ikke redigere innstillingene for standard layout.

11. Når den nye layouten er valgt i **Layout**-listen, klikker du på **Rediger layout**-knappen for å tilpasse skjermens layout. Se [Redigere oppsett – Hovedkort][1] eller [Redigeringsoppsett – Arkiver (detaljkort)][2].
<!-- markdownlint-restore -->

> [!NOTE]
> Hvis du vil slette en layout, velger du layouten i **Layouter**-listen og klikker på **Slett**. Brukergrupper som er tilordnet den slettede layouten, går tilbake til standardlayouten.

## Layout for detaljkort og arkiv

Tilpasning av layouten til de ulike detaljkortene/arkivene for et hovedkort gjøres normalt når det er ulike behov for de ulike brukergruppene.

Du kan opprette en ny layout for den (de) spesifikke brukergruppen(e) og konfigurere de forskjellige detaljkortene til å vises med forskjellig innhold.

Opprett en ny layout for en bestemt brukergruppe ved å konfigurere detaljkort med innhold som er relevant for den brukergruppen. Ved å legge til og fjerne de forskjellige fanene, kan du opprette ønsket oppsett på et hovedkort for brukergruppen din.

![Legg til navnet i den nye detaljkort-/arkivlayouten, og velg brukergruppen(e) den skal vises for -screenshot][img3]

## Aktuelt innhold

* [Hvordan konfigurerer jeg hvilken informasjon brukerne av firmaet vårt kan få tilgang til i SuperOffice CRM?][3]
* [Hvordan oppretter jeg en ny brukergruppe i SuperOffice CRM?][4]
* [Brukerhåndtering][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: edit-layout-archives.md
[3]: ../../../admin/user-management/learn/role/index.md
[4]: ../../../admin/user-management/learn/user-groups.md
[5]: ../../../admin/user-management/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/ui/add-new-screen-layout.png
[img3]: ../../../../media/loc/en/ui/admin-screendesigner-add-archive-layout.png
