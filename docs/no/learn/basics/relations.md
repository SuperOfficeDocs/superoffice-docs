---
uid: help-no-company-contact-relations
title: Firma- og personrelasjoner i SuperOffice CRM
description: Lær hvordan du kan se, legge til og administrere relasjoner mellom firmaer og personer i SuperOffice CRM, slik at du enklere kan holde oversikt over komplekse strukturer og tilpassede tilkoblinger.
keywords: legge til relasjon, slette relasjon, relasjon, person, kontakt, firma, forbindelse
author: Bergfrid Skaara Dias
date: 02.06.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Firma- og personrelasjoner i SuperOffice CRM

Relasjoner i SuperOffice CRM gjør det mulig å etablere forbindelser mellom firmaer og personer. Relasjoner består alltid av to parter: en aktiv og en passiv. For eksempel, "Firma A eier Firma B," der Firma A er den aktive parten og Firma B er den passive. Denne veiledningen gir en oversikt over hvordan du ser, legger til og administrerer disse relasjonene, slik at du enklere kan holde oversikt over komplekse strukturer, samarbeid eller tilpassede relasjoner som din bedrift krever.

## Eksempler på relasjoner

Eksempler inkluderer eierskapsstrukturer, partnerskapsavtaler eller personlige forbindelser mellom personer.

| Type | Aktiv | Passiv |
|---|---|---|
| Firma - firma | Firma ABC A/S samarbeider med Konsulenter A/S. | Konsulenter A/S samarbeider med Firma ABC A/S. |
| Firma - person | Firma ABC A/S leier inn Greg Campbell (Konsulenter A/S). | Greg Campbell (Konsulenter A/S) leies inn av Firma ABC A/S. |
| Person - firma | Per Arnesen eier Firma ABC A/S. | Firma ABC A/S eies av Per Arnesen. |
| Person - person | Jon Arnesen (Konsulenter A/S) er sønnen til Per Arnesen (Firma ABC A/S). | Per Arnesen (Firma ABC A/S) er faren til Jon Arnesen (Konsulenter A/S). |

## Se relasjoner

Detaljkortet **Relasjoner**, tilgjengelig på både Firmakortet og Personkortet, viser relasjoner mellom den valgte enheten og andre firmaer eller personer.

![Relasjoner (Firmakort) -screenshot][img2]

[!include[Kolonner for Relasjonsfanen](../includes/table-relations-tab-columns.md)]

For å se flere detaljer eller for å redigere, dobbeltklikk på en rad for å åpne **Relasjon**-dialogen.

## <a id="add"></a>Legg til relasjon

1. Gå til Firmakortet eller Personkortet der du ønsker å legge til en relasjon.

1. Velg detaljkortet **Relasjoner**.

1. Klikk på **Legg til** for å åpne **Relasjon**-dialogen.

 ![Relasjoner-dialog -screenshot][img1]

1. **Angi parter:**

    * **Aktiv:** Velg et firma eller en person.
    * **Passiv:** Velg den andre enheten involvert i relasjonen.

1. **Velg relasjonstype:** Velg relasjonstypen, for eksempel "eier", "ansatt av" eller "partner" fra **Relasjon**-listen. De tilgjengelige alternativene avhenger av om relasjonen er mellom en person og et firma eller mellom to personer.

    **Resultat**-feltet oppdateres automatisk basert på dine valg.

1. Legg til en beskrivelse (valgfritt): Inkluder ekstra informasjon om nødvendig.

1. Klikk **Lagre** for å opprette relasjonen.

## <a id="delete"></a>Slett relasjon

1. Gå til detaljkortet **Relasjoner** på enten Firmakortet eller Personkortet.

1. Finn relasjonen du vil slette, høyreklikk og velg **Slett**.

1. I dialogboksen som vises, klikk **Ja** for å bekrefte.

## Ekstra tips

* **Dropdown-søk:** Når du velger aktive og passive parter, start å skrive navnet for raskt å finne firmaet eller personen.

* **Relasjonstyper:** Relasjonstyper defineres i Innstillinger og vedlikehold. Å tilpasse disse gjør det enklere å reflektere din organisasjons spesifikke behov.

## Relatert innhold

* [Slette elementer i SuperOffice CRM][2]
* [Gruppere informasjon i detaljkort][1]
* [Legge til forekomster på listen Generelt - Relasjon][3]
* [Tilpassede felt i relasjoner][4]

<!-- Referenced links -->
[1]: ../section-tabs/index.md
[2]: deleting-elements.md
[3]: ../../admin/lists/learn/adding-items-to-relation-list.md
[4]: ../../custom-objects/learn/extra-field.md#relation

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/relation.png
[img2]: ../../../media/loc/en/company/relations-detail.png
