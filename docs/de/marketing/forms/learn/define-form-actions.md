---
uid: help-de-form-actions
title: Formularaktionen definieren
description: Formularaktionen definieren
keywords: Formular, Automatisierung, Formularaktionen, übermittelte Formulare
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Automatisierte Formularaktionen definieren

Die manuelle Bearbeitung von 200 Anmeldungen für eine Veranstaltung ist zeitaufwendig und unnötig. Automatisierte Formularaktionen können diesen Prozess optimieren.

Automatisierung spart Zeit, die sonst für die Bearbeitung von Antworten aufgewendet würde. Wenn eine Person das Formular übermittelt, führt das System die Aktionen für Sie aus!

![Formularaktionen definieren -screenshot][img17]

## Verfügbare Aktionen

### Durch Erstellen von Anfragen über Übermittlungen benachrichtigen

Wählen Sie diese Option, um für jedes übermittelte Formular [eine Anfrage zu erstellen][8]. Geben Sie einen Titel ein und wählen Sie die Kategorie und Priorität für die Anfrage.

Übermittelte Formulare sind in den Ansichten **Anfragen** und in der Bereichsregisterkarte **Anfrage** in den Ansichten Firma und Person in SuperOffice CRM verfügbare.

### Wie sollen übermittelte Formulare verarbeitet werden?

Hier können Sie definieren, ob übermittelte Formulare automatisch verarbeitet werden sollen.

* **Verarbeiten Sie alle Übermittlungen automatisch. Fügen Sie eine neue Person hinzu, wenn keine Übereinstimmung gefunden wird**: Alle übermittelten Formulare werden automatisch verarbeitet. Es werden keine Benachrichtigungen für die übermittelten Formulare ausgegeben.

* **Manuell bei unbekanntem Übermittler. Automatisch bei bekanntem Übermittler**: Wenn die im Formular übermittelte E-Mail-Adresse mit einer E-Mail-Adresse in SuperOffice übereinstimmt, wird das übermittelte Formular automatisch verarbeitet. Andernfalls muss es manuell verarbeitet werden. Sie erhalten eine Benachrichtigung.

* **Manuell bei allen Übermittlungen**: Sie erhalten eine Benachrichtigung für jedes übermittelte Formular.

![Symbol][img11] [Übermittelte Formulare verarbeiten][6].

### Was soll bei Verarbeitung des Formulars passieren?

Hier können Sie Aktionen auswählen, die bei der automatischen oder manuellen Verarbeitung eines Formulars ausgeführt werden sollen:

* **Person zu Selektion hinzufügen**: Wenn Sie oben die automatische Verarbeitung gewählt haben, sollten Sie hier eine Selektion hinzufügen, um über dieses Formular hinzugefügte Personen nachzuverfolgen. Das erleichtert das Entfernen nicht relevanter Personen und Firmen.

* **Person zu Projekt hinzufügen**: Wählen Sie ein Projekt. Personen, die dieses Formular übermitteln, werden zu diesem Projekt hinzugefügt.

* **Interessen zu Person hinzufügen**: Wählen Sie ein Interesse. Dieses Interesse wird zu Personen hinzugefügt, die dieses Formular übermitteln.

* **E-Mail-Antwort**: Wählen Sie eine Formularantwort, die an Personen gesendet werden soll, sobald die von ihnen übermittelten Formulare verarbeitet werden. [Wie man eine Formularantwort erstellt][7].

* **Anfrage erstellen**: Wenn Sie ein Anfragefeld in der Kategorie **Felder** hinzugefügt haben, müssen Sie auch eine Standardkategorie und Priorität für die aus diesem Formular erstellten Anfragen auswählen. Übermittelte Formulare sind unter **Anfragen** in SuperOffice Service und in der Bereichsregisterkarte **Anfrage** in den Ansichten Firma und Person in SuperOffice CRM verfügbare.

* **CRMScript ausführen**: Wählen Sie ein [CRMScript][9] oder ein Makro aus, das ausgeführt werden soll, wenn ein übermitteltes Formular verarbeitet wird.

* **Standardkategorie**/**Standardbranche**: Wählen Sie eine Standardkategorie und eine Standardbranche für alle Personen oder Firmen aus, die aus übermittelten Formularen zu SuperOffice hinzugefügt werden. Mit dieser Option können Sie die Formularübermittlungen und neue Personen/Firmen unter einer bestimmten Kategorie und/oder Branche gruppieren.

    Wenn Sie z. B. ein Formular für Interessenten haben, wählen Sie Interessenten als Kategorie aus. Sie können dann ganz einfach Selektionen auf Basis dieser Kategorie und/oder dieser Branche erstellen.

> [!NOTE]
> Wenn Sie einen Formular aktualisieren, denken Sie daran, dass er von mehreren Kampagnen und/oder automatisierten Flows verwendet werden kann. Stellen Sie sicher, dass es keine duplizierten oder widersprüchlichen Aktionen gibt.

## Verwandte Inhalte

* [Formulare veröffentlichen][2]

<!-- Referenced links -->
[2]: publish.md
[6]: process-submissions.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.md
[8]: ../../../request/learn/create.md
[9]: ../../../../en/automation/crmscript/howto/marketing/forms.md

<!-- Referenced images -->
[img11]: ../../../../media/loc/en/marketing/form-notification.png
[img17]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
