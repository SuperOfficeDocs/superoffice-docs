---
uid: help-no-contact-create
title: Opprette person
description: Slik oppretter du en person i SuperOffice.
author: SuperOffice RnD
date: 11.29.2024
keywords: person, person
topic: howto
language: no
---

# Opprette ny person

Det er mange måter å legge til personer i SuperOffice CRM på:

* Legg til en person fra topplinjen **eller** Firma-bildet – se fremgangsmåtene nedenfor.
* [Skann et visittkort][1] med SuperOffice Mobile CRM-appen.
* [Masseimport][2] av flere personer (krever administratorrettigheter).

![Du kan legge til en person fra firmakortet i to trinn -screenshot][img1]

## Trinn

1. Åpne Person-bildet.

    * Klikk på **Ny** i toppraden, og velg **Person**.
    * Du kan også gå til ønsket firma i Firma-bildet, velge detaljkortet **Personer**, og deretter klikke på **Legg til**-knappen under detaljkortet.

2. I den øverste delen av fanen skriver du inn følgende informasjon:

    * Personens fornavn og/eller etternavn. Obligatorisk: Du må enten skrive inn et fornavn eller et etternavn.
    * Titulering (***Hr/Fr***)
    * Firma. Velg et firma fra listen, eller begynn å skrive inn et firmanavn for å søke. Hvis personen ikke er tilknyttet et firma, kan du velge **(Ingen valgt)**.
    * Personbilde. Du kan legge til et bilde ved å dra bildefilen fra Windows Explorer og slippe det på bildefeltet øverst til venstre i fanen.

    Du kan også legge til et bilde ved å høyreklikke på bildefeltet øverst til venstre i fanen. Klikk på koblingen og bla deg frem til ønsket bilde, og klikk på **Åpne** for å legge til bildet.

3. Skriv inn personinformasjon i fanen **Person**.

    <details><summary>Hva skal stå i de ulike feltene?</summary>

    [!include[Steps to populate company fields](includes/contact-fields.md)]

    </details>

4. Gå til fanen **Detaljer**. Her kan du angi ytterligere informasjon for personen.

    <details><summary>Hva skal stå i de ulike feltene?</summary>

    [!include[Steps to populate company details](includes/contact-details.md)]

    </details>

5. Gå til [Mer-fanen][12] for å legge inn informasjon. Denne fanen viser brukerdefinerte felt spesifikke for den valgte personen.

6. Gå til fanen **Interesser**. Her kan du angi interesser og alternativer for e-markedsføring/abonnement for personen.

7. Gå til fanen **Notat**. Her kan du legge inn informasjonen du måtte ønske.

8. Gå til fanen **www**. Se detaljer under.

9. Klikk på **Hjemmel** nederst på personkortet.

    I dialogboksen **Personvern** må du [se gjennom og redigere samtykkeinformasjonen][7] ved behov. Klikk på **Lukk** når du er ferdig.

10. Velg **Tidligere ansatt** (nederst på personkortet) hvis denne personen har forlatt firmaet. En person som er registrert som sluttet, vises vanligvis ikke på listene over personer eller prosjektdeltakere.

11. Når du har lagt inn nødvendig informasjon, klikker du på **Lagre**-knappen.

    Opplysningene om personen lagres nå i databasen og vises på personkortet. Hvis du har knyttet personen til et firma, vises personen i fanen **Personer** i Firma-bildet.

12. Gå til detaljkortet **Relasjoner**. Her kan du [legge til relasjoner][8] mellom denne personen og en annen person eller et annet firma.

## <a id="interests-tab"></a>Fanen Interesser (Person-bildet)

I fanen **Interesser** finner du følgende alternativer:

* **Interesser:** Her kan du velge hvilke interesser en person har. Interesser brukes til å opprette utvalg for utsendelser og lignende. [!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!TIP]
    > Interesser kan være nyttige hvis du skal definere utvalg. Hvis du for eksempel har definert *referansekunde* som interesse, kan du lage et utvalg som inneholder alle referansekundene dine. Da er det enkelt å lage markedsføringskampanjer mot denne kundegruppen.

* **E-markedsføring/abonnementer:** Hvis personen har sagt seg enig i (gitt sitt samtykke til) å motta elektronisk markedsføringsmateriale (utsendelser), kan du klikke på **E-markedsføring**. Ved å aktivere alternativet **E-markedsføring** for en person, angir du samtidig hjemmelen for formålet **E-markedsføring**. Den endres til **Berettiget interesse**.

    Du kan også angi hvilke typer e-markedsføring vedkommende skal motta (også kalt abonnementstyper). Disse innstillingene kan ha blitt justert av kundene selv via en kundeportal.

## Fanen www (Person-bilde)

[!include[About the www tab](../../learn/includes/www-tab.md)]

## Fanen ERP (Person-bilde)

[!include[About the ERP tab](../../learn/includes/erp-tab.md)]

## Fanen Notat (Person-bilde)

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

[!include[Tip](../../learn/includes/tip-open-website.md)]

## Aktuelle emner

* [Legge til oppføring som favoritt][4]

<!-- Referenced links -->
[1]: https://docs.superoffice.com/en/mobile/superoffice-mobile/company-contact/scan-business-card.html
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/add-contact-from-company-card.png
