---
uid: help-nl-mail-link-create-template
title: E-mailsjablonen maken
description: E-mailsjablonen maken
keywords: E-mailsjablonen maken, e-mailsjabloon, documentsjabloon
author: SuperOffice RnD
date: 06.29.2022
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# E-mailsjablonen maken

U kunt uw eigen sjablonen maken om te gebruiken bij het maken van e-mails vanuit SuperOffice CRM. Ga als volgt te werk:

1. Maak een nieuwe e-mail met bijvoorbeeld Outlook Express. Als u standaardvariabelen voor documentsjablonen gebruikt, plaatst u deze als volgt tussen accolades: `{name}`.

2. Sla het bestand op in *.oft*-indeling maar stel de extensie in op *.somail*. Bijvoorbeeld *mijn-mail.somail*.

3. Verplaats het bestand naar de *map \\so_arc\\template* .

4. Open Instellingen en onderhoud.

5. Open het scherm **Lijsten**.

6. Selecteer het tabblad **Items**.

7. [!include[Click arrow and select](includes/expand-list.md)] **Documentsjabloon** in de vervolgkeuze **Lijst**.

8. Klik op de knop **Toevoegen** onder de lijst **Items**.

9. Voer in het dialoogvenster de vereiste naam van de sjabloon in het verplichte veld **Naam** in.

10. Klik in het veld **Bestandsnaam** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteer het bestand *.somail* dat u zojuist hebt gemaakt.

11. Klik in het veld **Richting** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en kies **Uitgaand** in de vervolgkeuze.

12. Klik in het veld **Recordtype** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en kies **E-mail**.

13. Selecteer in het veld **Documentplug-in** het programma dat u wilt gebruiken om het document weer te geven door te klikken op <i class="ph ph-caret-down" aria-label="Chevron"></i> en een keuze te maken in de keuzelijst.

14. Klik in het veld **Intentie** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteer een van de vooraf gedefinieerde opties in de keuzelijst. Deze items worden met statuscontroles gebruikt in SuperOffice CRM (SAINT-licentie is vereist).

15. Schakel het vakje **Publiceren** in om een gebruiker toe te staan te selecteren in het Dialoogvenster Document dat de desbetreffende documentsjabloon beschikbaar moet worden gesteld aan externe gebruikers.

16. Geef met behulp van de sjabloonvariabelen de standaardinstelling op voor het veld **Onze referentie (standaard)**, bijvoorbeeld {auth} voor de voor- en achternaam van de afzender.

17. Kies in het veld **Opslaan in database** de optie **Nee**.

18. Voer in het veld **Code voor openen register** *SoMailParser.exe* in.

19. Typ zo nodig een beschrijving voor de e-mailsjabloon in het veld **Beschrijving**.

20. Klik op **OK**. De sjabloon wordt als een afzonderlijk item toegevoegd aan de lijst **Items**.

21. Klik op **Opslaan**.

U kunt nu nieuwe e-mails maken vanuit SuperOffice CRM met behulp van deze sjabloon.
