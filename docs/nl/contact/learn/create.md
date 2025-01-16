---
uid: help-nl-contact-create
title: Contactpersoon maken
description: Een contactpersoon maken in SuperOffice.
author: SuperOffice RnD
date: 11.29.2024
keywords: persoon, contactpersoon
topic: howto
language: nl
---

# Nieuwe persoon maken

Er zijn veel manieren waarop u personen kunt toevoegen aan SuperOffice CRM:

* Voeg een contactpersoon toe vanuit de bovenste balk **of** het bedrijfsscherm - zie onderstaande stappen.
* [Scan een visitekaartje][1] met de SuperOffice Mobile CRM-app.
* [Grotere aantallen contactpersonen bulksgewijs importeren][2] (hiervoor zijn beheerdersrechten vereist).

![U kunt in twee stappen een contactpersoon toevoegen vanaf de bedrijfskaart -screenshot][img1]

## Stappen

1. Open het scherm Persoon.

    * Klik op **Nieuw** op de bovenste balk en selecteer **Persoon**.
    * Ga naar het gewenste bedrijf in het scherm Bedrijf, selecteer het sectietabblad **Personen** en klik op de knop **Toevoegen** onder het sectietabblad.

2. Voer in het bovenste deel van het tabblad de volgende informatie in:

    * Voornaam en/of achternaam van persoon. Verplicht: U moet een voornaam of een achternaam invoeren.
    * Aanhef (***Dhr./Mw.***)
    * Bedrijf. Selecteer een bedrijf uit de lijst of begin een bedrijfsnaam te typen als u wilt zoeken. Als u de persoon niet wilt verbinden met een bedrijf, selecteert u **(Geen selectie)**.
    * Afbeelding persoon. U kunt een foto toevoegen door het afbeeldingsbestand te slepen vanuit de Windows Verkenner en neer te zetten in het afbeeldingsveld linksboven in de tab.

    U kunt ook een afbeelding toevoegen door met de rechtermuisknop op het afbeeldingsveld linksboven op het tabblad te klikken. Klik op de koppeling en blader naar de gewenste afbeelding en klik op **Openen** om de afbeelding toe te voegen.

3. Voer informatie over de persoon in op de tab **Persoon**.

    <details><summary>Wat moet in de verschillende velden worden ingevoerd?</summary>

    [!include[Steps to populate company fields](includes/contact-fields.md)]

    </details>

4. Ga naar het tabblad **Details**. Hier kunt u aanvullende informatie invoeren over de persoon.

    <details><summary>Wat moet in de verschillende velden worden ingevoerd?</summary>

    [!include[Steps to populate company details](includes/contact-details.md)]

    </details>

5. Ga naar het [tabblad Meer][12] om informatie in te voeren. Dit tabblad toont aangepaste velden die specifiek zijn voor de geselecteerde persoon.

6. Selecteer het tabblad **Interesses**. Hier kunt u interesses en opties voor e-marketing/abonnement instellen voor de persoon.

7. Ga naar de tab **Opmerking**. Hier kunt u elke gewenste informatie invoeren.

8. Ga naar de tab **www**. Zie details hieronder.

9. Klik op **Rechtsgrondslag** onder aan het visitekaartje.

    **Controleer en bewerk**in het dialoogvenster [Privacy][7] de toestemmingsgegevens indien nodig. Klik op **Sluiten** wanneer u klaar bent.

10. Controleer **voormalige werknemer** (onderaan het visitekaartje) of deze persoon het bedrijf heeft verlaten. Een persoon die is geregistreerd als voormalige werknemer, wordt niet weergegeven in de lijsten met personen of projectleden.

11. Nadat u de benodigde informatie hebt ingevoerd, klikt u op de knop **Opslaan**.

    De informatie over de persoon is nu opgeslagen in de database en wordt weergegeven op het visitekaartje. Als u de persoon aan een bedrijf hebt gekoppeld, wordt de persoon weergegeven op het tabblad **Personen** in het scherm Bedrijf.

12. Ga naar het sectietabblad **Relaties**. Hier kunt u [relaties toevoegen][8] tussen deze persoon en een andere persoon of een bedrijf.

## <a id="interests-tab"></a>Het tabblad Interesses (scherm Persoon)

De tab **Interesses** bevat de volgende opties:

* **Interesses:** Hier selecteert u de interesses van een persoon. Interesses worden gebruikt om selecties te maken voor mailings en dergelijke.[!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!TIP]
    > interesses kunnen goed van pas komen bij het definiëren van selecties. Als u bijvoorbeeld *Referentieaccount* hebt gedefinieerd als interesse, kunt u een selectie maken met daarin alle referentieaccounts. Dit maakt het makkelijk een marketingcampagne te maken die op deze klantgroep is gericht.

* **E-marketing/abonnementen:** Als de persoon ermee heeft ingestemd (toestemming heeft gegeven) e-marketing (mailings) te ontvangen, kunt u klikken op **E-marketing**. Door de optie **E-marketing** voor een persoon te activeren, stelt u ook de rechtsgrondslag in voor het doel **E-marketing**. Deze is gewijzigd in **Rechtmatig belang**.

    U kunt ook opgeven welk type e-marketing deze persoon moet ontvangen (ook wel type abonnementen genoemd). Deze instellingen kunnen zijn aangepast door de klant zelf via een klantenportal.

## De tab WWW (scherm Persoon)

[!include[About the www tab](../../learn/includes/www-tab.md)]

## De tab ERP (scherm Persoon)

[!include[About the ERP tab](../../learn/includes/erp-tab.md)]

## De tab Opmerking (scherm Persoon)

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

[!include[Tip](../../learn/includes/tip-open-website.md)]

## Verwante onderwerpen

* [Record toevoegen als een favoriet][4]

<!-- Referenced links -->
[1]: https://docs.superoffice.com/en/mobile/superoffice-mobile/company-contact/scan-business-card.html
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/add-contact-from-company-card.png
