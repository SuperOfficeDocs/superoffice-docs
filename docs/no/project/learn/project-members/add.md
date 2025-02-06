---
uid: help-no-project-member-add
title: Legg til prosjektdeltaker
description: Slik legger du til en prosjektdeltaker i SuperOffice
keywords: legg til prosjektdeltaker, deltaker, prosjektdeltaker, prosjektmedlem, tildel funksjoner, prosjekt
author: Bergfrid Dias
date: 01.31.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Legge til prosjektdeltakere

For å knytte et prosjekt til et firma, må minst en prosjektdeltaker spesifiseres. Dette kan gjøres på Prosjektskjermen eller [via detaljkortene](#from-section-tab) for personer i Firma-, Utvalg- eller Salgsskjermene.

Når du legger til deltakere i et prosjekt, kan du tildele funksjoner individuelt mens du legger til personer/firmaer, tildele funksjoner etter at alle deltakere er lagt til, eller bruke en kombinasjon av begge metodene.

## Steg

1. Åpne prosjektet (se [Bruke Finn-bildet][1]) og gå til detaljkortet **Prosjektdeltakere**.

1. Klikk på **Legg til** under detaljkortet. Dialogen **Legg til/rediger prosjektdeltakere** åpnes.

1. Klikk på **Firma/person**-listen for å legge til deltakere. Du har flere alternativer:

    * **Søk**: Skriv inn minst to tegn for å søke etter en person eller firma.

    * **Historikk/Favoritter**: Velg fra historikklisten eller favoritter.

      ![Legg til/rediger prosjektdeltakere dialog, historikk - skjermbilde][img5]

    * **Brukergruppe**: Klikk <i class="ph ph-users" aria-label="Associate icon"></i> for å bla gjennom medarbeidere etter gruppe.

      ![Legg til/rediger prosjektdeltakere dialog, gruppe - skjermbilde][img6]

    * **Firma**: Klikk <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i> for å bla gjennom personer i et firma eller legge til et firma som medlem.

      ![Legg til/rediger prosjektdeltakere dialog, firma - skjermbilde][img7]

1. **Tildel funksjoner**: Velg en prosjektdeltaker og tildel en funksjon. For å tildele samme funksjon til flere deltakere samtidig, bruk **Merk alle** eller hold **Ctrl/Shift** mens du velger.

    ![Legg til/rediger prosjektdeltakere dialog, funksjon - skjermbilde][img8]

    Valgfritt: Legg til en kommentar for å beskrive prosjektdeltakerens funksjon i mer detalj.

1. Klikk på **OK**.

## <a id="from-section-tab"></a>Legg til prosjektdeltakere og interessenter fra detaljkort

Du kan legge til prosjektdeltakere og interessenter fra personoversiktene i ulike detaljkort, for eksempel **Firma** (**Personer**), **Utvalg** (**Firma/Person**), **Salg** (**Interessenter**) og **Prosjekt** (**Prosjektdeltakere**). Dermed kan prosedyren nedenfor også utføres fra fanen **Resultat** i [Finn][1]-bildet.

**Trinn:**

1. Gå til ønsket detaljkort eller **Finn**-bildet.

2. Velg ønsket person fra listen.

    > [!NOTE]
    > Hvis du vil legge til flere personer som interessenter/prosjektdeltakere, bruker du **Skift** eller **Ctrl** + klikk.

3. Høyreklikk på personene, og velg **Legg til i salg** eller **Legg til i prosjekt** på menyen som vises.

4. I feltet **Salg** eller **Prosjekt** angir du hvilket salg/prosjekt personene skal legges til i. Dette kan du gjøre enten ved å klikke på pilen og velge ønsket salg/prosjekt i listeboksen som vises, ved å skrive inn hele eller begynnelsen av salgs-/prosjektnavnet.

5. I feltet **Salgsrolle** eller **Funksjon** angir du hvilken salgsrolle/funksjon hver av personene har i salget/prosjektet. Hvis du klikker på pilen, får du frem en liste over forhåndsdefinerte alternativer du kan velge mellom.

6. Klikk på **Lagre**.

## Feilsøking

* **Manglende person:** Hvis en person ikke er oppført, må du først [registrere personen][3].

* **Manglende roller:** Tilgjengelige [funksjoner][5] er definert i Innstillinger og Vedlikehold.

## Tips

* **Legg til kommentarer**

    Hvis en kommentar er lagt til, vises en binders (<i class="ph ph-paperclip" aria-hidden="true"></i>) ved siden av kolonnen **Informasjon om prosjektdeltaker** i detaljkortet **Prosjektdeltakere**. Hold musepekeren over bindersen for å se kommentartipset.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[3]: ../../../contact/learn/create.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/project/add-project-member-from-history.png
[img6]: ../../../../media/loc/en/project/add-project-member-from-group.png
[img7]: ../../../../media/loc/en/project/add-project-member-from-company.png
[img8]: ../../../../media/loc/en/project/set-project-member-function.png
