---
uid: help-no-screen-designer-archive
title: Arbeide med detaljkort (arkiv)
description: Hvordan tilpasse detaljkort (arkiv) i Skjermdesigneren i Innstillinger of vedlikehold.
keywords: Skjermdesigner, layout, oppsett, detaljkort, arkiv, arkivlayout
author: Bergfrid Dias
date: 10.07.2024
version: 10.2.11
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Arbeide med detaljkort (arkiv)

Du kan tilpasse layouten ved å legge til eller fjerne detaljkort (også kalt arkiv) på hovedkortene for skjermene Firma, Person, Salg, Prosjekt og Sak.

Detaljkort tilpasses vanligvis for å imøtekomme de spesifikke behovene til ulike brukergrupper. Du kan opprette en layout som er skreddersydd for en bestemt brukergruppe og sørge for at detaljkortene viser relevant innhold for den gruppen.

![Legg til navnet til den nye arkivlayouten, og velg brukergruppene den skal vises for -screenshot][img6]

## Forstå detaljkort

Detaljkort, som ligger nederst på de fleste SuperOffice CRM-skjermbilder, viser relaterte data som kontakter, aktiviteter, prosjekter og salg. Selv om noen detaljkort, som Salgsguide og Tilbud, ikke er arkiv, vil vi for enkelhets skyld referere til alle som arkiv eller arkivfaner.

Når du lager en ny layout for en brukergruppe, bør du vurdere hvilke data de trenger mest. Ved å tilpasse arkiver kan du filtrere og prioritere informasjon, slik at brukerne lettere finner det de trenger.

## Legg til detaljkort

Du kan legge til et nytt detaljkort på hvilken som helst skjerm som har et detaljkortområde. Avhengig av hvilken skjerm du velger, kan du legge til en ny fane med innhold av: dokument, avtale, produkt, prosjekt, prosjektdeltaker, salg, salgsinteressent, sak, person og relasjon.

![Velg hvilken type innhold du vil vise i detaljkortet -screenshot][img5]

**Trinn:**

1. Åpne Skjermdesigneren.

1. Øverst velg en skjerm du vil tilpasse, og klikk på **Arkiv**.

1. Velg en layout fra listen, og klikk på **Rediger layout** under forhåndsvisningen.

1. Klikk på **Legg til** for å åpne **Fane**-seksjonen.

1. Erstatt "Ny fane" med arkivnavnet, og angi en beskrivelse for den nye layouten. Eventuelt klikk på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til teksten på andre språk][1].

1. Juster **Unikt navn for fane** (soprotocol) etter behov. Dette navnet kan ikke endres senere.

1. Velg i seksjonen **Innstillinger** hvilken datatype (innhold) som skal vises i arkivet.

    Data er begrenset til den gjeldende skjermen. For eksempel, hvis du legger til et arkiv på Firmaskjermen, vises kun data knyttet til **gjeldende** firma.

1. Legg til eller rediger kriterier under **Filter** for å finjustere de viste dataene. Disse kriteriene fungerer på samme måte som [søkefiltre på **Finn**-skjermen][2] og i utvalg.

    Klikk på **Oppdater forhåndsvisning** for å se de filtrerte dataene.

1. (Valgfritt) Bruk **Avanserte alternativer** for å tilpasse handlinger for enkeltklikk og dobbeltklikk. Som standard vil et enkeltklikk velge en rad, og et dobbeltklikk vil åpne en oppføring/enhet i SuperOffice.

    > [!TIP]
    > Hold musepekeren over <i class="ph ph-info" aria-label="Info"></i> for eksempler.

1. Dra arkivet til ønsket posisjon i forhåndsvisningen.

1. Velg **Lagre utkast** eller **Lagre + Publiser** for å lagre endringene dine. Klikk på **Avbryt** for å forkaste endringene dine.

## Rediger eksisterende detaljkort

For å endre et eksisterende arkiv, velger du det og oppdaterer feltene og innstillingene i seksjonene **Fane** og **Innstillinger**. Du kan også endre fanens plassering ved å dra den.

### Begrensninger

* Standardfaner kan ikke redigeres.

* Noen faner, som **Tilbud**, **Salgsguide** og **Prosjektguide**, kan ikke redigeres fordi de har spesifikke funksjoner.

## Fjern detaljkort

1. Velg arkivet eller detaljkortfanen.

1. Klikk på **Oppgave** > **Fjern fane**.

1. Bekreft ved å klikke på **OK**. Fanen vil bli skjult, men ikke slettet.

![Klikk på Oppgave og deretter Fjern fane for å fjerne uønskede faner i detaljkortet (arkiv) -screenshot][img1]

For å angre disse endringene klikker du på **Gjenopprett faner**.

## Relatert innhold

* [Hvordan organiserer jeg feltene i Mer-fanen etter oppgraderingen til SuperOffice versjon 10?][3] - FAQ
* [Opprett ny layout][4]

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../search-options/learn/search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive-add-tab.png
[img6]: ../../../../media/loc/en/ui/admin-screendesigner-add-archive-layout.png
