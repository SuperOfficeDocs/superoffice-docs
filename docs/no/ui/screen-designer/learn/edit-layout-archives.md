---
uid: help-no-archive-edit-layout
title: Rediger layout på detaljkort/arkiver
description: Skjermdesigner Rediger layout – Arkiver (detaljkort)
author: SuperOffice RnD
so.date: 02.23.2023
keywords: Skjermdesigner, detaljkort, arkiv
so.topic: howto
so.user: admin
language: no
---

# Rediger layout på detaljkort/arkiver

Du kan redigere layouten ved å legge til eller fjerne detaljkort/arkiver på de forskjellige hovedkortene for firma, person, salg, prosjekt, og sak.

## Fjerne flertydighet

Detaljkort er fanene som ligger nederst på de fleste SuperOffice CRM-skjermbildene. Eksempel: Firma-skjermbildet har detaljkort som inneholder personer, aktiviteter, prosjekter og salg. Disse omtales også som Arkiver. Det finnes også detaljkort som ikke regnes som arkiver, for eksempel detaljkort som inneholder salgsguider, prosjektguider og tilbud. I forbindelse med dette emnet vil vi referere til dem som arkiver eller arkivfaner (når vi refererer til selve fanen som inneholder arkivet).

Når du har opprettet en ny layout for arkiver (detaljkort) som beskrevet i Legg til ny layout, kan du tilpasse den i henhold til behovene som den (de) tilordnede brukergruppen(e) har. Hvis du tilpasser en layout for salgsteamet, bør du ha en klar plan for hvilke behov de har med hensyn til layout, formatering og innhold i arkivene. Trenger de tilpassede arkiver med filtrerte data? Hvilken informasjon bør man kunne finne først og enklest? Trenger de alle arkivene?

## Trinn

Du kan legge til et nytt detaljkort på et hvilket som helst hovedkort. Avhengig av hovedkortet som er valgt, kan du legge til en ny fane med følgende innhold: Dokument, Avtale, Produkt, Prosjekt, Prosjektdeltaker, Salg, Salgsinteressent, Sak, Person og Relasjon.

![Velg innholdstypen du vil vise i detaljkortet -screenshot][img5]

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->

3. Klikk på **Arkiver**.

4. Velg en layout i listen til venstre.

5. Klikk på **Rediger layout** under forhåndsvisningen. Et nytt vindu åpnes.

6. Se avsnittene nedenfor for mer informasjon om hvordan du redigerer layouten.

7. Når du er ferdig å redigere layouten, klikker du på en av de følgende knappene:

    * **Lagre utkast**: Klikk denne knappen hvis layouten ikke er ferdig ennå.
    * **Lagre + Publiser**: Klikk denne knappen for å publisere layouten til de valgte brukergruppene.
    * **Avbryt**: Klikk på denne knappen for å [forkaste alle endringer](#undo-changes).
<!-- markdownlint-restore -->

## Legg til arkivfane

1. Klikk på ![ikon][img2] **Legg til**. **Fane**-delen åpnes til venstre.

2. Under **Navn** erstatter du teksten **Ny fane** med navnet på arkivet. Du kan også legge til navnet på [andre språk][1] ved å klikke på ![ikon][img3].

3. Dersom relevant, endre **Unikt navn for kort (soprotocol)**. Dette navnet kan ikke endres senere.

4. Angi en beskrivelse av arkivet i feltet **Beskrivelse**. Du kan også legge til beskrivelsen på [andre språk][1] ved å klikke på ![ikon][img3].

5. Velg **Innstillinger**-delen.

6. I listen **Innhold** velger du datatypen du vil vise i arkivet. Dataene i arkivet vil være begrenset til data for gjeldende skjerm.

    Eksempel: Hvis du legger til et arkiv for skjermbildet Firma, vises bare data knyttet til gjeldende firma.

7. Legg til/rediger de relevante kriteriene på følgende måte **under Filter**:

    * [Rediger et kriterium][2].

        Eksempel: Velg **Avtale** i **Innholdslisten** og legg til kriterier for å vise bare interne og eksterne møter for denne uken og neste uke.

    * Klikk **Legg til** for å angi flere kriterier. En ny linje legges til i kriterielisten.

    * Bruk klikk og dra for å flytte kriterier.

    * Klikk **Eller** for å legge til et annet sett med kriterier.

8. Klikk på **Oppdater forhåndsvisning** for å vise data for gjeldende kriterier, i forhåndsvisningen på høyre side. Bruk listen **Forhåndsvisning av firma** til å velge hvilket firma du vil vise.

9. Klikk på **Avanserte innstillinger** for å endre standardhandlingene for enkeltklikk og dobbeltklikk i arkivet. Du kan se eksempler på hvordan du konfigurerer dette under **Eksempel på syntaks**, og ved å holde musepekeren over ikonet (![ikon][img4]).

    > [!NOTE]
    > Som standard vil et enkeltklikk velge en rad, og et dobbeltklikk vil åpne en oppføring/enhet i SuperOffice. Hvis firmaet imidlertid bruker egendefinerte arkiver til å vise data fra andre systemer, kan du endre disse innstillingene for å åpne en oppføring i et eksternt system.

10. Klikk og dra det nyopprettede arkivet inn i forhåndsvisningen, og flytt det til ønsket posisjon.

11. Lagre endringene som beskrevet ovenfor.

## Redigere eksisterende detaljkort

Hvis du vil redigere et eksisterende arkiv, velger du dette og redigerer de tilgjengelige feltene og innstillingene i feltene **Faner** og **Innstillinger**. Du kan også klikke og dra det til en ny posisjon.

## Begrensninger

* Standardfaner kan ikke redigeres.

* Noen faner kan ikke redigeres siden de har bestemte funksjoner, slik som **Tilbud**, **Salgsguide** og **Prosjektguide**.

## Fjerne et arkiv

1. Velg arkivet (eller et annet detaljkort) og klikk på **Oppgave** > **Fjern fane**.

1. Klikk på **OK** i dialogboksen som kommer til syne. Fanen er fjernet (skjult, men ikke slettet).

![Klikk på Oppgave og deretter Fjern fane for å fjerne eventuelle uønskede faner i detaljkortet (arkiv) -screenshot][img1]

Du kan alltid klikke på **Gjenopprett faner** for å angre disse endringene.

## <a id="#undo-changes" />Angre endringer

Hvis du må gå tilbake til en tidligere versjon av skjermbildet, har du tilgang til følgende alternativer fra **Oppgave**-knappen:

* **Tilbakestill til fabrikkinnstillinger**: Dette alternativet sletter alle endringer og tilbakestiller layouten til standardlayouten som er levert av SuperOffice.

* **Gjenopprett faner**: Dette alternativet gjenoppretter alle faner som er fjernet.

* **Slett utkast**: Sletter alle endringer og tilbakestillinger til den publiserte versjonen av layouten.

## Relatert

* [Hvordan omorganiserer jeg feltene i Mer-fanen i bildene Firma og Person etter oppgraderingen til SuperOffice versjon 10?][3] - FAQ
* [Opprett ny layout][4]

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../search-options/learn/search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-new-layout.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../../common/icons/az.png
[img4]: ../../../../../common/icons/info-ball.png
[img1]: media/admin-screendesigner-edit-archive.png
[img5]: media/admin-screendesigner-edit-archive-add-tab.png
