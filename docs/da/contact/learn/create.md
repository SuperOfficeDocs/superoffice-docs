---
uid: help-da-contact-create
title: Opret person
description: Sådan opretter du en ny person i SuperOffice
author: SuperOffice RnD
date: 11.29.2024
keywords: person, contact
topic: howto
language: da
---

# Opret ny person

Der er mange måder, du kan føje kontakter til SuperOffice CRM på:

* Tilføj en kontakt fra den øverste bjælke **eller** virksomhedsskærmen - se trin nedenfor.
* [Scan et visitkort][1] med SuperOffice Mobile CRM-appen.
* [Masseimport][2] af et større antal kontakter (kræver administratorrettigheder).

![Du kan tilføje en person fra virksomhedskortet i to trin -screenshot][img1]

## Trin

1. Åbn skærmbilledet Person.

    * Klik på **Ny** i toplinjen, og vælg **Person**.
    * Eller gå til det ønskede firma på skærmbilledet Firma, vælg detaljekortet **Personer** sektion, og klik på knappen **Tilføj** under sektionsfanen.

2. Indtast følgende oplysninger i øverste del af fanen:

    * Personens fornavn og/eller efternavn. Obligatorisk: Du skal enten angive et fornavn eller et efternavn.
    * Titulering (***Hr/Fr***)
    * Firma. Vælg et firma fra listen, eller begynd at skrive et firmanavn for at søge. Hvis personen ikke er tilknyttet et firma, kan du vælge **(Ingen valgt)**.
    * Personbillede. Du kan tilføje et billede ved at trække billedfilen fra Windows Stifinder og slippe den i billedfeltet øverst til venstre i fanen.

    Du kan også tilføje et billede ved at højreklikke på billedfeltet øverst til venstre i fanen. Klik på linket, og gå til det ønskede billede, og klik på **Åbn** for at tilføje billedet.

3. Indtast personinformation i fanen **Person**.

    <details><summary>Hvad skal der stå i de forskellige felter?</summary>

    [!include[Steps to populate company fields](includes/contact-fields.md)]

    </details>

4. Gå til fanen **Detaljer**. Her kan du angive yderligere information om personen.

    <details><summary>Hvad skal der stå i de forskellige felter?</summary>

    [!include[Steps to populate company details](includes/contact-details.md)]

    </details>

5. Gå til [Mere-fanen][12] for at indtaste oplysninger. Denne fane viser brugerdefinerede felter specifikke for den valgte person.

6. Gå til fanen **Interesser**. Her kan du angive interesser og alternativer for e-markedsføring/abonnement for personen.

7. Gå til fanen **Bemærkning**. Her kan du indtaste oplysninger af enhver slags.

8. Gå til fanen **www**. Se detaljer nedenunder.

9. Klik på **Retsgrundlag** nederst på personkortet.

    I dialogboksen **Privacy** skal du [Gennemgå og rediger dine samtykkeoplysningerne,][7] hvis det er nødvendigt. Klik på **Luk**, når du er færdig.

10. Marker **Tidligere medarbejder** (nederst på personkortet), hvis denne person ikke længere arbejder hos firmaet. En person, hvis ansættelsesforhold er registreret som fratrådt, vises ikke på listerne over personer eller projektdeltagere.

11. Når du har tilføjet de ønskede oplysninger, skal du klikke på knappen **Gem**.

    Oplysningerne om personen gemmes nu i databasen og vises på personkortet. Hvis du har knyttet personen til et firma, vises personen i fanen **Personer** i skærmbilledet Firma.

12. Gå til detaljekortet **Relationer**. Her kan du [tilføje relationer][8] mellem denne person og en anden person eller et andet firma.

## <a id="interests-tab"></a>Fanen Interesser (skærmbilledet Person)

På fanen **Interesser** finder du følgende alternativer:

* **Interesser:** Her kan du vælge en persons interesser. Interesser bruges til at oprette udvalg til udsendelser og lignende.[!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!TIP]
    > Interesser kan være nyttige, hvis du skal definere udvalg. Hvis du for eksempel har defineret *referencekunde* som interesse, kan du lave et udvalg, som indeholder alle dine referencekunder. Efterfølgende er det så nemt og enkelt at lave markedsføringskampagner, der er rettet mod denne kundegruppe.

* **E-markedsføring/abonnement:** Hvis personen har indvilget i (givet samtykke til) at modtage elektronisk markedsføringsmateriale (udsendelser), kan du klikke på **E-markedsføring**. Ved at aktivere **E-markedsføring** for en person angiver du samtidig retsgrundlaget for formålet **E-markedsføring**. Den ændres til **Berettiget interesse**.

    Du kan også angive hvilke typer e-markedsføring, vedkommende skal modtage (også kaldet abonnementstyper). Disse indstillinger kan være blevet redigeret af kunderne selv via en kundeportal.

## Fanen www (skærmbilledet Person)

[!include[About the www tab](../../learn/includes/www-tab.md)]

## Fanen ERP (skærmbilledet Person)

[!include[About the ERP tab](../../learn/includes/erp-tab.md)]

## Fanen Notat (skærmbilledet Person)

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

[!include[Tip](../../learn/includes/tip-open-website.md)]

## Relaterede emner

* [Tilføj post som foretrukken][4]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/add-contact-from-company-card.png
