---
uid: help-nl-lead-category-automation
title: Lead-categorisatie automatiseren
description: Configureer automatische categorie-updates wanneer verkopen van status veranderen of de leadstatus wordt bijgewerkt om handmatig werk te verminderen en de nauwkeurigheid van gegevens te behouden.
keywords: leadbeheer, categorie-automatisering, workflow, lead-categorisatie, automatische categorie-update
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: howto
category: sale
topic: lead
license: salespremium
audience: settings
audience_tooltip: Instellingen en onderhoud
index: true
language: nl
---

# Lead-categorisatie automatiseren

[!include[Must be admin](../../learn/includes/req-admin.md)]

Het automatiseren van bedrijfscategorie-updates helpt handmatig werk te verminderen en zorgt ervoor dat uw gegevens nauwkeurig blijven. Wanneer de [status van een verkoop][6] verandert of een [leadstatus][4] wordt bijgewerkt, kan het gerelateerde bedrijf automatisch worden bijgewerkt met de juiste categorie.

U kunt de automatisering zo configureren dat deze volledig automatisch wordt uitgevoerd of de gebruiker vragen om de wijziging te bevestigen voordat deze wordt toegepast.

## Vereisten

* De huidige categorie van het bedrijf moet behoren tot de groep **Potentiële klant** om in aanmerking te komen voor automatische updates. Zie [Bedrijfscategorie en categoriegroep][1].
* Voor op leadstatus gebaseerde automatisering moet **Leadstatus** zijn ingeschakeld voor de huidige categorie van het bedrijf.

## Categorie-automatiseringsregels configureren

U kunt een of alle van de volgende automatiseringsregels inschakelen:

| Automatiseringsregel | Beschrijving |
|---|---|
| Categorie bijwerken wanneer een verkoop is verkocht | Werkt automatisch de bedrijfscategorie bij wanneer een verkoop is gemarkeerd als **Verkocht**. |
| Categorie bijwerken wanneer een verkoop is verloren | Werkt automatisch de bedrijfscategorie bij wanneer een verkoop is gemarkeerd als **Verloren**. |
| Categorie bijwerken wanneer een verkoop wordt geregistreerd bij het bedrijf | Werkt automatisch de bedrijfscategorie bij wanneer een nieuwe verkoop wordt aangemaakt en gekoppeld aan het bedrijf. |
| Categorie bijwerken wanneer een leadstatus is ingesteld op | Werkt automatisch de bedrijfscategorie bij wanneer de leadstatus van een contactpersoon wordt gewijzigd naar een specifieke waarde, zoals *Gekwalificeerd* of *Gediskwalificeerd*. Vereist dat leadstatus is ingeschakeld voor de categorie. |

### Stappen

1. Open **Instellingen en onderhoud**.

1. Selecteer in de Navigator <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow**.

1. Selecteer het tabblad **Leads categoriseren**. Dit scherm toont de automatiseringsopties.

    ![Admin workflow - Tabblad Lead-categorisatie met automatiseringsschakelaars -screenshot][img1]

1. Schakel de schakelaar in voor de regel die u wilt activeren.

1. Wanneer u een schakelaar inschakelt, verschijnen er extra opties:

    * **Categorie instellen op:** Selecteer de doelcategorie uit de lijst. Dit is de categorie waarnaar het bedrijf wordt bijgewerkt wanneer aan de voorwaarde is voldaan.

        U kunt elke categorie selecteren, ongeacht de categoriegroep.

    * **Vraag om gebruikersbevestiging voordat u bijwerkt:** Vink dit vakje aan als u wilt dat de gebruiker de categoriewijziging bevestigt voordat deze wordt toegepast.

        Laat het uitgevinkt voor volledig automatische updates.

1. Herhaal dit voor andere regels die u wilt inschakelen.

1. Klik op **Opslaan** om uw wijzigingen toe te passen, of klik op **Annuleren** om ze te verwerpen.

    > [!NOTE]
    > De knop **Opslaan** is ingeschakeld pas nadat u een categorie hebt geselecteerd in het veld **Categorie instellen op** voor alle ingeschakelde schakelaars.

## Wanneer gebruikersbevestiging gebruiken

Beslis op basis van uw zakelijke behoeften of categorie-updates automatisch moeten zijn of gebruikersbevestiging vereisen:

* **Volledig automatisch:** Het beste voor eenvoudige lead-naar-klant workflows waarbij categoriewijzigingen voorspelbaar en consistent zijn. Bijvoorbeeld het automatisch verplaatsen van een lead naar de categorie *Klant* wanneer een verkoop als verkocht wordt gemarkeerd.

* **Gebruikersbevestiging:** Aanbevolen wanneer categoriewijzigingen beoordeling vereisen of wanneer meerdere categorieën van toepassing kunnen zijn. Als u bijvoorbeeld werkt met meerdere klantenniveaus (VIP, A, B, C), zorgt het vragen aan de gebruiker ervoor dat de juiste categorie wordt geselecteerd.

Wanneer **Vraag om gebruikersbevestiging voordat u bijwerkt** is ingeschakeld, ziet de gebruiker een dialoogvenster waarin de categoriewijziging wordt voorgesteld. Ze kunnen het voorstel accepteren of een andere categorie kiezen voordat ze opslaan.

## Voorbeeld: Lead-naar-klant-overgang automatiseren

Een veelvoorkomend gebruik is om een lead automatisch bij te werken naar een klantencategorie wanneer een verkoop is verkocht:

1. Schakel **Categorie bijwerken wanneer een verkoop is verkocht** in.

1. Stel **Categorie instellen op** = *Klant* in.

1. Laat **Vraag om gebruikersbevestiging voordat u bijwerkt** uitgevinkt voor volledige automatisering.

1. Klik op **Opslaan**.

Nu, wanneer een verkoop die is gekoppeld aan een bedrijf in de groep *Potentiële klant* als verkocht wordt gemarkeerd, verandert de bedrijfscategorie automatisch naar *Klant*.

## Gerelateerde inhoud

* [Bedrijfscategorie en categoriegroep][1]
* [Overzicht van leadbeheer][3]
* [Leadstatussen beheren][2]
* [Een verkoop bijwerken][7]
* [Verkoopgidsen][5]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[4]: ../learn/index.md#status
[5]: ../../sale/learn/sales-guides.md
[6]: ../../sale/learn/index.md
[7]: ../../sale/learn/update.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/lead-categorization.png
