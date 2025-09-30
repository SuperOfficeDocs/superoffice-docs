---
uid: help-nl-form-actions
title: Formulieracties definiëren
description: Formulieracties definiëren
keywords: formulier, automatisering, formulieractie, formulierverzending
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Formulieracties definiëren

Het handmatig bijwerken van 200 aanmeldingen voor een evenement is tijdrovend en onnodig. Geautomatiseerde formulieracties kunnen dit proces stroomlijnen.

Automatisering bespaart tijd die anders zou worden besteed aan het afhandelen van reacties. Wanneer iemand het formulier indient, voert het systeem de acties voor u uit!

![Formulieracties definiëren -screenshot][img17]

## Beschikbare acties

### Verzendingen melden door verzoeken te maken

Selecteer deze optie om een [verzoek te maken][8] voor elk formulier dat wordt verzonden. Geef een titel op en selecteer de categorie en prioriteit voor het verzoek.

Verzonden formulieren zijn beschikbaar onder **Verzoeken** in SuperOffice Service en in het sectietabblad **Verzoek** in de schermen Bedrijf en Persoon in SuperOffice CRM.

### Hoe moet een formulierverzending worden verwerkt?

Hier kunt u opgeven of de verzonden formulieren automatisch moeten worden verwerkt.

* **Alle verzendingen automatisch verwerken. Nieuwe persoon maken als er geen overeenkomst is gevonden**: Alle formulierverzendingen worden automatisch verwerkt. Er komen geen meldingen van verzonden formulieren.

* **Handmatig als indiener onbekend is. Automatisch als indiener bekend is**: Als het e-mailadres dat is verzonden in het formulier, overeenkomt met een e-mailadres in SuperOffice, wordt de formulierverzending automatisch verwerkt. Anders wordt deze handmatig verwerkt. U ontvangt een melding.

* **Handmatig voor alle verzendingen**: U ontvangt een melding voor elk verzonden formulier.

![pictogram][img11] [Formulierverzendingen verwerken][6].

### Wat moet er gebeuren wanneer het formulier wordt verwerkt?

Hier kunt u acties selecteren die worden uitgevoerd wanneer een formulier wordt verwerkt (automatisch of handmatig):

* **Persoon toevoegen aan selectie**: Als u hierboven automatische verwerking hebt geselecteerd, moet u hier een selectie toevoegen om personen te volgen die via dit formulier zijn toegevoegd. Dit maakt het ook makkelijker om irrelevante personen (en bedrijven) te verwijderen.

* **Persoon toevoegen aan project**: Selecteer een project. Personen die dit formulier verzenden, worden aan dit project toegevoegd.

* **Interesses toevoegen aan persoon**: Selecteer een interesse. Deze interesse wordt toegevoegd aan personen die dit formulier verzenden.

* **E-mailantwoord**: Selecteer een formulierantwoord om te verzenden naar personen wanneer hun formulier is verwerkt. [Een formulierantwoord maken][7].

* **Verzoek maken**: Als u een verzoekveld hebt toegevoegd in de categorie **Velden**, moet u ook een standaardcategorie en prioriteit selecteren voor de verzoeken die vanuit dit formulier worden gemaakt. Verzonden formulieren zijn beschikbaar onder **Verzoeken** in SuperOffice Service en in het sectietabblad **Verzoek** in de schermen Bedrijf en Persoon in SuperOffice CRM.

* **CRMScript uitvoeren**: Selecteer een [CRMScript][9] of macro om uit te voeren wanneer een formulierverzending is verwerkt.

* **Standaardcategorie** / **Standaardbedrijf**: Selecteer een standaardcategorie en -bedrijf voor alle personen of bedrijven die aan SuperOffice worden toegevoegd op basis van ingediende formulieren. Met deze optie kunt u de formulierverzendingen en nieuwe personen/bedrijven groeperen in één specifieke categorie en/of branche.

    Als u bijvoorbeeld een formulier voor prospects hebt, selecteert u prospects als uw categorie. U kunt dan eenvoudig selecties maken op basis van deze categorie en/of branche.

> [!NOTE]
> Houd er bij het bijwerken van een formulier rekening mee dat dit mogelijk wordt gebruikt in meerdere mailings en/of geautomatiseerde flows. Zorg ervoor dat er geen dubbele of conflicterende acties zijn.

## Gerelateerde inhoud

* [Formulieren publiceren][2]

<!-- Referenced links -->
[2]: publish.md
[6]: process-submissions.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.md
[8]: ../../../request/learn/create.md
[9]: ../../../../en/automation/crmscript/howto/marketing/forms.md

<!-- Referenced images -->
[img11]: ../../../../media/loc/en/marketing/form-notification.png
[img17]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
