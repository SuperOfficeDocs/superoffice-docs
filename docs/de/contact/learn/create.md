---
uid: help-de-contact-create
title: Person erstellen
description: Wie man eine Person in SuperOffice erstellt.
author: SuperOffice RnD
date: 11.29.2024
keywords: person, Person
topic: howto
language: de
---

# Neue Person erstellen

Es gibt viele Möglichkeiten, wie Sie Personen zu SuperOffice CRM hinzufügen können:

* Fügen Sie eine Person von der oberen Leiste **oder** der Anzeige Firma hinzu - siehe Schritte unten.
* [Scannen Sie eine Branchenkarte][1] mit der SuperOffice Mobile CRM-App.
* [Massenimport][2] einer größeren Anzahl von Personen (erfordert Administratorrechte).

![Sie können in zwei Schritten eine Person von der Firmenkarte hinzufügen -screenshot][img1]

## Schritte

1. Öffnen Sie die Ansicht Person.

    * Klicken Sie auf **Neu** auf der oberen Leiste und wählen Sie **Person**.
    * Oder gehen Sie zur Anzeige Firma, wählen Sie die Registerkarte **Personen** aus und klicken Sie auf die Schaltfläche **Hinzufügen** unter der Bereichsregisterkarte.

2. Im oberen Bereich der Registerkarte geben Sie folgende Informationen ein:

    * Vor- und/oder Nachname der Person. Obligatorisch: Sie müssen entweder einen Vor- oder einen Nachnamen eingeben.
    * Anrede (***Hr./Fr.***)
    * Firma. Wählen Sie eine Firma aus der Liste aus oder geben Sie zum Suchen die ersten Buchstaben des Firmennamens ein. Wenn die Person nicht mit einer Firma verbunden werden soll, wählen Sie **(Keine Selektion)**.
    * Personenbild. Sie können ein Foto hinzufügen, indem Sie die Bilddatei vom Windows Explorer ziehen und auf dem Bildfeld weiter oben links auf der Registerkarte ablegen.

    Sie können auch ein Bild hinzufügen, indem Sie mit der rechten Maustaste auf das Bildfeld weiter oben links auf der Registerkarte klicken. Klicken Sie auf den Link, suchen Sie das gewünschte Bild und klicken Sie auf **Öffnen**, um das Bild hinzuzufügen.

3. Geben Sie Informationen auf der Registerkarte **Person** ein.

    <details><summary>Welche Informationen werden in die Felder eingetragen?</summary>

    [!include[Steps to populate company fields](includes/contact-fields.md)]

    </details>

4. Wechseln Sie zur Registerkarte **Details**. Hier können Sie weitere Informationen zur Person eingeben.

    <details><summary>Welche Informationen werden in die Felder eingetragen?</summary>

    [!include[Steps to populate company details](includes/contact-details.md)]

    </details>

5. Gehen Sie zur [Registerkarte Mehr][12], um Informationen einzugeben. Diese Registerkarte zeigt benutzerdefinierte Felder, die für den ausgewählten Person spezifisch sind.

6. Wechseln Sie zur Registerkarte **Interessen**. Hier können Sie Interessen und E-Marketing-/Abonnementoptionen für die Person festlegen.

7. Wechseln Sie zur Registerkarte **Notiz**. Hier können Sie beliebige Informationen eingeben.

8. Wechseln Sie zur Registerkarte **www**. Für weitere Details siehe unten.

9. Klicken Sie unten in der Personenkarte auf **Rechtsgrundlage**.

    Im Dialogfeld **Datenschutz** müssen Sie gegebenenfalls die Informationen zur [Einwilligung überprüfen und bearbeiten][7]. Klicken Sie, sobald Sie fertig sind, auf **Schließen**.

10. Aktivieren Sie **Ausgeschiedene Mitarbeiter** (unten auf der Personenkarte), wenn diese Person die Firma verlassen hat. Personen, die als ausgeschiedene Mitarbeiter markiert sind, erscheinen nicht auf der Liste der Personen oder Projektmitglieder.

11. Nachdem Sie die erforderliche Information eingegeben haben, klicken Sie auf die Schaltfläche **Speichern**.

    Die Informationen über die Person werden nun in der Datenbank gespeichert und auf der Personenkarte angezeigt. Wenn Sie die Person mit einer Firma verknüpft haben, wird die Person auf der Registerkarte **Personen** in der Ansicht Firma angezeigt.

12. Wechseln Sie zur Bereichsregisterkarte **Beziehungen**. Hier können Sie [Beziehungen hinzufügen][8], die zwischen dieser und einer anderen Person oder Firma bestehen.

## <a id="interests-tab"></a>Die Registerkarte Interessen (Ansicht Person)

Auf der Registerkarte **Interessen** stehen folgende Optionen zur Verfügung:

* **Interessen:** Hier können Sie die Interessen einer Person auswählen. Interessen werden verwendet, um Selektionen für Kampagnen und ähnliches zu erstellen. [!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!TIP]
    > Interessen können für die Definition von Selektionen nützlich sein. Wenn Sie beispielsweise *Referenzkunde* als eine der Interessen festgelegt haben, können Sie eine Auswahl erstellen, die all Ihre Referenzkunden enthält. Das ermöglicht die Durchführung einer Werbekampagne, die auf diese Kundengruppe abzielt.

* **E-Marketing/Abonnements:** Wenn die Person dem Empfang von E-Marketing (Kampagnen) zugestimmt, also ihre Einwilligung gegeben hat, können Sie auf **E-Marketing** klicken. Wenn Sie die Option **E-Marketing** für eine Person aktivieren, legen Sie auch die Rechtsgrundlage für den Zweck **E-Marketing** fest. Sie ändert sich in **Berechtigte Interessen**.

    Sie können auch angeben, welchen Typ von E-Marketing die Person empfangen sollte (auch als Abonnementtypen bezeichnet). Diese Einstellungen wurden über ein Kundenportal möglicherweise von den Kunden selbst vorgenommen.

## Die Registerkarte www (Ansicht Person)

[!include[About the www tab](../../learn/includes/www-tab.md)]

## Die Registerkarte ERP (Ansicht Person)

[!include[About the ERP tab](../../learn/includes/erp-tab.md)]

## Die Registerkarte Notiz (Ansicht Person)

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

[!include[Tip](../../learn/includes/tip-open-website.md)]

## Verwandte Themen

* [Datensatz als Favoriten hinzufügen][4]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/add-contact-from-company-card.png
